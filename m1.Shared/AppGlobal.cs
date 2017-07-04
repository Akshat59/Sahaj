using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using m1.Shared.Entities;

namespace m1.Shared
{
    public static class AppGlobal
    {
        public static string appLog = string.Empty;
        public static string sqlLog = string.Empty;
        public static string CurrentAppEnv = AppConstants.AppEnvironments.Keys.First(); //Setting Dev
        public static string CurrentUserRole = AppConstants.AppUserRoles.Keys.First(); //Setting Admin

        public static string appErrorLog = string.Empty;
        public static string sqlErrorLog = string.Empty;
        public const string super_admin_PassKey = "1234";

        public static GenEntity g_GEntity = null;
        public static SessionEntity g_SessionEntity = null;

    }
}
