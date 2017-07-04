namespace Sayen.UserControls
{
    partial class uc_welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_welcome));
            this.lbl_greeting = new System.Windows.Forms.Label();
            this.lbl_u_fullname = new System.Windows.Forms.Label();
            this.pb_pflPic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pflPic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_greeting
            // 
            this.lbl_greeting.AutoSize = true;
            this.lbl_greeting.Location = new System.Drawing.Point(24, 134);
            this.lbl_greeting.Name = "lbl_greeting";
            this.lbl_greeting.Size = new System.Drawing.Size(52, 13);
            this.lbl_greeting.TabIndex = 5;
            this.lbl_greeting.Text = "Welcome";
            // 
            // lbl_u_fullname
            // 
            this.lbl_u_fullname.AutoSize = true;
            this.lbl_u_fullname.Location = new System.Drawing.Point(108, 134);
            this.lbl_u_fullname.Name = "lbl_u_fullname";
            this.lbl_u_fullname.Size = new System.Drawing.Size(45, 13);
            this.lbl_u_fullname.TabIndex = 6;
            this.lbl_u_fullname.Text = "<name>";
            this.lbl_u_fullname.Visible = false;
            // 
            // pb_pflPic
            // 
            this.pb_pflPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_pflPic.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb_pflPic.ErrorImage")));
            this.pb_pflPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_pflPic.InitialImage")));
            this.pb_pflPic.Location = new System.Drawing.Point(645, 120);
            this.pb_pflPic.Name = "pb_pflPic";
            this.pb_pflPic.Size = new System.Drawing.Size(194, 218);
            this.pb_pflPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pflPic.TabIndex = 2;
            this.pb_pflPic.TabStop = false;
            this.pb_pflPic.WaitOnLoad = true;
            this.pb_pflPic.Click += new System.EventHandler(this.pb_pflPic_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lbl_greeting);
            this.panel1.Controls.Add(this.lbl_u_fullname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pb_pflPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 341);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(842, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // uc_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "uc_welcome";
            this.Size = new System.Drawing.Size(842, 341);
            this.Load += new System.EventHandler(this.uc_welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_pflPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_pflPic;
        private System.Windows.Forms.Label lbl_greeting;
        private System.Windows.Forms.Label lbl_u_fullname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
