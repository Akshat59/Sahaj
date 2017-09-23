using FileHelpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace m1.Shared.DataBackUp
{
    public class FileHelperMain
    {
        //Under Writing
        public void WriteFile(DataTable dt)
        {
            var engine = new FileHelperEngine<d1_cdt_employees>();

            var obj = new List<d1_cdt_employees>();

            string[] _val = new string[dt.Rows.Count];
            ArrayList prpVal = new ArrayList();
            ArrayList prpName = new ArrayList();
            var qq = obj.GetType().GetProperties();
            //foreach (var prop in obj.GetType().GetProperties())          

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                foreach (var prop in obj.GetType().GetProperties())
                {
                    prpVal.Add(prop.GetValue(obj, null).ToString());
                    prpName.Add(prop.Name);
                }


                obj.Add(new d1_cdt_employees()
                {
                    ////prpName[i] = prpVal[i]; //Need to generalize
                    //_e_uid = dt.Rows[i][0].ToString(),
                    //_emp_id = dt.Rows[i][1].ToString(),
                    //_firstname = dt.Rows[i][2].ToString(),
                    //_lastname = dt.Rows[i][3].ToString(),
                    //_petname = dt.Rows[i][4].ToString(),
                    //_dob = dt.Rows[i][5].ToString(),
                    //_gender = dt.Rows[i][6].ToString(),
                    //_emptype = dt.Rows[i][7].ToString(),
                    //_designation = dt.Rows[i][8].ToString(),
                    //_empaddress = dt.Rows[i][9].ToString(),
                    //_pincode = dt.Rows[i][10].ToString(),
                    //_homephone = dt.Rows[i][11].ToString(),
                    //_mobile = dt.Rows[i][12].ToString(),
                    //_emailid = dt.Rows[i][13].ToString(),
                    //_education = dt.Rows[i][14].ToString(),
                    //_aadhaarno = dt.Rows[i][15].ToString(),
                    //_addressproof = dt.Rows[i][16].ToString(),
                    //_dl_no = dt.Rows[i][17].ToString(),
                    //_dl_htmv = dt.Rows[i][18].ToString(),
                    //_dl_hmv = dt.Rows[i][19].ToString(),
                    //_dl_lmv = dt.Rows[i][20].ToString(),
                    //_dl_rto = dt.Rows[i][21].ToString(),
                    //_dl_expdt = dt.Rows[i][22].ToString(),
                    //_hiring_manager_id = dt.Rows[i][23].ToString(),
                    //_hiring_date = dt.Rows[i][24].ToString(),
                    //_experience = dt.Rows[i][25].ToString(),
                    //_attributes = dt.Rows[i][26].ToString(),
                    //_otherdetails = dt.Rows[i][27].ToString(),
                    //_emp_status = dt.Rows[i][28].ToString(),
                    //_allow_login = dt.Rows[i][29].ToString(),
                    //_create_id = dt.Rows[i][30].ToString(),
                    //_create_date = dt.Rows[i][31].ToString(),
                    //_update_id = dt.Rows[i][32].ToString(),
                    //_update_date = dt.Rows[i][33].ToString(),
                });
            }

            engine.WriteFile(@"C:\Users\punee\Documents\sahaj\bkup\tmp.csv", obj);
        }
    }
}
