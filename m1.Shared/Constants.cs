using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m1.Shared
{
    public class Constants
    {
    }

    #region ApplicationConstants

    public class ApplicationConstants
    {
        public const string CallStatusSuccess = "Success";
        public const string CallStatusFailure = "Failure";
        public const string CallStatusError = "Error";

        public static Dictionary<string, string> AppEnvironments = new Dictionary<string, string>()
        {
            { "DEV", "d1_dev" },
            { "TEST", "t1_dev" },
            { "PROD", "p1_dev" }
        };
    }


    



    #endregion ApplicationConstants

    #region UserMessages
    public struct UserMessages
    {
        public const string InvalidLogon = "Invalid UserName/Password";
        public const string DatabaseNotConnected = "Invalid UserName/Password";
        public const string ValidLogon = "Logon Successfull...";
        public const string AppException = "Exception Occured";
        public const string LogonDisclaimerTitle = "STOP and READ";


        public const string LogonDisclaimer = @"======================================================================================="
                                               + "\r\nPROPRIETARY INFORMATION\r\n\r\n"
                                               + "All content of this Application and its associated sub-systems are PROPRIETARY INFORMATION and remain the sole and exclusive property of NEW PREM BUS SERVICE.\r\n"
                                               + "This application may be accessed and used by authorized personnel only. Authorized users may only perform authorized activities and may not exceed the limits of such authorization.\r\n"
                                               + "Disclosure of information found in this application for any unauthorized use is *STRICTLY PROHIBITED*. All activities on this system are subject to monitoring. Intentional misuse of this system can result in disciplinary action or criminal prosecution.\r\n"
                                               + "\r\nARE YOU SURE YOU WANT TO CONTINUE?\r\n"
                                               + "========================================================================================";


    }
    #endregion UserMessages


}


