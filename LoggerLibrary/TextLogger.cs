using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Extensions;
using Utils;
using Constants;
using Exceptions;

namespace LoggerLibrary
{
    public abstract class TextLogger : ILogger
    {
        
        private const string LogFolderPathConfigKey = "LogFolderPath";
        public static string LogFileNameExtensionConfigKey
        {
            get; set;
        }

        protected static string logPath
        {
            get; set;
        }

        protected static string logFolder
        {
            get; set;
        }

        protected static string logFileName
        {
            get; set;
        }

        protected static string logFileNameExtension
        {
            get; set;
        }
        public static string LogFileConfigKey { get;  set; }

        public void Log(object o)
        {
            File.AppendAllText(logPath, o.ToString());
        }

        
        public TextLogger()
        {
            logFolder = ConfigurationManager.AppSettings[LogFolderPathConfigKey];
            if(logFolder.IsNullOrEmpty())
            {
                throw new LogFolderConfigKeyMissingException();
            }

            if (!Directory.Exists(logFolder))
                Directory.CreateDirectory(logFolder);

            string logFileName = ConfigurationManager.AppSettings[LogFileConfigKey];
            if (logFileName.IsNullOrEmpty())
            {
                logFileName = RandomUtils.GetRandomFileName(LogConstants.LogDefaultFileNameSize);
            }

            string logFileNameExtension = ConfigurationManager.AppSettings[LogFileNameExtensionConfigKey];
            if (logFileNameExtension.IsNullOrEmpty())
            {
                logFileNameExtension = LogConstants.LogDefaultFileNameExtension;
            }

            logPath = string.Format("{0}/{1}{2}", logFolder, logFileName, logFileNameExtension);
        }
    }
}
