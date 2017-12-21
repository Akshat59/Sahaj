using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using m1.Shared;
using Sahaj.UserControls;
using System.Resources;
using m1.Sahaj.Properties;

namespace Sayen.userForms
{
    public partial class frm_Backdoor : Form
    {
        frm_login _objFormLogin;

        public frm_Backdoor()
        {
            InitializeComponent();
            
        }

        #region Controls
        public frm_Backdoor(frm_login obj)
        {
            InitializeComponent();
            _objFormLogin = obj;
            _objFormLogin.Enabled = false;
            this.LoadFormBackdoor();
        }


        private void txt_passkey_TextChanged(object sender, EventArgs e)
        {
            if (txt_passkey.TextLength == 4 && txt_passkey.Text=="1234")//AppGlobal.super_admin_PassKey.ToString())
            { 
                this.Size=new Size(192,104);
                panel1.Visible = true; panel1.Enabled = true; txt_passkey.Enabled = false;
            }
        }

        private void lbl_viewLogs_Click(object sender, EventArgs e)
        {
            string _message = AppGlobal.appErrorLog + "\r\n" + AppGlobal.sqlErrorLog;
            if (_message.Trim().Length < 1) { _message = UserMessages.NoLogsMsg; }

            MessageBox.Show(_message.Trim(), UserMessages.ShowLogTitle);
        }

        private void lbl_goBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _objFormLogin.Enabled = true;
            _objFormLogin.Activate();
        }

        private void frm_Backdoor_FormClosing(object sender, FormClosingEventArgs e)
        {
            _objFormLogin.Enabled = true;
            _objFormLogin.Activate();
        }

        #endregion Controls

        #region UserMethods
        private void LoadFormBackdoor()
        {
            this.Size = new Size(192, 58);
            this.ActiveControl = lbl_viewLogs;
            ddl_Environment.DataSource = new BindingSource(AppConstants.d_AppEnvironments,null);
            ddl_Environment.ValueMember = "Value";
            ddl_Environment.DisplayMember = "Key";
            AppGlobal.CurrentAppEnv = ddl_Environment.Text;

        }
        #endregion UserMethods

        private void ddl_Environment_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppGlobal.CurrentAppEnv = ddl_Environment.Text;
        }

        private void pb_settingsAdmin_Click(object sender, EventArgs e)
        {
            if(panel2.Controls.ContainsKey("uc_AppSettings"))
            {
                panel2.Controls.RemoveByKey("uc_AppSettings");
            }

            uc_AppSettings _uc_AppSettings = new uc_AppSettings();
            _uc_AppSettings.AutoSize = true;
            _uc_AppSettings.BackColor = Color.Transparent;
            ResourceManager rm = Resources.ResourceManager;
            Bitmap img = (Bitmap)rm.GetObject("img_matrixCode");
            _uc_AppSettings.BackgroundImage = img;

            Control control;
            Utilities.GetControlByNameFromControlList(_uc_AppSettings.Controls, "tableLayoutPanel1",out control);
            if (!control.Equals(null))
            {
                var ww = (TableLayoutPanel)control;
                ww.AutoSize = true;
                ww.BackColor = Color.AliceBlue;
            }
            //Utilities.GetControlByNameFromControlList(_uc_AppSettings.Controls, "panel_row2", out control);
            //if (control!=null)
            //{
            //    var ww = (Panel)control;
            //    ww.BackColor = Color.AliceBlue;
            //}
            //Utilities.GetControlByNameFromControlList(_uc_AppSettings.Controls, "lbl_title", out control);
            //if (control != null)
            //{
            //    var ww = (Label)control;
            //    ww.BackColor = Color.White;
            //    ww.BorderStyle = BorderStyle.Fixed3D;
            //}          

            this.AutoSize = true;
            this.Width = 1200;
            panel2.Width = 1150;
            panel2.AutoSize = true;
            panel2.Visible = true;
            panel2.BackgroundImage = img;
            panel2.Controls.Add(_uc_AppSettings);
        }
    }
}
