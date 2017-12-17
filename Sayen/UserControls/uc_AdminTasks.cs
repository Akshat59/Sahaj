using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using m1.Shared.Entities;
using m1.BPC;
using m1.Shared.Configs;
using m1.Shared;

namespace Sahaj.UserControls
{
    public partial class uc_AdminTasks : UserControl
    {
        private genBPC _genBPC;
        public genBPC GenBPC
        {
            get { if (_genBPC == null) { _genBPC = new genBPC(); } return _genBPC; }
            set { _genBPC = new genBPC(); }

        }
        public uc_AdminTasks()
        {
            InitializeComponent();
            lbl_retMsg.Text = string.Empty;
        }

        private void uc_AppSettings_Load(object sender, EventArgs e)
        {            
            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;
            this.Width = this.Parent.Width;
            //panel1.AutoScroll = true;
            //panel1.Dock = DockStyle.Fill;
            //panel1.AutoSize = true;
            //dataGridView1.BackgroundColor = Color.AliceBlue; 

            LoadTask1();
        }        

        #region Task1 - Execute SQL Query        
        bool isValidated = false;

        private void LoadTask1()
        {
            List<string> tblnames = new List<string>();           

            string msg = string.Empty;
            DataTable dt = new DataTable();
            string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME like 'd1_%'";

            GenBPC.bpcParseExecuteQuery(query, 1, out msg, out dt);
            tblnames = (from row in dt.AsEnumerable() select Convert.ToString(row["TABLE_NAME"])).ToList();
            tblnames.Insert(0,"--Select One--");
            ddl_tableNames.DataSource = tblnames;
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {

            
            lbl_retMsg.Text = string.Empty;
            if (txt_queryBox.TextLength > 0)
            {
                string valText = "set PARSEONLY on ";
                DataTable retDT  = null;
                string retMsg = string.Empty;

                GenBPC.bpcParseExecuteQuery(string.Format("{0}{1};", valText, txt_queryBox.Text), 0,out retMsg,out retDT);

               
                if (retMsg.Length > 90) { lbl_retMsg.Text = retMsg.Substring(0, 90); } else { lbl_retMsg.Text = retMsg;}
                isValidated = retMsg == String.Empty ? true : false;               
            }

            if(isValidated)
            {
                btn_execute.Enabled = true;
                lbl_retMsg.Text = "Query Validated Successfully, Click Execute";
            }
            else
            {
                btn_execute.Enabled = false;

            }
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            DataTable retDT = new DataTable();
            string retMsg = string.Empty;
            GenBPC.bpcParseExecuteQuery(string.Format("{0};", txt_queryBox.Text), 1,out retMsg, out retDT);
            isValidated = retMsg == String.Empty ? true : false;
            if (isValidated)
            {
                lbl_retMsg.Text = "Query Executed Successfully";
                if (retDT!=null && retDT.Rows.Count > 0) { dataGridView1.DataSource = retDT; }
            }
            else
            {
                lbl_retMsg.Text = retMsg;
            }
            
        }

        private void txt_queryBox_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null) { dataGridView1.DataSource = null; }
            if (lbl_retMsg.Text != "Click Validate to validate query") { lbl_retMsg.Text = "Click Validate to validate query"; }
            if (btn_execute.Enabled) { btn_execute.Enabled = false; };
        }

        private void ddl_tableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddl_tableNames.SelectedItem.ToString() != "--Select One--")
            {
                string msg = string.Empty;
                DataTable dt = new DataTable();
                string query = string.Format("SELECT * FROM {0}", ddl_tableNames.SelectedItem.ToString());

                GenBPC.bpcParseExecuteQuery(query, 1, out msg, out dt);                
                dataGridView1.DataSource = dt;
            }
        }

        #endregion Task1 - Execute SQL Query


    }
}
