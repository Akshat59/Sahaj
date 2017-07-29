using static m1.Shared.AppCommon;
using static m1.Shared.AppConstants;

namespace m1.Shared.Entities
{
    
    public class EmployeeEntity
    {

        #region Properties

        private string _emp_id = string.Empty;        
        private string _firstname = string.Empty;        
        private string _lastname = string.Empty;        
        private string _petname = string.Empty;
        private string _dob = string.Empty;
        private string _gender = string.Empty;
        private string _emptype = string.Empty;
        private string _empaddress = string.Empty;
        private string _pincode = string.Empty;
        private string _homephone = string.Empty;
        private string _mobile = string.Empty;
        private string _emailid = string.Empty;
        private string _education = string.Empty;
        private string _aadhaarno = string.Empty;
        private string _addressproof = string.Empty;
        private string _dl_no = string.Empty;
        private string _dl_htmv = string.Empty;
        private string _dl_hmv = string.Empty;
        private string _dl_lmv = string.Empty;
        private string _dl_rto = string.Empty;
        private string _dl_expDt = string.Empty;        
        private string _hiring_manager_id = string.Empty;
        private string _experience = string.Empty;
        private string _attributes = string.Empty;
        private string _otherdetails = string.Empty;
        private string _emp_status = string.Empty;

        public string Emp_id
        {
            get
            {
                return _emp_id;
            }

            set
            {
                _emp_id = value;
            }
        }

        [IsCamelCase(true)]
        public string Firstname
        {
            get
            {
                return _firstname;
            }

            set
            {
                _firstname = value;
            }
        }

        [IsCamelCase(true)]
        public string Lastname
        {
            get
            {
                return _lastname;
            }

            set
            {
                _lastname = value;
            }
        }

        public string Petname
        {
            get
            {
                return _petname;
            }

            set
            {
                _petname = value;
            }
        }

        public string Dob
        {
            get
            {
                return _dob;
            }

            set
            {
                _dob = value;
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        public string Emptype
        {
            get
            {
                return _emptype;
            }

            set
            {
                _emptype = value;
            }
        }

        [IsCamelCase(true)]
        public string Empaddress
        {
            get
            {
                return _empaddress;
            }

            set
            {
                _empaddress = value;
            }
        }

        public string Pincode
        {
            get
            {
                return _pincode;
            }

            set
            {
                _pincode = value;
            }
        }

        public string Homephone
        {
            get
            {
                return _homephone;
            }

            set
            {
                _homephone = value;
            }
        }

        public string Mobile
        {
            get
            {
                return _mobile;
            }

            set
            {
                _mobile = value;
            }
        }

        public string Education
        {
            get
            {
                return _education;
            }

            set
            {
                _education = value;
            }
        }

        public string Aadhaarno
        {
            get
            {
                return _aadhaarno;
            }

            set
            {
                _aadhaarno = value;
            }
        }

        public string Addressproof
        {
            get
            {
                return _addressproof;
            }

            set
            {
                _addressproof = value;
            }
        }

        public string Dl_no
        {
            get
            {
                return _dl_no;
            }

            set
            {
                _dl_no = value;
            }
        }

        public string Dl_htmv
        {
            get
            {
                return _dl_htmv;
            }

            set
            {
                _dl_htmv = value;
            }
        }

        public string Dl_hmv
        {
            get
            {
                return _dl_hmv;
            }

            set
            {
                _dl_hmv = value;
            }
        }

        public string Dl_lmv
        {
            get
            {
                return _dl_lmv;
            }

            set
            {
                _dl_lmv = value;
            }
        }

        public string Dl_rto
        {
            get
            {
                return _dl_rto;
            }

            set
            {
                _dl_rto = value;
            }
        }

        public string Dl_expDt
        {
            get
            {
                return _dl_expDt;
            }

            set
            {
                _dl_expDt = value;
            }
        }

        public string Hiring_manager_id
        {
            get
            {
                return _hiring_manager_id;
            }

            set
            {
                _hiring_manager_id = value;
            }
        }

        public string Experience
        {
            get
            {
                return _experience;
            }

            set
            {
                _experience = value;
            }
        }

        public string Attributes
        {
            get
            {
                return _attributes;
            }

            set
            {
                _attributes = value;
            }
        }

        public string Otherdetails
        {
            get
            {
                return _otherdetails;
            }

            set
            {
                _otherdetails = value;
            }
        }

        public string Emp_status
        {
            get
            {
                return _emp_status;
            }

            set
            {
                _emp_status = value;
            }
        }

        public string Designation { get; set; }

        public string Emailid
        {
            get
            {
                return _emailid;
            }

            set
            {
                _emailid = value;
            }
        }

        public string Allow_login
        {
            get
            {
                return allow_login;
            }

            set
            {
                allow_login = value;
            }
        }

        
        private string allow_login;

        private string _retmessage = string.Empty;
        public string RetMessage
        {
            get
            {
                return _retmessage;
            }

            set
            {
                _retmessage = value;
            }
        }

        private string _retIndicator = string.Empty;
        public string RetIndicator
        {
            get
            {
                return _retIndicator;
            }

            set
            {
                _retIndicator = value;
            }
        }


        #endregion Properties

    }

   
}
