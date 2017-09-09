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
using System.Reflection;
using System.Globalization;
using System.Threading;
using System.IO;
using System.Diagnostics;
using static m1.Shared.AppConstants;
using System.Drawing.Imaging;

namespace Sayen.UserControls
{
    public partial class uc_AddEmpl : UserControl
    {

        #region Objects
        frm_Home _objfrmHome;
        bool _isPostback = false;
        AppConstants.e_frmOperationType _operationType;
        EmployeeEntity emp = new EmployeeEntity();
        static DocumentCollection docCol = null;
        string _empID = string.Empty;
        //EmployeeDocs edoc = new EmployeeDocs();

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

        public uc_AddEmpl()
        {
            InitializeComponent();
            LoadAddEmpUC();
        }

        public uc_AddEmpl(AppConstants.e_frmOperationType optyp, frm_Home objFrmHome, string empId = "")
        {
            InitializeComponent();
            _objfrmHome = objFrmHome;
            _operationType = optyp;
            docCol = new DocumentCollection();

            if (optyp == AppConstants.e_frmOperationType.S)
            { LoadAddEmpUC(); }
            else if (optyp == AppConstants.e_frmOperationType.V)
            { LoadAddEmpUC(); LoadViewEmp(empId); }
            else { } //RaiseError  #futureCode}

            this._genBPC = null;
            if (_genBPC == null) { _genBPC = new genBPC(); }
        }
        #endregion

        #region Controls

        #region Events


        private void ddl_empType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_designation.Text = ddl_empType.Text;
        }



        private void btn_reset_Click(object sender, EventArgs e) { this.ucResetControls(); } 

        private void chk_prefill_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_prefill.Checked) { PrefillControls(); }
            else { this.ucResetControls(); }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (_operationType == e_frmOperationType.S || _operationType == e_frmOperationType.U)
            {
                if (this.Validate_AddEmpl())
                {
                    this.Save_addEmpl();
                    if (docCol != null)
                    {
                        docCol.Clear();
                        docCol = null;
                        docCol = new DocumentCollection();
                    }
                }
            }
            else if (_operationType == e_frmOperationType.X)
            {
                DialogResult res = Utilities.GetYesNoConfirmation(UserMessages.ConfirmTerminateEmp_title, UserMessages.ConfirmTerminateEmp_text);
                if (res.Equals(DialogResult.Yes))
                { this.Save_addEmpl(); }
            }
            else
            {
                Exception Ex = new Exception("Operation Not allowed; _operationType is UnExpected; Source: " + "uc_AddEmpl.btn_submit_Click");
                ExceptionManagement.logUserException(Ex);
            }

            
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

        private void lbl_title_Click(object sender, EventArgs e)
        {
           
        }

        private void chk_escalatedEmp_CheckedChanged(object sender, EventArgs e)
        {
            //Thread.Sleep(1000);
            //chk_escalatedEmp.Visible = false;
        }

        private void rdl_editEmp_CheckedChanged(object sender, EventArgs e)
        {

            panel5.Visible = true;            

            if (rdl_editEmp.Checked)
            {
                _operationType = AppConstants.e_frmOperationType.U;
                Utilities.EnableDisableControls(panel1.Controls, true);
                Utilities.SetControlReadonly(panel1.Controls, false);
                txt_age.Enabled = false;
                ddl_hiring_manager.Enabled = false;

            }
            else if (rdl_terminateEmp.Checked)
            {
                _operationType = AppConstants.e_frmOperationType.X;
                Utilities.EnableDisableControls(panel1.Controls, false);
                Utilities.SetControlReadonly(panel1.Controls, true);
                Utilities.EnableDisableControls(panel5.Controls, true);
                Utilities.EnableDisableControls(panel7.Controls, true);

            }
        }

        private void rdl_terminateEmp_CheckedChanged(object sender, EventArgs e)
        {
            panel5.Visible = true;
            txt_age.Enabled = false;

            if (rdl_terminateEmp.Checked)
            {
                _operationType = AppConstants.e_frmOperationType.X;
                Utilities.EnableDisableControls(panel1.Controls, false);
                Utilities.SetControlReadonly(panel1.Controls, true);
                Utilities.EnableDisableControls(panel5.Controls, true);
                Utilities.EnableDisableControls(panel7.Controls, true);

            }
            else if (rdl_editEmp.Checked)
            {
                _operationType = AppConstants.e_frmOperationType.U;
                Utilities.EnableDisableControls(panel1.Controls, true);
                Utilities.SetControlReadonly(panel1.Controls, false);

            }

        }

        private void lbl_title_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_operationType==e_frmOperationType.S &&(AppGlobal.g_GEntity.UserEntity.Role_id.Equals(((int)AppConstants.e_AppUserRoles.Admin).ToString())
               || AppGlobal.g_GEntity.UserEntity.Role_id.Equals(((int)AppConstants.e_AppUserRoles.AppDeveloper).ToString())))
            {
                chk_escalatedEmp.Visible = true;
            }
        }

        #endregion Events

        #region Validation
        private void txt_firstName_Validating(object sender, CancelEventArgs e)
        {
            if (!txt_firstName.ReadOnly) { Utilities.DontAllow_Empty(txt_firstName, errorProvider1, e); }
        }

        private void txt_lastName_Validating(object sender, CancelEventArgs e)
        {
            if (!txt_lastName.ReadOnly) { Utilities.DontAllow_Empty(txt_lastName, errorProvider1, e); }
        }
        private void dtp_dob_Validating(object sender, CancelEventArgs e)
        {
            if (dtp_dlValidity.Enabled) { Utilities.DontAllow_InvalidDOB(dtp_dob, txt_age, errorProvider1, e); }
        }

        private void dtp_validity_Validating(object sender, CancelEventArgs e)
        {

            if (dtp_dlValidity.Enabled && txt_dlno.Text.Length > 0)
            { Utilities.DontAllow_InvalidExpiryDate(dtp_dlValidity, errorProvider1, e); }
        }

        private void txt_mobileNo_Validating(object sender, CancelEventArgs e)
        {
            if (!txt_mobileNo.ReadOnly)
            {
                Utilities.DontAllow_Empty(txt_mobileNo, errorProvider1, e);
                if (txt_mobileNo.TextLength != 10)
                {
                    errorProvider1.SetError(txt_mobileNo, UserMessages.InvalidMobileNumber);
                    e.Cancel = true;
                }
            }
        }

        private void txt_aadhaar_Validating(object sender, CancelEventArgs e)
        {
            if (!txt_aadhaar.ReadOnly)
            {
                Utilities.DontAllow_Empty(txt_aadhaar, errorProvider1, e);
                if (txt_aadhaar.TextLength != 12)
                {
                    errorProvider1.SetError(txt_aadhaar, UserMessages.InvalidAadhar);
                    e.Cancel = true;
                }
            }
        }
        private void txt_dlno_Validating(object sender, CancelEventArgs e)
        {
            if (!txt_dlno.ReadOnly)
            {
                if (ddl_empType.Text == e_EmployeeType.Driver.ToString() && txt_dlno.TextLength < 5)
                {
                    txt_rto.Text = string.Empty;
                    dtp_dlValidity.Text = string.Empty;
                    errorProvider1.SetError(txt_dlno, UserMessages.ValidDLRequired);
                    e.Cancel = true;
                }

                else { errorProvider1.SetError(txt_dlno, ""); }
            }

        }

        private void dtp_hiringDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtp_hiringDate.Enabled) { Utilities.DontAllow_FutureDate(dtp_hiringDate, errorProvider1, e); }
        }



        #endregion Validation

        #region EmpDocs

        private void lbl_hide_viewDoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utilities.SetDocPanel(e_DocType.AAD, lbl_upload_uid, lbl_view_uid, pb_del_uid, lbl_fileName_uid, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.H, docCol);
        }

        private void lbl_upload_uid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utilities.SetDocPanel(e_DocType.AAD, lbl_upload_uid, lbl_view_uid, pb_del_uid, lbl_fileName_uid, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.U, docCol);
        }

        private void lbl_view_uid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utilities.SetDocPanel(e_DocType.AAD, lbl_upload_uid, lbl_view_uid, pb_del_uid, lbl_fileName_uid, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.V, docCol);
        }

        private void pb_del_uid_Click(object sender, EventArgs e)
        {
            Utilities.SetDocPanel(e_DocType.AAD, lbl_upload_uid, lbl_view_uid, pb_del_uid, lbl_fileName_uid, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.D, docCol);
        }

        private void lbl_upload_ap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utilities.SetDocPanel(e_DocType.APX, lbl_upload_ap, lbl_view_ap, pb_del_ap, lbl_fileName_ap, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.U, docCol);
        }

        private void lbl_view_ap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utilities.SetDocPanel(e_DocType.APX, lbl_upload_ap, lbl_view_ap, pb_del_ap, lbl_fileName_ap, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.V, docCol);
        }

        private void pb_del_ap_Click(object sender, EventArgs e)
        {
            Utilities.SetDocPanel(e_DocType.APX, lbl_upload_ap, lbl_view_ap, pb_del_ap, lbl_fileName_ap, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.D, docCol);
        }

        private void lbl_upload_ppic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utilities.SetDocPanel(e_DocType.EPH, lbl_upload_ppic, lbl_view_ppic, pb_del_ppic, lbl_fileName_ppic, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.U, docCol);
        }

        private void lbl_view_ppic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utilities.SetDocPanel(e_DocType.EPH, lbl_upload_ppic, lbl_view_ppic, pb_del_ppic, lbl_fileName_ppic, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.V, docCol);
        }

        private void pb_del_ppic_Click(object sender, EventArgs e)
        {
            Utilities.SetDocPanel(e_DocType.EPH, lbl_upload_ppic, lbl_view_ppic, pb_del_ppic, lbl_fileName_ppic, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.D, docCol);
        }

        private void lbl_upload_dl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utilities.SetDocPanel(e_DocType.DLF, lbl_upload_dl, lbl_view_dl, pb_del_dl, lbl_fileName_dl, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.U, docCol);
        }

        private void lbl_view_dl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utilities.SetDocPanel(e_DocType.DLF, lbl_upload_dl, lbl_view_dl, pb_del_dl, lbl_fileName_dl, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.V, docCol);
        }

        private void pb_del_dl_Click(object sender, EventArgs e)
        {
            Utilities.SetDocPanel(e_DocType.DLF, lbl_upload_dl, lbl_view_dl, pb_del_dl, lbl_fileName_dl, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.D, docCol);

        }

        private void pb_viewDoc_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point mPointWhenClicked = new Point(e.X, e.Y);
                Thread.Sleep(500);
                contextMenuStrip1.Show(mPointWhenClicked);
            }
        }

        private void tsmi_savePicture_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Hide();
            Utilities.ContextMenuStrip_pb(pb_viewDoc, 2);
        }

        private void tsmi_showPicture_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Hide();
            Utilities.ContextMenuStrip_pb(pb_viewDoc, 1);
        }

        #endregion EmpDocs

        #region KeyPress
        private void txt_pinCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(txt_pinCode.Text.Length < 6 || (e.KeyChar == (char)Keys.Back))) { e.Handled = true; }
            else { Utilities.DontAllowAlphabet(sender, e); }
        }

        private void txt_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilities.DontAllowDigit(sender, e);

            if (tableLayoutPanel5.HasChildren)
            { tableLayoutPanel5.Controls.Clear(); }
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


        private void LoadAddEmpUC()
        {
            if (AppGlobal.CurrentAppEnv == AppConstants.d_AppEnvironments.FirstOrDefault(x => x.Key == AppConstants.e_AppEnvironment.DEV.ToString()).Key
                || AppGlobal.CurrentAppEnv == AppConstants.d_AppEnvironments.FirstOrDefault(x => x.Key == AppConstants.e_AppEnvironment.TEST.ToString()).Key)
            { chk_prefill.Visible = true; }
            else { chk_prefill.Visible = false; }
            rdl_bulkUpload.Enabled = true;

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

        private void LoadViewEmp(string empID)
        {
            lbl_title.Text = "View / Edit" + " " + "Employee";
            { rdl_bulkUpload.Visible = rdl_singleUpload.Visible = btn_reset.Visible = chk_prefill.Visible = panel5.Visible = false; }

            Utilities.EnableDisableControls(panel1.Controls, false);
            { lbl_view_uid.Enabled = lbl_view_ap.Enabled = lbl_view_ppic.Enabled = lbl_view_dl.Enabled = lbl_hide_viewDoc.Enabled = pb_viewDoc.Enabled = true; }
            Utilities.SetControlReadonly(panel1.Controls, true);
            Utilities.EnableDisableControls(panel7.Controls, true);
            panel7.Visible = true;

            if (empID.Length > 0)
            {
                _empID = empID;
                lbl_empId.Visible = true;
                lbl_empId.Text = empID;

                //Retrieve emp details from database
                EmployeeCollection m_eCol = new EmployeeCollection();
                EmployeeEntity m_emp = new EmployeeEntity();
                m_eCol.Optype = _operationType;
                m_emp.Emp_id = empID;
                m_eCol.Add(m_emp);

                GenBPC.bpcGetEmpDetails(m_eCol);

                string empStatus;
                foreach (EmployeeEntity _emp in m_eCol)
                {
                    PopulateControls(_emp);
                    empStatus = _emp.Emp_status;
                    if(_emp.Emp_status !=AppKeys.Active)
                    { MessageBox.Show("Employee is terminated, Edit and submit to Reactivate"); }
                    else
                    {
                        //Retrieve emp docs
                        DocumentCollection m_dCol = new DocumentCollection();
                        formDocs m_doc = new formDocs();
                        m_dCol.Optype = _operationType;
                        m_doc.EmpId = empID;
                        m_dCol.Add(m_doc);

                        docCol = GenBPC.bpcGetEmpDocs(m_dCol);
                        //m_dcol.FormMessages. = UserMessages.RetrieveEmpDocsFailed;

                        if (docCol.DocCount>0)
                        { foreach (formDocs _empdoc in docCol) { PopulateDocsPanel(_empdoc); } }
                    }
                    break;
                }

               

            }
            else
            {                
                Exception Ex = new Exception("Operation Not allowed; empID is not set; Source: " + "LoadViewEmp");
                ExceptionManagement.logUserException(Ex);
            }

        }

        private void PopulateControls(EmployeeEntity emp)
        {
            txt_firstName.Text = emp.Firstname;
            txt_lastName.Text = emp.Lastname;
            txt_petName.Text = emp.Petname;
            dtp_dob.Text = emp.Dob;
            rdl_gender_m.Checked = emp.Gender.Equals(e_Gender.M.ToString()) ? true : false;
            rdl_gender_f.Checked = emp.Gender.Equals(e_Gender.F.ToString()) ? true : false;
            ddl_empType.Text = emp.Emptype;
            ddl_designation.Text = emp.Designation;
            txt_address.Text = emp.Empaddress;
            txt_pinCode.Text = emp.Pincode;
            txt_homePhone.Text = emp.Homephone;
            txt_mobileNo.Text = emp.Mobile;
            txt_email.Text = emp.Emailid;
            txt_education.Text = emp.Education;
            txt_aadhaar.Text = emp.Aadhaarno;
            txt_addressProof.Text = emp.Addressproof;
            txt_dlno.Text = emp.Dl_no;
            chk_dltype_htmv.Checked = emp.Dl_htmv.Equals(AppKeys.Yes) ? true : false;
            chk_dltype_hmv.Checked = emp.Dl_hmv.Equals(AppKeys.Yes) ? true : false;
            chk_dltype_lmv.Checked = emp.Dl_lmv.Equals(AppKeys.Yes) ? true : false;
            txt_rto.Text = emp.Dl_rto;
            dtp_dlValidity.Text = emp.Dl_expDt;
            ddl_hiring_manager.Text = emp.Hiring_manager_id;
            dtp_hiringDate.Text = (DateTime.ParseExact(emp.Hiring_Date, "dd-MM-yyyy", CultureInfo.InvariantCulture)).ToString();
            txt_experience.Text = emp.Experience;
            txt_attributes.Text = emp.Attributes;
            txt_otherDetails.Text = emp.Otherdetails;
            lbl_empStatus.Text = emp.Emp_status == AppKeys.Active ? "Active" : "Terminated";
            lbl_empStatus.ForeColor = emp.Emp_status == AppKeys.Active ? Color.LimeGreen : Color.Red;
            //txt_allow_login.Text = emp.Allow_login;
        }

        private void PopulateDocsPanel(formDocs empDoc)
        {
            switch (empDoc.DocType)
            {
                case AppConstants.e_DocType.AAD:
                    Utilities.SetDocPanel(e_DocType.AAD, lbl_upload_uid, lbl_view_uid, pb_del_uid, lbl_fileName_uid, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.P, docCol);
                    break;
                case AppConstants.e_DocType.APX:
                    Utilities.SetDocPanel(e_DocType.APX, lbl_upload_ap, lbl_view_ap, pb_del_ap, lbl_fileName_ap, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.P, docCol);
                    break;
                case AppConstants.e_DocType.DLF:
                    Utilities.SetDocPanel(e_DocType.DLF, lbl_upload_dl, lbl_view_dl, pb_del_dl, lbl_fileName_dl, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.P, docCol);
                    break;
                case AppConstants.e_DocType.EPH:
                    //lbl_fileName_ppic.Text = empDoc.DocName;
                    Utilities.SetDocPanel(e_DocType.EPH, lbl_upload_ppic, lbl_view_ppic, pb_del_ppic, lbl_fileName_ppic, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.P, docCol);
                    Utilities.SetDocPanel(e_DocType.EPH, lbl_upload_ppic, lbl_view_ppic, pb_del_ppic, lbl_fileName_ppic, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.V, docCol);
                    break;
            }

            //txt_firstName.Text = emp.Firstname;
            //txt_lastName.Text = emp.Lastname;

        }

        private void PrefillControls()
        {
            txt_firstName.Text = "ram";
            txt_lastName.Text = "kumar";
            txt_petName.Text = "ramu";
            rdl_gender_m.Checked = true;
            dtp_dob.Text = "01/01/1983";
            ddl_empType.Text = "Driver";
            txt_address.Text = "1234 mohala 1 nagrota Bagwan hP";
            txt_pinCode.Text = "176047";
            txt_homePhone.Text = "01892252000";
            txt_mobileNo.Text = "9418012345";
            txt_email.Text = "ram_kumar@gmail.com";
            txt_education.Text = "Graduation";
            txt_aadhaar.Text = "123456789012";
            txt_addressProof.Text = "rashan card";
            txt_dlno.Text = "hp-40-123456789";
            chk_dltype_hmv.Checked = true;
            chk_dltype_htmv.Checked = true;
            chk_dltype_lmv.Checked = true;
            dtp_dlValidity.Text = "01/01/2025";
            dtp_hiringDate.Text = DateTime.Now.Date.ToString();
            txt_rto.Text = "nagrota bagwan";
            txt_experience.Text = "5 years with national\r\n3 years with shivalik";
            txt_attributes.Text = "Long Route driver";
            txt_otherDetails.Text = "smoker, drinker";
        }

        private void setMaintenanceMode()
        {
            if (rdl_singleUpload.Checked)
            {
                //Do Nothing   #futureCode   handle this to log               
            }
            else if (rdl_bulkUpload.Checked && _isPostback)
            {
                _isPostback = false;
                rdl_bulkUpload.Enabled = false;
                uc_BulkUpload obj = new uc_BulkUpload(_objfrmHome, AppConstants.e_BulkUploadType.EMPLOYEE, AppConstants.TabPageManage);
                _objfrmHome.LoadStripUC_frmUC(obj, AppConstants.TabPageManage, this, AppConstants.TabPageManage);
                this.Dispose();
                rdl_bulkUpload.Enabled = true;
            }
        }

        private bool Validate_AddEmpl()
        {
            //#futurecode
            if (Utilities.UC_hasValidationErrors(this.Controls))
            {
                MessageBox.Show(UserMessages.SubmitFormError);
                return false;
            }
            else
            //if we get here the validation passed
            {
                MessageBox.Show(UserMessages.SubmitFormSuccess);
                return true;
            }
        }

        /// <summary>
        /// Method to Insert Employee details into Database
        /// </summary>
        private void Save_addEmpl()
        {
            EmployeeCollection empCol = new EmployeeCollection();

            empCol.Optype = _operationType;
            try
            {
                //SetEmployeeCollections
                this.SetEmployeeCollection(emp);
                empCol.Add(emp);
                empCol.Messages = string.Empty;

                if(docCol.DocCount > 0) { this.SetEmployeeDocCollection(emp.Emp_id); }

                if (_operationType == e_frmOperationType.S)
                {
                    //call method chain to insert emp details
                    _genBPC.bpcInsertEmployeeDetails(empCol);


                    if (empCol.RetIndicator != AppKeys.Failure)
                    {
                        string _s = emp.Firstname + " " + emp.Lastname;
                        string _msg = string.Format(UserMessages.InsertEmpIDSuccess, _s.Trim(), emp.Emp_id); 
                        MessageBox.Show(_msg);
                    }

                    //call method chain to insert emp Documents details
                    if (docCol.DocCount > 0)
                    {
                        _genBPC.bpcInsertEmployeeDocs(docCol);

                        if (empCol.RetIndicator == AppKeys.Failure)
                        {
                            MessageBox.Show(UserMessages.UpdateEmpDocFailure);
                        }
                    }

                }
                else if (_operationType == e_frmOperationType.U)
                {
                    _genBPC.bpcUpdateEmployeeDetails(empCol);

                    if (docCol.DocCount > 0) { _genBPC.bpcUpdateEmployeeDocs(docCol); }

                    if (empCol.RetIndicator != AppKeys.Failure)
                    {
                        MessageBox.Show(UserMessages.DatabaseUpdateSuccess);
                    }
                }
                else if (_operationType == e_frmOperationType.X)
                {
                    _genBPC.bpcTerminateEmployee(empCol);

                    if (docCol.DocCount > 0) { _genBPC.bpcTerminateEmployeeDocs(docCol); }

                    if (empCol.RetIndicator != AppKeys.Failure) { MessageBox.Show(UserMessages.DatabaseUpdateSuccess); }
                }
                
            }
            catch (Exception Ex)
            {
                ExceptionManagement.logAppException(Ex);
            }
            finally
            {
                this.postSubmission(empCol, docCol);
            }
        }


        private void SetEmployeeCollection(EmployeeEntity emp)
        {
            if (_operationType == e_frmOperationType.S)
            {
                string _seriesInitals = string.Empty;
                //First Get Next ID
                //set empid series
                if (chk_escalatedEmp.Checked || ddl_empType.Text == AppConstants.e_EmployeeType.Board.ToString())
                { _seriesInitals = AppConstants.e_PrimaryKeySeries.a09.ToString(); }
                else if (ddl_empType.Text == AppConstants.e_EmployeeType.OfficeStaff.ToString())
                { _seriesInitals = AppConstants.e_PrimaryKeySeries.e11.ToString(); }
                else if (ddl_empType.Text == AppConstants.e_EmployeeType.Driver.ToString() || ddl_empType.Text == AppConstants.e_EmployeeType.Conductor.ToString())
                { _seriesInitals = AppConstants.e_PrimaryKeySeries.e12.ToString(); }
                else { _seriesInitals = AppConstants.e_PrimaryKeySeries.e13.ToString(); }

                emp.Emp_id = GenBPC.bpcGetNextID(AppDBContants.EmpDetails, AppDBContants.EmpDetailsPkey, AppDBContants.EmpDetailsPkeyLen, _seriesInitals);

            }
            else
            { emp.Emp_id = _empID; }

            emp.Firstname = txt_firstName.Text == String.Empty ? String.Empty : txt_firstName.Text;
            emp.Lastname = txt_lastName.Text == String.Empty ? String.Empty : txt_lastName.Text;
            emp.Petname = txt_petName.Text == String.Empty ? String.Empty : txt_petName.Text;
            emp.Dob = dtp_dob.Text == String.Empty ? String.Empty : dtp_dob.Text;
            emp.Gender = rdl_gender_f.Checked ? AppConstants.e_Gender.F.ToString() : AppConstants.e_Gender.M.ToString();
            emp.Emptype = ddl_empType.Text == String.Empty ? String.Empty : ddl_empType.Text;
            emp.Designation = ddl_designation.Text == String.Empty ? String.Empty : ddl_designation.Text;
            emp.Empaddress = txt_address.Text == String.Empty ? String.Empty : txt_address.Text;
            emp.Pincode = txt_pinCode.Text == String.Empty ? String.Empty : txt_pinCode.Text;
            emp.Homephone = txt_homePhone.Text == String.Empty ? String.Empty : txt_homePhone.Text;
            emp.Mobile = txt_mobileNo.Text == String.Empty ? String.Empty : txt_mobileNo.Text;
            emp.Emailid = txt_email.Text == String.Empty ? String.Empty : txt_email.Text;
            emp.Education = txt_education.Text == String.Empty ? String.Empty : txt_education.Text;
            emp.Aadhaarno = txt_aadhaar.Text == String.Empty ? String.Empty : txt_aadhaar.Text;
            emp.Addressproof = txt_addressProof.Text == String.Empty ? String.Empty : txt_addressProof.Text;
            emp.Dl_no = txt_dlno.Text == String.Empty ? String.Empty : txt_dlno.Text;
            emp.Dl_htmv = txt_dlno.Text != String.Empty && chk_dltype_htmv.Checked ? AppKeys.Yes.ToString() : AppKeys.No.ToString();
            emp.Dl_hmv = txt_dlno.Text != String.Empty && chk_dltype_hmv.Checked ? AppKeys.Yes.ToString() : AppKeys.No.ToString();
            emp.Dl_lmv = txt_dlno.Text != String.Empty && chk_dltype_lmv.Checked ? AppKeys.Yes.ToString() : AppKeys.No.ToString();
            emp.Dl_rto = txt_rto.Text == String.Empty || txt_dlno.Text == String.Empty ? String.Empty : txt_rto.Text;
            emp.Dl_expDt = dtp_dlValidity.Text == String.Empty || txt_dlno.Text == String.Empty ? String.Empty : dtp_dlValidity.Text;
            emp.Hiring_manager_id = ddl_hiring_manager.Text == String.Empty ? String.Empty : ddl_hiring_manager.Text;
            emp.Hiring_Date = dtp_hiringDate.Text == String.Empty ? String.Empty : dtp_hiringDate.Text;
            emp.Experience = txt_experience.Text == String.Empty ? String.Empty : txt_experience.Text;
            emp.Attributes = txt_attributes.Text == String.Empty ? String.Empty : txt_attributes.Text;
            emp.Otherdetails = txt_otherDetails.Text == String.Empty ? String.Empty : txt_otherDetails.Text;
            if (_operationType == e_frmOperationType.S || _operationType == e_frmOperationType.U)
            {
                emp.Emp_status = AppKeys.Active;
                emp.Allow_login = AppKeys.Yes;
            }
            else if (_operationType == e_frmOperationType.X)
            {
                emp.Emp_status = AppKeys.Deactive;
                emp.Allow_login = AppKeys.No;
            }


            //format emp properties
            this.formatEntity(emp);

        }

        private void SetEmployeeDocCollection(string _empID)
        {
            foreach (formDocs edoc in docCol)
            {
                if (_operationType == e_frmOperationType.X)
                {
                    edoc.ActiveInd = AppKeys.Deactive;
                    edoc.EmpId = _empID;
                    edoc.DocUpdateType = Utilities.e_DocAction.D;
                    edoc.HasChange = true;
                }

                else if (File.Exists(edoc.DocPath) && (_operationType == e_frmOperationType.S || _operationType == e_frmOperationType.U))
                {
                    FileInfo _f;
                    string _sourcePath = string.Empty;
                    string _fileName;
                    string _sp = Directory.GetParent(Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath)).FullName;
                    DirectoryInfo dir = new DirectoryInfo(AppConstants.setHomePath);
                    string _targetPath = dir.FullName + AppConstants.setImagesPath + AppConstants.empImgDocPath;
                    string _sourceFile;
                    string _destFile;

                    if (!System.IO.Directory.Exists(_targetPath))
                    {
                        System.IO.Directory.CreateDirectory(_targetPath);
                    }

                    _f = new FileInfo(edoc.DocPath);
                    edoc.EmpId = _empID;
                    edoc.DocName = AppConstants.fn_empDoc + _empID + "_" + edoc.DocType.ToString() + "_001";
                    edoc.DocExtn = _f.Extension;

                    //if (_operationType == e_frmOperationType.S || _operationType == e_frmOperationType.U)
                    //{ edoc.ActiveInd = AppKeys.Active; }                    
                    //else { /*Not a expected operation log into app/error logs #futureCode*/}
                    //if (_operationType == e_frmOperationType.S)
                    //{ edoc.DocUpdateType = Utilities.e_DocAction.U; }

                    // we are saving file in app images folder and also into database
                    //Copy to SQL
                    Image img = Image.FromFile(edoc.DocPath);
                    MemoryStream tmpStream = new MemoryStream();
                    img.Save(tmpStream, ImageFormat.Png); // change to other format
                    tmpStream.Seek(0, SeekOrigin.Begin);
                    byte[] imgBytes = new byte[tmpStream.Length]; //MAX_IMG_SIZE
                    tmpStream.Read(imgBytes, 0, imgBytes.Length);
                    edoc.Image = imgBytes;


                    //Copy to folder
                    _sourcePath = _f.DirectoryName;
                    _fileName = _f.Name;
                    _sourceFile = Path.Combine(_sourcePath, _fileName);
                    _destFile = Path.Combine(_targetPath, edoc.DocName + edoc.DocExtn);

                    // To copy a file to another location and Overwrite the destination file if it already exists.
                    if (!_sourceFile.Equals(_destFile))
                    { File.Copy(_sourceFile, _destFile, true); }
                    else if (_sourceFile.Equals(_destFile) && _operationType == e_frmOperationType.U)
                    { }//ignore as file update is existing /*log into app logs #futureCode*/
                    else
                    { /*log into app/error logs #futureCode*/
                        Exception Ex = new Exception("Operation Not allowed. Source: " + "SetEmployeeDocCollection");
                        ExceptionManagement.logUserException(Ex);
                    }

                }

                else
                {
                    Exception Ex = new Exception("Operation Not allowed. Source: " + "SetEmployeeDocCollection");
                    ExceptionManagement.logUserException(Ex);
                }/*log into app/error logs #futureCode*/
            }
            
        }

        private void formatEntity(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            string _s = string.Empty;
            // string _s1;
            //string _s2;

            foreach (PropertyInfo propertyInfo in emp.GetType().GetProperties())
            {
                string propertyName = propertyInfo.Name;
                _s = propertyInfo.GetValue(obj, null).ToString().Trim();

                object[] attribute = propertyInfo.GetCustomAttributes(typeof(IsCamelCase), true);
                // Just in case you have a property without this annotation
                if (attribute.Length > 0 && _s.Length > 0)
                {
                    IsCamelCase myAttribute = (IsCamelCase)attribute[0];
                    bool attributeValue = myAttribute.isCamelCase;

                    if (attributeValue)
                    {
                        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                        propertyInfo.SetValue(obj, textInfo.ToTitleCase(_s), null);
                    }
                    else
                    { //Not to format as CamelCase}

                    }
                }

            }
        }

        private void postSubmission(EmployeeCollection empCol, DocumentCollection docCol)
        {
            //Post Insertion Reset Controls
            if (empCol.RetIndicator == AppKeys.Success) { Utilities.CallResetControl(this.panel1); }

            if (empCol.FormMessages.Count > 0 || docCol.FormMessages.Count > 0)
            {
                TextBox txt_ucAlerts = Utilities.GetAlertTextBox();

                foreach (FormMessage msg in empCol.FormMessages)
                {
                    txt_ucAlerts.Text = msg.Message + "\r\n";
                }

                foreach (FormMessage msg in docCol.FormMessages)
                {
                    txt_ucAlerts.Text = txt_ucAlerts.Text + msg.Message + "\r\n";
                }
                txt_ucAlerts.Text = txt_ucAlerts.Text.Trim();

                var lines = txt_ucAlerts.Lines.Count();
                lines -= String.IsNullOrWhiteSpace(txt_ucAlerts.Lines.Last()) ? 1 : 0;

                if (lines > 1) { txt_ucAlerts.ScrollBars = ScrollBars.Both; }
                tableLayoutPanel5.Controls.Add(txt_ucAlerts, 0, 0);
            }

            Utilities.SetDocPanel(e_DocType.AAD, lbl_upload_uid, lbl_view_uid, pb_del_uid, lbl_fileName_uid, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.D, docCol);
            Utilities.SetDocPanel(e_DocType.APX, lbl_upload_ap, lbl_view_ap, pb_del_ap, lbl_fileName_ap, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.D, docCol);
            Utilities.SetDocPanel(e_DocType.EPH, lbl_upload_ppic, lbl_view_ppic, pb_del_ppic, lbl_fileName_ppic, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.D, docCol);
            Utilities.SetDocPanel(e_DocType.DLF, lbl_upload_dl, lbl_view_dl, pb_del_dl, lbl_fileName_dl, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.D, docCol);


            empCol = new EmployeeCollection();
            if (docCol != null)
            {
                docCol.Clear();
                docCol = null;
                docCol = new DocumentCollection();
            }


            //Leave Add/View/Edit Emp UserControl
            if (_operationType == e_frmOperationType.U || _operationType == e_frmOperationType.X)
            {
                uc_ViewEntity _ucViewEmp = new uc_ViewEntity(AppConstants.e_ViewEntityType.EMPLOYEE, _objfrmHome);
                _objfrmHome.LoadStripUC(_ucViewEmp, AppConstants.TabPageManage);
            }
        }

        private void ucResetControls()
        {

            foreach (Control ctrl in tableLayoutPanel4.Controls)
            {
                if (ctrl.Name == "txt_ucAlerts")
                {
                    tableLayoutPanel4.Controls.Remove(ctrl);
                }
            }
            Utilities.CallResetControl(this.panel1);

            if (docCol != null)
            {
                Utilities.SetDocPanel(e_DocType.AAD, lbl_upload_uid, lbl_view_uid, pb_del_uid, lbl_fileName_uid, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.D, docCol);
                Utilities.SetDocPanel(e_DocType.APX, lbl_upload_ap, lbl_view_ap, pb_del_ap, lbl_fileName_ap, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.D, docCol);
                Utilities.SetDocPanel(e_DocType.EPH, lbl_upload_ppic, lbl_view_ppic, pb_del_ppic, lbl_fileName_ppic, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.D, docCol);
                Utilities.SetDocPanel(e_DocType.DLF, lbl_upload_dl, lbl_view_dl, pb_del_dl, lbl_fileName_dl, pb_viewDoc, panel7_viewDoc, Utilities.e_DocAction.D, docCol);

                docCol.Clear();
                docCol = null;
                docCol = new DocumentCollection();
            }

            errorProvider1.Clear();
        }

        #endregion UserMethods
    }
}
