namespace Sahaj.UserControls
{
    partial class uc_ErrorLogs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_view = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_noDataMsg = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_row1 = new System.Windows.Forms.Panel();
            this.panel_row2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_row1.SuspendLayout();
            this.panel_row2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_title.Location = new System.Drawing.Point(243, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(205, 36);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "View Error Logs";
            this.lbl_title.DoubleClick += new System.EventHandler(this.lbl_title_DoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dateTimePicker1.Location = new System.Drawing.Point(537, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.Lavender;
            this.btn_view.Location = new System.Drawing.Point(752, 64);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(23, 23);
            this.btn_view.TabIndex = 6;
            this.btn_view.Text = ">";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(840, 402);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.Visible = false;
            // 
            // lbl_noDataMsg
            // 
            this.lbl_noDataMsg.AutoSize = true;
            this.lbl_noDataMsg.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noDataMsg.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_noDataMsg.Location = new System.Drawing.Point(277, 5);
            this.lbl_noDataMsg.Name = "lbl_noDataMsg";
            this.lbl_noDataMsg.Size = new System.Drawing.Size(191, 29);
            this.lbl_noDataMsg.TabIndex = 2;
            this.lbl_noDataMsg.Text = "No Records Found";
            this.lbl_noDataMsg.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel_row1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_row2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 416F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 550);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel_row1
            // 
            this.panel_row1.Controls.Add(this.lbl_title);
            this.panel_row1.Controls.Add(this.dateTimePicker1);
            this.panel_row1.Controls.Add(this.btn_view);
            this.panel_row1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_row1.Location = new System.Drawing.Point(3, 3);
            this.panel_row1.Name = "panel_row1";
            this.panel_row1.Size = new System.Drawing.Size(843, 100);
            this.panel_row1.TabIndex = 0;
            // 
            // panel_row2
            // 
            this.panel_row2.Controls.Add(this.lbl_noDataMsg);
            this.panel_row2.Controls.Add(this.dataGridView2);
            this.panel_row2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_row2.Location = new System.Drawing.Point(3, 109);
            this.panel_row2.Name = "panel_row2";
            this.panel_row2.Size = new System.Drawing.Size(843, 410);
            this.panel_row2.TabIndex = 8;
            // 
            // uc_ErrorLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uc_ErrorLogs";
            this.Size = new System.Drawing.Size(855, 553);
            this.Load += new System.EventHandler(this.uc_ErrorLogs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_row1.ResumeLayout(false);
            this.panel_row1.PerformLayout();
            this.panel_row2.ResumeLayout(false);
            this.panel_row2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_noDataMsg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_row1;
        private System.Windows.Forms.Panel panel_row2;
    }
}
