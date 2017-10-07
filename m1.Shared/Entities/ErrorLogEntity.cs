using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace m1.Shared.Entities
{
    public class ErrorLogEntity
    {

        public enum errorLoggedBy {System,User,SQL};
        public enum errorType { Info, Warning, Error };

        private string u_error_cd = string.Empty;
        private errorType u_error_type = errorType.Error;
        private string u_error_date = string.Empty;
        private string u_error_message = string.Empty;
        private string u_error_detail = string.Empty;
        private string u_request_xml = string.Empty;
        private string u_response_xml = string.Empty;
        private string u_stacktrace = string.Empty;
        private string u_error_log = string.Empty;
        private string u_error_source = string.Empty;
        private errorLoggedBy u_error_loggedby = errorLoggedBy.System;
        private string u_create_id = string.Empty;
        private string u_create_date = string.Empty;
        private bool u_IfLogtoDatabase = false;
        private bool u_IfLogtoEventLogs = false;

       


        //From Exception class

        //
        // Summary:
        //     Gets or sets a link to the help file associated with this exception.
        //
        // Returns:
        //     The Uniform Resource Name (URN) or Uniform Resource Locator (URL).
        public string HelpLink { get; set; }
        //
        // Summary:
        //     Gets the System.Exception instance that caused the current exception.
        //
        // Returns:
        //     An instance of Exception that describes the error that caused the current exception.
        //     The InnerException property returns the same value as was passed into the constructor,
        //     or a null reference (Nothing in Visual Basic) if the inner exception value was
        //     not supplied to the constructor. This property is read-only.
        public string InnerException { get; set; }
        //
        // Summary:
        //     Gets a message that describes the current exception.
        //
        // Returns:
        //     The error message that explains the reason for the exception, or an empty string("").
        //public string Message { get; set; }
        //
        // Summary:
        //     Gets or sets the name of the application or the object that causes the error.
        //
        // Returns:
        //     The name of the application or the object that causes the error.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The object must be a runtime System.Reflection object
        //public string Source { get; set; }
        //
        // Summary:
        //     Gets a string representation of the immediate frames on the call stack.
        //
        // Returns:
        //     A string that describes the immediate frames of the call stack.
        //public string StackTrace { get; set; }
        //
        // Summary:
        //     Gets the method that throws the current exception.
        //
        // Returns:
        //     The System.Reflection.MethodBase that threw the current exception.
        public MethodBase TargetSite { get; set; }

        //
        // Summary:
        //     Gets or sets a link to the help file associated with this exception.
        //
        // Returns:
        //     The Uniform Resource Name (URN) or Uniform Resource Locator (URL).


        //From SQL Exception class
        //
        // Summary:
        //     Gets the line number within the Transact-SQL command batch or stored procedure
        //     that generated the error.
        //
        // Returns:
        //     The line number within the Transact-SQL command batch or stored procedure that
        //     generated the error.
        public int s_LineNumber { get; set; }
        //
        // Summary:
        //     Gets a number that identifies the type of error.
        //
        // Returns:
        //     The number that identifies the type of error.
        public int s_Number { get; set; }
        //
        // Summary:
        //     Gets the name of the stored procedure or remote procedure call (RPC) that generated
        //     the error.
        //
        // Returns:
        //     The name of the stored procedure or RPC.
        public string s_Procedure { get; set; }
        //
        // Summary:
        //     Gets the name of the computer that is running an instance of SQL Server that
        //     generated the error.
        //
        // Returns:
        //     The name of the computer running an instance of SQL Server.
        public string s_Server { get; set; }
        //
        // Summary:
        //     Gets the name of the provider that generated the error.
        //
        // Returns:
        //     The name of the provider that generated the error.
        public string s_Source { get; set; }
        //
        // Summary:
        //     Gets a numeric error code from SQL Server that represents an error, warning or
        //     "no data found" message. For more information about how to decode these values,
        //     see SQL Server Books Online.
        //
        // Returns:
        //     The number representing the error code.
        public byte s_State { get; }

        public string U_error_cd
        {
            get
            {
                return u_error_cd;
            }

            set
            {
                u_error_cd = value;
            }
        }

        public errorType U_error_type
        {
            get
            {
                return u_error_type;
            }

            set
            {
                u_error_type = value;
            }
        }

        public string U_error_message
        {
            get
            {
                return u_error_message;
            }

            set
            {
                u_error_message = value;
            }
        }

        public string U_error_detail
        {
            get
            {
                return u_error_detail;
            }

            set
            {
                u_error_detail = value;
            }
        }

        public string U_request_xml
        {
            get
            {
                return u_request_xml;
            }

            set
            {
                u_request_xml = value;
            }
        }

        public string U_response_xml
        {
            get
            {
                return u_response_xml;
            }

            set
            {
                u_response_xml = value;
            }
        }

        public string U_stacktrace
        {
            get
            {
                return u_stacktrace;
            }

            set
            {
                u_stacktrace = value;
            }
        }

        public string U_error_log
        {
            get
            {
                return u_error_log;
            }

            set
            {
                u_error_log = value;
            }
        }

        public string U_error_source
        {
            get
            {
                return u_error_source;
            }

            set
            {
                u_error_source = value;
            }
        }

        public errorLoggedBy U_error_loggedby
        {
            get
            {
                return u_error_loggedby;
            }

            set
            {
                u_error_loggedby = value;
            }
        }

        public string U_create_id
        {
            get
            {
                return u_create_id;
            }

            set
            {
                u_create_id = value;
            }
        }

        public string U_create_date
        {
            get
            {
                return u_create_date;
            }

            set
            {
                u_create_date = value;
            }
        }

        public bool U_IfLogtoDatabase
        {
            get
            {
                return u_IfLogtoDatabase;
            }

            set
            {
                u_IfLogtoDatabase = value;
            }
        }

        public bool U_IfLogtoEventLogs
        {
            get
            {
                return u_IfLogtoEventLogs;
            }

            set
            {
                u_IfLogtoEventLogs = value;
            }
        }

        public string U_error_date
        {
            get
            {
                return u_error_date;
            }

            set
            {
                u_error_date = value;
            }
        }


        //User created



    }
}
