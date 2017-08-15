using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using m1.BPC;
using m1.Shared;

namespace Sayen.UserControls
{
    public partial class uc_welcome : UserControl
    {
        public uc_welcome()
        {
            InitializeComponent();
        }

        genBPC objbpc = new genBPC();

        private void uc_welcome_Load(object sender, EventArgs e)
        {
            initializeDisplay();

            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.AutoSize = true;


            timer1.Enabled = true;
            timer1.Interval = 1000;
            lbl_currentTime.Text = string.Empty;
            lbl_currentTime.Visible = true;
        }

        private void initializeDisplay()
        {
            if (AppGlobal.g_GEntity.UserEntity != null)
            {
                string _userFullName = AppGlobal.g_GEntity.UserEntity.User_fname + " " + AppGlobal.g_GEntity.UserEntity.User_lname;
                if (_userFullName.Length > 0) { lbl_u_fullname.Text = _userFullName; lbl_u_fullname.Visible = true; }
                else { lbl_u_fullname.Text = ""; lbl_u_fullname.Visible = false; }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_currentTime.Text = DateTime.Now.ToString("dddd, dd-MM-yyyy hh:mm:ss tt");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
