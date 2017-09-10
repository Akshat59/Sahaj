using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sayen.UserControls;
using m1.Shared;
using Sayen.userForms;
using Sahaj.UserControls;

namespace Sayen
{
    public partial class frm_Home : Form
    {
        #region Initialization
        public frm_Home()
        {
            InitializeComponent();

        }

        uc_welcome ucWel;
        uc_search ucSrch;
        uc_AddEmpl _ucAddEmp;
        uc_ViewEntity _ucViewEmp;
        #endregion Initialization



        #region Controls
        private void lbl_logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult res = Utilities.GetYesNoConfirmation(UserMessages.Ques_AreYouSure,UserMessages.ConfirmAppLogOut);
            if (res.Equals(DialogResult.Yes))
            {
                this.Hide();
                var objFrmLogin = new frm_login();
                objFrmLogin.Show();
                objFrmLogin.Closed += (s, args) => this.Close();
                objFrmLogin.Show();
            }
        }


        private void DisposeTabPageObjects()
        {            
            if(ucWel != null){ucWel.Dispose(); ucWel = null; }
            if (ucSrch != null) { ucSrch.Dispose(); ucSrch = null; }
            if (_ucAddEmp != null) { _ucAddEmp.Dispose(); _ucAddEmp = null; }
            if (_ucViewEmp != null) { _ucViewEmp.Dispose(); _ucViewEmp = null; }            
        }

        private void tabCtrl_home_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisposeTabPageObjects();


            if (tabCtrl_home.SelectedTab.Name.Equals(AppConstants.TabPageWelcome))
            {
                this.LoadWelcome();
            }
            else if (tabCtrl_home.SelectedTab.Name.Equals(AppConstants.TabPageManage))
            {
                //this.LoadWelcome();
            }
            else if (tabCtrl_home.SelectedTab.Name.Equals(AppConstants.TabPageSearch))
            {
                this.LoadSearch();
            }
            else
            {
                //Exception Ex = new Exception("Operation Not allowed; Tab is not Designed; Source: " + "tabCtrl_home_SelectedIndexChanged");
                //ExceptionManagement.logUserException(Ex);
            }
        }

        private void lbl_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult res = Utilities.GetYesNoConfirmation( UserMessages.Ques_AreYouSure, UserMessages.ConfirmAppExit);
            if (res.Equals(DialogResult.Yes)){Application.Exit();}
        }


        private void frm_Home_Load(object sender, EventArgs e)
        {
            
            LoadFormHome();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_titleHome_Click(object sender, EventArgs e)
        {
            if (AppGlobal.CurrentUserRole == "Admin")
            {
                ddl_env.Visible = true;
                ddl_env.DataSource = new BindingSource(AppConstants.d_AppEnvironments, null);
                ddl_env.ValueMember = "Value";
                ddl_env.DisplayMember = "Key";

            }
        }

        private void ddl_env_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ddl_env_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (!ddl_env.Text.Equals(null) && (ddl_env.Text == "DEV" || ddl_env.Text == "TEST"))
            {
                AppGlobal.CurrentAppEnv = ddl_env.Text;
                lbl_environment.Text = ddl_env.Text;
                lbl_environment.Visible = true;
                ddl_env.Visible = false;
            }
            else if (!ddl_env.Text.Equals(null) && ddl_env.Text == "PROD")
            {
                AppGlobal.CurrentAppEnv = ddl_env.Text;
                lbl_environment.Text = ddl_env.Text;
                lbl_environment.Visible = true;
                ddl_env.Visible = false;
            }
            else //if (AppGlobal.CurrentAppEnv == "PROD")
            {
                AppGlobal.CurrentAppEnv = ddl_env.Text;
                lbl_environment.Text = string.Empty;
                //lbl_environment.Visible = false;
                ddl_env.Visible = false;

            }

        }

        #endregion Controls

        #region Strips

        #region HomeStrip

        private void tabCtrl_home_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                //e.Handled = true;
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _message = AppGlobal.appErrorLog + "\r\n" + AppGlobal.sqlErrorLog;
            if (_message.Trim().Length < 1) { _message = UserMessages.NoLogsMsg; }

            MessageBox.Show(_message.Trim(), UserMessages.ShowLogTitle);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppGlobal.appErrorLog = string.Empty;
            AppGlobal.sqlErrorLog = string.Empty;
        }
        #endregion HomeStrip


        #region WelcomeStrip

        public void LoadWelcome()
        {
            ucWel = new uc_welcome();
            ucWel.AutoSize = true;
            ucWel.Dock = DockStyle.Fill;
            tabCtrl_home.TabPages[AppConstants.TabPageWelcome].Controls.Add(ucWel);
        }


        #endregion WelcomeStrip

        #region SearchStrip
       
        public void LoadSearch()
        {
            ucSrch = new uc_search();
            tabCtrl_home.TabPages[AppConstants.TabPageSearch].Controls.Add(ucSrch);

        }

        #endregion SearchStrip

        #region ManageStrip

        #region ManageEmployee
        private void tsmi2_emp_addNew_Click(object sender, EventArgs e)
        {
            _ucAddEmp = new uc_AddEmpl(AppConstants.e_frmOperationType.S, this);          

            this.LoadStripUC(_ucAddEmp, AppConstants.TabPageManage);
        }
        private void tsmi2_emp_modify_Click(object sender, EventArgs e)
        {
            _ucViewEmp = new uc_ViewEntity(AppConstants.e_ViewEntityType.EMPLOYEE,this);

            this.LoadStripUC(_ucViewEmp, AppConstants.TabPageManage);
        }
        #endregion ManageEmployee


        #endregion ManageStrip

        #endregion Strips

        #region UserMethods


        public void LoadStripUC(UserControl obj,string stripID)
        {

            foreach (Control ctrl in tabCtrl_home.TabPages[stripID].Controls)
            {
                if(ctrl.Name!= "menuStrip_Manage")
                tabCtrl_home.TabPages[stripID].Controls.Remove(ctrl);
            }
                     
            tabCtrl_home.TabPages[stripID].Controls.Add(obj);
        }

        public void LoadStripUC_frmUC(UserControl objAdd, string stripID_add, UserControl objRmv, string stripID_rmv)
        {
            tabCtrl_home.TabPages[stripID_rmv].Controls.Remove(objRmv);
            //bool _b = this.Controls.ContainsKey("uc_AddEmpl");
            //bool _z = tabCtrl_home.TabPages[stripID_rmv].Controls.ContainsKey("uc_AddEmpl");
            objRmv.Dispose();
            objRmv = null;
            tabCtrl_home.TabPages[stripID_add].Controls.Add(objAdd);
        }


        private void LoadFormHome()
        {
            this.ActiveControl = this.tabCtrl_home;
            tabCtrl_home.AutoSize = true;
            tabCtrl_home.TabPages[0].AutoSize = true;
            
            if (AppGlobal.CurrentAppEnv == AppConstants.d_AppEnvironments.FirstOrDefault(x => x.Key == AppConstants.e_AppEnvironment.DEV.ToString()).Key 
                || AppGlobal.CurrentAppEnv == AppConstants.d_AppEnvironments.FirstOrDefault(x => x.Key == AppConstants.e_AppEnvironment.TEST.ToString()).Key)
            {
                lbl_environment.Text = AppGlobal.CurrentAppEnv;
                lbl_environment.Visible = true;
            }
            this.LoadWelcome();
        }


        #endregion UserMethods

      
    }
}
