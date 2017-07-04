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

            this.AutoSize = true;
            
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.AutoSize = true;
            //_ucAddEmp.Anchor = AnchorStyles.None;

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
            if (chk_prefill.Checked)
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
                //txt_validity.Text = "12/12/2025";
                dateTimePicker1.Text = "12/12/2025";
                txt_rto.Text = "nagrota bagwan";
                txt_experience.Text = "5 years";
                txt_attributes.Text = "Long Route driver";
                txt_otherDetails.Text = "smoker, drinker";
            }
            else
            {
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    this.Controls[i].ResetText();
                }

               // uc_AddEmpl _obj = new uc_AddEmpl();
                //_obj.Show();
                //_obj.Dispose(false);
            }
        }

        private void ddl_empType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ddl_designation.Items.Insert(0, new ListItem());
            //ddl_designation.SelectedIndex = 0;
            ddl_designation.Text = ddl_empType.Text;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chk_dlTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_rto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_validity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_dlno_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_upload_dl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lbl_filename_dl_Click(object sender, EventArgs e)
        {

        }

        private void lbl_rto_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dlno_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dlTypes_Click(object sender, EventArgs e)
        {

        }

        private void lbl_firstName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void txt_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_petName_Click(object sender, EventArgs e)
        {

        }

        private void txt_petName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdl_gendel_f_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdl_gender_m_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_gender_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pinCode_Click(object sender, EventArgs e)
        {

        }

        private void lbl_homePhone_Click(object sender, EventArgs e)
        {

        }

        private void lbl_mobileNo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_address_Click(object sender, EventArgs e)
        {

        }

        private void lbl_empType_Click(object sender, EventArgs e)
        {

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pinCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_homePhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mobileNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_aadhaar_Click(object sender, EventArgs e)
        {

        }

        private void lbl_drivingLicence_Click(object sender, EventArgs e)
        {

        }

        private void lbl_addressProof_Click(object sender, EventArgs e)
        {

        }

        private void lbl_attributes_Click(object sender, EventArgs e)
        {

        }

        private void lbl_otherDetails_Click(object sender, EventArgs e)
        {

        }

        private void lbl_experience_Click(object sender, EventArgs e)
        {

        }

        private void txt_experience_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_attributes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_aadhaar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_addressProof_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_filename_uid_Click(object sender, EventArgs e)
        {

        }

        private void lbl_filename_add_Click(object sender, EventArgs e)
        {

        }

        private void lbl_upload_uid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lbl_upload_add_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lbl_designation_Click(object sender, EventArgs e)
        {

        }

        private void ddl_designation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_validity_Click(object sender, EventArgs e)
        {

        }

        private void txt_otherDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //var _panel1 = panel1;
            //AppCommon.ClearFormControls(this);

            //this.Controls.Add(_panel1);
            //this.LoadAddEmp();
        }
    }
}
