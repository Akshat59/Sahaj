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

namespace Sahaj.UserControls
{
    public partial class uc_ViewEntity : UserControl
    {
        private genBPC _genBPC;
        e_ViewEntityType _op_Type;
        SearchEntity se;

        public genBPC GenBPC
        {
            get { if (_genBPC == null) { _genBPC = new genBPC(); } return _genBPC; }
            set { _genBPC = new genBPC(); }

        }
        public uc_ViewEntity()
        {
            InitializeComponent();
        }
        public uc_ViewEntity(e_ViewEntityType op_Type)
        {
            InitializeComponent();

            this.AutoSize = true;
            this.Dock = DockStyle.Fill;
            this.AutoScroll = true;
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.AutoSize = true;

            switch (op_Type)
            {
                case e_ViewEntityType.EMPLOYEE:
                    lbl_title.Text = "View / Edit" + " " + "Employee";
                    lbl_entID.Text = "Employee ID";
                    _op_Type = op_Type;
                    break;
            }


        }


        private void uc_ViewEntity_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            

            if (txt_entID.TextLength <= 0 && txt_name.TextLength <= 0)
            {
                errorProvider1.SetError(txt_entID, "Required");
                errorProvider1.SetError(txt_name, "Required");
                return;
            }

            se = new SearchEntity();
            se.SearchType = _op_Type.ToString();
            if (txt_entID.TextLength > 0)
            {
                se.EntID = txt_entID.Text;
            }
            if (txt_name.TextLength > 0)
            {
                se.Name = txt_name.Text;                
            }

            GenBPC.bpcSearchEntity(se);

            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.DataSource = se._retDT;
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

        }
    }
}
