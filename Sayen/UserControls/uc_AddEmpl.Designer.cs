namespace Sayen.UserControls
{
    partial class uc_AddEmpl
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
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddl_designation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_prefill = new System.Windows.Forms.CheckBox();
            this.lbl_upload_add = new System.Windows.Forms.LinkLabel();
            this.lbl_upload_uid = new System.Windows.Forms.LinkLabel();
            this.lbl_filename_add = new System.Windows.Forms.Label();
            this.lbl_filename_uid = new System.Windows.Forms.Label();
            this.txt_addressProof = new System.Windows.Forms.TextBox();
            this.txt_aadhaar = new System.Windows.Forms.TextBox();
            this.txt_otherDetails = new System.Windows.Forms.TextBox();
            this.txt_attributes = new System.Windows.Forms.TextBox();
            this.txt_experience = new System.Windows.Forms.TextBox();
            this.lbl_validity = new System.Windows.Forms.Label();
            this.lbl_experience = new System.Windows.Forms.Label();
            this.lbl_otherDetails = new System.Windows.Forms.Label();
            this.lbl_attributes = new System.Windows.Forms.Label();
            this.lbl_addressProof = new System.Windows.Forms.Label();
            this.lbl_drivingLicence = new System.Windows.Forms.Label();
            this.lbl_aadhaar = new System.Windows.Forms.Label();
            this.txt_mobileNo = new System.Windows.Forms.TextBox();
            this.txt_homePhone = new System.Windows.Forms.TextBox();
            this.txt_pinCode = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.ddl_empType = new System.Windows.Forms.ComboBox();
            this.lbl_empType = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_mobileNo = new System.Windows.Forms.Label();
            this.lbl_homePhone = new System.Windows.Forms.Label();
            this.lbl_pinCode = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdl_gendel_f = new System.Windows.Forms.RadioButton();
            this.rdl_gender_m = new System.Windows.Forms.RadioButton();
            this.txt_petName = new System.Windows.Forms.TextBox();
            this.lbl_petName = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chk_dlTypes = new System.Windows.Forms.CheckedListBox();
            this.txt_rto = new System.Windows.Forms.TextBox();
            this.txt_validity = new System.Windows.Forms.TextBox();
            this.txt_dlno = new System.Windows.Forms.TextBox();
            this.lbl_upload_dl = new System.Windows.Forms.LinkLabel();
            this.lbl_filename_dl = new System.Windows.Forms.Label();
            this.lbl_rto = new System.Windows.Forms.Label();
            this.lbl_dlno = new System.Windows.Forms.Label();
            this.lbl_dlTypes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(384, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(151, 25);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add Employee";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(103, 47);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(188, 20);
            this.txt_firstName.TabIndex = 1;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(13, 50);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_firstName.TabIndex = 2;
            this.lbl_firstName.Text = "First Name";
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(361, 453);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(13, 87);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_lastName.TabIndex = 4;
            this.lbl_lastName.Text = "Last Name";
            this.lbl_lastName.Click += new System.EventHandler(this.lbl_lastName_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.txt_otherDetails);
            this.panel1.Controls.Add(this.lbl_validity);
            this.panel1.Controls.Add(this.ddl_designation);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chk_prefill);
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.lbl_upload_add);
            this.panel1.Controls.Add(this.lbl_upload_uid);
            this.panel1.Controls.Add(this.lbl_filename_add);
            this.panel1.Controls.Add(this.lbl_filename_uid);
            this.panel1.Controls.Add(this.txt_addressProof);
            this.panel1.Controls.Add(this.txt_aadhaar);
            this.panel1.Controls.Add(this.txt_attributes);
            this.panel1.Controls.Add(this.txt_experience);
            this.panel1.Controls.Add(this.lbl_experience);
            this.panel1.Controls.Add(this.lbl_otherDetails);
            this.panel1.Controls.Add(this.lbl_attributes);
            this.panel1.Controls.Add(this.lbl_addressProof);
            this.panel1.Controls.Add(this.lbl_drivingLicence);
            this.panel1.Controls.Add(this.lbl_aadhaar);
            this.panel1.Controls.Add(this.txt_mobileNo);
            this.panel1.Controls.Add(this.txt_homePhone);
            this.panel1.Controls.Add(this.txt_pinCode);
            this.panel1.Controls.Add(this.txt_address);
            this.panel1.Controls.Add(this.ddl_empType);
            this.panel1.Controls.Add(this.lbl_empType);
            this.panel1.Controls.Add(this.lbl_address);
            this.panel1.Controls.Add(this.lbl_mobileNo);
            this.panel1.Controls.Add(this.lbl_homePhone);
            this.panel1.Controls.Add(this.lbl_pinCode);
            this.panel1.Controls.Add(this.lbl_gender);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_petName);
            this.panel1.Controls.Add(this.lbl_petName);
            this.panel1.Controls.Add(this.txt_lastName);
            this.panel1.Controls.Add(this.txt_firstName);
            this.panel1.Controls.Add(this.lbl_lastName);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.lbl_firstName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 479);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ddl_designation
            // 
            this.ddl_designation.Enabled = false;
            this.ddl_designation.FormattingEnabled = true;
            this.ddl_designation.Location = new System.Drawing.Point(103, 220);
            this.ddl_designation.Name = "ddl_designation";
            this.ddl_designation.Size = new System.Drawing.Size(185, 21);
            this.ddl_designation.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Designation";
            // 
            // chk_prefill
            // 
            this.chk_prefill.AutoSize = true;
            this.chk_prefill.Location = new System.Drawing.Point(713, 17);
            this.chk_prefill.Name = "chk_prefill";
            this.chk_prefill.Size = new System.Drawing.Size(51, 17);
            this.chk_prefill.TabIndex = 42;
            this.chk_prefill.Text = "Prefill";
            this.chk_prefill.UseVisualStyleBackColor = true;
            this.chk_prefill.CheckedChanged += new System.EventHandler(this.chk_prefill_CheckedChanged);
            // 
            // lbl_upload_add
            // 
            this.lbl_upload_add.AutoSize = true;
            this.lbl_upload_add.Location = new System.Drawing.Point(710, 76);
            this.lbl_upload_add.Name = "lbl_upload_add";
            this.lbl_upload_add.Size = new System.Drawing.Size(41, 13);
            this.lbl_upload_add.TabIndex = 41;
            this.lbl_upload_add.TabStop = true;
            this.lbl_upload_add.Text = "Upload";
            // 
            // lbl_upload_uid
            // 
            this.lbl_upload_uid.AutoSize = true;
            this.lbl_upload_uid.Location = new System.Drawing.Point(710, 46);
            this.lbl_upload_uid.Name = "lbl_upload_uid";
            this.lbl_upload_uid.Size = new System.Drawing.Size(41, 13);
            this.lbl_upload_uid.TabIndex = 40;
            this.lbl_upload_uid.TabStop = true;
            this.lbl_upload_uid.Text = "Upload";
            // 
            // lbl_filename_add
            // 
            this.lbl_filename_add.AutoSize = true;
            this.lbl_filename_add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_filename_add.Location = new System.Drawing.Point(761, 73);
            this.lbl_filename_add.Name = "lbl_filename_add";
            this.lbl_filename_add.Size = new System.Drawing.Size(61, 13);
            this.lbl_filename_add.TabIndex = 39;
            this.lbl_filename_add.Text = "<file name>";
            // 
            // lbl_filename_uid
            // 
            this.lbl_filename_uid.AutoSize = true;
            this.lbl_filename_uid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_filename_uid.Location = new System.Drawing.Point(761, 50);
            this.lbl_filename_uid.Name = "lbl_filename_uid";
            this.lbl_filename_uid.Size = new System.Drawing.Size(61, 13);
            this.lbl_filename_uid.TabIndex = 38;
            this.lbl_filename_uid.Text = "<file name>";
            // 
            // txt_addressProof
            // 
            this.txt_addressProof.Location = new System.Drawing.Point(502, 73);
            this.txt_addressProof.Name = "txt_addressProof";
            this.txt_addressProof.Size = new System.Drawing.Size(188, 20);
            this.txt_addressProof.TabIndex = 37;
            // 
            // txt_aadhaar
            // 
            this.txt_aadhaar.Location = new System.Drawing.Point(502, 43);
            this.txt_aadhaar.Name = "txt_aadhaar";
            this.txt_aadhaar.Size = new System.Drawing.Size(188, 20);
            this.txt_aadhaar.TabIndex = 36;
            // 
            // txt_otherDetails
            // 
            this.txt_otherDetails.Location = new System.Drawing.Point(499, 361);
            this.txt_otherDetails.Multiline = true;
            this.txt_otherDetails.Name = "txt_otherDetails";
            this.txt_otherDetails.Size = new System.Drawing.Size(332, 54);
            this.txt_otherDetails.TabIndex = 35;
            // 
            // txt_attributes
            // 
            this.txt_attributes.Location = new System.Drawing.Point(499, 288);
            this.txt_attributes.Multiline = true;
            this.txt_attributes.Name = "txt_attributes";
            this.txt_attributes.Size = new System.Drawing.Size(332, 54);
            this.txt_attributes.TabIndex = 34;
            // 
            // txt_experience
            // 
            this.txt_experience.Location = new System.Drawing.Point(499, 211);
            this.txt_experience.Multiline = true;
            this.txt_experience.Name = "txt_experience";
            this.txt_experience.Size = new System.Drawing.Size(332, 61);
            this.txt_experience.TabIndex = 32;
            // 
            // lbl_validity
            // 
            this.lbl_validity.AutoSize = true;
            this.lbl_validity.Location = new System.Drawing.Point(447, 153);
            this.lbl_validity.Name = "lbl_validity";
            this.lbl_validity.Size = new System.Drawing.Size(40, 13);
            this.lbl_validity.TabIndex = 28;
            this.lbl_validity.Text = "Validity";
            // 
            // lbl_experience
            // 
            this.lbl_experience.AutoSize = true;
            this.lbl_experience.Location = new System.Drawing.Point(362, 223);
            this.lbl_experience.Name = "lbl_experience";
            this.lbl_experience.Size = new System.Drawing.Size(60, 13);
            this.lbl_experience.TabIndex = 26;
            this.lbl_experience.Text = "Experience";
            // 
            // lbl_otherDetails
            // 
            this.lbl_otherDetails.AutoSize = true;
            this.lbl_otherDetails.Location = new System.Drawing.Point(362, 369);
            this.lbl_otherDetails.Name = "lbl_otherDetails";
            this.lbl_otherDetails.Size = new System.Drawing.Size(68, 13);
            this.lbl_otherDetails.TabIndex = 24;
            this.lbl_otherDetails.Text = "Other Details";
            // 
            // lbl_attributes
            // 
            this.lbl_attributes.AutoSize = true;
            this.lbl_attributes.Location = new System.Drawing.Point(364, 313);
            this.lbl_attributes.Name = "lbl_attributes";
            this.lbl_attributes.Size = new System.Drawing.Size(51, 13);
            this.lbl_attributes.TabIndex = 23;
            this.lbl_attributes.Text = "Attributes";
            // 
            // lbl_addressProof
            // 
            this.lbl_addressProof.AutoSize = true;
            this.lbl_addressProof.Location = new System.Drawing.Point(358, 80);
            this.lbl_addressProof.Name = "lbl_addressProof";
            this.lbl_addressProof.Size = new System.Drawing.Size(73, 13);
            this.lbl_addressProof.TabIndex = 22;
            this.lbl_addressProof.Text = "Address Proof";
            // 
            // lbl_drivingLicence
            // 
            this.lbl_drivingLicence.AutoSize = true;
            this.lbl_drivingLicence.Location = new System.Drawing.Point(358, 115);
            this.lbl_drivingLicence.Name = "lbl_drivingLicence";
            this.lbl_drivingLicence.Size = new System.Drawing.Size(81, 13);
            this.lbl_drivingLicence.TabIndex = 21;
            this.lbl_drivingLicence.Text = "Driving Licence";
            // 
            // lbl_aadhaar
            // 
            this.lbl_aadhaar.AutoSize = true;
            this.lbl_aadhaar.Location = new System.Drawing.Point(358, 50);
            this.lbl_aadhaar.Name = "lbl_aadhaar";
            this.lbl_aadhaar.Size = new System.Drawing.Size(47, 13);
            this.lbl_aadhaar.TabIndex = 20;
            this.lbl_aadhaar.Text = "Aadhaar";
            // 
            // txt_mobileNo
            // 
            this.txt_mobileNo.Location = new System.Drawing.Point(103, 384);
            this.txt_mobileNo.Name = "txt_mobileNo";
            this.txt_mobileNo.Size = new System.Drawing.Size(188, 20);
            this.txt_mobileNo.TabIndex = 19;
            // 
            // txt_homePhone
            // 
            this.txt_homePhone.Location = new System.Drawing.Point(103, 348);
            this.txt_homePhone.Name = "txt_homePhone";
            this.txt_homePhone.Size = new System.Drawing.Size(188, 20);
            this.txt_homePhone.TabIndex = 18;
            // 
            // txt_pinCode
            // 
            this.txt_pinCode.Location = new System.Drawing.Point(103, 310);
            this.txt_pinCode.Name = "txt_pinCode";
            this.txt_pinCode.Size = new System.Drawing.Size(188, 20);
            this.txt_pinCode.TabIndex = 17;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(103, 248);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(188, 40);
            this.txt_address.TabIndex = 16;
            // 
            // ddl_empType
            // 
            this.ddl_empType.FormattingEnabled = true;
            this.ddl_empType.Location = new System.Drawing.Point(103, 189);
            this.ddl_empType.Name = "ddl_empType";
            this.ddl_empType.Size = new System.Drawing.Size(185, 21);
            this.ddl_empType.TabIndex = 15;
            this.ddl_empType.SelectedIndexChanged += new System.EventHandler(this.ddl_empType_SelectedIndexChanged);
            // 
            // lbl_empType
            // 
            this.lbl_empType.AutoSize = true;
            this.lbl_empType.Location = new System.Drawing.Point(13, 192);
            this.lbl_empType.Name = "lbl_empType";
            this.lbl_empType.Size = new System.Drawing.Size(31, 13);
            this.lbl_empType.TabIndex = 14;
            this.lbl_empType.Text = "Type";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(13, 259);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(45, 13);
            this.lbl_address.TabIndex = 13;
            this.lbl_address.Text = "Address";
            // 
            // lbl_mobileNo
            // 
            this.lbl_mobileNo.AutoSize = true;
            this.lbl_mobileNo.Location = new System.Drawing.Point(13, 387);
            this.lbl_mobileNo.Name = "lbl_mobileNo";
            this.lbl_mobileNo.Size = new System.Drawing.Size(38, 13);
            this.lbl_mobileNo.TabIndex = 12;
            this.lbl_mobileNo.Text = "Mobile";
            // 
            // lbl_homePhone
            // 
            this.lbl_homePhone.AutoSize = true;
            this.lbl_homePhone.Location = new System.Drawing.Point(13, 351);
            this.lbl_homePhone.Name = "lbl_homePhone";
            this.lbl_homePhone.Size = new System.Drawing.Size(69, 13);
            this.lbl_homePhone.TabIndex = 11;
            this.lbl_homePhone.Text = "Home Phone";
            // 
            // lbl_pinCode
            // 
            this.lbl_pinCode.AutoSize = true;
            this.lbl_pinCode.Location = new System.Drawing.Point(13, 317);
            this.lbl_pinCode.Name = "lbl_pinCode";
            this.lbl_pinCode.Size = new System.Drawing.Size(50, 13);
            this.lbl_pinCode.TabIndex = 10;
            this.lbl_pinCode.Text = "Pin Code";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(13, 153);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 9;
            this.lbl_gender.Text = "Gender";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdl_gendel_f);
            this.panel2.Controls.Add(this.rdl_gender_m);
            this.panel2.Location = new System.Drawing.Point(103, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 32);
            this.panel2.TabIndex = 8;
            // 
            // rdl_gendel_f
            // 
            this.rdl_gendel_f.AutoSize = true;
            this.rdl_gendel_f.Location = new System.Drawing.Point(87, 12);
            this.rdl_gendel_f.Name = "rdl_gendel_f";
            this.rdl_gendel_f.Size = new System.Drawing.Size(59, 17);
            this.rdl_gendel_f.TabIndex = 1;
            this.rdl_gendel_f.TabStop = true;
            this.rdl_gendel_f.Text = "Female";
            this.rdl_gendel_f.UseVisualStyleBackColor = true;
            // 
            // rdl_gender_m
            // 
            this.rdl_gender_m.AutoSize = true;
            this.rdl_gender_m.Location = new System.Drawing.Point(3, 12);
            this.rdl_gender_m.Name = "rdl_gender_m";
            this.rdl_gender_m.Size = new System.Drawing.Size(48, 17);
            this.rdl_gender_m.TabIndex = 0;
            this.rdl_gender_m.TabStop = true;
            this.rdl_gender_m.Text = "Male";
            this.rdl_gender_m.UseVisualStyleBackColor = true;
            // 
            // txt_petName
            // 
            this.txt_petName.Location = new System.Drawing.Point(103, 115);
            this.txt_petName.Name = "txt_petName";
            this.txt_petName.Size = new System.Drawing.Size(188, 20);
            this.txt_petName.TabIndex = 7;
            // 
            // lbl_petName
            // 
            this.lbl_petName.AutoSize = true;
            this.lbl_petName.Location = new System.Drawing.Point(13, 122);
            this.lbl_petName.Name = "lbl_petName";
            this.lbl_petName.Size = new System.Drawing.Size(54, 13);
            this.lbl_petName.TabIndex = 6;
            this.lbl_petName.Text = "Pet Name";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(103, 80);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(188, 20);
            this.txt_lastName.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txt_rto);
            this.panel3.Controls.Add(this.txt_validity);
            this.panel3.Controls.Add(this.txt_dlno);
            this.panel3.Controls.Add(this.lbl_upload_dl);
            this.panel3.Controls.Add(this.lbl_filename_dl);
            this.panel3.Controls.Add(this.lbl_rto);
            this.panel3.Controls.Add(this.lbl_dlno);
            this.panel3.Controls.Add(this.lbl_dlTypes);
            this.panel3.Location = new System.Drawing.Point(355, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 113);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chk_dlTypes);
            this.panel4.Location = new System.Drawing.Point(144, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 19);
            this.panel4.TabIndex = 46;
            // 
            // chk_dlTypes
            // 
            this.chk_dlTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_dlTypes.ColumnWidth = 70;
            this.chk_dlTypes.FormattingEnabled = true;
            this.chk_dlTypes.Items.AddRange(new object[] {
            "HPMV",
            "HTV",
            "LMV"});
            this.chk_dlTypes.Location = new System.Drawing.Point(3, 0);
            this.chk_dlTypes.MultiColumn = true;
            this.chk_dlTypes.Name = "chk_dlTypes";
            this.chk_dlTypes.Size = new System.Drawing.Size(188, 19);
            this.chk_dlTypes.TabIndex = 46;
            // 
            // txt_rto
            // 
            this.txt_rto.Location = new System.Drawing.Point(147, 87);
            this.txt_rto.Name = "txt_rto";
            this.txt_rto.Size = new System.Drawing.Size(188, 20);
            this.txt_rto.TabIndex = 45;
            // 
            // txt_validity
            // 
            this.txt_validity.Location = new System.Drawing.Point(147, 61);
            this.txt_validity.Name = "txt_validity";
            this.txt_validity.Size = new System.Drawing.Size(188, 20);
            this.txt_validity.TabIndex = 44;
            // 
            // txt_dlno
            // 
            this.txt_dlno.Location = new System.Drawing.Point(147, 9);
            this.txt_dlno.Name = "txt_dlno";
            this.txt_dlno.Size = new System.Drawing.Size(188, 20);
            this.txt_dlno.TabIndex = 42;
            // 
            // lbl_upload_dl
            // 
            this.lbl_upload_dl.AutoSize = true;
            this.lbl_upload_dl.Location = new System.Drawing.Point(355, 12);
            this.lbl_upload_dl.Name = "lbl_upload_dl";
            this.lbl_upload_dl.Size = new System.Drawing.Size(41, 13);
            this.lbl_upload_dl.TabIndex = 42;
            this.lbl_upload_dl.TabStop = true;
            this.lbl_upload_dl.Text = "Upload";
            // 
            // lbl_filename_dl
            // 
            this.lbl_filename_dl.AutoSize = true;
            this.lbl_filename_dl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_filename_dl.Location = new System.Drawing.Point(406, 12);
            this.lbl_filename_dl.Name = "lbl_filename_dl";
            this.lbl_filename_dl.Size = new System.Drawing.Size(61, 13);
            this.lbl_filename_dl.TabIndex = 40;
            this.lbl_filename_dl.Text = "<file name>";
            // 
            // lbl_rto
            // 
            this.lbl_rto.AutoSize = true;
            this.lbl_rto.Location = new System.Drawing.Point(92, 87);
            this.lbl_rto.Name = "lbl_rto";
            this.lbl_rto.Size = new System.Drawing.Size(30, 13);
            this.lbl_rto.TabIndex = 27;
            this.lbl_rto.Text = "RTO";
            // 
            // lbl_dlno
            // 
            this.lbl_dlno.AutoSize = true;
            this.lbl_dlno.Location = new System.Drawing.Point(94, 12);
            this.lbl_dlno.Name = "lbl_dlno";
            this.lbl_dlno.Size = new System.Drawing.Size(28, 13);
            this.lbl_dlno.TabIndex = 30;
            this.lbl_dlno.Text = "DL#";
            // 
            // lbl_dlTypes
            // 
            this.lbl_dlTypes.AutoSize = true;
            this.lbl_dlTypes.Location = new System.Drawing.Point(92, 38);
            this.lbl_dlTypes.Name = "lbl_dlTypes";
            this.lbl_dlTypes.Size = new System.Drawing.Size(36, 13);
            this.lbl_dlTypes.TabIndex = 29;
            this.lbl_dlTypes.Text = "Types";
            // 
            // uc_AddEmpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Name = "uc_AddEmpl";
            this.Size = new System.Drawing.Size(823, 489);
            this.Load += new System.EventHandler(this.uc_AddEmpl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_pinCode;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.ComboBox ddl_empType;
        private System.Windows.Forms.Label lbl_empType;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_mobileNo;
        private System.Windows.Forms.Label lbl_homePhone;
        private System.Windows.Forms.Label lbl_pinCode;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdl_gendel_f;
        private System.Windows.Forms.RadioButton rdl_gender_m;
        private System.Windows.Forms.TextBox txt_petName;
        private System.Windows.Forms.Label lbl_petName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label lbl_aadhaar;
        private System.Windows.Forms.TextBox txt_mobileNo;
        private System.Windows.Forms.TextBox txt_homePhone;
        private System.Windows.Forms.TextBox txt_experience;
        private System.Windows.Forms.Label lbl_dlno;
        private System.Windows.Forms.Label lbl_dlTypes;
        private System.Windows.Forms.Label lbl_validity;
        private System.Windows.Forms.Label lbl_experience;
        private System.Windows.Forms.Label lbl_otherDetails;
        private System.Windows.Forms.Label lbl_attributes;
        private System.Windows.Forms.Label lbl_addressProof;
        private System.Windows.Forms.Label lbl_drivingLicence;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_rto;
        private System.Windows.Forms.Label lbl_filename_add;
        private System.Windows.Forms.Label lbl_filename_uid;
        private System.Windows.Forms.TextBox txt_addressProof;
        private System.Windows.Forms.TextBox txt_aadhaar;
        private System.Windows.Forms.TextBox txt_otherDetails;
        private System.Windows.Forms.TextBox txt_attributes;
        private System.Windows.Forms.Label lbl_filename_dl;
        private System.Windows.Forms.LinkLabel lbl_upload_add;
        private System.Windows.Forms.LinkLabel lbl_upload_uid;
        private System.Windows.Forms.TextBox txt_rto;
        private System.Windows.Forms.TextBox txt_validity;
        private System.Windows.Forms.TextBox txt_dlno;
        private System.Windows.Forms.LinkLabel lbl_upload_dl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckedListBox chk_dlTypes;
        private System.Windows.Forms.CheckBox chk_prefill;
        private System.Windows.Forms.ComboBox ddl_designation;
        private System.Windows.Forms.Label label1;
    }
}
