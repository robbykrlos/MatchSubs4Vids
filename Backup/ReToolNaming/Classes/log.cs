using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ReToolNaming.Classes
{
    public static class log
    {
        private const string LOG_FILE_NAME = "log.txt";

        public static void addLogTextLine(string strLogTextLine)
        {
            try //in case WIN 7 special permissions blocks the file, skipp.
            {
                StreamWriter streamWriter;
                string strAppExecutablePath = Assembly.GetExecutingAssembly().Location;
                FileInfo execFile = new FileInfo(strAppExecutablePath);
                string strAppInstallationPath = execFile.Directory.FullName;
                FileInfo fileInfo = new FileInfo(strAppInstallationPath + "\\" + LOG_FILE_NAME);

                streamWriter = new StreamWriter(fileInfo.FullName, fileInfo.Exists);

                streamWriter.WriteLine("[" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString() + "] " + strLogTextLine);
                streamWriter.Close();
            }
            catch(Exception ex){}
        }
    }
}
