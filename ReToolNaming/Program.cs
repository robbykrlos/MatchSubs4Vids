using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace MatchSubs4Vids
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] arrArgs = Environment.GetCommandLineArgs();
            string path = "";
            for (int i = 0; i < arrArgs.Length; i++)
            {
                string arg = arrArgs[i];

                switch (arg)
                {
                    case "/path":
                        if (i < arrArgs.Length)
                        {
                            path += arrArgs[++i];
                        }
                        break;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(path));
        }
    }
}
