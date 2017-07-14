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
using Sahaj.UserControls;
using m1.BPC;
using m1.Shared.Entities;

namespace Sayen.UserControls
{
    public partial class uc_AddEmpl : UserControl
    {

        #region Objects
        frm_Home _objfrmHome;
        bool _isPostback = false;
        AppConstants.e_frmOperationType _operationType;
        EmployeeEntity emp = new EmployeeEntity();

        private genBPC _genBPC;

        public genBPC GenBPC
        {
            get { if (_genBPC == null) { _genBPC = new genBPC(); } return _genBPC; }
            set { _genBPC = new genBPC(); }

        }

        private GenEntity _gEntity;

        public GenEntity GEntity
        {
            get { if (_gEntity == null) { _gEntity = new GenEntity(); } return _gEntity; }
        }
        #endregion

        public uc_AddEmpl()
        {
            InitializeComponent();
            LoadAddEmp();
        }

        public uc_AddEmpl(frm_Home objFrmHome, AppConstants.e_frmOperationType optyp )
        {
            InitializeComponent();

            LoadAddEmp();
            _objfrmHome = objFrmHome;
            _operationType = optyp;
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

        private void btn_submit_Click(object sender, EventArgs e)
        {
            this.ValidateAndSave_addEmpl();
        }

        

        private void txt_firstName_Validating(object sender, CancelEventArgs e)
        {
            Utilities.DontAllow_Empty(txt_firstName, errorProvider1, e);
        }

        private void rdl_singleUpload_CheckedChanged(object sender, EventArgs e)
        {
            setMaintenanceMode();
        }

        private void rdl_bulkUpload_CheckedChanged(object sender, EventArgs e)
        {
            setMaintenanceMode();
        }

        private void dtp_dob_ValueChanged(object sender, EventArgs e)
        {
            int _age = Utilities.GetAge(DateTime.Now.AddDays(30), dtp_dob.Value);
            txt_age.Text = _age.ToString();
        }

        #region KeyPress
        private void txt_pinCode_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!(txt_pinCode.Text.Length < 6|| (e.KeyChar == (char)Keys.Back))) { e.Handled = true; }
            else { Utilities.DontAllowAlphabet(sender, e); }
        }

        private void txt_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.DontAllowDigit(sender, e);
        }

        private void txt_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.DontAllowDigit(sender, e);
        }

        private void txt_petName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.DontAllowDigit(sender, e);
        }

        private void txt_homePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.DontAllowAlphabet(sender, e);
        }

        private void txt_mobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.DontAllowAlphabet(sender, e);
        }

        private void txt_aadhaar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.DontAllowAlphabet(sender, e);
        }

        private void txt_addressProof_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.DontAllowDigit(sender, e);
        }

        private void txt_rto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.DontAllowDigit(sender, e);
        }

        #endregion KeyPress
        #endregion Controls

        #region UserMethods


        private void LoadAddEmp()
        {
            if (AppGlobal.CurrentAppEnv == AppConstants.d_AppEnvironments.FirstOrDefault(x => x.Key == AppConstants.e_AppEnvironment.DEV.ToString()).Key
                || AppGlobal.CurrentAppEnv == AppConstants.d_AppEnvironments.FirstOrDefault(x => x.Key == AppConstants.e_AppEnvironment.TEST.ToString()).Key)
                { chk_prefill.Visible = true; }
            else { chk_prefill.Visible = false; }

            
            ddl_empType.DataSource = new BindingSource(AppConstants.d_EmployeeType, null);
            ddl_empType.ValueMember = "Value";
            ddl_empType.DisplayMember = "Key";
            ddl_empType.SelectedText = "";
            ddl_designation.Text = ddl_empType.Text;

            _isPostback = true;

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
            dtp_dob.Text = "01/01/1983";
            ddl_empType.Text = "Driver";
            txt_address.Text = "1234 Mohala 1 Nagrota Bagwan HP";
            txt_pinCode.Text = "176047";
            txt_homePhone.Text = "01892252000";
            txt_mobileNo.Text = "9418012345";
            txt_education.Text = "Graduation";
            txt_aadhaar.Text = "123456789012";
            txt_addressProof.Text = "rashan card";
            txt_dlno.Text = "hp-40-123456789";
            chk_dltype_hmv.Checked = true;
            chk_dltype_htmv.Checked = true;
            chk_dltype_lmv.Checked = true;
            dtp_validity.Text = "01/01/2025";
            txt_rto.Text = "nagrota bagwan";
            txt_experience.Text = "5 years with national\r\n3 years with shivalik";
            txt_attributes.Text = "Long Route driver";
            txt_otherDetails.Text = "smoker, drinker";
        }

        private void setMaintenanceMode()
        {
            if (rdl_singleUpload.Checked )
            {
                //Do Nothing   #futureCode   handle this to log               
            }
            else if (rdl_bulkUpload.Checked && _isPostback)
            {
                _isPostback = false;
                rdl_bulkUpload.Enabled = false;
                uc_BulkUpload obj = new uc_BulkUpload(_objfrmHome,AppConstants.e_BulkUploadType.EMPLOYEE, AppConstants.TabPageManage);
                _objfrmHome.LoadStripUC_frmUC(obj, AppConstants.TabPageManage,this, AppConstants.TabPageManage);
                this.Dispose();
                rdl_bulkUpload.Enabled = true;
            }
        }

        private bool Validate_AddEmpl()
        {
            return true;  //#futureCode
        }


        private void SetEmployeeCollections(EmployeeEntity emp)
        {
            
            emp.Firstname = txt_firstName.Text;
            emp.Lastname = txt_lastName.Text;
            emp.Petname = txt_petName.Text;
            emp.Dob = dtp_dob.Text;
            emp.Gender = rdl_gender_m.Checked ? AppConstants.e_Gender.M.ToString(): AppConstants.e_Gender.F.ToString();
            emp.Emptype = ddl_empType.Text;
            emp.Designation = ddl_designation.Text;
            emp.Empaddress = txt_address.Text;
            emp.Pincode = txt_pinCode.Text;
            emp.Homephone = txt_homePhone.Text;
            emp.Mobile = txt_mobileNo.Text;
            emp.Education = txt_education.Text;
            emp.Aadhaarno = txt_aadhaar.Text;
            emp.Addressproof = txt_addressProof.Text;
            emp.Dl_no = txt_dlno.Text;
            emp.Dl_htmv = chk_dltype_htmv.Checked ? AppKeys.Yes : AppKeys.No;
            emp.Dl_hmv = chk_dltype_hmv.Checked ? AppKeys.Yes : AppKeys.No;
            emp.Dl_lmv = chk_dltype_lmv.Checked ? AppKeys.Yes : AppKeys.No;
            emp.Dl_rto = txt_rto.Text;
            emp.Hiring_manager_id = ddl_hiring_manager.Text;
            emp.Experience = txt_experience.Text;
            emp.Attributes = txt_attributes.Text;
            emp.Otherdetails = txt_otherDetails.Text;
            emp.Emp_status = AppKeys.Active;

        }

        private void ValidateAndSave_addEmpl()
        {
            //Include Validation

            bool _valStatus = this.Validate_AddEmpl();
            //if (Utilities.UC_hasValidationErrors(this.Controls))
            //{ MessageBox.Show("FALSE"); }
            //else
            // if we get here the validation passed
            //this.close();
            //{ MessageBox.Show("TRUE"); }

            //EmployeeCollection empCol = new EmployeeCollection();
           
            emp.Optype = AppConstants.e_frmOperationType.S;

            //SetEmployeeCollections
            this.SetEmployeeCollections(emp);

            //GenEntity gEntity = new GenEntity();
            //gEntity.empEntity = emp;

            //InsertEmpDetails
            if (_valStatus)
            {
                if (emp == null)
                    { }
                else
                _genBPC.bpcSingfleEmpInsert(emp);
            }
            else
            { //Shoe Error #futureCode
            }
        }

        #endregion UserMethods


    }
}
