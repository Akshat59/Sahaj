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
                    return true;
                }
            }
        }

        public void dacInsertEmpDetails(EmployeeEntity emp)
        {
            //Retrieve Query to insert employee details
            string _sqlQuery = base.RetrieveSqlQuery(QueryConstants.InsertEmpDetails).ToString();

            //Retrieve next empid

            List<SqlParameter> sp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@emp_id", SqlDbType = SqlDbType.NVarChar, Value= "u01002"},
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
            };

            //just for test #future code - remove this test method
            dacTruncateTable("d1_cdt_employees");
            
            int _cnt = base.bExecuteNonQuery(_sqlQuery, sp);
            if (_cnt <= 0)
            { emp.RetIndicator = AppKeys.Failure;emp.Message= UserMessages.InsertEmpFailure; }
            else
            {
                string _s = emp.Firstname + " " + emp.Lastname;
                { emp.RetIndicator = AppKeys.Success; emp.Message = string.Format(UserMessages.InsertEmpSuccess,_s.Trim()); }
            }
           
        }

        public void dacTruncateTable(string tableName)
        {
            string _sqlQuery = (QueryConstants.TruncateTable) + tableName;
            _retCnt = base.bExecuteNonQuery(_sqlQuery);
            if (_retCnt <= 0) { }
            else { }

        }

        #endregion PublicMethod
    }
}
