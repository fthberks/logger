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
    public class ErrorLogger : TextLogger
    {
        
        public ErrorLogger() :base()
        {
            LogFileConfigKey = "ErrorLogFile";
            logFileNameExtension = "ErrorLogFileNameExtension";            
        }
    }
}
