using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sayen.UserControls
{
    public partial class uc_search : UserControl
    {
        public uc_search()
        {
            InitializeComponent();
        }

        private void uc_search_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.AutoSize = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            { MessageBox.Show("Component not Designed yet"); }
        }

        private void lbl_advSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            { MessageBox.Show("Component not Designed yet"); }
        }
    }
}
