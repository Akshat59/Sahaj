using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m1.Shared.Entities
{
    public class UserLogonEntity
    {
        #region Properties
        private string user_id = String.Empty;

        public string User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
        private string last_accessed = String.Empty;

        public string Last_accessed
        {
            get { return last_accessed; }
            set { last_accessed = value; }
        }
        private string last_pwd_change = String.Empty;

        public string Last_pwd_change
        {
            get { return last_pwd_change; }
            set { last_pwd_change = value; }
        }
        private string user_name = String.Empty;

        public string User_name
        {
            get { return user_name; }
            set { user_name = value; }
        }
        private int user_roleid = 0;

        public int User_roleid
        {
            get { return user_roleid; }
            set { user_roleid = value; }
        }
        #endregion
    }
}
