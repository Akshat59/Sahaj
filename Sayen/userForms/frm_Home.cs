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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void tabPage_welcome_Click(object sender, EventArgs e)
        {
            uc_welcome ucWel = new uc_welcome();
            tabCtrl_home.TabPages["tabPage_welcome"].Controls.Add(ucWel);
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            uc_welcome ucWel = new uc_welcome();
            tabCtrl_home.TabPages["tabPage_welcome"].Controls.Add(ucWel);
        }
        
        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string _message = AppGlobal.appErrorLog + "\r\n" + AppGlobal.sqlErrorLog;
            if (_message.Trim().Length < 1) { _message = "No Logs to Show"; }

            MessageBox.Show(_message.Trim(), "App Logs");

        }
        #endregion Controls
    }
}
