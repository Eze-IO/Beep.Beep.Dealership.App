using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Beep.Beep.Dealership.App.Core
{
    public static class Library
    {
        private static string mainApp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Beep.Beep.Dealership.App");
        private static string logfile = Path.Combine(mainApp, "events.log");

        public static string Logfile { get { return logfile; } }

        public static void WriteLog(string message, TypeLog type = TypeLog.Information)
        {
            WriteActualLog(message, type);
        }

        public static void WriteLog(Exception ex, TypeLog type = TypeLog.Error)
        {
            WriteActualLog(String.Format("Error[{0}]: {1}", ex.HResult, ex.Message), type);
        }

        private static void WriteActualLog(string message, TypeLog type)
        {
            try
            {
                createDirectory();

                if (string.IsNullOrEmpty(message))
                    return;

                if (File.Exists(logfile))
                    File.SetAttributes(logfile, FileAttributes.Normal);

                using (FileStream fs = File.Open(logfile, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(DateTime.Now.ToString() + "| [" + GetType(type) + "] " + message);
                        sw.Flush();
                        fs.Close();
                    }
                }
                File.SetAttributes(logfile, FileAttributes.ReadOnly);
            }
            catch { return; }
        }

        private static void createDirectory()
        {
            try
            {
                if (!Directory.Exists(mainApp))
                    Directory.CreateDirectory(mainApp);
            }
            catch { return; }
        }

        private static string GetType(TypeLog type)
        {
            string i = string.Empty;
            switch (type)
            {
                case TypeLog.Error:
                    i = "error";
                    break;
                case TypeLog.Warning:
                    i = "warn";
                    break;
                case TypeLog.CriticalError:
                    i = "critical error";
                    break;
                case TypeLog.Information:
                default:
                    i = "info";
                    break;
            }
            return i;
        } 
    }

    public enum TypeLog
    {
        Information = 1,
        Error = 2,
        Warning = 3,
        CriticalError = 4
    }
}
