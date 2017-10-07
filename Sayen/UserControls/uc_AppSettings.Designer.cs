namespace Sahaj.UserControls
{
    partial class uc_AppSettings
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
            this.clb_appSettings1 = new System.Windows.Forms.CheckedListBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.ddl_propertyKeys = new System.Windows.Forms.ComboBox();
            this.txt_propertyValue = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
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
            this.lbl_title.Location = new System.Drawing.Point(304, 5);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(167, 36);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "App Settings";
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 526);
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
            this.panel_row2.Controls.Add(this.btn_update);
            this.panel_row2.Controls.Add(this.txt_propertyValue);
            this.panel_row2.Controls.Add(this.btn_save);
            this.panel_row2.Controls.Add(this.ddl_propertyKeys);
            this.panel_row2.Controls.Add(this.clb_appSettings1);
            this.panel_row2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_row2.Location = new System.Drawing.Point(3, 63);
            this.panel_row2.Name = "panel_row2";
            this.panel_row2.Size = new System.Drawing.Size(843, 194);
            this.panel_row2.TabIndex = 8;
            // 
            // clb_appSettings1
            // 
            this.clb_appSettings1.BackColor = System.Drawing.Color.AliceBlue;
            this.clb_appSettings1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_appSettings1.CheckOnClick = true;
            this.clb_appSettings1.FormattingEnabled = true;
            this.clb_appSettings1.Location = new System.Drawing.Point(10, 5);
            this.clb_appSettings1.Name = "clb_appSettings1";
            this.clb_appSettings1.Size = new System.Drawing.Size(359, 15);
            this.clb_appSettings1.TabIndex = 0;
            this.clb_appSettings1.SelectedIndexChanged += new System.EventHandler(this.clb_appSettings1_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_save.Location = new System.Drawing.Point(10, 26);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 21);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ddl_propertyKeys
            // 
            this.ddl_propertyKeys.FormattingEnabled = true;
            this.ddl_propertyKeys.Location = new System.Drawing.Point(458, 5);
            this.ddl_propertyKeys.Name = "ddl_propertyKeys";
            this.ddl_propertyKeys.Size = new System.Drawing.Size(278, 21);
            this.ddl_propertyKeys.TabIndex = 1;
            this.ddl_propertyKeys.SelectedIndexChanged += new System.EventHandler(this.ddl_propertyKeys_SelectedIndexChanged);
            // 
            // txt_propertyValue
            // 
            this.txt_propertyValue.Location = new System.Drawing.Point(458, 32);
            this.txt_propertyValue.Multiline = true;
            this.txt_propertyValue.Name = "txt_propertyValue";
            this.txt_propertyValue.Size = new System.Drawing.Size(371, 145);
            this.txt_propertyValue.TabIndex = 2;
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(754, 3);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // uc_AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uc_AppSettings";
            this.Size = new System.Drawing.Size(855, 553);
            this.Load += new System.EventHandler(this.uc_AppSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_row1.ResumeLayout(false);
            this.panel_row1.PerformLayout();
            this.panel_row2.ResumeLayout(false);
            this.panel_row2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_row1;
        private System.Windows.Forms.Panel panel_row2;
        private System.Windows.Forms.CheckedListBox clb_appSettings1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_propertyValue;
        private System.Windows.Forms.ComboBox ddl_propertyKeys;
    }
}
