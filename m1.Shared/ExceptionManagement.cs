using m1.Shared.Configs;
using m1.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace m1.Shared
{
    public class ExceptionManagement
    {
        private static string _appErrorLog = string.Empty; //will be appended
        private static string _appErrorLog_new = string.Empty; //will get overriden

        public static void logAppException(ErrorLogEntity elog)
        {
            _appErrorLog_new = "\r\n" + elog.U_error_message + "\r\n" + elog.InnerException + "\r\n" + elog.U_stacktrace;
            _appErrorLog += _appErrorLog_new;

            PublishLogs_toAppGlobal();
            if (elog.U_IfLogtoEventLogs) { PublishLogs_toEventLog(); }
            if (elog.U_IfLogtoDatabase) { PublishLogs_toDatabase(elog); }

        }

        public static void logUserException(ErrorLogEntity elog)
        {
            _appErrorLog_new = "\r\n" + elog.U_error_message + "\r\n" + elog.InnerException + "\r\n" + elog.U_stacktrace;
            _appErrorLog += _appErrorLog_new;
            PublishLogs_toAppGlobal();
            if (elog.U_IfLogtoEventLogs) { PublishLogs_toEventLog(); }
            if (elog.U_IfLogtoDatabase) { PublishLogs_toDatabase(elog); }
        }
        private static void PublishLogs_toAppGlobal()
        {
            AppGlobal.appErrorLog = AppGlobal.g_GEntity.SessionEntity.CurrentTimeStamp+"\r\n"+_appErrorLog_new + "\r\n" + AppGlobal.appErrorLog ;
        }

        private static void PublishLogs_toEventLog()
        {
            //NoEventLogs  #futureCode
        }

        private static void PublishLogs_toDatabase(ErrorLogEntity elog)
        {
            elog.U_create_id = AppGlobal.g_GEntity.SessionEntity.User_id;
            elog.U_create_date = AppGlobal.g_GEntity.SessionEntity.CurrentTimeStamp;

            string query = ConfigSettings.GetAppSetting("Query_InsertErrorLogs").ToString();
            List<SqlParameter> sp = new List<SqlParameter>()
            {                
                new SqlParameter() {ParameterName = "@error_cd", SqlDbType = SqlDbType.NVarChar, Value= elog.U_error_cd},
                new SqlParameter() {ParameterName = "@error_type", SqlDbType = SqlDbType.NVarChar, Value= elog.U_error_type},
                new SqlParameter() {ParameterName = "@error_date", SqlDbType = SqlDbType.NVarChar, Value= elog.U_error_date},
                new SqlParameter() {ParameterName = "@error_message", SqlDbType = SqlDbType.NVarChar, Value= elog.U_error_message},
                new SqlParameter() {ParameterName = "@error_detail", SqlDbType = SqlDbType.NVarChar, Value= elog.U_error_detail},
                new SqlParameter() {ParameterName = "@request_xml", SqlDbType = SqlDbType.Xml, Value= elog.U_request_xml},
                new SqlParameter() {ParameterName = "@response_xml", SqlDbType = SqlDbType.Xml, Value= elog.U_response_xml},
                new SqlParameter() {ParameterName = "@stacktrace", SqlDbType = SqlDbType.NVarChar, Value= elog.U_stacktrace},
                new SqlParameter() {ParameterName = "@error_log", SqlDbType = SqlDbType.Xml, Value= elog.U_error_log},
                new SqlParameter() {ParameterName = "@error_source", SqlDbType = SqlDbType.NVarChar, Value= elog.U_error_source},
                new SqlParameter() {ParameterName = "@error_loggedby", SqlDbType = SqlDbType.NVarChar, Value= elog.U_error_loggedby},
                new SqlParameter() {ParameterName = "@Resv1", SqlDbType = SqlDbType.NVarChar, Value= string.Empty},
                new SqlParameter() {ParameterName = "@Resv2", SqlDbType = SqlDbType.NVarChar, Value= string.Empty},
                new SqlParameter() {ParameterName = "@create_id", SqlDbType = SqlDbType.NVarChar, Value= elog.U_create_id},
                new SqlParameter() {ParameterName = "@create_date", SqlDbType = SqlDbType.NVarChar, Value= elog.U_create_date},

            };
            if (1 != _ExecuteNonQuery(query, sp))
            {
                if (sp != null)
                {
                    foreach (SqlParameter p in sp)
                    {
                        query = query.Replace(p.ParameterName.ToString(), p.Value.ToString());
                    }
                }

                _appErrorLog_new = string.Format("Issues while inserting excption logs into database: Source - ExceptionManagement.PublishLogs_toDatabase; QueryUsed - {0}",query);
                PublishLogs_toAppGlobal();
            }
        }
        private static int _ExecuteNonQuery(string query, List<SqlParameter> sp)
        {
            int _ret = 0;
            string _sqlLog = string.Empty;

            try
            {
                string conStrng = ConfigSettings.GetConnectionString("SQL_d1_Dev_ConnectionString").ToString();
                using (SqlConnection myConnection = new SqlConnection(conStrng))
                {
                    SqlCommand oCmd = new SqlCommand(query, myConnection);
                    oCmd.CommandType = CommandType.Text;

                    if (sp != null)
                    {
                        oCmd.Parameters.AddRange(sp.ToArray());
                    }

                    myConnection.Open();

                    _ret = oCmd.ExecuteNonQuery();
                }
                return _ret;
            }
            //catch(SqlException S)
            //{
            //    return 0;
            //}
            catch (Exception Ex)
            {
                _appErrorLog += "\r\n" + Ex.Message + "\r\n" + Ex.InnerException + "\r\n" + Ex.StackTrace;
                AppGlobal.appErrorLog = AppGlobal.appErrorLog + "\r\n" + _appErrorLog;
                return 0;
            }
            finally
            {
                AppGlobal.sqlErrorLog = _sqlLog;
            }
        }

        /*      
         *      ErrorLogEntity elog = new ErrorLogEntity
                {
                    U_error_message = "Some Issues while Restoring Data",
                    U_error_source = "genDAC.dacWriteDataSetToTable",
                    U_error_detail = _logDetail,
                    U_IfLogtoDatabase = true,
                    U_IfLogtoEventLogs = true,
                    U_error_loggedby = ErrorLogEntity.errorLoggedBy.User,
                    U_error_type = ErrorLogEntity.errorType.Error,
                    U_error_date = AppGlobal.g_GEntity.SessionEntity.CurrentTimeStamp,
                };
                ExceptionManagement.logUserException(elog);
                */


    }



}

