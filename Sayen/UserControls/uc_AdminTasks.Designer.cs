namespace Sahaj.UserControls
{
    partial class uc_AdminTasks
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_row1 = new System.Windows.Forms.Panel();
            this.panel_row2 = new System.Windows.Forms.Panel();
            this.ddl_tableNames = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_retMsg = new System.Windows.Forms.Label();
            this.lbl_task1 = new System.Windows.Forms.Label();
            this.btn_validate = new System.Windows.Forms.Button();
            this.txt_queryBox = new System.Windows.Forms.TextBox();
            this.btn_execute = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_row1.SuspendLayout();
            this.panel_row2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_title.Location = new System.Drawing.Point(304, 5);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(165, 36);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Admin Tasks";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel_row1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_row2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 660);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel_row1
            // 
            this.panel_row1.Controls.Add(this.lbl_title);
            this.panel_row1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_row1.Location = new System.Drawing.Point(3, 3);
            this.panel_row1.Name = "panel_row1";
            this.panel_row1.Size = new System.Drawing.Size(843, 54);
            this.panel_row1.TabIndex = 0;
            // 
            // panel_row2
            // 
            this.panel_row2.AutoSize = true;
            this.panel_row2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_row2.Controls.Add(this.ddl_tableNames);
            this.panel_row2.Controls.Add(this.dataGridView1);
            this.panel_row2.Controls.Add(this.lbl_retMsg);
            this.panel_row2.Controls.Add(this.lbl_task1);
            this.panel_row2.Controls.Add(this.btn_validate);
            this.panel_row2.Controls.Add(this.txt_queryBox);
            this.panel_row2.Controls.Add(this.btn_execute);
            this.panel_row2.Location = new System.Drawing.Point(3, 63);
            this.panel_row2.Name = "panel_row2";
            this.panel_row2.Size = new System.Drawing.Size(834, 248);
            this.panel_row2.TabIndex = 8;
            // 
            // ddl_tableNames
            // 
            this.ddl_tableNames.FormattingEnabled = true;
            this.ddl_tableNames.Location = new System.Drawing.Point(584, 8);
            this.ddl_tableNames.Name = "ddl_tableNames";
            this.ddl_tableNames.Size = new System.Drawing.Size(245, 21);
            this.ddl_tableNames.TabIndex = 12;
            this.ddl_tableNames.SelectedIndexChanged += new System.EventHandler(this.ddl_tableNames_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(816, 147);
            this.dataGridView1.TabIndex = 11;
            // 
            // lbl_retMsg
            // 
            this.lbl_retMsg.AutoSize = true;
            this.lbl_retMsg.ForeColor = System.Drawing.Color.Red;
            this.lbl_retMsg.Location = new System.Drawing.Point(307, 20);
            this.lbl_retMsg.Name = "lbl_retMsg";
            this.lbl_retMsg.Size = new System.Drawing.Size(35, 13);
            this.lbl_retMsg.TabIndex = 10;
            this.lbl_retMsg.Text = "label1";
            // 
            // lbl_task1
            // 
            this.lbl_task1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_task1.AutoSize = true;
            this.lbl_task1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_task1.ForeColor = System.Drawing.Color.Blue;
            this.lbl_task1.Location = new System.Drawing.Point(11, 10);
            this.lbl_task1.Name = "lbl_task1";
            this.lbl_task1.Size = new System.Drawing.Size(134, 19);
            this.lbl_task1.TabIndex = 5;
            this.lbl_task1.Text = "Execute SQL query";
            // 
            // btn_validate
            // 
            this.btn_validate.Location = new System.Drawing.Point(754, 36);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(75, 23);
            this.btn_validate.TabIndex = 3;
            this.btn_validate.Text = "Validate";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // txt_queryBox
            // 
            this.txt_queryBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_queryBox.Location = new System.Drawing.Point(13, 36);
            this.txt_queryBox.Multiline = true;
            this.txt_queryBox.Name = "txt_queryBox";
            this.txt_queryBox.Size = new System.Drawing.Size(735, 54);
            this.txt_queryBox.TabIndex = 2;
            this.txt_queryBox.TextChanged += new System.EventHandler(this.txt_queryBox_TextChanged);
            // 
            // btn_execute
            // 
            this.btn_execute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_execute.Enabled = false;
            this.btn_execute.Location = new System.Drawing.Point(754, 63);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(75, 25);
            this.btn_execute.TabIndex = 9;
            this.btn_execute.Text = "Execute";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // uc_AdminTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uc_AdminTasks";
            this.Size = new System.Drawing.Size(855, 553);
            this.Load += new System.EventHandler(this.uc_AppSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_row1.ResumeLayout(false);
            this.panel_row1.PerformLayout();
            this.panel_row2.ResumeLayout(false);
            this.panel_row2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_row1;
        private System.Windows.Forms.Panel panel_row2;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.TextBox txt_queryBox;
        private System.Windows.Forms.Label lbl_task1;
        private System.Windows.Forms.Label lbl_retMsg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ddl_tableNames;
    }
}
