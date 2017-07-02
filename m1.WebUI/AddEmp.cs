using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace m1.WebUI
{
    public partial class AddEmp : UserControl
    {
        public AddEmp()
        {
            InitializeComponent();
            panel1.Visible = false;
        }
        
        public AddEmp(string callingMethod)
        {
            InitializeComponent();
            panel1.Visible = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
