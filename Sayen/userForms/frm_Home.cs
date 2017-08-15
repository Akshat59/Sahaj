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
        public frm_Home()
        {
            InitializeComponent();          

        }


        #region Controls
        private void lbl_logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            var objFrmLogin = new frm_login();
            objFrmLogin.Show();
            objFrmLogin.Closed += (s, args) => this.Close();
            objFrmLogin.Show();
        }


        private void tabCtrl_home_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrl_home.SelectedTab.Name.Equals(AppConstants.TabPageManage))
            {
                this.LoadWelcome();
            }
            else if (tabCtrl_home.SelectedTab.Name.Equals(AppConstants.TabPageSearch))
            {
                this.LoadSearch();
            }
            else
            {
                //Show - Not Implemented
            }
        }

        private void lbl_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();

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

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _message = AppGlobal.appErrorLog + "\r\n" + AppGlobal.sqlErrorLog;
            if (_message.Trim().Length < 1) { _message = UserMessages.NoLogsMsg; }

            MessageBox.Show(_message.Trim(), UserMessages.ShowLogTitle);

        }
        #endregion HomeStrip


        #region WelcomeStrip

        private void tabPage_welcome_Click(object sender, EventArgs e)
        {
            this.LoadWelcome();
            
        }


        public void LoadWelcome()
        {
            uc_welcome ucWel = new uc_welcome();
            ucWel.AutoSize = true;
            ucWel.Dock = DockStyle.Fill;
            tabCtrl_home.TabPages[AppConstants.TabPageWelcome].Controls.Add(ucWel);
        }


        #endregion WelcomeStrip

        #region SearchStrip

        private void tabPage_search_Click(object sender, EventArgs e)
        {
            this.LoadSearch();
        }

        public void LoadSearch()
        {
            uc_search ucSrch = new uc_search();
            tabCtrl_home.TabPages[AppConstants.TabPageSearch].Controls.Add(ucSrch);

        }

        #endregion SearchStrip

        #region ManageStrip

        #region ManageEmployee
        private void tsmi2_emp_addNew_Click(object sender, EventArgs e)
        {
            uc_AddEmpl _ucAddEmp = new uc_AddEmpl(AppConstants.e_frmOperationType.S, this);          

            this.LoadStripUC(_ucAddEmp, AppConstants.TabPageManage);
        }
        private void tsmi2_emp_modify_Click(object sender, EventArgs e)
        {
            uc_ViewEntity _ucViewEmp = new uc_ViewEntity(AppConstants.e_ViewEntityType.EMPLOYEE,this);

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
            bool _b = this.Controls.ContainsKey("uc_AddEmpl");
            bool _z = tabCtrl_home.TabPages[stripID_rmv].Controls.ContainsKey("uc_AddEmpl");
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

        private void tabCtrl_home_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.Handled = true;
            }
        }


    }
}
