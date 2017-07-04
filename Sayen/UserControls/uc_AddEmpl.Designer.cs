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
            this.chk_dlTypes = new System.Windows.Forms.CheckedListBox();
            this.txt_rto = new System.Windows.Forms.TextBox();
            this.txt_dlno = new System.Windows.Forms.TextBox();
            this.lbl_upload_dl = new System.Windows.Forms.LinkLabel();
            this.lbl_rto = new System.Windows.Forms.Label();
            this.lbl_dlno = new System.Windows.Forms.Label();
            this.lbl_dlTypes = new System.Windows.Forms.Label();
            this.lbl_filename_add = new System.Windows.Forms.Label();
            this.lbl_filename_dl = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.lbl_petName = new System.Windows.Forms.Label();
            this.txt_petName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdl_gendel_f = new System.Windows.Forms.RadioButton();
            this.rdl_gender_m = new System.Windows.Forms.RadioButton();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_pinCode = new System.Windows.Forms.Label();
            this.lbl_homePhone = new System.Windows.Forms.Label();
            this.lbl_mobileNo = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_empType = new System.Windows.Forms.Label();
            this.ddl_empType = new System.Windows.Forms.ComboBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_pinCode = new System.Windows.Forms.TextBox();
            this.txt_homePhone = new System.Windows.Forms.TextBox();
            this.txt_mobileNo = new System.Windows.Forms.TextBox();
            this.lbl_aadhaar = new System.Windows.Forms.Label();
            this.lbl_drivingLicence = new System.Windows.Forms.Label();
            this.lbl_addressProof = new System.Windows.Forms.Label();
            this.lbl_attributes = new System.Windows.Forms.Label();
            this.lbl_otherDetails = new System.Windows.Forms.Label();
            this.lbl_experience = new System.Windows.Forms.Label();
            this.txt_experience = new System.Windows.Forms.TextBox();
            this.txt_attributes = new System.Windows.Forms.TextBox();
            this.txt_aadhaar = new System.Windows.Forms.TextBox();
            this.txt_addressProof = new System.Windows.Forms.TextBox();
            this.lbl_filename_uid = new System.Windows.Forms.Label();
            this.lbl_upload_uid = new System.Windows.Forms.LinkLabel();
            this.lbl_upload_add = new System.Windows.Forms.LinkLabel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.chk_prefill = new System.Windows.Forms.CheckBox();
            this.lbl_designation = new System.Windows.Forms.Label();
            this.ddl_designation = new System.Windows.Forms.ComboBox();
            this.lbl_validity = new System.Windows.Forms.Label();
            this.txt_otherDetails = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_dlTypes
            // 
            this.chk_dlTypes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_dlTypes.ColumnWidth = 70;
            this.chk_dlTypes.FormattingEnabled = true;
            this.chk_dlTypes.Items.AddRange(new object[] {
            "HPMV",
            "HTV",
            "LMV"});
            this.chk_dlTypes.Location = new System.Drawing.Point(90, 103);
            this.chk_dlTypes.MultiColumn = true;
            this.chk_dlTypes.Name = "chk_dlTypes";
            this.chk_dlTypes.Size = new System.Drawing.Size(200, 19);
            this.chk_dlTypes.TabIndex = 46;
            this.chk_dlTypes.SelectedIndexChanged += new System.EventHandler(this.chk_dlTypes_SelectedIndexChanged);
            // 
            // txt_rto
            // 
            this.txt_rto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_rto.Location = new System.Drawing.Point(90, 129);
            this.txt_rto.Name = "txt_rto";
            this.txt_rto.Size = new System.Drawing.Size(200, 20);
            this.txt_rto.TabIndex = 45;
            this.txt_rto.TextChanged += new System.EventHandler(this.txt_rto_TextChanged);
            // 
            // txt_dlno
            // 
            this.txt_dlno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_dlno.Location = new System.Drawing.Point(90, 77);
            this.txt_dlno.Name = "txt_dlno";
            this.txt_dlno.Size = new System.Drawing.Size(200, 20);
            this.txt_dlno.TabIndex = 42;
            this.txt_dlno.TextChanged += new System.EventHandler(this.txt_dlno_TextChanged);
            // 
            // lbl_upload_dl
            // 
            this.lbl_upload_dl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_upload_dl.AutoSize = true;
            this.lbl_upload_dl.Location = new System.Drawing.Point(308, 80);
            this.lbl_upload_dl.Name = "lbl_upload_dl";
            this.lbl_upload_dl.Size = new System.Drawing.Size(41, 13);
            this.lbl_upload_dl.TabIndex = 42;
            this.lbl_upload_dl.TabStop = true;
            this.lbl_upload_dl.Text = "Upload";
            this.lbl_upload_dl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_upload_dl_LinkClicked);
            // 
            // lbl_rto
            // 
            this.lbl_rto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_rto.AutoSize = true;
            this.lbl_rto.Location = new System.Drawing.Point(54, 133);
            this.lbl_rto.Name = "lbl_rto";
            this.lbl_rto.Size = new System.Drawing.Size(30, 13);
            this.lbl_rto.TabIndex = 27;
            this.lbl_rto.Text = "RTO";
            this.lbl_rto.Click += new System.EventHandler(this.lbl_rto_Click);
            // 
            // lbl_dlno
            // 
            this.lbl_dlno.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_dlno.AutoSize = true;
            this.lbl_dlno.Location = new System.Drawing.Point(56, 80);
            this.lbl_dlno.Name = "lbl_dlno";
            this.lbl_dlno.Size = new System.Drawing.Size(28, 13);
            this.lbl_dlno.TabIndex = 30;
            this.lbl_dlno.Text = "DL#";
            this.lbl_dlno.Click += new System.EventHandler(this.lbl_dlno_Click);
            // 
            // lbl_dlTypes
            // 
            this.lbl_dlTypes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_dlTypes.AutoSize = true;
            this.lbl_dlTypes.Location = new System.Drawing.Point(48, 106);
            this.lbl_dlTypes.Name = "lbl_dlTypes";
            this.lbl_dlTypes.Size = new System.Drawing.Size(36, 13);
            this.lbl_dlTypes.TabIndex = 29;
            this.lbl_dlTypes.Text = "Types";
            this.lbl_dlTypes.Click += new System.EventHandler(this.lbl_dlTypes_Click);
            // 
            // lbl_filename_add
            // 
            this.lbl_filename_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_filename_add.AutoSize = true;
            this.lbl_filename_add.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_filename_add.Location = new System.Drawing.Point(371, 37);
            this.lbl_filename_add.Name = "lbl_filename_add";
            this.lbl_filename_add.Size = new System.Drawing.Size(61, 13);
            this.lbl_filename_add.TabIndex = 39;
            this.lbl_filename_add.Text = "<file name>";
            this.lbl_filename_add.Click += new System.EventHandler(this.lbl_filename_add_Click);
            // 
            // lbl_filename_dl
            // 
            this.lbl_filename_dl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_filename_dl.AutoSize = true;
            this.lbl_filename_dl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_filename_dl.Location = new System.Drawing.Point(371, 80);
            this.lbl_filename_dl.Name = "lbl_filename_dl";
            this.lbl_filename_dl.Size = new System.Drawing.Size(61, 13);
            this.lbl_filename_dl.TabIndex = 40;
            this.lbl_filename_dl.Text = "<file name>";
            this.lbl_filename_dl.Click += new System.EventHandler(this.lbl_filename_dl_Click);
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(9, 6);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_firstName.TabIndex = 2;
            this.lbl_firstName.Text = "First Name";
            this.lbl_firstName.Click += new System.EventHandler(this.lbl_firstName_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(300, 39);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(151, 25);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add Employee";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(8, 32);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_lastName.TabIndex = 4;
            this.lbl_lastName.Text = "Last Name";
            this.lbl_lastName.Click += new System.EventHandler(this.lbl_lastName_Click);
            // 
            // txt_firstName
            // 
            this.txt_firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_firstName.Location = new System.Drawing.Point(91, 3);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(188, 20);
            this.txt_firstName.TabIndex = 1;
            this.txt_firstName.TextChanged += new System.EventHandler(this.txt_firstName_TextChanged);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_lastName.Location = new System.Drawing.Point(91, 29);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(188, 20);
            this.txt_lastName.TabIndex = 5;
            this.txt_lastName.TextChanged += new System.EventHandler(this.txt_lastName_TextChanged);
            // 
            // lbl_petName
            // 
            this.lbl_petName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_petName.AutoSize = true;
            this.lbl_petName.Location = new System.Drawing.Point(10, 58);
            this.lbl_petName.Name = "lbl_petName";
            this.lbl_petName.Size = new System.Drawing.Size(54, 13);
            this.lbl_petName.TabIndex = 6;
            this.lbl_petName.Text = "Pet Name";
            this.lbl_petName.Click += new System.EventHandler(this.lbl_petName_Click);
            // 
            // txt_petName
            // 
            this.txt_petName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_petName.Location = new System.Drawing.Point(91, 54);
            this.txt_petName.Name = "txt_petName";
            this.txt_petName.Size = new System.Drawing.Size(188, 20);
            this.txt_petName.TabIndex = 7;
            this.txt_petName.TextChanged += new System.EventHandler(this.txt_petName_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.rdl_gendel_f);
            this.panel2.Controls.Add(this.rdl_gender_m);
            this.panel2.Location = new System.Drawing.Point(91, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 30);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.rdl_gendel_f.CheckedChanged += new System.EventHandler(this.rdl_gendel_f_CheckedChanged);
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
            this.rdl_gender_m.CheckedChanged += new System.EventHandler(this.rdl_gender_m_CheckedChanged);
            // 
            // lbl_gender
            // 
            this.lbl_gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(16, 89);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 9;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.Click += new System.EventHandler(this.lbl_gender_Click);
            // 
            // lbl_pinCode
            // 
            this.lbl_pinCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pinCode.AutoSize = true;
            this.lbl_pinCode.Location = new System.Drawing.Point(12, 217);
            this.lbl_pinCode.Name = "lbl_pinCode";
            this.lbl_pinCode.Size = new System.Drawing.Size(50, 13);
            this.lbl_pinCode.TabIndex = 10;
            this.lbl_pinCode.Text = "Pin Code";
            this.lbl_pinCode.Click += new System.EventHandler(this.lbl_pinCode_Click);
            // 
            // lbl_homePhone
            // 
            this.lbl_homePhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_homePhone.AutoSize = true;
            this.lbl_homePhone.Location = new System.Drawing.Point(3, 245);
            this.lbl_homePhone.Name = "lbl_homePhone";
            this.lbl_homePhone.Size = new System.Drawing.Size(69, 13);
            this.lbl_homePhone.TabIndex = 11;
            this.lbl_homePhone.Text = "Home Phone";
            this.lbl_homePhone.Click += new System.EventHandler(this.lbl_homePhone_Click);
            // 
            // lbl_mobileNo
            // 
            this.lbl_mobileNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_mobileNo.AutoSize = true;
            this.lbl_mobileNo.Location = new System.Drawing.Point(18, 275);
            this.lbl_mobileNo.Name = "lbl_mobileNo";
            this.lbl_mobileNo.Size = new System.Drawing.Size(38, 13);
            this.lbl_mobileNo.TabIndex = 12;
            this.lbl_mobileNo.Text = "Mobile";
            this.lbl_mobileNo.Click += new System.EventHandler(this.lbl_mobileNo_Click);
            // 
            // lbl_address
            // 
            this.lbl_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(15, 181);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(45, 13);
            this.lbl_address.TabIndex = 13;
            this.lbl_address.Text = "Address";
            this.lbl_address.Click += new System.EventHandler(this.lbl_address_Click);
            // 
            // lbl_empType
            // 
            this.lbl_empType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_empType.AutoSize = true;
            this.lbl_empType.Location = new System.Drawing.Point(22, 120);
            this.lbl_empType.Name = "lbl_empType";
            this.lbl_empType.Size = new System.Drawing.Size(31, 13);
            this.lbl_empType.TabIndex = 14;
            this.lbl_empType.Text = "Type";
            this.lbl_empType.Click += new System.EventHandler(this.lbl_empType_Click);
            // 
            // ddl_empType
            // 
            this.ddl_empType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddl_empType.FormattingEnabled = true;
            this.ddl_empType.Location = new System.Drawing.Point(93, 117);
            this.ddl_empType.Name = "ddl_empType";
            this.ddl_empType.Size = new System.Drawing.Size(185, 21);
            this.ddl_empType.TabIndex = 15;
            this.ddl_empType.SelectedIndexChanged += new System.EventHandler(this.ddl_empType_SelectedIndexChanged);
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_address.Location = new System.Drawing.Point(91, 169);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(188, 38);
            this.txt_address.TabIndex = 16;
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            // 
            // txt_pinCode
            // 
            this.txt_pinCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pinCode.Location = new System.Drawing.Point(91, 213);
            this.txt_pinCode.Name = "txt_pinCode";
            this.txt_pinCode.Size = new System.Drawing.Size(188, 20);
            this.txt_pinCode.TabIndex = 17;
            this.txt_pinCode.TextChanged += new System.EventHandler(this.txt_pinCode_TextChanged);
            // 
            // txt_homePhone
            // 
            this.txt_homePhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_homePhone.Location = new System.Drawing.Point(91, 241);
            this.txt_homePhone.Name = "txt_homePhone";
            this.txt_homePhone.Size = new System.Drawing.Size(188, 20);
            this.txt_homePhone.TabIndex = 18;
            this.txt_homePhone.TextChanged += new System.EventHandler(this.txt_homePhone_TextChanged);
            // 
            // txt_mobileNo
            // 
            this.txt_mobileNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_mobileNo.Location = new System.Drawing.Point(91, 271);
            this.txt_mobileNo.Name = "txt_mobileNo";
            this.txt_mobileNo.Size = new System.Drawing.Size(188, 20);
            this.txt_mobileNo.TabIndex = 19;
            this.txt_mobileNo.TextChanged += new System.EventHandler(this.txt_mobileNo_TextChanged);
            // 
            // lbl_aadhaar
            // 
            this.lbl_aadhaar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_aadhaar.AutoSize = true;
            this.lbl_aadhaar.Location = new System.Drawing.Point(11, 8);
            this.lbl_aadhaar.Name = "lbl_aadhaar";
            this.lbl_aadhaar.Size = new System.Drawing.Size(64, 13);
            this.lbl_aadhaar.TabIndex = 20;
            this.lbl_aadhaar.Text = "Aadhaar No";
            this.lbl_aadhaar.Click += new System.EventHandler(this.lbl_aadhaar_Click);
            // 
            // lbl_drivingLicence
            // 
            this.lbl_drivingLicence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_drivingLicence.AutoSize = true;
            this.lbl_drivingLicence.Location = new System.Drawing.Point(3, 59);
            this.lbl_drivingLicence.Name = "lbl_drivingLicence";
            this.lbl_drivingLicence.Size = new System.Drawing.Size(81, 13);
            this.lbl_drivingLicence.TabIndex = 21;
            this.lbl_drivingLicence.Text = "Driving Licence";
            this.lbl_drivingLicence.Click += new System.EventHandler(this.lbl_drivingLicence_Click);
            // 
            // lbl_addressProof
            // 
            this.lbl_addressProof.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_addressProof.AutoSize = true;
            this.lbl_addressProof.Location = new System.Drawing.Point(7, 37);
            this.lbl_addressProof.Name = "lbl_addressProof";
            this.lbl_addressProof.Size = new System.Drawing.Size(73, 13);
            this.lbl_addressProof.TabIndex = 22;
            this.lbl_addressProof.Text = "Address Proof";
            this.lbl_addressProof.Click += new System.EventHandler(this.lbl_addressProof_Click);
            // 
            // lbl_attributes
            // 
            this.lbl_attributes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_attributes.AutoSize = true;
            this.lbl_attributes.Location = new System.Drawing.Point(17, 76);
            this.lbl_attributes.Name = "lbl_attributes";
            this.lbl_attributes.Size = new System.Drawing.Size(51, 13);
            this.lbl_attributes.TabIndex = 23;
            this.lbl_attributes.Text = "Attributes";
            this.lbl_attributes.Click += new System.EventHandler(this.lbl_attributes_Click);
            // 
            // lbl_otherDetails
            // 
            this.lbl_otherDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_otherDetails.AutoSize = true;
            this.lbl_otherDetails.Location = new System.Drawing.Point(9, 143);
            this.lbl_otherDetails.Name = "lbl_otherDetails";
            this.lbl_otherDetails.Size = new System.Drawing.Size(68, 13);
            this.lbl_otherDetails.TabIndex = 24;
            this.lbl_otherDetails.Text = "Other Details";
            this.lbl_otherDetails.Click += new System.EventHandler(this.lbl_otherDetails_Click);
            // 
            // lbl_experience
            // 
            this.lbl_experience.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_experience.AutoSize = true;
            this.lbl_experience.Location = new System.Drawing.Point(13, 19);
            this.lbl_experience.Name = "lbl_experience";
            this.lbl_experience.Size = new System.Drawing.Size(60, 13);
            this.lbl_experience.TabIndex = 26;
            this.lbl_experience.Text = "Experience";
            this.lbl_experience.Click += new System.EventHandler(this.lbl_experience_Click);
            // 
            // txt_experience
            // 
            this.txt_experience.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_experience.Location = new System.Drawing.Point(93, 119);
            this.txt_experience.Multiline = true;
            this.txt_experience.Name = "txt_experience";
            this.txt_experience.Size = new System.Drawing.Size(332, 61);
            this.txt_experience.TabIndex = 32;
            this.txt_experience.TextChanged += new System.EventHandler(this.txt_experience_TextChanged);
            // 
            // txt_attributes
            // 
            this.txt_attributes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_attributes.Location = new System.Drawing.Point(93, 3);
            this.txt_attributes.Multiline = true;
            this.txt_attributes.Name = "txt_attributes";
            this.txt_attributes.Size = new System.Drawing.Size(332, 46);
            this.txt_attributes.TabIndex = 34;
            this.txt_attributes.TextChanged += new System.EventHandler(this.txt_attributes_TextChanged);
            // 
            // txt_aadhaar
            // 
            this.txt_aadhaar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_aadhaar.Location = new System.Drawing.Point(90, 5);
            this.txt_aadhaar.Name = "txt_aadhaar";
            this.txt_aadhaar.Size = new System.Drawing.Size(200, 20);
            this.txt_aadhaar.TabIndex = 36;
            this.txt_aadhaar.TextChanged += new System.EventHandler(this.txt_aadhaar_TextChanged);
            // 
            // txt_addressProof
            // 
            this.txt_addressProof.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_addressProof.Location = new System.Drawing.Point(90, 33);
            this.txt_addressProof.Name = "txt_addressProof";
            this.txt_addressProof.Size = new System.Drawing.Size(200, 20);
            this.txt_addressProof.TabIndex = 37;
            this.txt_addressProof.TextChanged += new System.EventHandler(this.txt_addressProof_TextChanged);
            // 
            // lbl_filename_uid
            // 
            this.lbl_filename_uid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_filename_uid.AutoSize = true;
            this.lbl_filename_uid.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_filename_uid.Location = new System.Drawing.Point(371, 8);
            this.lbl_filename_uid.Name = "lbl_filename_uid";
            this.lbl_filename_uid.Size = new System.Drawing.Size(61, 13);
            this.lbl_filename_uid.TabIndex = 38;
            this.lbl_filename_uid.Text = "<file name>";
            this.lbl_filename_uid.Click += new System.EventHandler(this.lbl_filename_uid_Click);
            // 
            // lbl_upload_uid
            // 
            this.lbl_upload_uid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_upload_uid.AutoSize = true;
            this.lbl_upload_uid.Location = new System.Drawing.Point(308, 8);
            this.lbl_upload_uid.Name = "lbl_upload_uid";
            this.lbl_upload_uid.Size = new System.Drawing.Size(41, 13);
            this.lbl_upload_uid.TabIndex = 40;
            this.lbl_upload_uid.TabStop = true;
            this.lbl_upload_uid.Text = "Upload";
            this.lbl_upload_uid.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_upload_uid_LinkClicked);
            // 
            // lbl_upload_add
            // 
            this.lbl_upload_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_upload_add.AutoSize = true;
            this.lbl_upload_add.Location = new System.Drawing.Point(308, 37);
            this.lbl_upload_add.Name = "lbl_upload_add";
            this.lbl_upload_add.Size = new System.Drawing.Size(41, 13);
            this.lbl_upload_add.TabIndex = 41;
            this.lbl_upload_add.TabStop = true;
            this.lbl_upload_add.Text = "Upload";
            this.lbl_upload_add.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_upload_add_LinkClicked);
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(122, 4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk_prefill
            // 
            this.chk_prefill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chk_prefill.AutoSize = true;
            this.chk_prefill.BackColor = System.Drawing.Color.PowderBlue;
            this.chk_prefill.Location = new System.Drawing.Point(699, 43);
            this.chk_prefill.Name = "chk_prefill";
            this.chk_prefill.Size = new System.Drawing.Size(51, 17);
            this.chk_prefill.TabIndex = 42;
            this.chk_prefill.Text = "Prefill";
            this.chk_prefill.UseVisualStyleBackColor = false;
            this.chk_prefill.CheckedChanged += new System.EventHandler(this.chk_prefill_CheckedChanged);
            // 
            // lbl_designation
            // 
            this.lbl_designation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_designation.AutoSize = true;
            this.lbl_designation.Location = new System.Drawing.Point(6, 146);
            this.lbl_designation.Name = "lbl_designation";
            this.lbl_designation.Size = new System.Drawing.Size(63, 13);
            this.lbl_designation.TabIndex = 43;
            this.lbl_designation.Text = "Designation";
            this.lbl_designation.Click += new System.EventHandler(this.lbl_designation_Click);
            // 
            // ddl_designation
            // 
            this.ddl_designation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddl_designation.Enabled = false;
            this.ddl_designation.FormattingEnabled = true;
            this.ddl_designation.Location = new System.Drawing.Point(93, 143);
            this.ddl_designation.Name = "ddl_designation";
            this.ddl_designation.Size = new System.Drawing.Size(185, 21);
            this.ddl_designation.TabIndex = 44;
            this.ddl_designation.SelectedIndexChanged += new System.EventHandler(this.ddl_designation_SelectedIndexChanged);
            // 
            // lbl_validity
            // 
            this.lbl_validity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_validity.AutoSize = true;
            this.lbl_validity.Location = new System.Drawing.Point(44, 161);
            this.lbl_validity.Name = "lbl_validity";
            this.lbl_validity.Size = new System.Drawing.Size(40, 13);
            this.lbl_validity.TabIndex = 28;
            this.lbl_validity.Text = "Validity";
            this.lbl_validity.Click += new System.EventHandler(this.lbl_validity_Click);
            // 
            // txt_otherDetails
            // 
            this.txt_otherDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_otherDetails.Location = new System.Drawing.Point(93, 55);
            this.txt_otherDetails.Multiline = true;
            this.txt_otherDetails.Name = "txt_otherDetails";
            this.txt_otherDetails.Size = new System.Drawing.Size(332, 54);
            this.txt_otherDetails.TabIndex = 35;
            this.txt_otherDetails.TextChanged += new System.EventHandler(this.txt_otherDetails_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 516);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 45;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txt_firstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_firstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_lastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_lastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ddl_designation, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_petName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_petName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_empType, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_gender, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_designation, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ddl_empType, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_address, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_address, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_pinCode, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_homePhone, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_mobileNo, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pinCode, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbl_homePhone, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbl_mobileNo, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 297);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.Controls.Add(this.chk_dlTypes, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_aadhaar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_aadhaar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_upload_uid, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_filename_dl, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_dlTypes, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_filename_uid, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_addressProof, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_upload_dl, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_addressProof, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_upload_add, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_filename_add, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_drivingLicence, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_dlno, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txt_dlno, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_rto, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txt_rto, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lbl_validity, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(342, 81);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(434, 182);
            this.tableLayoutPanel2.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-mm-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.90741F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.09259F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_experience, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_attributes, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_otherDetails, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_attributes, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_experience, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbl_otherDetails, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(344, 269);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(432, 186);
            this.tableLayoutPanel3.TabIndex = 48;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_title, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.chk_prefill, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(23, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.83333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.16667F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(753, 72);
            this.tableLayoutPanel4.TabIndex = 49;
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(22, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 50;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btn_reset, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_submit, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(569, 461);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 30);
            this.tableLayoutPanel5.TabIndex = 51;
            // 
            // uc_AddEmpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Orange;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "uc_AddEmpl";
            this.Size = new System.Drawing.Size(856, 534);
            this.Load += new System.EventHandler(this.uc_AddEmpl_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox chk_dlTypes;
        private System.Windows.Forms.TextBox txt_rto;
        private System.Windows.Forms.TextBox txt_dlno;
        private System.Windows.Forms.LinkLabel lbl_upload_dl;
        private System.Windows.Forms.Label lbl_filename_dl;
        private System.Windows.Forms.Label lbl_rto;
        private System.Windows.Forms.Label lbl_dlno;
        private System.Windows.Forms.Label lbl_dlTypes;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label lbl_petName;
        private System.Windows.Forms.TextBox txt_petName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdl_gendel_f;
        private System.Windows.Forms.RadioButton rdl_gender_m;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_pinCode;
        private System.Windows.Forms.Label lbl_homePhone;
        private System.Windows.Forms.Label lbl_mobileNo;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_empType;
        private System.Windows.Forms.ComboBox ddl_empType;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_pinCode;
        private System.Windows.Forms.TextBox txt_homePhone;
        private System.Windows.Forms.TextBox txt_mobileNo;
        private System.Windows.Forms.Label lbl_aadhaar;
        private System.Windows.Forms.Label lbl_drivingLicence;
        private System.Windows.Forms.Label lbl_addressProof;
        private System.Windows.Forms.Label lbl_attributes;
        private System.Windows.Forms.Label lbl_otherDetails;
        private System.Windows.Forms.Label lbl_experience;
        private System.Windows.Forms.TextBox txt_experience;
        private System.Windows.Forms.TextBox txt_attributes;
        private System.Windows.Forms.TextBox txt_aadhaar;
        private System.Windows.Forms.TextBox txt_addressProof;
        private System.Windows.Forms.Label lbl_filename_uid;
        private System.Windows.Forms.Label lbl_filename_add;
        private System.Windows.Forms.LinkLabel lbl_upload_uid;
        private System.Windows.Forms.LinkLabel lbl_upload_add;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.CheckBox chk_prefill;
        private System.Windows.Forms.Label lbl_designation;
        private System.Windows.Forms.ComboBox ddl_designation;
        private System.Windows.Forms.Label lbl_validity;
        private System.Windows.Forms.TextBox txt_otherDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}
