using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BlogBrush
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class UrlMD
    {
        String feedUri;
        String urlType;
        int setId;
        
        /// <summary>
        /// An Id for a set of URLs. Newly added ones are assigned 0. May be set to other values outside
        /// this application. This app always preserves the value.
        /// </summary>
        public int SetId
        {
            get { return setId; }
        }

        /// <summary>
        /// If one can be extracted from the HTML, this contains a feed URL. Otherwise is ""
        /// </summary>
        public String FeedUrl
        {
            get { return feedUri; }
            set { feedUri = value; }
        }

        /// <summary>
        /// Once classified this holds the assigned class.
        /// </summary>
        public String Type
        {
            get { return urlType; }
            set { urlType = value; }
        }

        public UrlMD(String Type, int SetId, String FeedUri)
        {
            feedUri = FeedUri;
            urlType = Type;
            setId = SetId;
        }

        public UrlMD(String Type, int SetId)
        {
            feedUri = "";
            urlType = Type;
            setId = SetId;
        }

        public UrlMD(String Type)
        {
            feedUri = "";
            urlType = Type;
            setId=0;
        }

        public UrlMD()
        {
            feedUri = "";
            urlType = "";
            setId = 0;
        }

    }
}
