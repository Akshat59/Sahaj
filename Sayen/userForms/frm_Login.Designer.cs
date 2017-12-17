namespace Sayen
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_loginMsg = new System.Windows.Forms.Label();
            this.lbl_loginIssue = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_title.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_title.Location = new System.Drawing.Point(61, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(69, 29);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Sahaj";
            this.lbl_title.DoubleClick += new System.EventHandler(this.lbl_title_DoubleClick);
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Location = new System.Drawing.Point(9, 48);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(60, 13);
            this.lbl_uname.TabIndex = 1;
            this.lbl_uname.Text = "User Name";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(9, 75);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(53, 13);
            this.lbl_pwd.TabIndex = 2;
            this.lbl_pwd.Text = "Password";
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(99, 44);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(100, 20);
            this.txt_uname.TabIndex = 3;
            this.txt_uname.Text = "akshats";
            this.txt_uname.TextChanged += new System.EventHandler(this.txt_uname_TextChanged);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(99, 70);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '•';
            this.txt_pwd.Size = new System.Drawing.Size(100, 20);
            this.txt_pwd.TabIndex = 4;
            this.txt_pwd.Text = "Test123";
            this.txt_pwd.UseSystemPasswordChar = true;
            this.txt_pwd.TextChanged += new System.EventHandler(this.txt_pwd_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(131, 96);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(68, 24);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_loginMsg
            // 
            this.lbl_loginMsg.AutoSize = true;
            this.lbl_loginMsg.Location = new System.Drawing.Point(54, 123);
            this.lbl_loginMsg.Name = "lbl_loginMsg";
            this.lbl_loginMsg.Size = new System.Drawing.Size(90, 13);
            this.lbl_loginMsg.TabIndex = 6;
            this.lbl_loginMsg.Text = "Login Successfull";
            this.lbl_loginMsg.Visible = false;
            // 
            // lbl_loginIssue
            // 
            this.lbl_loginIssue.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lbl_loginIssue.AutoSize = true;
            this.lbl_loginIssue.Location = new System.Drawing.Point(9, 102);
            this.lbl_loginIssue.Name = "lbl_loginIssue";
            this.lbl_loginIssue.Size = new System.Drawing.Size(67, 13);
            this.lbl_loginIssue.TabIndex = 7;
            this.lbl_loginIssue.TabStop = true;
            this.lbl_loginIssue.Text = "Login Issue?";
            this.lbl_loginIssue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_loginIssue_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.lbl_loginIssue);
            this.panel1.Controls.Add(this.lbl_uname);
            this.panel1.Controls.Add(this.lbl_loginMsg);
            this.panel1.Controls.Add(this.lbl_pwd);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.txt_uname);
            this.panel1.Controls.Add(this.txt_pwd);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 143);
            this.panel1.TabIndex = 9;
            // 
            // frm_login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(211, 152);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_loginMsg;
        private System.Windows.Forms.LinkLabel lbl_loginIssue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

