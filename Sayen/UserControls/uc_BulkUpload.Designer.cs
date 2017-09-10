using static m1.Shared.AppCommon;

namespace Sayen.UserControls
{
    partial class uc_BulkUpload
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3_bulkUpload = new System.Windows.Forms.Panel();
            this.chk_agreement = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lbl_bulkUpload = new System.Windows.Forms.Label();
            this.txt_browseFile = new System.Windows.Forms.TextBox();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdl_bulkUpload = new System.Windows.Forms.RadioButton();
            this.rdl_singleUpload = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel3_bulkUpload.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(265, 33);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(151, 25);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add Employee";
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_submit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_submit.Enabled = false;
            this.btn_submit.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(513, 243);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3_bulkUpload);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 1326);
            this.panel1.TabIndex = 0;
            // 
            // panel3_bulkUpload
            // 
            this.panel3_bulkUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3_bulkUpload.Controls.Add(this.chk_agreement);
            this.panel3_bulkUpload.Controls.Add(this.tableLayoutPanel8);
            this.panel3_bulkUpload.Controls.Add(this.btn_submit);
            this.panel3_bulkUpload.Controls.Add(this.dgv_data);
            this.panel3_bulkUpload.Location = new System.Drawing.Point(132, 89);
            this.panel3_bulkUpload.Name = "panel3_bulkUpload";
            this.panel3_bulkUpload.Size = new System.Drawing.Size(609, 278);
            this.panel3_bulkUpload.TabIndex = 51;
            // 
            // chk_agreement
            // 
            this.chk_agreement.AutoSize = true;
            this.chk_agreement.Location = new System.Drawing.Point(8, 224);
            this.chk_agreement.Name = "chk_agreement";
            this.chk_agreement.Size = new System.Drawing.Size(172, 17);
            this.chk_agreement.TabIndex = 53;
            this.chk_agreement.Text = "I agree to upload this bulk data";
            this.chk_agreement.UseVisualStyleBackColor = true;
            this.chk_agreement.CheckedChanged += new System.EventHandler(this.chk_agreement_CheckedChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.91837F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.08163F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel8.Controls.Add(this.btn_browse, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.lbl_bulkUpload, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.txt_browseFile, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(8, 12);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.91866F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(583, 32);
            this.tableLayoutPanel8.TabIndex = 50;
            // 
            // btn_browse
            // 
            this.btn_browse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_browse.Location = new System.Drawing.Point(502, 4);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(72, 23);
            this.btn_browse.TabIndex = 51;
            this.btn_browse.Text = "Browse...";
            this.btn_browse.UseVisualStyleBackColor = true;
            // 
            // lbl_bulkUpload
            // 
            this.lbl_bulkUpload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_bulkUpload.AutoSize = true;
            this.lbl_bulkUpload.Location = new System.Drawing.Point(6, 9);
            this.lbl_bulkUpload.Name = "lbl_bulkUpload";
            this.lbl_bulkUpload.Size = new System.Drawing.Size(65, 13);
            this.lbl_bulkUpload.TabIndex = 37;
            this.lbl_bulkUpload.Text = "Bulk Upload";
            // 
            // txt_browseFile
            // 
            this.txt_browseFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_browseFile.Location = new System.Drawing.Point(81, 6);
            this.txt_browseFile.Name = "txt_browseFile";
            this.txt_browseFile.Size = new System.Drawing.Size(410, 20);
            this.txt_browseFile.TabIndex = 38;
            // 
            // dgv_data
            // 
            this.dgv_data.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgv_data.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(8, 50);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.Size = new System.Drawing.Size(580, 155);
            this.dgv_data.TabIndex = 52;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_title, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(51, -1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.38889F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.61111F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(753, 72);
            this.tableLayoutPanel4.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdl_bulkUpload);
            this.panel3.Controls.Add(this.rdl_singleUpload);
            this.panel3.Location = new System.Drawing.Point(480, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 47);
            this.panel3.TabIndex = 43;
            // 
            // rdl_bulkUpload
            // 
            this.rdl_bulkUpload.AutoSize = true;
            this.rdl_bulkUpload.Checked = true;
            this.rdl_bulkUpload.Enabled = false;
            this.rdl_bulkUpload.Location = new System.Drawing.Point(107, 14);
            this.rdl_bulkUpload.Name = "rdl_bulkUpload";
            this.rdl_bulkUpload.Size = new System.Drawing.Size(83, 17);
            this.rdl_bulkUpload.TabIndex = 1;
            this.rdl_bulkUpload.TabStop = true;
            this.rdl_bulkUpload.Text = "Bulk Upload";
            this.rdl_bulkUpload.UseVisualStyleBackColor = true;
            this.rdl_bulkUpload.CheckedChanged += new System.EventHandler(this.rdl_bulkUpload_CheckedChanged);
            // 
            // rdl_singleUpload
            // 
            this.rdl_singleUpload.AutoSize = true;
            this.rdl_singleUpload.Location = new System.Drawing.Point(7, 14);
            this.rdl_singleUpload.Name = "rdl_singleUpload";
            this.rdl_singleUpload.Size = new System.Drawing.Size(83, 17);
            this.rdl_singleUpload.TabIndex = 0;
            this.rdl_singleUpload.Text = "Single Insert";
            this.rdl_singleUpload.UseVisualStyleBackColor = true;
            this.rdl_singleUpload.CheckedChanged += new System.EventHandler(this.rdl_singleUpload_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uc_BulkUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Orange;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "uc_BulkUpload";
            this.Size = new System.Drawing.Size(898, 1134);
            this.panel1.ResumeLayout(false);
            this.panel3_bulkUpload.ResumeLayout(false);
            this.panel3_bulkUpload.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel3_bulkUpload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label lbl_bulkUpload;
        private System.Windows.Forms.TextBox txt_browseFile;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdl_bulkUpload;
        private System.Windows.Forms.RadioButton rdl_singleUpload;
        private System.Windows.Forms.CheckBox chk_agreement;
    }
}
