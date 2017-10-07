using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Security.Permissions;
using m1.Shared.Entities;
using m1.Shared;

namespace Sayen
{
    static class Program
    {

        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        
        [STAThread]
        static void Main()
        {
            // Add handler to handle the exception raised by main threads
            Application.ThreadException +=
            new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            // Add handler to handle the exception raised by additional threads
            AppDomain.CurrentDomain.UnhandledException +=
            new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // try
            {
                Application.Run(new frm_login());
            }
          //  catch(Exception Ex)
            {
                //ShowExceptionDetails(Ex);
            }

        }

        static void Application_ThreadException
                (object sender, System.Threading.ThreadExceptionEventArgs e)
        {// All exceptions thrown by the main thread are handled over this method

            ShowExceptionDetails(e.Exception);
        }

        static void CurrentDomain_UnhandledException
            (object sender, UnhandledExceptionEventArgs e)
        {// All exceptions thrown by additional threads are handled in this method

            ShowExceptionDetails(e.ExceptionObject as Exception);

            e = null;

            // Suspend the current thread for now to stop the exception from throwing.
            //Thread.CurrentThread.Suspend();
        }

        private static void ShowExceptionDetails(Exception Ex)
        {
            ErrorLogEntity elog = new ErrorLogEntity();
            elog.HelpLink = Ex.HelpLink;
            // elog.InnerException = Ex.InnerException.ToString();
            elog.U_error_message = Ex.Message;
            elog.U_error_source = Ex.Source;
            elog.U_stacktrace = Ex.StackTrace;
            elog.TargetSite = Ex.TargetSite;
            elog.U_error_detail = string.Format("{0} TargetSite: {1}","Exception handeled in program.cs ",Ex.TargetSite.ToString());
            elog.U_IfLogtoDatabase = true;
            elog.U_IfLogtoEventLogs = true;
            elog.U_error_date = AppGlobal.g_GEntity.SessionEntity.CurrentTimeStamp;
            elog.U_error_loggedby = ErrorLogEntity.errorLoggedBy.System;
            ExceptionManagement.logAppException(elog);
        }
    }
}
