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
    public class genDAC:m1BaseDac
    {
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

            using (dt = base.ExecuteDataAdapter(SQLselect,sp))
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
        #endregion PublicMethod
    }
}
