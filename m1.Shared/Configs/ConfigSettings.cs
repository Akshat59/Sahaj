using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;

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
            return (ConfigurationManager.AppSettings[key]);
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
