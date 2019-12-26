using System;
using System.IO;
using System.Reflection;

namespace Classes
{
    public static class LogUtils
    {
        private static readonly string APP_START_TIME = DateTime.Now.ToString("yyyy-MM-dd_HHmmss").ToString();
        private static readonly string LOG_FILE_NAME = APP_START_TIME + "_log.txt";

        public static void AddLogTextLine(string strLogTextLine)
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
            catch (Exception)
            {
                //silence
            }
        }
    }
}
