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

    public class AppConstants
    {
        public const string CallStatusSuccess = "Success";
        public const string CallStatusFailure = "Failure";
        public const string CallStatusError = "Error";
        public const string DropDownListFirstItem = "--Select--";

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

        public enum e_AppUserRoles { Guest=0,Admin=1, AppDeveloper=2,AppTester=3,BranchManager=4,BranchClerk=5};
        

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

        public enum e_EmployeeType { Driver, Conductor, OfficeStaff,Board }

        /// <summary>
        /// This enum have codes which signifies type of Message of form
        /// A-Alert, E - Error, W - Warning, N - Notification
        /// </summary>
        public enum e_MsgType { A, E, W,N };

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
        /// <summary>
        /// This enum have codes which signifies initial of primary keys of varius database table
        /// a0-Escalated Employee, e11- employee office staff, e12- employee driverConductor, e13- employee others
        /// v15 - vehicles Private, v16-vehicles Buses, v17 - vehicles others
        /// p-20 - permits, i30-insurance,r40
        /// </summary>
        public enum e_PrimaryKeySeries { a09, e11, e12,e13,v15, v16, v17, p20,i30,r40 };

        public enum e_BulkUploadType { NONE,EMPLOYEE, VEHICLE, PERMIT, INSURANCE, ROUTE };

        /// <summary>
        /// Differeny Entities which can use use view User control EMPLOYEE, VEHICLE, PERMIT, INSURANCE, ROUTE, ALL
        /// </summary>
        public enum e_ViewEntityType { EMPLOYEE, VEHICLE, PERMIT, INSURANCE, ROUTE, ALL };
        public enum e_DrivingLicence { HMV, HLTV, LMV };

        /// <summary>
        /// This enum have codes which signifies type of operation happening
        /// V-View, S- Single Insert, B- Bulk Insert, X - Single Delete/Terminate, U- Single Update/Modify
        /// </summary>
        public enum e_frmOperationType { V, S, B, X, U };

        /// <summary>
        /// This enum have codes which signifies type of Gender
        /// M-Male, F- Female, X - Transgender, Z - NotSpecified
        /// </summary>
        public enum e_Gender { M,F,X,Z };

        /// <summary>
        /// This enum have codes which signifies type of Document
        /// XXX- Invalid, AAD-Adhaar, APX - Address Proof, DLF - Driving Licence Front, DLF - Driving Licence Back, EPH- Employee Photograph
        /// </summary>
        public enum e_DocType { XXX, AAD, APX, DLF, EPH};

        #region GetSetPaths
        public const string setHomePath = "..\\..\\..";
        public const string setImagesPath = "\\WEB\\images";
        public const string empImgDocPath = "\\empDocs";
        #endregion GetSetPaths

        #region FileNameInitialsSeries  //fn - filename
        public const string fn_empDoc = "img_edoc_";
        #endregion

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
        public const string NextIDEmpty = "Retrieved Next ID is empty";
        public const string SubmitFormError = "There are errors on form, Correct and Resubmit";
        public const string SubmitFormSuccess = "Form Validated successfully";
        public const string DatabaseUpdateFailure = "Error while updating Details";
        public const string DatabaseUpdateSuccess = "Details updated Successfully";

        public const string InsertEmpFailure = "Unexpected Error While Inserting Employee Details";
        public const string InsertEmpSuccess = "Details for {0} added Successfully";
        public const string InsertEmpIDSuccess = "Details for {0} added Successfully with empID: {1}";
        public const string UpdateEmpFailure = "Unexpected Error While Updating Employee Details";
        public const string UpdateEmpSuccess = "Details for {0} updated Successfully";
        public const string InsertEmpDocFailure = "One or more Employee Docs failed to Insert";
        public const string InsertEmpDocSuccess = "Documents added Successfully";
        public const string UpdateEmpDocFailure = "One or more Employee Docs failed to Update";
        public const string UpdateEmpDocSuccess = "Documents updated Successfully";
        public const string ValidDLRequired = "Valid DL is required";
        public const string InvalidMobileNumber = "Invalid Mobile Number";
        public const string InvalidAadhar= "Invalid Aadhaar Number";
        public const string RetrieveEmpFailed = "Error while retrieving employee details";
        public const string RetrieveEmpDocsFailed = "Error while retrieving employee docs";
        public const string ConfirmTerminateEmp_text = "Are you sure you want to terminate the Employee";
        public const string ConfirmTerminateEmp_title = "Terminate Employee?";
        public const string ConfirmAppLogOut = "Are you sure you want to Log Out?";
        public const string ConfirmAppExit = "Are you sure you want to Exit Application?";
        public const string Ques_AreYouSure = "Are You Sure?";


    }
    #endregion UserMessages


}


