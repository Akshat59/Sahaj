namespace Sayen.userForms
{
    partial class frm_Backdoor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Backdoor));
            this.lbl_viewLogs = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_backdoorAccess = new System.Windows.Forms.Label();
            this.ddl_Environment = new System.Windows.Forms.ComboBox();
            this.lbl_Environment = new System.Windows.Forms.Label();
            this.txt_passkey = new System.Windows.Forms.TextBox();
            this.lbl_goBack = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_viewLogs
            // 
            this.lbl_viewLogs.AutoSize = true;
            this.lbl_viewLogs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_viewLogs.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewLogs.Location = new System.Drawing.Point(62, 11);
            this.lbl_viewLogs.Name = "lbl_viewLogs";
            this.lbl_viewLogs.Size = new System.Drawing.Size(68, 11);
            this.lbl_viewLogs.TabIndex = 0;
            this.lbl_viewLogs.Text = "View Logs";
            this.lbl_viewLogs.Click += new System.EventHandler(this.lbl_viewLogs_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::m1.Sahaj.Properties.Resources.img_matrixCode;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_backdoorAccess);
            this.panel1.Controls.Add(this.ddl_Environment);
            this.panel1.Controls.Add(this.lbl_Environment);
            this.panel1.Location = new System.Drawing.Point(4, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 42);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // lbl_backdoorAccess
            // 
            this.lbl_backdoorAccess.AutoSize = true;
            this.lbl_backdoorAccess.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_backdoorAccess.Location = new System.Drawing.Point(22, 24);
            this.lbl_backdoorAccess.Name = "lbl_backdoorAccess";
            this.lbl_backdoorAccess.Size = new System.Drawing.Size(131, 11);
            this.lbl_backdoorAccess.TabIndex = 3;
            this.lbl_backdoorAccess.Text = "Super Admin Access";
            // 
            // ddl_Environment
            // 
            this.ddl_Environment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_Environment.FormattingEnabled = true;
            this.ddl_Environment.Location = new System.Drawing.Point(91, -1);
            this.ddl_Environment.Name = "ddl_Environment";
            this.ddl_Environment.Size = new System.Drawing.Size(80, 19);
            this.ddl_Environment.TabIndex = 3;
            this.ddl_Environment.SelectedIndexChanged += new System.EventHandler(this.ddl_Environment_SelectedIndexChanged);
            // 
            // lbl_Environment
            // 
            this.lbl_Environment.AutoSize = true;
            this.lbl_Environment.Location = new System.Drawing.Point(3, 3);
            this.lbl_Environment.Name = "lbl_Environment";
            this.lbl_Environment.Size = new System.Drawing.Size(82, 11);
            this.lbl_Environment.TabIndex = 0;
            this.lbl_Environment.Text = "Environment";
            // 
            // txt_passkey
            // 
            this.txt_passkey.BackColor = System.Drawing.Color.Black;
            this.txt_passkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_passkey.CausesValidation = false;
            this.txt_passkey.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txt_passkey.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_passkey.Location = new System.Drawing.Point(141, 11);
            this.txt_passkey.MaxLength = 10;
            this.txt_passkey.Name = "txt_passkey";
            this.txt_passkey.PasswordChar = ' ';
            this.txt_passkey.ShortcutsEnabled = false;
            this.txt_passkey.Size = new System.Drawing.Size(32, 11);
            this.txt_passkey.TabIndex = 2;
            this.txt_passkey.TextChanged += new System.EventHandler(this.txt_passkey_TextChanged);
            // 
            // lbl_goBack
            // 
            this.lbl_goBack.AutoSize = true;
            this.lbl_goBack.BackColor = System.Drawing.Color.Transparent;
            this.lbl_goBack.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_goBack.Location = new System.Drawing.Point(12, 11);
            this.lbl_goBack.Name = "lbl_goBack";
            this.lbl_goBack.Size = new System.Drawing.Size(33, 11);
            this.lbl_goBack.TabIndex = 3;
            this.lbl_goBack.Text = "Back";
            this.lbl_goBack.Click += new System.EventHandler(this.lbl_goBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Backdoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(187, 77);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_goBack);
            this.Controls.Add(this.txt_passkey);
            this.Controls.Add(this.lbl_viewLogs);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Backdoor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backdoor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Backdoor_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_viewLogs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_passkey;
        private System.Windows.Forms.ComboBox ddl_Environment;
        private System.Windows.Forms.Label lbl_Environment;
        private System.Windows.Forms.Label lbl_backdoorAccess;
        private System.Windows.Forms.Label lbl_goBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}