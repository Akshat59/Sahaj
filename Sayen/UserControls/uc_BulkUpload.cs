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

namespace Sayen.UserControls
{
    public partial class uc_BulkUpload : UserControl
    {
        frm_Home _objfrmHome;
        string _activeStrip;
        AppConstants.e_BulkUploadType _bulkUploadType;
        bool _isPostback = false;

        public uc_BulkUpload()
        {
            InitializeComponent();
        }

        public uc_BulkUpload(frm_Home objFrmHome, AppConstants.e_BulkUploadType BulkUploadType,string ActiveStrip)
        {
            InitializeComponent();
            
            _objfrmHome = objFrmHome;
            _bulkUploadType = BulkUploadType;
            _activeStrip = ActiveStrip;

            LoadBulkUpload();
        }

        #region Controls

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //if (Utilities.UC_hasValidationErrors(this.Controls))
            //{ MessageBox.Show("FALSE"); }
            //else
            // if we get here the validation passed
            //this.close();

            { MessageBox.Show("test TRUE"); }

        }

        

        private void rdl_singleUpload_CheckedChanged(object sender, EventArgs e)
        {
            setMaintenanceMode();
        }

        private void rdl_bulkUpload_CheckedChanged(object sender, EventArgs e)
        {
            setMaintenanceMode();
        }

        
        #endregion Controls

        #region UserMethods


        private void LoadBulkUpload()
        {
            if (AppGlobal.CurrentAppEnv == AppConstants.d_AppEnvironments.FirstOrDefault(x => x.Key == AppConstants.e_AppEnvironment.DEV.ToString()).Key
                || AppGlobal.CurrentAppEnv == AppConstants.d_AppEnvironments.FirstOrDefault(x => x.Key == AppConstants.e_AppEnvironment.TEST.ToString()).Key)
            { }
            else { }


            //Set control on the basis of caller Type
            switch (_bulkUploadType)
            {
                case AppConstants.e_BulkUploadType.EMPLOYEE:
                    lbl_title.Text = AppConstants.uc_title_AddEmployee;
                    break;
                case AppConstants.e_BulkUploadType.VEHICLE:
                    lbl_title.Text = AppConstants.uc_title_AddVehicle;
                    break;
                case AppConstants.e_BulkUploadType.PERMIT:
                    lbl_title.Text = AppConstants.uc_title_AddPermit;
                    break;
                case AppConstants.e_BulkUploadType.INSURANCE:
                    lbl_title.Text = AppConstants.uc_title_AddInsurance;
                    break;
                case AppConstants.e_BulkUploadType.ROUTE:
                    lbl_title.Text = AppConstants.uc_title_AddRoute;
                    break;
                default:
                    lbl_title.Text = AppConstants.uc_title_defaultBulkUpload;
                    break;
            }          

            _isPostback = true;

            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.AutoSize = true;

        }       

       
        private void setMaintenanceMode()
        {
            if (rdl_singleUpload.Checked &&  _isPostback)
            {
                _isPostback = false;
                rdl_singleUpload.Enabled = false;
                uc_AddEmpl obj = new uc_AddEmpl(_objfrmHome,AppConstants.e_frmOperationType.S);
                
                _objfrmHome.LoadStripUC_frmUC(obj, AppConstants.TabPageManage, this, AppConstants.TabPageManage);
                this.Dispose();
                rdl_singleUpload.Enabled = true;

            }
            else if (rdl_bulkUpload.Checked)
            {
                //Do Nothing  #futureCode log it
            }
        }



        #endregion

        private void chk_agreement_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_agreement.Checked) { btn_submit.Enabled = true; }
            else { btn_submit.Enabled = false; }
        }
    }
}
