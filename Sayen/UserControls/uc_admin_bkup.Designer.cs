namespace Sahaj.UserControls
{
    partial class uc_admin_bkup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_BackUpFolder = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_restoreDate = new System.Windows.Forms.TextBox();
            this.rdb_restore = new System.Windows.Forms.RadioButton();
            this.rdb_backup = new System.Windows.Forms.RadioButton();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.txt_filePath = new System.Windows.Forms.TextBox();
            this.chk_selectAll = new System.Windows.Forms.CheckBox();
            this.clb_dataTables = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_BackUpFolder);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_backup);
            this.panel1.Controls.Add(this.btn_Browse);
            this.panel1.Controls.Add(this.txt_filePath);
            this.panel1.Controls.Add(this.chk_selectAll);
            this.panel1.Controls.Add(this.clb_dataTables);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 509);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_BackUpFolder
            // 
            this.lbl_BackUpFolder.AutoSize = true;
            this.lbl_BackUpFolder.Location = new System.Drawing.Point(75, 57);
            this.lbl_BackUpFolder.Name = "lbl_BackUpFolder";
            this.lbl_BackUpFolder.Size = new System.Drawing.Size(74, 13);
            this.lbl_BackUpFolder.TabIndex = 7;
            this.lbl_BackUpFolder.Text = "Back Up Path";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_restoreDate);
            this.panel3.Controls.Add(this.rdb_restore);
            this.panel3.Controls.Add(this.rdb_backup);
            this.panel3.Location = new System.Drawing.Point(75, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 28);
            this.panel3.TabIndex = 6;
            // 
            // txt_restoreDate
            // 
            this.txt_restoreDate.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_restoreDate.Location = new System.Drawing.Point(227, 3);
            this.txt_restoreDate.Name = "txt_restoreDate";
            this.txt_restoreDate.ShortcutsEnabled = false;
            this.txt_restoreDate.Size = new System.Drawing.Size(142, 20);
            this.txt_restoreDate.TabIndex = 7;
            this.txt_restoreDate.Text = "Restore Date YYYY-MM-DD";
            this.txt_restoreDate.Visible = false;
            this.txt_restoreDate.Enter += new System.EventHandler(this.txt_restoreDate_Enter);
            this.txt_restoreDate.Leave += new System.EventHandler(this.txt_restoreDate_Leave);
            // 
            // rdb_restore
            // 
            this.rdb_restore.AutoSize = true;
            this.rdb_restore.Location = new System.Drawing.Point(137, 4);
            this.rdb_restore.Name = "rdb_restore";
            this.rdb_restore.Size = new System.Drawing.Size(62, 17);
            this.rdb_restore.TabIndex = 1;
            this.rdb_restore.Text = "Restore";
            this.rdb_restore.UseVisualStyleBackColor = true;
            this.rdb_restore.CheckedChanged += new System.EventHandler(this.rdb_restore_CheckedChanged);
            // 
            // rdb_backup
            // 
            this.rdb_backup.AutoSize = true;
            this.rdb_backup.Checked = true;
            this.rdb_backup.Location = new System.Drawing.Point(11, 4);
            this.rdb_backup.Name = "rdb_backup";
            this.rdb_backup.Size = new System.Drawing.Size(85, 17);
            this.rdb_backup.TabIndex = 0;
            this.rdb_backup.TabStop = true;
            this.rdb_backup.Text = "BackupData";
            this.rdb_backup.UseVisualStyleBackColor = true;
            this.rdb_backup.CheckedChanged += new System.EventHandler(this.rdb_backup_CheckedChanged);
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(520, 102);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(83, 23);
            this.btn_backup.TabIndex = 4;
            this.btn_backup.Text = "Backup";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(520, 51);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "Browse...";
            this.btn_Browse.UseVisualStyleBackColor = true;
            // 
            // txt_filePath
            // 
            this.txt_filePath.Enabled = false;
            this.txt_filePath.Location = new System.Drawing.Point(155, 53);
            this.txt_filePath.Name = "txt_filePath";
            this.txt_filePath.Size = new System.Drawing.Size(358, 20);
            this.txt_filePath.TabIndex = 2;
            // 
            // chk_selectAll
            // 
            this.chk_selectAll.AutoSize = true;
            this.chk_selectAll.Location = new System.Drawing.Point(75, 102);
            this.chk_selectAll.Name = "chk_selectAll";
            this.chk_selectAll.Size = new System.Drawing.Size(70, 17);
            this.chk_selectAll.TabIndex = 1;
            this.chk_selectAll.Text = "Select All";
            this.chk_selectAll.UseVisualStyleBackColor = true;
            this.chk_selectAll.CheckedChanged += new System.EventHandler(this.chk_selectAll_CheckedChanged);
            // 
            // clb_dataTables
            // 
            this.clb_dataTables.BackColor = System.Drawing.Color.AliceBlue;
            this.clb_dataTables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_dataTables.CheckOnClick = true;
            this.clb_dataTables.FormattingEnabled = true;
            this.clb_dataTables.Items.AddRange(new object[] {
            "d1_cdt_employees"});
            this.clb_dataTables.Location = new System.Drawing.Point(86, 125);
            this.clb_dataTables.Name = "clb_dataTables";
            this.clb_dataTables.Size = new System.Drawing.Size(427, 255);
            this.clb_dataTables.TabIndex = 0;
            // 
            // uc_admin_bkup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.Name = "uc_admin_bkup";
            this.Size = new System.Drawing.Size(936, 520);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox txt_filePath;
        private System.Windows.Forms.CheckBox chk_selectAll;
        private System.Windows.Forms.CheckedListBox clb_dataTables;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdb_restore;
        private System.Windows.Forms.RadioButton rdb_backup;
        private System.Windows.Forms.TextBox txt_restoreDate;
        private System.Windows.Forms.Label lbl_BackUpFolder;
    }
}
