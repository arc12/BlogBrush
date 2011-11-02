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
        int references;
        String type;
        public int References
        {
            get { return references; }

        }
        public String Type
        {
            get { return type; }
        }

        public UrlMD(String typ, int refs)
        {
            references = refs;
            type=typ;
        }
    }
}
