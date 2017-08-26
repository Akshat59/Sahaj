using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static m1.Shared.AppConstants;
using m1.BPC;
using m1.Shared;
using m1.Shared.Entities;
using Sayen.UserControls;
using Sayen;

namespace Sahaj.UserControls
{
    public partial class uc_ViewEntity : UserControl
    {
        frm_Home _objfrmHome;
        private genBPC _genBPC;
        e_ViewEntityType _op_Type;
        SearchEntity se;
        DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();

        public genBPC GenBPC
        {
            get { if (_genBPC == null) { _genBPC = new genBPC(); } return _genBPC; }
            set { _genBPC = new genBPC(); }

        }
        public uc_ViewEntity()
        {
            InitializeComponent();
            dataGridView1.BackgroundColor = Color.AliceBlue;
           
        }
        public uc_ViewEntity(e_ViewEntityType op_Type, frm_Home objFrmHome)
        {
            InitializeComponent();
            _objfrmHome = objFrmHome;

            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.AutoSize = true;
            dataGridView1.BackgroundColor = Color.AliceBlue;
            _op_Type = op_Type;

            switch (op_Type)
            {
                case e_ViewEntityType.EMPLOYEE:
                    lbl_title.Text = "View / Edit" + " " + "Employee";
                    lbl_entID.Text = "Employee ID";                    
                    break;
            }


        }


        private void uc_ViewEntity_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            panel2.Visible = false;
            dataGridView1.DataSource = null;
            //dataGridView1.Refresh();


            if (txt_entID.TextLength <= 0 && txt_name.TextLength <= 0)
            {
                errorProvider1.SetError(txt_entID, "Required");
                errorProvider1.SetError(txt_name, "Required");
                return;
            }

            se = new SearchEntity();
            se.SearchType = _op_Type;
            if (txt_entID.TextLength > 0)
            {
                se.EntID = txt_entID.Text;
            }
            if (txt_name.TextLength > 0)
            {
                se.Name = txt_name.Text;                
            }

            GenBPC.bpcSearchEntity(se);

            if (se._retDT.Rows.Count <= 0)
            {
                panel2.Visible = true;
            }
            else
            {
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                if (!dataGridView1.Columns.Contains(Editlink))
                {
                    Editlink.UseColumnTextForLinkValue = true;
                    Editlink.HeaderText = "";
                    Editlink.DataPropertyName = "lnkColumn";
                    Editlink.LinkBehavior = LinkBehavior.SystemDefault;
                    Editlink.Text = "View";
                    dataGridView1.Columns.Add(Editlink);
                }
                
                dataGridView1.DataSource = se._retDT;
                dataGridView1.Visible = true;
            }
        }

        private void btn_search_Validating(object sender, CancelEventArgs e)
        {
            if (txt_entID.TextLength > 0 || txt_name.TextLength > 0)
            {
                errorProvider1.SetError(txt_entID, "");
                errorProvider1.SetError(txt_name, "");
            }           
            else
            {
                Utilities.DontAllow_Empty(txt_entID, errorProvider1, e);
                Utilities.DontAllow_Empty(txt_name, errorProvider1, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                switch (_op_Type)
                {
                    case e_ViewEntityType.EMPLOYEE:
                        string _empID = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value);
                        uc_AddEmpl _ucAddEmp = new uc_AddEmpl(AppConstants.e_frmOperationType.V, _objfrmHome, _empID);
                        _objfrmHome.LoadStripUC_frmUC(_ucAddEmp, AppConstants.TabPageManage, this, AppConstants.TabPageManage);
                        break;

                }                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
