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

namespace Sayen.UserControls
{
    public partial class uc_AddEmpl : UserControl
    {
        public uc_AddEmpl()
        {
            
            InitializeComponent();
            LoadAddEmp();

        }

        private void LoadAddEmp()
        {
            if (AppGlobal.CurrentAppEnv == "DEV" || AppGlobal.CurrentAppEnv == "TEST"){ chk_prefill.Visible = true; }
            else { chk_prefill.Visible = false; }

            ddl_empType.DataSource = new BindingSource(AppConstants.EmployeeType, null);
            ddl_empType.ValueMember = "Value";
            ddl_empType.DisplayMember = "Key";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_firstName.Text);
        }

        private void uc_AddEmpl_Load(object sender, EventArgs e)
        {
            //ABC TRANSPORT  5 Years
        }

        private void lbl_lastName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chk_prefill_CheckedChanged(object sender, EventArgs e)
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
            for (int i = 0; i < chk_dlTypes.Items.Count; i++)
            {
                chk_dlTypes.SetItemChecked(i, true);
            }
            txt_validity.Text = "12/12/2025";
            txt_rto.Text = "nagrota bagwan";
            txt_experience.Text = "5 years";
            txt_attributes.Text = "Long Route driver";
            txt_otherDetails.Text = "smoker drinker";
        }

        private void ddl_empType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ddl_designation.Items.Insert(0, new ListItem());
            //ddl_designation.SelectedIndex = 0;
            ddl_designation.Text = ddl_empType.Text;

        }
    }
}
