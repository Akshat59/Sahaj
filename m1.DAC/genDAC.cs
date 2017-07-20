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

namespace m1.DAC
{
    public class genDAC : m1BaseDac
    {
        int _retCnt = 0;

        public genDAC()
        {

        }

        #region PublicMethod
        public bool dacTestDatabaseConnection()
        {
            return base.TestDatabaseConnection();
        }

       

       

        public bool dacValidateUserLogin(GenEntity GEntity)
        {

            string SQLselect = base.RetrieveSqlQuery(QueryConstants.ValidateUserLogin).ToString();
            DataTable dt = new DataTable();

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@user_id", SqlDbType = SqlDbType.NVarChar, Value= GEntity.UserEntity.Input_user_id},
                //new SqlParameter() {ParameterName = "@password", SqlDbType = SqlDbType.NVarChar, Value= GEntity.UserEntity.User_pwd},
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

       

        






        /// <summary>
        /// This method is to retrive next id column (primary key) from table from the database table as per enum e_PrimaryKeySeries
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="seriesInitials as specified enum e_PrimaryKeySeries"></param>
        /// <param name="sqlColumn target column"></param>
        /// <param name="totallength for padding"
        public string GetNextID(string tableName,string sqlColumn, string totalLength, string seriesInitials)
        {
            int _i = Convert.ToInt32(totalLength) - seriesInitials.Length; //to replace as {2}
            //SELECT RIGHT('0000'+ (CAST((SUBSTRING(ISNULL(MAX({1}),'E110001'),4,4)+1) AS VARCHAR(4))),4 ) FROM d1_cdt_employees;
            //SELECT RIGHT('0000'+ (CAST((SUBSTRING(ISNULL(MAX({1}),'{3}0001'),{2},{2})+1) AS VARCHAR({5}))),{2}) FROM {0};
            string sqlSelectQuery = string.Format(@"SELECT '{3}' + RIGHT('0000'+ (CAST((SUBSTRING(ISNULL(MAX({1}),'{3}0000'),{2},{2})+1) AS VARCHAR({2}))),{2}) FROM {0} WHERE SUBSTRING({1},1,{4}) = '{3}'"
                                                                    , tableName, sqlColumn, _i.ToString(), seriesInitials, seriesInitials.Length.ToString());

            //string sqlSelectQuery = string.Format("SELECT ISNULL(MAX({0}),'') FROM {1} WHERE SUBSTRING({0},0,2) = '{2}'", sqlColumn, tableName, seriesInitials);

            string _s_ret = base.bExecuteScalar(sqlSelectQuery);

            if (_s_ret.Equals(string.Empty))
            {
                //log error  #futureCode
                throw new Exception(UserMessages.NextIDEmpty);
            }

            return _s_ret;
        }

        public void dacTruncateTable(string tableName)
        {
            string _sqlQuery = (QueryConstants.TruncateTable) + tableName;
            _retCnt = base.bExecuteNonQuery(_sqlQuery);
            if (_retCnt <= 0) { }
            else { }

        }

        public void dacInsertEmpDetails(EmployeeEntity emp)
        {
            //Retrieve Query to insert employee details
            string _sqlQuery = base.RetrieveSqlQuery(QueryConstants.InsertEmpDetails).ToString();

            List<SqlParameter> cp = base.GetCommonParameters();

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
                new SqlParameter() {ParameterName = "@hiring_manager_id", SqlDbType = SqlDbType.NVarChar, Value= emp.Hiring_manager_id},
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
                { emp.RetIndicator = AppKeys.Success; emp.RetMessage = string.Format(UserMessages.InsertEmpSuccess, _s.Trim()); }
            }

        }

        public void dacInsertDocs(EmployeeDocs edoc)
        {
            //Retrieve Query to insert employee details
            string _sqlQuery = base.RetrieveSqlQuery(QueryConstants.InsertEmpDetails).ToString();

            List<SqlParameter> cp = base.GetCommonParameters();            

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@emp_id", SqlDbType = SqlDbType.NVarChar, Value= edoc.Emp_id},
                new SqlParameter() {ParameterName = "@doc_type", SqlDbType = SqlDbType.NVarChar, Value= edoc.Doc_type},
                new SqlParameter() {ParameterName = "@doc_image", SqlDbType = SqlDbType.Image, Value= edoc.Image},

            };

            sp.AddRange(cp);

            //just for test #future code - remove this test method
            //dacTruncateTable("d1_cdt_employees");

            int _cnt = base.bExecuteNonQuery(_sqlQuery, sp);
            if (_cnt <= 0)
            { edoc.RetIndicator = AppKeys.Failure; edoc.RetMessage = UserMessages.InsertEmpDocFailure; }
            else
            {
                
                { edoc.RetIndicator = AppKeys.Success; edoc.RetMessage = string.Format(UserMessages.InsertEmpDocSuccess, edoc.Emp_id); }
            }
        }

        #endregion PublicMethod
    }
}
