using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;
using m1.Shared.Entities;

namespace m1.Shared.Configs
{
    public class ConfigSettings
    {
        public enum ConfigSection { appSettings = 0, DatabaseSettings = 1 }

        public static string GetConnectionString(string key)
        {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }


        #region GetQueries
        public static string GetAppSetting(string key)
        {
            try
            {
                return (ConfigurationManager.AppSettings[key]);
            }
            catch(Exception Ex)
            {
                SetException(Ex);
                return "Error - Invalid Key/Value found";
            }
        }

        public static string GetAppSettingValue(string key)
        {
            try
            {
                return (ConfigurationManager.AppSettings[key]);
            }
            catch (Exception Ex)
            {
                SetException(Ex);
                return "Error - Invalid Key/Value found";
            }
        }

        private static void SetException(Exception Ex)
        {
            ErrorLogEntity elog = new ErrorLogEntity
            {
                U_error_message = "Invalid Key/Value used for app config",
                U_error_detail = string.Format("{0}::{1)}", Ex.Message,Ex.Source),
                U_stacktrace = Ex.StackTrace,
                U_error_source = "ConfigSettings",
                U_IfLogtoDatabase = true,
                U_IfLogtoEventLogs = true,
                U_error_loggedby = ErrorLogEntity.errorLoggedBy.User,
                U_error_type = ErrorLogEntity.errorType.Error,
                U_error_date = AppGlobal.g_GEntity.SessionEntity.CurrentTimeStamp,
            };
            ExceptionManagement.logUserException(elog);
        }

        public static void SetAppSetting(string key, string value)
        {
            try
            {
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.AppSettings.Settings[key].Value = value;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception Ex)
            {
                SetException(Ex);               
            }
        }

        public static void SetConnectionString(string key, string value)
        {
            try
            {
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;               
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
            }
            catch (Exception Ex)
            {
                SetException(Ex);
            }
        }

        public static List<string> GetAllProperties()
        {           
            return  ConfigurationManager.AppSettings.AllKeys.ToList();
        }

        public static List<string> GetAllConnectionStrings()
        {
            List<string> op = new List<string>();
            foreach (ConnectionStringSettings c in System.Configuration.ConfigurationManager.ConnectionStrings)
            {
                if (c.Name.EndsWith("ConnectionString"))
                { op.Add(c.Name.ToString()); }
            }
                        
            return op;
        }
       

        #endregion


        #region SCRAP
        /*
        #region Properties
        public static string DatabaseConnectionName { get { return GetAppSetting("Application.DatabaseConnectionName", "m1cfg.Connect_String"); } }
        
        #endregion

        #region PublicMethod

        public static string GetConfigSetting(string key) {return GetConfigSetting(key,string.Empty);}

        public static string GetConfigSetting(string key, object defaultValue) 
        {
            object appSetting = ConfigurationManager.AppSettings[key];
            return (appSetting != null && appSetting.ToString().Length > 0 ? appSetting.ToString() : defaultValue.ToString());        
        }

        public static string GetConfigSetting(ConfigSection configSection, string key, object defaultValue)
        {
            object keyValue = defaultValue.ToString();
            object cfg = ConfigurationManager.GetSection(configSection.ToString());
            if (cfg != null)
            {
                NameValueCollection col = (NameValueCollection)cfg;
                keyValue = col[key];
            }

            if (keyValue == null) { keyValue = defaultValue.ToString(); }

            return keyValue.ToString();


        }

        public static string GetAppSetting(string key) { return GetAppSetting(key, string.Empty); }
        
        public static string GetAppSetting(string key, object defaultValue)
        {
            return (ConfigurationManager.AppSettings[key] != null) ? ConfigurationManager.AppSettings[key].ToString() : defaultValue.ToString();
        }

        #endregion
        */
        #endregion

    }
}
