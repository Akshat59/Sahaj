using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m1.Shared.Entities
{
    public class UserEntity
    {
        #region Properties
        private string _input_user_id = String.Empty;
        public string Input_user_id
        {
            get { return _input_user_id; }
            set { _input_user_id = value; }
        }
        
        private string user_id = String.Empty;
        public string User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        private string user_name = String.Empty;

        public string User_name
        {
            get { return user_name; }
            set { user_name = value; }
        }
        private string user_pwd = String.Empty;

        public string User_pwd
        {
            get { return user_pwd; }
            set { user_pwd = value; }
        }
        private string user_fname = String.Empty;

        public string User_fname
        {
            get { return user_fname; }
            set { user_fname = value; }
        }
        private string user_lname = String.Empty;

        public string User_lname
        {
            get { return user_lname; }
            set { user_lname = value; }
        }
        private string role_id = String.Empty;

        public string Role_id
        {
            get { return role_id; }
            set { role_id = value; }
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
        private string profilepic = String.Empty;

        public string Profilepic
        {
            get { return profilepic; }
            set { profilepic = value; }
        }

        public string UserNoteText
        {
            get
            {
                return _userNoteText;
            }

            set
            {
                _userNoteText = value;
            }
        }

        public DateTime UserNoteDate
        {
            get
            {
                return _userNoteDate;
            }

            set
            {
                _userNoteDate = value;
            }
        }

        private string _userNoteText = string.Empty;
        private DateTime _userNoteDate ;


        #endregion
    }
}
