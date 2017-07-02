using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sayen
{
    public partial class frm_Loading : Form
    {
        public frm_Loading()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Loading_Activated(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
            this.Hide();
            var objFrmLogin = new frm_login();
            objFrmLogin.Show();
            objFrmLogin.Closed += (s, args) => this.Close();
            objFrmLogin.Show();
        }


        

       

    }
}
