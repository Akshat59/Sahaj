using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m1.Shared
{
    public class ExceptionManagement
    {
        private static string _appErrorLog = string.Empty;

        public static void  logAppException(Exception Ex)
        {
            _appErrorLog += "\r\n" + Ex.Message+"\r\n"+Ex.InnerException + "\r\n" + Ex.StackTrace;
            PublishLogstoDatabase();

        }

        public static void logUserException(Exception Ex)
        {
            _appErrorLog += "\r\n" + Ex.Message;
            PublishLogs();


        }

        public static void PublishLogs()
        {
            AppGlobal.appErrorLog = AppGlobal.appErrorLog + "\r\n" + _appErrorLog;
        }

        public static void PublishLogstoDatabase()
        {
            AppGlobal.appErrorLog = AppGlobal.appErrorLog + "\r\n" + _appErrorLog;

            //Code to write logs to file & Database................... #futureCode
        }



    }
}
