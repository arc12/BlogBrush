using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BlogBrush
{
    public partial class Form1 : Form
    {
        public Hashtable UrlSet;
        public ArrayList UrlSetBare; //URLs only from UrlSet. Used for iterator
        public Hashtable NewUrlSet;
        public StringDictionary WhiteDomains;//URLs containing these domains are automatically added to NewUrlSet
        public StringDictionary BlackDomains;//and these ones are automatically nuked
        public IEnumerator UrlSetEnumerator;
        public int currentIndex;
        String currentEntryUrl;
        UrlMD currentEntryMD;
        String lastExtractedUrl = "";
        bool abort;

        frmUrlCheck frmUC;

        public Form1()
        {
            InitializeComponent();
            frmUC = new frmUrlCheck();
        }

        #region utility functions
        /// <summary>
        /// Adds a URL to the hashtable with some checking
        /// </summary>
        public void ProtectedAdd2UrlSet(String URL, UrlMD MD){
            URL = CleanTrailingSlash(URL);
            if (!UrlSet.ContainsKey(URL))
            {
                UrlSet.Add(URL, MD);
            }
        }

        /// <summary>
        /// Adds a URL to the hashtable of NEW URLs with some checking
        /// </summary>
        public void ProtectedAdd2NewUrlSet(String URL, UrlMD MD)
        {
            URL = CleanTrailingSlash(URL);
            if (URL.Length > 0)
            {
                if (!NewUrlSet.ContainsKey(URL) && !UrlSet.ContainsKey(URL))
                {
                    NewUrlSet.Add(URL, MD);
                }
            }
        }

        private String CleanTrailingSlash(String Url)
        {
            if (Url.Length > 0)
            {
                if (Url[Url.Length - 1] == '/')
                {
                    Url = Url.Substring(0, Url.Length - 1);
                }
            }
            return Url;
        }

        /// <summary>
        /// checks if the URL contains a blacklisted domain
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public bool IsBlackListed(String URL)
        {
            bool black = false;
            foreach (DictionaryEntry de in BlackDomains)
            {
                if (URL.IndexOf(de.Key.ToString()) >= 0)
                {
                    black = true;
                    break;
                }
            }
            return black;
        }

        /// <summary>
        /// checks if the URL contains a whitelisted domain
        /// </summary>
        /// <param name="URL"></param>
        /// <returns></returns>
        public bool IsWhiteListed(String URL)
        {
            bool white = false;
            foreach (DictionaryEntry de in WhiteDomains)
            {
                if (URL.IndexOf(de.Key.ToString()) >= 0)
                {
                    white = true;
                    break;
                }
            }
            return white;
        }

        #endregion

        #region main process - iteration, extraction, updating

        public void UrlSetIterate()
        {
            currentIndex++;
            bool url2get = UrlSetEnumerator.MoveNext();
            //this bit skips over entries that have already been given a type
            if(url2get){
                currentEntryUrl = UrlSetEnumerator.Current.ToString();
                currentEntryMD = (UrlMD)UrlSet[currentEntryUrl];
                while ((currentEntryMD.Type != "") && url2get)
                {
                    url2get = UrlSetEnumerator.MoveNext();
                    if (url2get)
                    {
                        currentEntryUrl = UrlSetEnumerator.Current.ToString();
                        currentEntryMD = (UrlMD)UrlSet[currentEntryUrl];
                    }
                }
            }
            //now load up the browser OR report all done
            if (url2get)
            {
                btnOpen.Enabled = false;
                grpDecisions.Enabled = false;
                grpExtract.Enabled = false;
                btnAbort.Enabled = true;
                abort = false;
                try
                {
                    webBrowser.Navigate(currentEntryUrl);
                    txtAddress.Text = currentEntryUrl;
                    //wait for the browser object to load the page
                    while ((webBrowser.ReadyState != WebBrowserReadyState.Complete) && !abort)
                    {
                        Application.DoEvents();
                    }
                    grpExtract.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem loading: suggest select \"defer\" or \"Reject\"");
                }
                btnAbort.Enabled = false;
                grpDecisions.Enabled = true;
                //show progress
                progressBar.Value = 100 * currentIndex / UrlSet.Count;
            }
            else
            {
                MessageBox.Show("No more URLs");
                grpDecisions.Enabled = false;
                grpExtract.Enabled = false;
                progressBar.Value = 100;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        public void UpdateCurrentEntryType(String Type)
        {
            currentEntryMD = new UrlMD(Type, currentEntryMD.References);
            //check if the user navigated away.
            //if they ended up at a different URL then "reject" the old one and add the new with the chosen type
            //if they ended up at a different URL, add the new URL as if it was auto-extracted and mark the original URL as type=""
            String navUrl = CleanTrailingSlash(webBrowser.Url.ToString());
            if (navUrl == currentEntryUrl)
            {
                UrlSet[currentEntryUrl] = currentEntryMD;
            }
            else
            {
                UrlSet[currentEntryUrl] = new UrlMD("reject", 0);
                //UrlSet.Remove(currentEntryUrl);
                currentEntryUrl = navUrl;
                ProtectedAdd2UrlSet(currentEntryUrl, currentEntryMD);
            }
            grpFile.Enabled = true;
            btnSave.Enabled = true;
        }

 
        /// <summary>
        /// grabs links from current page if not already known and discarding pdf, doc, images etc
        /// uses WhileDomains and Black domains to pre-filter the list then
        /// opens a form for user to choose which to accept then adds to NewUrlSet 
        /// </summary>
        public void ExtractLinks()
        {
            String navUrl = CleanTrailingSlash(webBrowser.Url.ToString());
            StringDictionary candidateUrls = new StringDictionary();

            //avoid re-doing if there was a manual "extract" and we have not moved to a new URL
            if (lastExtractedUrl == navUrl) { return; }
            lastExtractedUrl = navUrl;

            HtmlElementCollection links = webBrowser.Document.Links;
            for (int i = 0; i < links.Count; i++)
            {
                String link;
                try
                {
                    link = CleanTrailingSlash(new Uri(links[i].GetAttribute("href")).ToString());

                    if (!(link.ToLower().EndsWith(".pdf") || link.ToLower().EndsWith(".doc") ||
                        link.ToLower().EndsWith(".docx") || link.ToLower().EndsWith(".xls") ||
                        link.ToLower().EndsWith(".xlsx") || link.ToLower().EndsWith(".jpg") ||
                        link.ToLower().EndsWith(".jpeg") || link.ToLower().EndsWith(".gif") ||
                        link.ToLower().EndsWith(".png")))//discard useless hrefs
                    {
                        if (!NewUrlSet.ContainsKey(link) && !UrlSet.ContainsKey(link))//discard if known
                        {
                            if (!IsBlackListed(link))
                            {
                                //check the link doesn't contain the current page URL
                                if (link.IndexOf(navUrl) == -1)
                                {
                                    if (IsWhiteListed(link))
                                    {
                                        //just add to the NewUrlSet without showing to user
                                        ProtectedAdd2NewUrlSet(link, new UrlMD("", 0));
                                    }
                                    else
                                    {
                                        //add it to the list of candidates if not already there
                                        if (!candidateUrls.ContainsKey(link))
                                        {
                                            candidateUrls.Add(link, link);
                                        }
                                    }
                                    
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }

            //show the list to user and then handle the sets they selected
            frmUC.Candidates = candidateUrls;
            frmUC.ShowDialog();
            String[] Scan = frmUC.Scan;
            for (int i = 0; i < Scan.Length; i++)
            {
                ProtectedAdd2NewUrlSet(Scan[i].Trim(), new UrlMD("", 0));
            }
            String[] Whitelist = frmUC.Whitelist;
            for (int i = 0; i < Whitelist.Length; i++)
            {
                if (Whitelist[i].Length > 0)
                {
                    if (!WhiteDomains.ContainsKey(Whitelist[i]))
                    {
                        WhiteDomains.Add(Whitelist[i].Trim(), Whitelist[i].Trim());
                    }
                }
            }
            String[] Blacklist = frmUC.Blacklist;
            for (int i = 0; i < Blacklist.Length; i++)
            {
                if (Blacklist[i].Length > 0)
                {
                    if (!BlackDomains.ContainsKey(Blacklist[i]))
                    {
                        BlackDomains.Add(Blacklist[i].Trim(), Blacklist[i].Trim());
                    }
                }
            }
            frmUC.Clear();
            btnSave.Enabled = true;
        }

        #endregion

        #region file operations
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog.InitialDirectory = Path.GetDirectoryName(openFileDialog.FileName);
                
                UrlSet = new Hashtable();
                NewUrlSet = new Hashtable();
                WhiteDomains = new StringDictionary();
                BlackDomains = new StringDictionary();

                //Read in the CSV file and create a hashtable keyed off the URLs
                FileInfo fi = new FileInfo(openFileDialog.FileName);
                StreamReader sr = fi.OpenText();
                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine().Trim();
                    String[] parts = line.Split(',');
                    UrlMD md;
                    if (parts.Length == 1)
                    {
                        md = new UrlMD("", 0);//allows for a simple URL list on 1st invokation
                    }
                    else
                    {
                        md = new UrlMD( parts[1].Trim(),Convert.ToInt32(parts[2].Trim()));
                    }
                    ProtectedAdd2UrlSet(CleanTrailingSlash(parts[0].Trim()), md);
                }
                sr.Close();

                //Repeat for the "New" list
                FileInfo fiNew = new FileInfo(fi.FullName.Replace(".csv", "_New.csv"));
                if (fiNew.Exists)
                {
                    sr = fiNew.OpenText();
                    while (!sr.EndOfStream)
                    {
                        String line = sr.ReadLine().Trim();
                        String[] parts = line.Split(',');
                        UrlMD md;
                        if (parts.Length == 1)
                        {
                            md = new UrlMD("", 0);//allows for a simple URL list on 1st invokation
                        }
                        else
                        {
                            md = new UrlMD(parts[1].Trim(), Convert.ToInt32(parts[2].Trim()));
                        }
                        ProtectedAdd2NewUrlSet(CleanTrailingSlash(parts[0].Trim()), md);
                    }
                    sr.Close();
                }

                //read from whitelist and blacklist files (one domain per line) from same directory
                fi = new FileInfo(Path.Combine(Path.GetDirectoryName(openFileDialog.FileName),"WhiteDomains"));
                if (fi.Exists)
                {
                    sr = fi.OpenText();
                    while (!sr.EndOfStream)
                    {
                        String white = sr.ReadLine().Trim();
                        if (!WhiteDomains.ContainsKey(white) && white.Length > 0)
                        {
                            WhiteDomains.Add(white, white);
                        }
                    }
                }
                sr.Close();
                fi = new FileInfo(Path.Combine(Path.GetDirectoryName(openFileDialog.FileName), "BlackDomains"));
                if (fi.Exists)
                {
                    sr = fi.OpenText();
                    while (!sr.EndOfStream)
                    {
                        String black = sr.ReadLine().Trim();
                        if (!BlackDomains.ContainsKey(black) && black.Length>0)
                        {
                            BlackDomains.Add(black, black);
                        }
                    }
                }
                sr.Close();

                //get the enumerator and get the 1st URL
                currentIndex = 0;
                UrlSetBare = new ArrayList(UrlSet.Keys);
                lblUrlCount.Text = UrlSetBare.Count.ToString();
                UrlSetEnumerator = UrlSetBare.GetEnumerator();
                UrlSetIterate();

                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveFileDialog.FileName);
                //write out the working set of URLs, hopefully with some user-set types
                foreach (DictionaryEntry de in UrlSet)
                {
                    UrlMD md = (UrlMD)de.Value;
                    tw.WriteLine(String.Format("{0},{1},{2}",
                        de.Key.ToString(),md.Type,md.References.ToString()));
                }
                tw.Close();

                //repeat for the "NEW URLS" (which may have some user types, although not usually)
                tw = new StreamWriter(saveFileDialog.FileName.Replace(".csv","_New.csv"));
                foreach (DictionaryEntry de in NewUrlSet)
                {
                    UrlMD md = (UrlMD)de.Value;
                    tw.WriteLine(String.Format("{0},{1},{2}",
                        de.Key.ToString(), md.Type, md.References.ToString()));
                }
                tw.Close();

                //now save the white and black domain lists
                tw = new StreamWriter(Path.Combine(Path.GetDirectoryName(saveFileDialog.FileName), "WhiteDomains"));
                foreach (DictionaryEntry de in WhiteDomains){
                    if (de.Key.ToString().Length > 0)
                    {
                        tw.WriteLine(de.Key);
                    }
                }
                tw.Close();
                tw = new StreamWriter(Path.Combine(Path.GetDirectoryName(saveFileDialog.FileName), "BlackDomains"));
                foreach (DictionaryEntry de in BlackDomains)
                {
                    if (de.Key.ToString().Length > 0)
                    {
                        tw.WriteLine(de.Key);
                    }
                }
                tw.Close();

                MessageBox.Show(String.Format("Saved {0} previous URLs + {1} newly acquired URLs for future \"blog-brushing\"",UrlSet.Count, NewUrlSet.Count));

                btnOpen.Enabled = true;
                btnSave.Enabled = false;
            }
        }
        #endregion

        #region events (buttons mostly)

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btnBlog_Click(object sender, EventArgs e)
        {
            //a blog from a member of the community without commercial overtones
            UpdateCurrentEntryType("blog");
            ExtractLinks();
            UrlSetIterate();
        }

        private void btnCommercial_Click(object sender, EventArgs e)
        {
            //a news feed or similar from a commercial provider
            UpdateCurrentEntryType("commercial");
            ExtractLinks();
            UrlSetIterate();
        }

        private void btnWebPage_Click(object sender, EventArgs e)
        {
            //just a web page, although relevant
            UpdateCurrentEntryType("webpage");
            UrlSetIterate();
        }

        private void btnUnknown_Click(object sender, EventArgs e)
        {
            //effectively the same as "reject" but flagged as difficult to decide on
            UpdateCurrentEntryType("unkown");
            UrlSetIterate();
        }

        private void btnDefer_Click(object sender, EventArgs e)
        {
            //come back to this URL next time
            UpdateCurrentEntryType("");
            UrlSetIterate();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            //the URL is useless
            UpdateCurrentEntryType("reject");
            UrlSetIterate();
        }


        private void btnExtract_Click(object sender, EventArgs e)
        {
            ExtractLinks();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            abort = true;
            webBrowser.Stop();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            abort = true;//?
            webBrowser.Stop();
        }
        #endregion
    }
}
