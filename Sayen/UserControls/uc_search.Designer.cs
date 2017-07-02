namespace Sayen.userForms
{
    partial class uc_search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_search));
            this.pb_searchlogo = new System.Windows.Forms.PictureBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_advSearch = new System.Windows.Forms.LinkLabel();
            this.dg_search = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pb_searchlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_search)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_searchlogo
            // 
            this.pb_searchlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_searchlogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb_searchlogo.ErrorImage")));
            this.pb_searchlogo.Image = ((System.Drawing.Image)(resources.GetObject("pb_searchlogo.Image")));
            this.pb_searchlogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_searchlogo.InitialImage")));
            this.pb_searchlogo.Location = new System.Drawing.Point(229, 12);
            this.pb_searchlogo.Name = "pb_searchlogo";
            this.pb_searchlogo.Size = new System.Drawing.Size(207, 87);
            this.pb_searchlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_searchlogo.TabIndex = 3;
            this.pb_searchlogo.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(110, 115);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(456, 20);
            this.txt_search.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(285, 141);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(80, 24);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // lbl_advSearch
            // 
            this.lbl_advSearch.AutoSize = true;
            this.lbl_advSearch.Location = new System.Drawing.Point(582, 118);
            this.lbl_advSearch.Name = "lbl_advSearch";
            this.lbl_advSearch.Size = new System.Drawing.Size(93, 13);
            this.lbl_advSearch.TabIndex = 6;
            this.lbl_advSearch.TabStop = true;
            this.lbl_advSearch.Text = "Advanced Search";
            // 
            // dg_search
            // 
            this.dg_search.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dg_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_search.GridColor = System.Drawing.SystemColors.Control;
            this.dg_search.Location = new System.Drawing.Point(9, 181);
            this.dg_search.Name = "dg_search";
            this.dg_search.Size = new System.Drawing.Size(678, 183);
            this.dg_search.TabIndex = 7;
            // 
            // uc_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dg_search);
            this.Controls.Add(this.lbl_advSearch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.pb_searchlogo);
            this.Name = "uc_search";
            this.Size = new System.Drawing.Size(696, 372);
            ((System.ComponentModel.ISupportInitialize)(this.pb_searchlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_searchlogo;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.LinkLabel lbl_advSearch;
        private System.Windows.Forms.DataGridView dg_search;
    }
}
