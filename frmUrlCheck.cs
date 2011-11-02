using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlogBrush
{
    public partial class frmUrlCheck : Form
    {
        public frmUrlCheck()
        {
            InitializeComponent();
        }

        private void btnAdd2Scan_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (object item in listCandidates.SelectedItems)
            {
                sb.AppendLine(item.ToString());
            }
            txtScan.Text = sb.ToString();
            listCandidates.ClearSelected();
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (object item in listCandidates.SelectedItems)
            {
                Uri u = new Uri(item.ToString());
                String h = u.Host;
                sb.AppendLine(h.Substring(1+h.IndexOf('.')));
            }
            txtWhite.Text = sb.ToString();
            listCandidates.ClearSelected();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (object item in listCandidates.SelectedItems)
            {
                Uri u = new Uri(item.ToString());
                String h = u.Host;
                sb.AppendLine(h.Substring(1 + h.IndexOf('.')));
            }
            txtBlack.Text = sb.ToString();
            listCandidates.ClearSelected();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String[] Scan
        {
            get
            {
                return txtScan.Text.Trim().Replace("\r\n", "\r").Split('\r');
            }
        }

        public String[] Whitelist
        {
            get
            {
                return txtWhite.Text.Trim().Replace("\r\n", "\r").Split('\r');
            }
        }

        public String[] Blacklist
        {
            get
            {
                return txtBlack.Text.Trim().Replace("\r\n", "\r").Split('\r');
            }
        }

        public StringDictionary Candidates
        {
            set
            {
                foreach (DictionaryEntry de in value)
                {
                    listCandidates.Items.Add(de.Key);
                }
            }
        }

        public void Clear()
        {
            listCandidates.Items.Clear();
            txtScan.Text = "";
            txtWhite.Text = "";
            txtBlack.Text = "";
        }
    }
}
