using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m1.Shared.Entities
{
    public class SessionEntity
    {
        #region Properties
        private string _SqlLog = string.Empty;

        public string SqlLog
        {
            get { return _SqlLog; }
            set { _SqlLog = value; }
        }

        private string user_id = String.Empty;
        public string User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        private string role_id = String.Empty;

        public string Role_id
        {
            get { return role_id; }
            set { role_id = value; }
        }

        private string currentTimeStamp;
        public string CurrentTimeStamp
        {
            get
            {
                currentTimeStamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                return currentTimeStamp;
            }
        }
        #endregion Properties
    }
}
