﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m1.Shared
{
    public class Constants
    {
    }

    #region ApplicationConstants

    public class AppConstants
    {
        public const string CallStatusSuccess = "Success";
        public const string CallStatusFailure = "Failure";
        public const string CallStatusError = "Error";

        public static Dictionary<string, string> d_AppEnvironments = new Dictionary<string, string>()
        {
            { "DEV", "d1_dev" },
            { "TEST", "t1_dev" },
            { "PROD", "p1_dev" }
        };

        public enum e_AppEnvironment { DEV,TEST,PROD };

        public static Dictionary<string, string> AppUserRoles = new Dictionary<string, string>()
        {
            { "Admin", "role_admin" },
            { "AppDeveloper", "role_appdev" },
            { "AppTester", "role_apptest" },
            { "BranchManager", "role_brnchmgr" },
            { "BranchClerk", "role_brnchclerk" },
            { "Guest", "role_guest" }
        };

        public static Dictionary<string, string> d_HomePageTabs = new Dictionary<string, string>()
        {
            { "Welcome", "tabPage_welcome" },
            { "Notifications", "tabPage_notifications" },
            { "Search", "tabPage_search" },
            { "View", "tabPage_view" },
            { "Manage", "tabPage_manage" },
            { "Bookings", "tabPage_bookings" },
            { "Admin", "tabPage_admin" },
        };

        public static Dictionary<string, string> d_EmployeeType = new Dictionary<string, string>()
        {
            { "Driver", "emptype_driver_5531" },
            { "Conductor", "emptype_conductor_5532" },
            { "Office Staff", "emptype_officestaff_5533" }
         
        };

        public const string TabPageWelcome= "tabPage_welcome";
        public const string TabPageNotifications = "tabPage_notifications";
        public const string TabPageSearch = "tabPage_search";
        public const string TabPageView = "tabPage_view";
        public const string TabPageManage = "tabPage_manage";
        public const string TabPageBooking = "tabPage_booking";
        public const string TabPageAdmin = "tabPage_admin";

        public const string uc_title_AddEmployee = "Add Employee";
        public const string uc_title_AddVehicle = "Add Vehicle";
        public const string uc_title_AddPermit = "Add Permit";
        public const string uc_title_AddInsurance = "Add Insurance";
        public const string uc_title_AddRoute = "Add Route";
        public const string uc_title_defaultBulkUpload = "Bulk Upload";

        public static Dictionary<string, string> d_BulkUploadType = new Dictionary<string, string>()
        {
            { "blkup_Employee", "blkupload_employee_5541" }

        };

        public enum e_BulkUploadType { NONE,EMPLOYEE, VEHICLE, PERMIT, INSURANCE, ROUTE };
        public enum e_DrivingLicence { HMV, HLTV, LMV };

        /// <summary>
        /// This enum have codes which signifies type of operation happening
        /// V-View, S- Single Insert, B- Bulk Insert, X - Single Delete, U- Update
        /// </summary>
        public enum e_frmOperationType { V, S, B, X, U };

        /// <summary>
        /// This enum have codes which signifies type of Gender
        /// M-Male, F- Female, X - Transgender, Z - NotSpecified
        /// </summary>
        public enum e_Gender { M,F,X,Z };

        

    }

    public struct AppKeys
    {
        public const string Yes = "Y";
        public const string No = "N";
        public const string Success = "S";
        public const string Failure = "F";
        public const string Active = "A";
        public const string Deactive = "D";
    }




    #endregion ApplicationConstants

    #region UserMessages
    public struct UserMessages
    {
        public const string InvalidLogon = "Invalid UserName/Password";
        public const string DatabaseNotConnected = "Invalid UserName/Password";
        public const string ValidLogon = "Logon Successfull...";
        public const string AppException = "Exception Occured";
        public const string LoginIsuuesMsg = "Contact System admin";
        public const string LoginIsuuesTitle = "Login Issue?";

        public const string LogonDisclaimerTitle = "STOP and READ";
        public const string LogonDisclaimer = @"======================================================================================="
                                               + "\r\nPROPRIETARY INFORMATION\r\n\r\n"
                                               + "All content of this Application and its associated sub-systems are PROPRIETARY INFORMATION and remain the sole and exclusive property of NEW PREM BUS SERVICE.\r\n"
                                               + "This application may be accessed and used by authorized personnel only. Authorized users may only perform authorized activities and may not exceed the limits of such authorization.\r\n"
                                               + "Disclosure of information found in this application for any unauthorized use is *STRICTLY PROHIBITED*. All activities on this system are subject to monitoring. Intentional misuse of this system can result in disciplinary action or criminal prosecution.\r\n"
                                               + "\r\nARE YOU SURE YOU WANT TO CONTINUE?\r\n"
                                               + "========================================================================================";

        public const string NoLogsMsg = "No Logs to Show";
        public const string ShowLogTitle = "App Logs";
    }
    #endregion UserMessages


}


