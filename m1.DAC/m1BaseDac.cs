using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using m1.Shared.Collections;
using m1.Shared.Configs;
using System.Xml;
using System.Reflection;
using System.Configuration;
using System.Collections;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.SqlClient;
using m1.Shared;
namespace m1.DAC
{
    public class m1BaseDac //:BaseDac
    {
        private string _sqlLog = String.Empty;
        int _ret = 0;

        protected string RetrieveSqlQuery(string key)
        {
            return ConfigSettings.GetAppSetting(key); 
        }

        protected string GetConnectionString(string key)
        {
            return ConfigSettings.GetConnectionString(key);
        }

        private void SetExceptionLog(Exception Ex)
        {
            _sqlLog = "\r\n" + Ex.Message + Ex.InnerException + "\r\n" + Ex.StackTrace; 
            //#futureCode write logs to file/db.
        }

        private void SetSQLExceptionLog(SqlException Ex)
        {
            _sqlLog = "\r\n" + Ex.Message + Ex.InnerException + "\r\n" + Ex.StackTrace;
            //#futurecode
        }

        private void WriteLog(string log)
        {
            //#futurecode
        }

        protected List<SqlParameter> GetCommonParameters()
        {
            List<SqlParameter> cp = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName = "@create_id", SqlDbType = SqlDbType.NVarChar, Value= AppGlobal.g_GEntity.SessionEntity.User_id},
                new SqlParameter() {ParameterName = "@create_date", SqlDbType = SqlDbType.DateTime2, Value= AppGlobal.g_GEntity.SessionEntity.CurrentTimeStamp},
                new SqlParameter() {ParameterName = "@update_id", SqlDbType = SqlDbType.NVarChar, Value= AppGlobal.g_GEntity.SessionEntity.User_id},
                new SqlParameter() {ParameterName = "@update_date", SqlDbType = SqlDbType.DateTime2, Value= AppGlobal.g_GEntity.SessionEntity.CurrentTimeStamp},

             };
            return cp;
        }

        protected bool TestDatabaseConnection()
        {
            string conStrng = ConfigSettings.GetConnectionString(DatabaseConstants.ConnStringKey).ToString();
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection myConnection = new SqlConnection(conStrng))
                {
                    myConnection.Open();
                    if (myConnection.State.Equals(ConnectionState.Open))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception Ex)
            {
                this.SetExceptionLog(Ex);
                return false;
            }
            finally
            {
                AppGlobal.sqlErrorLog = _sqlLog;
            }
        }

        /// <summary>
        /// Dont Use
        /// </summary>
        /// <param name="SQLselect"></param>
        /// <returns></returns>
        protected DataSet ExecuteDataAdapter(string SQLselect)
        {       
            //Dont Use
            string conStrng = ConfigSettings.GetConnectionString(DatabaseConstants.ConnStringKey).ToString();
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection myConnection = new SqlConnection(conStrng))
                {
                    SqlCommand oCmd = new SqlCommand(SQLselect, myConnection);
                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(oCmd);
                    int res = da.Fill(ds);

                    myConnection.Close();
                }
                if (ds.Tables[0].Rows[0].Equals(DBNull.Value)) { conStrng = "1"; } else { conStrng = "2"; }
                return ds;
            }
            catch (Exception Ex)
            {
                this.SetExceptionLog(Ex);
                return ds;
            }
            finally
            {
                AppGlobal.sqlErrorLog = _sqlLog;    
            }    
        }

        protected DataTable ExecuteDataAdapter(string sqlQuery,List<SqlParameter> sp = null)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            //Setting _queryLog as actual query got executed including parameters value
            string _queryLog = sqlQuery;
            foreach (SqlParameter p in sp)
            {
                _queryLog = _queryLog.Replace(p.ParameterName.ToString(), p.Value.ToString());
                //Add _querylog to logs/db       #futureCode
            }

            try
            {
                string conStrng = ConfigSettings.GetConnectionString(DatabaseConstants.ConnStringKey).ToString();
                using (SqlConnection myConnection = new SqlConnection(conStrng))
                {
                    SqlCommand oCmd = new SqlCommand(sqlQuery, myConnection);
                    oCmd.CommandType = CommandType.Text;

                    if (sp != null)
                    {
                        oCmd.Parameters.AddRange(sp.ToArray());
                    }

                    myConnection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(oCmd);
                    int res = da.Fill(ds,"dt");
                    dt = ds.Tables["dt"];
                    return dt;
                }
            }
            catch (Exception Ex)
            {
                this.SetExceptionLog(Ex);                
                return dt;
            }
            finally
            {
                AppGlobal.sqlErrorLog = _sqlLog;    
            }            

        }

        public int bExecuteNonQuery(string sqlQuery, List<SqlParameter> sp)
        {            
            _ret = 0;
            _sqlLog = string.Empty;

            //Setting _queryLog as actual query got executed including parameters value
            string _queryLog = sqlQuery;
            foreach (SqlParameter p in sp)
            {               
                _queryLog = _queryLog.Replace(p.ParameterName.ToString(), "'" + p.Value.ToString() + "'");
                //Add _queryLog to logs       #futureCode
            }

            try
            {
                string conStrng = ConfigSettings.GetConnectionString(DatabaseConstants.ConnStringKey).ToString();
                using (SqlConnection myConnection = new SqlConnection(conStrng))
                {
                    SqlCommand oCmd = new SqlCommand(sqlQuery, myConnection);
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
            catch (Exception Ex)
            {
                this.SetExceptionLog(Ex);
                return 0;
            }
            finally
            {
                AppGlobal.sqlErrorLog = _sqlLog;               
            }
        }

        public int bExecuteNonQuery(string sqlQuery)
        {
            _ret = 0;
            _sqlLog = string.Empty;

            try
            {
                string conStrng = ConfigSettings.GetConnectionString(DatabaseConstants.ConnStringKey).ToString();
                using (SqlConnection myConnection = new SqlConnection(conStrng))
                {
                    SqlCommand oCmd = new SqlCommand(sqlQuery, myConnection);
                    oCmd.CommandType = CommandType.Text;                    

                    myConnection.Open();

                    _ret = oCmd.ExecuteNonQuery();
                }
                return _ret;
            }
            catch (Exception Ex)
            {
                this.SetExceptionLog(Ex);
                return 0;
            }
            finally
            {
                AppGlobal.sqlErrorLog = _sqlLog;
            }
        }

        public string bExecuteScalar(string sqlSelectQuery)
        {
            string _s_ret = string.Empty;
            try
            {
                string conStrng = ConfigSettings.GetConnectionString(DatabaseConstants.ConnStringKey).ToString();
                using (SqlConnection myConnection = new SqlConnection(conStrng))
                {
                    SqlCommand oCmd = new SqlCommand(sqlSelectQuery, myConnection);
                    oCmd.CommandType = CommandType.Text;
                    myConnection.Open();

                    var _v = oCmd.ExecuteScalar();
                    if (_v != null) { _s_ret =  _v.ToString(); }
                    else { _s_ret =  string.Empty; }
                }
                return _s_ret;
                
            }
            catch (Exception Ex)
            {
                this.SetExceptionLog(Ex);
                return _s_ret;
            }
            finally
            {
                AppGlobal.sqlErrorLog = _sqlLog;
            }
        }


        #region Scrap
        /*
          protected SqlDataReader ExecuteDataReader(string SQLselect)
        {
            SqlDataReader dr = null;// new SqlDataReader();

            string con = ConfigSettings.GetConnectionString(DatabaseConstants.ConnStringKey).ToString();
            SqlConnection myConnection = new SqlConnection(con);

            //SqlConnection myConnection = new SqlConnection("Data Source=Server=DESKTOP-HKS5HV8\\SQLEXPRESS.;Initial Catalog=d1_dev");
            //SqlConnection myConnection = new SqlConnection("Server=localhost\\SQLExpress; Database=d1_dev; Integrated Security=SSPI;");
            //Data Source=localhost\SQLEXPRESS;Initial Catalog=test;Integrated Security=SSPI;
            //conn.Open();

           // myConnection.Open();

            //sqlCnn.Open();
              //  sqlCmd = new SqlCommand(sql, sqlCnn);
                //adapter.SelectCommand = sqlCmd;
                //adapter.Fill(ds);
                //for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                //{
                  //  MessageBox.Show(ds.Tables[0].Rows[i].ItemArray[0] + " -- " + ds.Tables[0].Rows[i].ItemArray[1]);
                //}
              
              
              
              
             
             

        
            //using (SqlConnection myConnection = new SqlConnection(con))
            //{
                myConnection.Open();
                    SqlCommand oCmd = new SqlCommand(SQLselect, myConnection); //CommandBehavior.CloseConnection

                using (SqlDataReader oReader = oCmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (oReader.Read())
                    {
                        string qq = oReader[0].ToString();
                        return oReader;                        
                    }

                    myConnection.Close();
                }
           // }

            return dr;
        }
        protected IDataReader ExecuteDataReader(string SQLselect, parameterCollection pc)
        {
            IDataReader dr = null;

            var con = ConfigSettings.GetConnectionString(DatabaseConstants.ConnStringKey);


            using (SqlConnection myConnection = new SqlConnection(con))
            {
                SqlCommand oCmd = new SqlCommand(SQLselect, myConnection);

                //foreach (var item in pc)
                //{
                    
                //}

                //SqlParameterCollection spc = new SqlParameterCollection();
                
                //oCmd.Parameters.AddWithValue("@Fname", fName);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (oReader.Read())
                    {
                  //      matchingPerson.firstName = oReader["FirstName"].ToString();
                    //    matchingPerson.lastName = oReader["LastName"].ToString();
                    }

                    myConnection.Close();
                }
            }

            return dr;
        }

         
        
        protected readonly Database Database = DatabaseFactory.CreateDatabase(ConfigSettings.DatabaseConnectionName);
        public static SqlScriptCollection SqlScripts = BuildSqlScripts();

        public static SqlScriptCollection BuildSqlScripts()
        {
            SqlScriptCollection sqlScripts = null;
            XmlDocument xmlSql = new XmlDocument();

            Assembly M1DataLayerAssembly = Assembly.GetAssembly(typeof(m1.DAC.m1BaseDac));


            return sqlScripts;

        }

        protected string RetrieveSql(string key)
        {
            string sqlStatement = string.Empty;
            try
            {
                //sqlStatement.SQLScripts[key].Script;

                return "";

            }

            catch
            {

            }

            return "";
        }

        protected Hashtable RetrieveSqlQuery_Scrap(string key)
        {
            //ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
            //configMap.ExeConfigFilename = @"\\oraDB.config";
            //Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);

            //var p1 = System.IO.Path.Combine(System.AppDomain.CurrentDomain..ToString(), "oraDB.config");

            var path = Path.Combine(Directory.GetCurrentDirectory(), "m1.DAC.oraDB.config");
            //string path = ".\\oraDB.config";


            Hashtable _ret = new Hashtable();
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader
                (
                    new FileStream(
                        path,
                        FileMode.Open,
                        FileAccess.Read,
                        FileShare.Read)
                );
                XmlDocument doc = new XmlDocument();
                string xmlIn = reader.ReadToEnd();
                reader.Close();
                doc.LoadXml(xmlIn);
                foreach (XmlNode child in doc.ChildNodes)
                    if (child.Name.Equals("oraQueries"))
                        foreach (XmlNode node in child.ChildNodes)
                            if (node.Name.Equals("add"))
                                _ret.Add
                                (
                                    node.Attributes["key"].Value,
                                    node.Attributes["value"].Value
                                );
            }
            return (_ret);

        }
         * */
        #endregion
    }
}
