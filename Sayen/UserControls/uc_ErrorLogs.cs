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

namespace Sahaj.UserControls
{
    public partial class uc_ErrorLogs : UserControl
    {
        private genBPC _genBPC;
        public genBPC GenBPC
        {
            get { if (_genBPC == null) { _genBPC = new genBPC(); } return _genBPC; }
            set { _genBPC = new genBPC(); }

        }
        public uc_ErrorLogs()
        {
            InitializeComponent();
        }

        private void lbl_title_DoubleClick(object sender, EventArgs e)
        {
            RetrieveLogs();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            RetrieveLogs();
        }



        private void uc_ErrorLogs_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;            
            this.Width = this.Parent.Width;
            //panel1.AutoScroll = true;
            //panel1.Dock = DockStyle.Fill;
            //panel1.AutoSize = true;
            //dataGridView1.BackgroundColor = Color.AliceBlue;
        }

        private void RetrieveLogs()
        {
            string refDate = dateTimePicker1.Value.ToShortDateString();
           
            dataGridView2.DataSource = null;
            lbl_noDataMsg.Visible = false;
            SearchEntity se = new SearchEntity();
            se.SearchField1 = refDate;

            GenBPC.bpcRetrieveErrorLogs(se);
            dataGridView2.DataSource = se._retDT;
            
            if (se.RetCount > 0) { formatDataGridView(); } else {  ShowNoDataLabel(); }
        }

        private void ShowNoDataLabel()
        {
            dataGridView2.Visible = false;
            lbl_noDataMsg.Visible = true; 
        }

        private void formatDataGridView()
        {
            if (dataGridView2.Columns.Contains("error_date")){ dataGridView2.Columns["error_date"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss:fff"; }
            if (dataGridView2.Columns.Contains("create_date")) { dataGridView2.Columns["error_date"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss:fff"; }


            var height = 40;
            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                height += dr.Height;
            }

            dataGridView2.Height = height<270?height:270;
            dataGridView2.Visible = true;
        }

        private void panel_row2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
