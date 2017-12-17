using m1.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace m1.Sahaj.userForms
{
    public partial class frm_About : Form
    {
        public frm_About()
        {
            InitializeComponent();
            loadForm();
        }

        private void loadForm()
        {
            Timer t1 = new Timer();
            string msg = "Sahaj is inhouse app owned and managed by\r\nNew Prem Bus Service Nagrota Bagwan HP\r\n\r\nContact admin for any issues\r\n\r\n";
            

            //Retrieve registery variable
            string s_build = Utilities.ReadRegSubKeyValue(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\New Prem\Sahaj", "Build");
            string s_version = Utilities.ReadRegSubKeyValue(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\New Prem\Sahaj", "Version");
            string s_lastUpdated = Utilities.ReadRegSubKeyValue(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\New Prem\Sahaj", "UpdateDate");

            label1.Text = string.Format("{0}\r\nBuild: {1}\r\nVersion: {2}\r\nLast Build: {3}\r\n\r\n\r\n\r\nSahaj ©NewPrem 2018", msg,s_build,s_version,s_lastUpdated);
        }
    }
}
