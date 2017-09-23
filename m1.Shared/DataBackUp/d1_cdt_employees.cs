using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileHelpers;

namespace m1.Shared.DataBackUp
{

    public class BackupTables
    {
        public const string d1_cdt_employees = "d1_cdt_employees";
    }

    [DelimitedRecord("|")]
   public  class d1_cdt_employees
    {
        public int e_uid = 0 ;
        public string emp_id = string.Empty;
        public string firstname = string.Empty;
        public string lastname = string.Empty;
        public string petname = string.Empty;
        public string dob = string.Empty;
        public string gender = string.Empty;
        public string emptype = string.Empty;
        public string designation = string.Empty;
        public string empaddress = string.Empty;
        public string pincode = string.Empty;
        public string homephone = string.Empty;
        public string mobile = string.Empty;
        public string emailid = string.Empty;
        public string education = string.Empty;
        public string aadhaarno = string.Empty;
        public string addressproof = string.Empty;
        public string dl_no = string.Empty;
        public string dl_htmv = string.Empty;
        public string dl_hmv = string.Empty;
        public string dl_lmv = string.Empty;
        public string dl_rto = string.Empty;
        public string dl_expdt = string.Empty;
        public string hiring_manager_id = string.Empty;
        public string hiring_date = string.Empty;
        public string experience = string.Empty;
        public string attributes = string.Empty;
        public string otherdetails = string.Empty;
        public string emp_status = string.Empty;
        public string allow_login = string.Empty;
        public string create_id = string.Empty;
        public string create_date = string.Empty;
        public string update_id = string.Empty;
        public string update_date = string.Empty;

    }
}
