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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_welcome));
            this.lbl_greeting = new System.Windows.Forms.Label();
            this.lbl_u_fullname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_currentTime = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.lbl_u_fullname.Location = new System.Drawing.Point(107, 134);
            this.lbl_u_fullname.Name = "lbl_u_fullname";
            this.lbl_u_fullname.Size = new System.Drawing.Size(45, 13);
            this.lbl_u_fullname.TabIndex = 6;
            this.lbl_u_fullname.Text = "<name>";
            this.lbl_u_fullname.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.lbl_currentTime);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.lbl_greeting);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_u_fullname);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 555);
            this.panel1.TabIndex = 7;
            this.panel1.Leave += new System.EventHandler(this.panel1_Leave);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 10F);
            this.richTextBox1.ForeColor = System.Drawing.Color.Blue;
            this.richTextBox1.Location = new System.Drawing.Point(515, 307);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 245);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "Notes- ";
            this.richTextBox1.Visible = false;
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            this.richTextBox1.Leave += new System.EventHandler(this.richTextBox1_Leave);
            // 
            // lbl_currentTime
            // 
            this.lbl_currentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_currentTime.AutoSize = true;
            this.lbl_currentTime.Location = new System.Drawing.Point(529, 121);
            this.lbl_currentTime.Name = "lbl_currentTime";
            this.lbl_currentTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_currentTime.Size = new System.Drawing.Size(76, 13);
            this.lbl_currentTime.TabIndex = 9;
            this.lbl_currentTime.Text = "<currentTIme>";
            this.lbl_currentTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_currentTime.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(515, 143);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // uc_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "uc_welcome";
            this.Size = new System.Drawing.Size(772, 555);
            this.Load += new System.EventHandler(this.uc_welcome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_greeting;
        private System.Windows.Forms.Label lbl_u_fullname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_currentTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
