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
        }

        private void initializeDisplay()
        {
            string _userFullName = AppGlobal.g_GEntity.UserEntity.User_fname+" "+AppGlobal.g_GEntity.UserEntity.User_lname;
            if (_userFullName.Length > 0) { lbl_u_fullname.Text = _userFullName; lbl_u_fullname.Visible = true; }
            else { lbl_u_fullname.Text = ""; lbl_u_fullname.Visible = false;}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
