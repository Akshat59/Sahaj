using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using m1.Shared.Entities;
//using m1.Shared;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using m1.Shared;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using m1.Shared.DataBackUp;
using System.Globalization;
using System.Collections;

namespace m1.DAC
{
    public class genDAC : m1BaseDac
    {
        int _retCnt = 0;

        public genDAC()
        {

        }

        #region UserMethods
        public bool dacTestDatabaseConnection()
        {
            return base.TestDatabaseConnection();
        }


        /// <summary>
        /// This method is to retrive next id column (primary key) from table from the database table as per enum e_PrimaryKeySeries
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="seriesInitials as specified enum e_PrimaryKeySeries"></param>
        /// <param name="sqlColumn target column"></param>
        /// <param name="totallength for padding"
        public string dacGetNextID(string tableName, string sqlColumn, string totalLength, string seriesInitials, bool randomNo=false)
        {
            string _nextID = string.Empty;
            string sqlSelectQuery = base.RetrieveSqlQuery(QueryConstants.GetNextID).ToString();
            int _i = Convert.ToInt32(totalLength) - seriesInitials.Length; //to replace as {2}

            //futureCode - use Procedure to implement if user needs next id as random
            

            sqlSelectQuery = string.Format(sqlSelectQuery, tableName, sqlColumn, seriesInitials, seriesInitials.Length.ToString(), totalLength);


            string _s_ret = base.bExecuteScalar(sqlSelectQuery);

            if (_s_ret.Equals(string.Empty))
            {
                //log error  #futureCode
                throw new Exception(UserMessages.NextIDEmpty);
            }
            else
            {
                _nextID = _s_ret.PadLeft(Convert.ToInt32(totalLength) - seriesInitials.Length, '0');
                _nextID = seriesInitials + _nextID;
            }

            return _nextID;
        }

        public void dacParseExecuteQuery(string _sqlQuery, int mode,out string retMsg,out DataTable retDT)
        {
            base.bParseExecute(_sqlQuery, mode, out retMsg,out retDT);            
        }

        public void dacReadTableData(object obj)
        {
            DataBackupEntity _obj = (DataBackupEntity)obj;

            string SQLselect = string.Format(QueryConstants.ReadTableData, _obj.TableName);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            using (dt = base.bExecuteDataReader(SQLselect))
            {
                if (dt.Rows.Count >= 1)
                {
                    dt1 = dt.Copy();
                    ds.Tables.Add(dt1);
                }
                else
                {
                    string _logDetail = string.Format("Query Used - {0}\r\nRows Retrieved: {1}", SQLselect, dt.Rows.Count);

                    ErrorLogEntity elog = new ErrorLogEntity
                    {
                        U_error_message = "Some Issues while Backing Data",
                        U_error_source = "genDAC.dacReadTableData",
                        U_error_detail = _logDetail,
                        U_IfLogtoDatabase = true,
                        U_IfLogtoEventLogs = true,
                        U_error_loggedby = ErrorLogEntity.errorLoggedBy.User,
                        U_error_type = ErrorLogEntity.errorType.Error,
                        U_error_date = AppGlobal.g_GEntity.SessionEntity.CurrentTimeStamp,                        
                    };

                    ExceptionManagement.logUserException(elog);
                }
            }

            _obj.ResultDataSet = ds;
        }

        public void dacRetrieveErrorLogs(SearchEntity se)
        {
            string SQLselect = base.RetrieveSqlQuery(QueryConstants.RetrieveErrorLogs).ToString();
            DataTable dt = new DataTable();

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@refDate", SqlDbType = SqlDbType.DateTime, Value= Convert.ToDateTime(se.SearchField1)},
            };

            using (dt = base.bExecuteDataReader(SQLselect, sp))
            {
                if (dt.Rows.Count < 1)
                {
                    se.RetCount = 0;
                }
                else
                {
                    se.RetCount = dt.Rows.Count;
                    se._retDT = dt;
                }
            }
        }

        public void dacWriteDataSetToTable(DataBackupEntity obj_dataBkup)
        {
            string _tableName = string.Format("{0}{1}", obj_dataBkup.TableName, "_bkup"); 

            StringBuilder _colList = new StringBuilder();
            _colList = Utilities.RetrieveColumnList(obj_dataBkup.TableName);           

            StringBuilder sqlQuery = new StringBuilder();
            sqlQuery.Append(string.Format("SET IDENTITY_INSERT dbo.{0} ON; ", _tableName));
            sqlQuery.Append("INSERT INTO ");
            sqlQuery.Append(_tableName);
            //sqlQuery.Append("_bkup");
            sqlQuery.Append(string.Format("({0})", _colList.ToString()));
            sqlQuery.Append(" VALUES\r\n(");

            DataTable dt = new DataTable();
            dt = obj_dataBkup.ResultDataSet.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                sqlQuery.Append(row[0].ToString());
                sqlQuery.Append(",");
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    sqlQuery.Append("'");
                    sqlQuery.Append(row[i].ToString());
                    sqlQuery.Append("'");
                    sqlQuery.Append(",");
                }
                sqlQuery.Length -= 1;
                sqlQuery.Append("),\r\n(");                
            }
            string _sqlQuery = sqlQuery.ToString().Trim();
            sqlQuery = new StringBuilder(_sqlQuery);
            
            sqlQuery.Length -= 4;
            string _q = sqlQuery.ToString();
            sqlQuery.Append("; ");
            sqlQuery.Append(string.Format("SET IDENTITY_INSERT dbo.{0} OFF; ", _tableName));
            _sqlQuery = sqlQuery.ToString().Trim();

            this.dacTruncateTable(_tableName);

            int ret = base.bExecuteNonQuery(_sqlQuery);
            if (dt.Rows.Count == ret)
            {
                obj_dataBkup.ReturnInd = AppKeys.Success;
                obj_dataBkup.ReturnMessage = "Data Restore Successfull";
            }
            else
            {
                string _logDetail = string.Format("Query Used - {0}", _sqlQuery);
                
                ErrorLogEntity elog = new ErrorLogEntity
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
            }
        }

        public void dacTruncateTable(string tableName)
        {
            string _sqlQuery = (QueryConstants.TruncateTable) + tableName;
            _retCnt = base.bExecuteNonQuery(_sqlQuery);
            if (_retCnt <= 0) { }
            else { }

        }

        public bool dacValidateUserLogin(GenEntity GEntity)
        {

            string SQLselect = base.RetrieveSqlQuery(QueryConstants.ValidateUserLogin).ToString();
            DataTable dt = new DataTable();

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@user_id", SqlDbType = SqlDbType.NVarChar, Value= GEntity.UserEntity.Input_user_id},
                new SqlParameter() {ParameterName = "@password", SqlDbType = SqlDbType.NVarChar, Value= GEntity.UserEntity.User_pwd}, //#futureCode add pwd
            };

            using (dt = base.ExecuteDataAdapter(SQLselect, sp))
            {
                if (dt.Rows.Count < 1)
                {
                    return false;
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        GEntity.UserEntity.User_id = dr["user_id"].ToString();
                        GEntity.UserEntity.User_name = dr["user_name"].ToString();
                        GEntity.UserEntity.User_fname = dr["user_first_name"].ToString();
                        GEntity.UserEntity.User_lname = dr["user_last_name"].ToString();
                        GEntity.UserEntity.Role_id = dr["role_id"].ToString();
                        GEntity.UserEntity.Last_accessed = dr["last_accessed"].ToString();
                        GEntity.UserEntity.Last_pwd_change = dr["last_pwd_change"].ToString();
                        GEntity.UserEntity.Profilepic = dr["profilepic"].ToString();
                        break;
                    }
                   
                    AppGlobal.g_GEntity = GEntity;
                    AppGlobal.g_GEntity.SessionEntity.User_id = GEntity.UserEntity.User_id;
                    AppGlobal.g_GEntity.SessionEntity.Role_id = GEntity.UserEntity.Role_id;
                    return true;
                }
            }
        }

        public void dacGetUserNotes(UserEntity userEntity)
        {
            string SQLselect = base.RetrieveSqlQuery(QueryConstants.RetrieveUserNotes).ToString();
            DataTable dt = new DataTable();

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@user_id", SqlDbType = SqlDbType.NVarChar, Value= userEntity.User_id.ToString()},
                new SqlParameter() {ParameterName = "@note_date", SqlDbType = SqlDbType.Date, Value= userEntity.UserNoteDate},
            };

            using (dt = base.ExecuteDataAdapter(SQLselect, sp))
            {
                foreach (DataRow dr in dt.Rows)
                {
                    userEntity.UserNoteText = dr["note_text"].ToString();
                    break;
                }
            }
        }

        public List<DateTime> dacGetUserNoteAlldates(string userID)
        {
            string SQLselect = base.RetrieveSqlQuery(QueryConstants.RetrieveUserNoteAlldate).ToString();
            DataTable dt = new DataTable();
            List<DateTime> noteDates =new List<DateTime>();

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@user_id", SqlDbType = SqlDbType.NVarChar, Value= userID},                
            };

            using (dt = base.ExecuteDataAdapter(SQLselect, sp))
            {
                foreach (DataRow dr in dt.Rows)
                {                    
                    DateTime d = Convert.ToDateTime(dr["note_date"].ToString());
                    noteDates.Add(d);                                        
                }

                return noteDates;
            }
        }

        public void dacSaveUserNotes(UserEntity userEntity)
        {            
            string _sqlQuery = base.RetrieveSqlQuery(QueryConstants.InsertUserNotes).ToString();

            List<SqlParameter> cp = base.GetCommonParameters_Ins();

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@user_id", SqlDbType = SqlDbType.NVarChar, Value= userEntity.User_id},
                new SqlParameter() {ParameterName = "@note_date", SqlDbType = SqlDbType.NVarChar, Value= userEntity.UserNoteDate},
                new SqlParameter() {ParameterName = "@note_text", SqlDbType = SqlDbType.NVarChar, Value= userEntity.UserNoteText},

            };

            sp.AddRange(cp);

            int _cnt = base.bExecuteNonQuery(_sqlQuery, sp);
            if (_cnt <= 0)
            { }//log failure  #futureCode
            else { }//log success #futureCode
            }

        public void dacDeleteUserNotes(UserEntity userEntity)
        {
            string _sqlQuery = base.RetrieveSqlQuery(QueryConstants.DeleteUserNotes).ToString();

            List<SqlParameter> cp = base.GetCommonParameters_Ins();

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@user_id", SqlDbType = SqlDbType.NVarChar, Value= userEntity.User_id},
                new SqlParameter() {ParameterName = "@note_date", SqlDbType = SqlDbType.NVarChar, Value= userEntity.UserNoteDate},
            };

            sp.AddRange(cp);

            int _cnt = base.bExecuteNonQuery(_sqlQuery, sp);
            if (_cnt <= 0)
            { }//log failure  #futureCode
            else { }//log success #futureCode
        }

        public void dacSearchEntity(SearchEntity se)
        {
            string SQLselect = base.RetrieveSqlQuery(QueryConstants.SearchEntity).ToString();
            DataTable dt = new DataTable();

            List<SqlParameter> sp = new List<SqlParameter>()
            {
               
                new SqlParameter() {ParameterName = "@entId", SqlDbType = SqlDbType.NVarChar, Value= se.EntID},
                new SqlParameter() {ParameterName = "@name", SqlDbType = SqlDbType.NVarChar, Value= se.Name},
                new SqlParameter() {ParameterName = "@searchtype", SqlDbType = SqlDbType.NVarChar, Value= se.SearchType.ToString()},
            };

            using (dt = base.ExecuteDataAdapter(SQLselect, sp,CommandType.StoredProcedure))
            {
                if (dt.Rows.Count < 1)
                {
                    se.RetCount = 0;
                }
                else
                {
                    se.RetCount = dt.Rows.Count;
                    se._retDT = dt;
                }
            }
        }

        #region ManageEmployee

        
        public void dacGetEmpDetails(EmployeeEntity m_emp)
        {
            string SQLselect = base.RetrieveSqlQuery(QueryConstants.RetrieveEmpDetails).ToString();
            DataTable dt = new DataTable();
            
            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@emp_id", SqlDbType = SqlDbType.NVarChar, Value= m_emp.Emp_id},
            };



            using (dt = base.ExecuteDataAdapter(SQLselect, sp))
            {
                if (dt.Rows.Count < 1)
                {
                    m_emp.RetIndicator = AppKeys.Failure;
                    m_emp.RetMessage = UserMessages.RetrieveEmpFailed;
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        m_emp.Firstname = dr["firstname"].ToString();
                        m_emp.Lastname = dr["lastname"].ToString();
                        m_emp.Petname = dr["petname"].ToString();
                        m_emp.Dob = dr["dob"].ToString();
                        m_emp.Gender = dr["gender"].ToString();
                        m_emp.Emptype = dr["emptype"].ToString();
                        m_emp.Designation = dr["designation"].ToString();
                        m_emp.Empaddress = dr["empaddress"].ToString();
                        m_emp.Pincode = dr["pincode"].ToString();
                        m_emp.Homephone = dr["homephone"].ToString();
                        m_emp.Mobile = dr["mobile"].ToString();
                        m_emp.Emailid = dr["emailid"].ToString();
                        m_emp.Education = dr["education"].ToString();
                        m_emp.Aadhaarno = dr["aadhaarno"].ToString();
                        m_emp.Addressproof = dr["addressproof"].ToString();
                        m_emp.Dl_no = dr["dl_no"].ToString();
                        m_emp.Dl_htmv = dr["dl_htmv"].ToString();
                        m_emp.Dl_hmv = dr["dl_hmv"].ToString();
                        m_emp.Dl_lmv = dr["dl_lmv"].ToString();
                        m_emp.Dl_rto = dr["dl_rto"].ToString();
                        m_emp.Dl_expDt = dr["dl_expdt"].ToString();
                        m_emp.Hiring_manager_id = dr["hiring_manager_id"].ToString();
                        m_emp.Hiring_Date = dr["hiring_date"].ToString();
                        m_emp.Experience = dr["experience"].ToString();
                        m_emp.Attributes = dr["attributes"].ToString();
                        m_emp.Otherdetails = dr["otherdetails"].ToString();
                        m_emp.Emp_status = dr["emp_status"].ToString();
                        //m_emp.Allow_login = dr["allow_login"].ToString();
                        break;
                    }
                    m_emp.RetIndicator = AppKeys.Success;
                    m_emp.RetMessage = string.Empty;
                }
            }
        }

        public DocumentCollection dacGetEmpDocs(DocumentCollection m_dcol)
        {
            string SQLselect = base.RetrieveSqlQuery(QueryConstants.RetrieveEmpDocs).ToString();
            DataTable dt = new DataTable();
            DocumentCollection dcol = new DocumentCollection();
            dcol.Optype = m_dcol.Optype;

            foreach (formDocs m_edoc in m_dcol)
            {
                List<SqlParameter> sp = new List<SqlParameter>()
                {
                    new SqlParameter() {ParameterName = "@empid", SqlDbType = SqlDbType.NVarChar, Value= m_edoc.EmpId},
                };               

                using (dt = base.ExecuteDataAdapter(SQLselect, sp))
                {
                    if (dt.Rows.Count < 1)
                    {                        
                        dcol = m_dcol; //return same collection if nothing is in database
                    }
                    else
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            formDocs fd = new formDocs();

                            fd.EmpId = m_edoc.EmpId;                            
                            AppConstants.e_DocType _docType = AppConstants.e_DocType.XXX;
                            Enum.TryParse(dr["doctype"].ToString(), out _docType); //string to enum conversion
                            fd.DocType = _docType;
                            fd.DocName = dr["doc_name"].ToString();
                            fd.Image = dr["doc_img"] as byte[] ?? null;
                            fd.DocExtn = dr["doc_extn"].ToString();
                            fd.DocUpdateType = Utilities.e_DocAction.M;
                            fd.ExistInDB = true;
                            fd.HasChange = false;
                            fd.RetIndicator = AppKeys.Success;
                            fd.RetMessage = string.Empty;

                            //check if file present in folders
                            DirectoryInfo dir = new DirectoryInfo(AppConstants.setHomePath);
                            string _imgPath = dir.FullName + AppConstants.setImagesPath + AppConstants.empImgDocPath + "\\" + fd.DocName+ fd.DocExtn;

                            //string _imgPath = AppConstants.setHomePath + AppConstants.setImagesPath + AppConstants.empImgDocPath+"\\"+ fd.DocName;
                            if (File.Exists(_imgPath))
                            { fd.DocPath = _imgPath; }

                            dcol.DocCount++;

                            dcol.Add(fd);
                        }
                        
                    }
                }

            }
            return dcol;

        }

        

        public void dacInsertEmpDetails(EmployeeEntity emp)
        {
            //Retrieve Query to insert employee details
            string _sqlQuery = base.RetrieveSqlQuery(QueryConstants.InsertEmpDetails).ToString();

            List<SqlParameter> cp = base.GetCommonParameters_Ins();

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@emp_id", SqlDbType = SqlDbType.NVarChar, Value= emp.Emp_id},
                new SqlParameter() {ParameterName = "@firstname", SqlDbType = SqlDbType.NVarChar, Value= emp.Firstname},
                new SqlParameter() {ParameterName = "@lastname", SqlDbType = SqlDbType.NVarChar, Value= emp.Lastname},
                new SqlParameter() {ParameterName = "@petname", SqlDbType = SqlDbType.NVarChar, Value= emp.Petname},
                new SqlParameter() {ParameterName = "@dob", SqlDbType = SqlDbType.NVarChar, Value= emp.Dob},
                new SqlParameter() {ParameterName = "@gender", SqlDbType = SqlDbType.NVarChar, Value= emp.Gender},
                new SqlParameter() {ParameterName = "@emptype", SqlDbType = SqlDbType.NVarChar, Value= emp.Emptype},
                new SqlParameter() {ParameterName = "@designation", SqlDbType = SqlDbType.NVarChar, Value= emp.Designation},
                new SqlParameter() {ParameterName = "@empaddress", SqlDbType = SqlDbType.NVarChar, Value= emp.Empaddress},
                new SqlParameter() {ParameterName = "@pincode", SqlDbType = SqlDbType.NVarChar, Value= emp.Pincode},
                new SqlParameter() {ParameterName = "@homephone", SqlDbType = SqlDbType.NVarChar, Value= emp.Homephone},
                new SqlParameter() {ParameterName = "@mobile", SqlDbType = SqlDbType.NVarChar, Value= emp.Mobile},
                new SqlParameter() {ParameterName = "@emailid", SqlDbType = SqlDbType.NVarChar, Value= emp.Emailid},
                new SqlParameter() {ParameterName = "@education", SqlDbType = SqlDbType.NVarChar, Value= emp.Education},
                new SqlParameter() {ParameterName = "@aadhaarno", SqlDbType = SqlDbType.NVarChar, Value= emp.Aadhaarno},
                new SqlParameter() {ParameterName = "@addressproof", SqlDbType = SqlDbType.NVarChar, Value= emp.Addressproof},
                new SqlParameter() {ParameterName = "@dl_no", SqlDbType = SqlDbType.NVarChar, Value= emp.Dl_no},
                new SqlParameter() {ParameterName = "@dl_htmv", SqlDbType = SqlDbType.NVarChar, Value= emp.Dl_htmv},
                new SqlParameter() {ParameterName = "@dl_hmv", SqlDbType = SqlDbType.NVarChar, Value= emp.Dl_hmv},
                new SqlParameter() {ParameterName = "@dl_lmv", SqlDbType = SqlDbType.NVarChar, Value= emp.Dl_lmv},
                new SqlParameter() {ParameterName = "@dl_rto", SqlDbType = SqlDbType.NVarChar, Value= emp.Dl_rto},
                new SqlParameter() {ParameterName = "@dl_expdt", SqlDbType = SqlDbType.NVarChar, Value= emp.Dl_expDt},
                new SqlParameter() {ParameterName = "@hiring_manager_id", SqlDbType = SqlDbType.NVarChar, Value= emp.Hiring_manager_id},
                new SqlParameter() {ParameterName = "@hiring_date", SqlDbType = SqlDbType.NVarChar, Value= emp.Hiring_Date},
                new SqlParameter() {ParameterName = "@experience", SqlDbType = SqlDbType.NVarChar, Value= emp.Experience},
                new SqlParameter() {ParameterName = "@attributes", SqlDbType = SqlDbType.NVarChar, Value= emp.Attributes},
                new SqlParameter() {ParameterName = "@otherdetails", SqlDbType = SqlDbType.NVarChar, Value= emp.Otherdetails},
                new SqlParameter() {ParameterName = "@emp_status", SqlDbType = SqlDbType.NVarChar, Value= emp.Emp_status},
                new SqlParameter() {ParameterName = "@allow_login", SqlDbType = SqlDbType.NVarChar, Value= emp.Allow_login},

            };

            sp.AddRange(cp);

            //just for test #future code - remove this test method
            //dacTruncateTable("d1_cdt_employees");

            int _cnt = base.bExecuteNonQuery(_sqlQuery, sp);
            if (_cnt <= 0)
            { emp.RetIndicator = AppKeys.Failure; emp.RetMessage = UserMessages.InsertEmpFailure; }
            else
            {
                string _s = emp.Firstname + " " + emp.Lastname;
                { emp.RetIndicator = AppKeys.Success; emp.RetMessage = string.Format(UserMessages.InsertEmpSuccess, _s.Trim(),emp.Emp_id); }
            }

        }

        public void dacUpdateEmpDetails(EmployeeEntity emp)
        {
            string _sqlQuery = base.RetrieveSqlQuery(QueryConstants.UpdateEmpDetails).ToString();

            List<SqlParameter> cp = base.GetCommonParameters_Updt();

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@emp_id", SqlDbType = SqlDbType.NVarChar, Value= emp.Emp_id},
                new SqlParameter() {ParameterName = "@firstname", SqlDbType = SqlDbType.NVarChar, Value= emp.Firstname},
                new SqlParameter() {ParameterName = "@lastname", SqlDbType = SqlDbType.NVarChar, Value= emp.Lastname},
                new SqlParameter() {ParameterName = "@petname", SqlDbType = SqlDbType.NVarChar, Value= emp.Petname},
                new SqlParameter() {ParameterName = "@dob", SqlDbType = SqlDbType.NVarChar, Value= emp.Dob},
                new SqlParameter() {ParameterName = "@gender", SqlDbType = SqlDbType.NVarChar, Value= emp.Gender},
                new SqlParameter() {ParameterName = "@emptype", SqlDbType = SqlDbType.NVarChar, Value= emp.Emptype},
                new SqlParameter() {ParameterName = "@designation", SqlDbType = SqlDbType.NVarChar, Value= emp.Designation},
                new SqlParameter() {ParameterName = "@empaddress", SqlDbType = SqlDbType.NVarChar, Value= emp.Empaddress},
                new SqlParameter() {ParameterName = "@pincode", SqlDbType = SqlDbType.NVarChar, Value= emp.Pincode},
                new SqlParameter() {ParameterName = "@homephone", SqlDbType = SqlDbType.NVarChar, Value= emp.Homephone},
                new SqlParameter() {ParameterName = "@mobile", SqlDbType = SqlDbType.NVarChar, Value= emp.Mobile},
                new SqlParameter() {ParameterName = "@emailid", SqlDbType = SqlDbType.NVarChar, Value= emp.Emailid},
                new SqlParameter() {ParameterName = "@education", SqlDbType = SqlDbType.NVarChar, Value= emp.Education},
                new SqlParameter() {ParameterName = "@aadhaarno", SqlDbType = SqlDbType.NVarChar, Value= emp.Aadhaarno},
                new SqlParameter() {ParameterName = "@addressproof", SqlDbType = SqlDbType.NVarChar, Value= emp.Addressproof},
                new SqlParameter() {ParameterName = "@dl_no", SqlDbType = SqlDbType.NVarChar, Value= emp.Dl_no},
                new SqlParameter() {ParameterName = "@dl_htmv", SqlDbType = SqlDbType.NVarChar, Value= emp.Dl_htmv},
                new SqlParameter() {ParameterName = "@dl_hmv", SqlDbType = SqlDbType.NVarChar, Value= emp.Dl_hmv},
                new SqlParameter() {ParameterName = "@dl_lmv", SqlDbType = SqlDbType.NVarChar, Value= emp.Dl_lmv},
                new SqlParameter() {ParameterName = "@dl_rto", SqlDbType = SqlDbType.NVarChar, Value= emp.Dl_rto},
                new SqlParameter() {ParameterName = "@dl_expdt", SqlDbType = SqlDbType.NVarChar, Value= emp.Dl_expDt},
                new SqlParameter() {ParameterName = "@hiring_manager_id", SqlDbType = SqlDbType.NVarChar, Value= emp.Hiring_manager_id},
                new SqlParameter() {ParameterName = "@hiring_date", SqlDbType = SqlDbType.NVarChar, Value= emp.Hiring_Date},
                new SqlParameter() {ParameterName = "@experience", SqlDbType = SqlDbType.NVarChar, Value= emp.Experience},
                new SqlParameter() {ParameterName = "@attributes", SqlDbType = SqlDbType.NVarChar, Value= emp.Attributes},
                new SqlParameter() {ParameterName = "@otherdetails", SqlDbType = SqlDbType.NVarChar, Value= emp.Otherdetails},
                new SqlParameter() {ParameterName = "@emp_status", SqlDbType = SqlDbType.NVarChar, Value= emp.Emp_status},
                new SqlParameter() {ParameterName = "@allow_login", SqlDbType = SqlDbType.NVarChar, Value= emp.Allow_login},

            };

            sp.AddRange(cp);

            int _cnt = base.bExecuteNonQuery(_sqlQuery, sp);
            if (_cnt <= 0)
            { emp.RetIndicator = AppKeys.Failure; emp.RetMessage = UserMessages.UpdateEmpFailure; }
            else
            {
                string _s = emp.Firstname + " " + emp.Lastname;
                { emp.RetIndicator = AppKeys.Success; emp.RetMessage = string.Format(UserMessages.UpdateEmpSuccess, _s.Trim()); }
            }

        }

        public void dacTerminateEmp(EmployeeEntity emp)
        {
            string _sqlQuery = base.RetrieveSqlQuery(QueryConstants.TerminateEmp).ToString();

            List<SqlParameter> cp = base.GetCommonParameters_Updt();

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@emp_id", SqlDbType = SqlDbType.NVarChar, Value= emp.Emp_id},
                new SqlParameter() {ParameterName = "@emp_status", SqlDbType = SqlDbType.NVarChar, Value= emp.Emp_status},
                new SqlParameter() {ParameterName = "@allow_login", SqlDbType = SqlDbType.NVarChar, Value= emp.Allow_login},
            };

            sp.AddRange(cp);

            int _cnt = base.bExecuteNonQuery(_sqlQuery, sp);
            if (_cnt <= 0)
            { emp.RetIndicator = AppKeys.Failure; emp.RetMessage = UserMessages.DatabaseUpdateFailure; }
            else
            { emp.RetIndicator = AppKeys.Success; emp.RetMessage = UserMessages.DatabaseUpdateSuccess; }
            

        }

        public void dacInsertDocs(formDocs edoc)
        {
            //Retrieve Query to insert employee docs details
            string _sqlQuery = base.RetrieveSqlQuery(QueryConstants.InsertEmpDocs).ToString();

            List<SqlParameter> cp = base.GetCommonParameters_Ins();            

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@emp_id", SqlDbType = SqlDbType.NVarChar, Value= edoc.EmpId},
                new SqlParameter() {ParameterName = "@doc_type", SqlDbType = SqlDbType.NVarChar, Value= edoc.DocType},
                new SqlParameter() {ParameterName = "@doctype_id", SqlDbType = SqlDbType.NVarChar, Value= string.Empty},
                new SqlParameter() {ParameterName = "@doc_name", SqlDbType = SqlDbType.NVarChar, Value= edoc.DocName},
                new SqlParameter() {ParameterName = "@doc_extn", SqlDbType = SqlDbType.NVarChar, Value= edoc.DocExtn},
                new SqlParameter() {ParameterName = "@doc_img", SqlDbType = SqlDbType.Image, Value= edoc.Image},
                new SqlParameter() {ParameterName = "@active_ind", SqlDbType = SqlDbType.NVarChar, Value= edoc.ActiveInd},

            };

            sp.AddRange(cp);

            int _cnt = base.bExecuteNonQuery(_sqlQuery, sp);
            if (_cnt <= 0)
            { edoc.RetIndicator = AppKeys.Failure; }
            else { edoc.RetIndicator = AppKeys.Success; }

        }

        public void dacUpdateEmpDocs(formDocs edoc)
        {
            string _sqlQuery = base.RetrieveSqlQuery(QueryConstants.UpdateEmpDocs).ToString();

            List<SqlParameter> cp = base.GetCommonParameters_Updt();

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@emp_id", SqlDbType = SqlDbType.NVarChar, Value= edoc.EmpId},
                new SqlParameter() {ParameterName = "@doc_type", SqlDbType = SqlDbType.NVarChar, Value= edoc.DocType},
                new SqlParameter() {ParameterName = "@doctype_id", SqlDbType = SqlDbType.NVarChar, Value= string.Empty},
                new SqlParameter() {ParameterName = "@doc_name", SqlDbType = SqlDbType.NVarChar, Value= edoc.DocName},
                new SqlParameter() {ParameterName = "@doc_extn", SqlDbType = SqlDbType.NVarChar, Value= edoc.DocExtn},
                new SqlParameter() {ParameterName = "@doc_img", SqlDbType = SqlDbType.Image, Value= edoc.Image},
                new SqlParameter() {ParameterName = "@active_ind", SqlDbType = SqlDbType.NVarChar, Value= edoc.ActiveInd},
            };

            sp.AddRange(cp);

            //just for test #future code - remove this test method
            //dacTruncateTable("d1_cdt_empdocs");

            int _cnt = base.bExecuteNonQuery(_sqlQuery, sp);
            if (_cnt <= 0)
            { edoc.RetIndicator = AppKeys.Failure; }
            else { edoc.RetIndicator = AppKeys.Success; }

        }

        public void dacTerminateEmpDoc(formDocs edoc)
        {
            string _sqlQuery = base.RetrieveSqlQuery(QueryConstants.TerminateEmpDocs).ToString();

            List<SqlParameter> cp = base.GetCommonParameters_Updt();

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@emp_id", SqlDbType = SqlDbType.NVarChar, Value= edoc.EmpId},
                new SqlParameter() {ParameterName = "@doc_type", SqlDbType = SqlDbType.NVarChar, Value= edoc.DocType},
                new SqlParameter() {ParameterName = "@active_ind", SqlDbType = SqlDbType.NVarChar, Value= edoc.ActiveInd},
            };

            sp.AddRange(cp);

            int _cnt = base.bExecuteNonQuery(_sqlQuery, sp);
            if (_cnt <= 0)
            { edoc.RetIndicator = AppKeys.Failure; }
            else { edoc.RetIndicator = AppKeys.Success; }

        }
        #endregion ManageEmployee

        #endregion UserMethods
    }
}
