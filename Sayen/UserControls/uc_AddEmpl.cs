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
        EmployeeDocsCollection edocCol = null;
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
            LoadAddEmp();
        }

        public uc_AddEmpl(frm_Home objFrmHome, AppConstants.e_frmOperationType optyp)
        {
            InitializeComponent();

            LoadAddEmp();
            _objfrmHome = objFrmHome;
            _operationType = optyp;
            edocCol = new EmployeeDocsCollection();

            this._genBPC = null;
            if (_genBPC == null) { _genBPC = new genBPC(); }
        }
        #endregion

        #region Controls

        private void ddl_empType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_designation.Text = ddl_empType.Text;
        }



        private void btn_reset_Click(object sender, EventArgs e) { this.ucResetControls(); }

       

        private void chk_prefill_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_prefill.Checked) {PrefillControls();}
            else { this.ucResetControls(); }
           
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (this.Validate_AddEmpl())
            { this.Save_addEmpl(); }
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

        private void lbl_title_Click(object sender, EventArgs e)
        {
            if (AppGlobal.g_GEntity.UserEntity.Role_id.Equals(((int)AppConstants.e_AppUserRoles.Admin).ToString())
                || AppGlobal.g_GEntity.UserEntity.Role_id.Equals(((int)AppConstants.e_AppUserRoles.AppDeveloper).ToString()))
            {
                chk_escalatedEmp.Visible = true;
            }
        }

        private void chk_escalatedEmp_CheckedChanged(object sender, EventArgs e)
        {
            //Thread.Sleep(1000);
            //chk_escalatedEmp.Visible = false;
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
            //#futurecode
            //if (Utilities.UC_hasValidationErrors(this.Controls))
            //{ MessageBox.Show("FALSE"); }
            //else
            // if we get here the validation passed
            //this.close();
            //{ MessageBox.Show("TRUE"); }           


            return true;  //#futureCode
        }        

        /// <summary>
        /// Method to Insert Employee details into Database
        /// </summary>
        private void Save_addEmpl()
        {
            EmployeeCollection empCol = new EmployeeCollection();
                        
            empCol.Optype = AppConstants.e_frmOperationType.S;
            try
            {       
                //SetEmployeeCollections
                this.SetEmployeeCollection(emp);
                
                empCol.Add(emp);
                empCol.Messages = string.Empty;

                //call method chain to insert emp details
                _genBPC.bpcInsertEmployeeDetails(empCol);
                this.postSubmission(empCol);

                //call method chain to insert emp Documents details
                this.SetEmployeeDocCollection(emp.Emp_id);
                _genBPC.bpcInsertEmployeeDocs(edocCol);

            }
            catch (Exception Ex)
            {
                ExceptionManagement.logAppException(Ex);
            }
            finally
            {
                edocCol = new EmployeeDocsCollection();
            }
        }


        private void SetEmployeeCollection(EmployeeEntity emp)
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
            emp.Dl_htmv = chk_dltype_htmv.Checked ? AppKeys.Yes.ToString() : AppKeys.No.ToString();
            emp.Dl_hmv = chk_dltype_hmv.Checked ? AppKeys.Yes.ToString() : AppKeys.No.ToString();
            emp.Dl_lmv = chk_dltype_lmv.Checked ? AppKeys.Yes.ToString() : AppKeys.No.ToString();
            emp.Dl_rto = txt_rto.Text == String.Empty ? String.Empty : txt_rto.Text;
            emp.Hiring_manager_id = ddl_hiring_manager.Text == String.Empty ? String.Empty : ddl_hiring_manager.Text;
            emp.Experience = txt_experience.Text == String.Empty ? String.Empty : txt_experience.Text;
            emp.Attributes = txt_attributes.Text == String.Empty ? String.Empty : txt_attributes.Text;
            emp.Otherdetails = txt_otherDetails.Text == String.Empty ? String.Empty : txt_otherDetails.Text;
            emp.Emp_status = AppKeys.Active;
            emp.Allow_login = AppKeys.Yes;

            //format emp properties
            this.formatEntity(emp);

        }

        private void SetEmployeeDocCollection(string _empID)
        {
            FileInfo _f;
            string _sourcePath = string.Empty;
            string _fileName;
            string _sp = Directory.GetParent(Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath)).FullName;
            DirectoryInfo dir = new DirectoryInfo(AppConstants.setHomePath);
            string _targetPath = dir.FullName + AppConstants.setImagesPath+AppConstants.empImgDocPath;
            string _sourceFile;
            string _destFile;

            if (!System.IO.Directory.Exists(_targetPath))
            {
                System.IO.Directory.CreateDirectory(_targetPath);
            }

            foreach (EmployeeDocs edoc in edocCol)
            {
                _f = new FileInfo(edoc.DocPath);
                edoc.EmpId = _empID;
                edoc.DocName = AppConstants.fn_empDoc+ _empID+"_"+edoc.DocType.ToString()+"_001";
                edoc.DocExtn = _f.Extension;
                edoc.ActiveInd = AppKeys.Deactive;


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
                _destFile = Path.Combine(_targetPath, edoc.DocName+ edoc.DocExtn);

                // To copy a file to another location and Overwrite the destination file if it already exists.               
                File.Copy(_sourceFile, _destFile, true);

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

        private void postSubmission(EmployeeCollection empCol)
        {
            //Post Insertion Reset Controls
            if (empCol.RetIndicator == AppKeys.Success) { Utilities.CallResetControl(this.panel1); }

            if (empCol.Messages != string.Empty)
            {
                TextBox txt_ucAlerts = Utilities.GetAlertTextBox();
                txt_ucAlerts.Text = Text = empCol.Messages.Trim();

                var lines = txt_ucAlerts.Lines.Count();
                lines -= String.IsNullOrWhiteSpace(txt_ucAlerts.Lines.Last()) ? 1 : 0;

                if (lines > 1) { txt_ucAlerts.ScrollBars = ScrollBars.Both; }
                //panel6_ucAlert.Controls.Add(txt_ucAlerts);
                //panel6_ucAlert.AutoSize = true;
                tableLayoutPanel5.Controls.Add(txt_ucAlerts, 0, 0);

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
        }


        #endregion UserMethods

        private void lbl_upload_uid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeDocs edoc = new EmployeeDocs();
            edoc.DocType = e_DocType.AAD;
            edoc.DocPath = Utilities.SelectImagePath();
            edocCol.Add(edoc);            

        }
    }
}
