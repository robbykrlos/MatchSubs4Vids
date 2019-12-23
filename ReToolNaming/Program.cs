using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace ReToolNaming
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
            string cmdLineArg = "";
            string path = "";
            for (int i = 0; i < arrArgs.Length; i++   ){
                string arg = arrArgs[i];

                switch (arg)
                {
                    case "/u":
                        i++;
                        if (i < arrArgs.Length) cmdLineArg += "/x{" + arrArgs[i] + "}";
                        break;

                    case "/path":
                        i++;
                        if (i < arrArgs.Length) path += arrArgs[i];
                        break;
                }
            }

            if (cmdLineArg != "")
            {
                Process.Start("msiexec.exe", cmdLineArg);
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(path));
            }
        }
    }
}
