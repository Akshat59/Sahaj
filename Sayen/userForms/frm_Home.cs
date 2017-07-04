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

namespace Sayen
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();

            //ddl_environment.DataSource = new BindingSource(AppConstants.AppEnvironments, null);
            //ddl_environment.ValueMember = "Value";
            //ddl_environment.DisplayMember = "Key";

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
            if (tabCtrl_home.SelectedTab.Name.Equals("tabPage_welcome"))
            {
                this.LoadWelcome();
            }
            else if (tabCtrl_home.SelectedTab.Name.Equals("tabPage_search"))
            {
                this.LoadSearch();
            }
        }

        private void lbl_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();

        }


        private void frm_Home_Load(object sender, EventArgs e)
        {
            this.LoadWelcome();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            tabCtrl_home.TabPages["tabPage_welcome"].Controls.Add(ucWel);

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
            uc_AddEmpl obj = new uc_AddEmpl();
            this.LoadStripUC(obj, AppConstants.TabPageManage);
        }
        #endregion ManageEmployee


        #endregion ManageStrip

        #endregion Strips

        #region UserMethods

        
        void LoadStripUC(UserControl obj,string stripID)
        {            
            tabCtrl_home.TabPages[stripID].Controls.Add(obj);
        }

        #endregion UserMethods

        private void lbl_titleHome_Click(object sender, EventArgs e)
        {
            if (AppGlobal.CurrentUserRole == "Admin")
            {
                ddl_env.Visible = true;
                ddl_env.DataSource = new BindingSource(AppConstants.AppEnvironments, null);
                ddl_env.ValueMember = "Value";
                ddl_env.DisplayMember = "Key";

            }
        }

        private void ddl_env_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ddl_env_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            if (!ddl_env.Text.Equals(null)&&(ddl_env.Text == "DEV" || ddl_env.Text == "TEST"))
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
                lbl_environment.Visible = false;
                ddl_env.Visible = false;

            }

        }
    }
}
