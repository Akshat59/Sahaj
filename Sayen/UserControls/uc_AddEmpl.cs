using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using m1.Shared;
using System.Windows.Documents;
using static m1.Shared.AppCommon;

namespace Sayen.UserControls
{
    public partial class uc_AddEmpl : UserControl
    {
        public uc_AddEmpl()
        {

            InitializeComponent();
            LoadAddEmp();

        }

        #region Controls

        private void ddl_empType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_designation.Text = ddl_empType.Text;
        }



        private void btn_reset_Click(object sender, EventArgs e)
        {
            Utilities.CallResetControl(this.panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_firstName.Text);
        }

        private void chk_prefill_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_prefill.Checked)
            {
                PrefillControls();
            }
            else
            {
                Utilities.CallResetControl(this.panel1);
            }
        }


        #endregion

        #region UserMethods


        private void LoadAddEmp()
        {
            if (AppGlobal.CurrentAppEnv == "DEV" || AppGlobal.CurrentAppEnv == "TEST") { chk_prefill.Visible = true; }
            else { chk_prefill.Visible = false; }

            ddl_empType.DataSource = new BindingSource(AppConstants.EmployeeType, null);
            ddl_empType.ValueMember = "Value";
            ddl_empType.DisplayMember = "Key";
            ddl_empType.SelectedText = "";
            ddl_designation.Text = ddl_empType.Text;


            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.AutoSize = true;

        }       

        private void PrefillControls()
        {
            txt_firstName.Text = "ram";
            txt_lastName.Text = "kumar";
            txt_petName.Text = "ramu";
            rdl_gender_m.Checked = true;
            ddl_empType.Text = "Driver";
            txt_address.Text = "1234 Mohala 1 Nagrota Bagwan HP";
            txt_pinCode.Text = "176047";
            txt_homePhone.Text = "01892252000";
            txt_mobileNo.Text = "9418012345";
            txt_aadhaar.Text = "123456789012";
            txt_addressProof.Text = "rashan card";
            txt_dlno.Text = "hp-40-123456789";
            chk_dltype_hmv.Checked = true;
            chk_dltype_htmv.Checked = true;
            chk_dltype_lmv.Checked = true;
            dtp_validity.Text = "12/12/2025";
            txt_rto.Text = "nagrota bagwan";
            txt_experience.Text = "5 years with national\r\n3 years with shivalik";
            txt_attributes.Text = "Long Route driver";
            txt_otherDetails.Text = "smoker, drinker";
        }



        #endregion

        private void txt_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

       
    }
}
