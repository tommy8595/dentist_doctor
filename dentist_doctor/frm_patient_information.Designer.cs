namespace dentist_doctor
{
    partial class frm_patient_information
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TC = new System.Windows.Forms.TabControl();
            this.tabGI = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fungetPatientByIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentistDataSet = new dentist_doctor.DentistDataSet();
            this.btnShowPic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fungetPatientImageByIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKhLname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKhFname = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Reg_Phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Reg_Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Reg_Job = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMd = new System.Windows.Forms.TabPage();
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabXray = new System.Windows.Forms.TabPage();
            this.dgvOne = new System.Windows.Forms.DataGridView();
            this.patxraydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patxraycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xray_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fungetPatientXrayByPatIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabDiag = new System.Windows.Forms.TabPage();
            this.tabTP = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fungetAllPatientServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPs = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.psdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psdesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fungetPrescriptionByPatIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPatId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPatName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPatientDetail = new System.Windows.Forms.Button();
            this.fun_getPatientByIDTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getPatientByIDTableAdapter();
            this.fun_getPatientImageByIDTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getPatientImageByIDTableAdapter();
            this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter();
            this.fun_getPatientXrayByPatIDTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getPatientXrayByPatIDTableAdapter();
            this.fun_getAllPatientServiceTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getAllPatientServiceTableAdapter();
            this.fun_getPrescriptionByPatIDTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getPrescriptionByPatIDTableAdapter();
            this.TabTd = new System.Windows.Forms.TabPage();
            this.tpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fungetPatientTdByPatIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fun_getPatientTdByPatIDTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getPatientTdByPatIDTableAdapter();
            this.TC.SuspendLayout();
            this.tabGI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientByIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientImageByIDBindingSource)).BeginInit();
            this.tabMd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource)).BeginInit();
            this.tabXray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientXrayByPatIDBindingSource)).BeginInit();
            this.tabTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllPatientServiceBindingSource)).BeginInit();
            this.tabPs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPrescriptionByPatIDBindingSource)).BeginInit();
            this.TabTd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientTdByPatIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TC
            // 
            this.TC.Controls.Add(this.tabGI);
            this.TC.Controls.Add(this.tabMd);
            this.TC.Controls.Add(this.tabXray);
            this.TC.Controls.Add(this.tabDiag);
            this.TC.Controls.Add(this.tabTP);
            this.TC.Controls.Add(this.TabTd);
            this.TC.Controls.Add(this.tabPs);
            this.TC.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TC.Location = new System.Drawing.Point(12, 90);
            this.TC.Name = "TC";
            this.TC.SelectedIndex = 0;
            this.TC.Size = new System.Drawing.Size(1311, 671);
            this.TC.TabIndex = 0;
            this.TC.SelectedIndexChanged += new System.EventHandler(this.TC_SelectedIndexChanged);
            // 
            // tabGI
            // 
            this.tabGI.Controls.Add(this.label2);
            this.tabGI.Controls.Add(this.textBox1);
            this.tabGI.Controls.Add(this.btnShowPic);
            this.tabGI.Controls.Add(this.pictureBox1);
            this.tabGI.Controls.Add(this.label12);
            this.tabGI.Controls.Add(this.txtLname);
            this.tabGI.Controls.Add(this.label13);
            this.tabGI.Controls.Add(this.txtFname);
            this.tabGI.Controls.Add(this.label10);
            this.tabGI.Controls.Add(this.txtKhLname);
            this.tabGI.Controls.Add(this.label11);
            this.tabGI.Controls.Add(this.txtKhFname);
            this.tabGI.Controls.Add(this.textBox4);
            this.tabGI.Controls.Add(this.textBox3);
            this.tabGI.Controls.Add(this.textBox2);
            this.tabGI.Controls.Add(this.label9);
            this.tabGI.Controls.Add(this.txt_Reg_Phone);
            this.tabGI.Controls.Add(this.label8);
            this.tabGI.Controls.Add(this.txt_Reg_Address);
            this.tabGI.Controls.Add(this.label7);
            this.tabGI.Controls.Add(this.txt_Reg_Job);
            this.tabGI.Controls.Add(this.label6);
            this.tabGI.Controls.Add(this.label5);
            this.tabGI.Controls.Add(this.label1);
            this.tabGI.Location = new System.Drawing.Point(4, 38);
            this.tabGI.Name = "tabGI";
            this.tabGI.Padding = new System.Windows.Forms.Padding(3);
            this.tabGI.Size = new System.Drawing.Size(1303, 629);
            this.tabGI.TabIndex = 0;
            this.tabGI.Text = "General Information";
            this.tabGI.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 454);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 192;
            this.label2.Text = "កាលបរិច្ឆេទណាត់ជួប";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_app_date", true));
            this.textBox1.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(592, 452);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(418, 36);
            this.textBox1.TabIndex = 191;
            // 
            // fungetPatientByIDBindingSource
            // 
            this.fungetPatientByIDBindingSource.DataMember = "fun_getPatientByID";
            this.fungetPatientByIDBindingSource.DataSource = this.dentistDataSet;
            // 
            // dentistDataSet
            // 
            this.dentistDataSet.DataSetName = "DentistDataSet";
            this.dentistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnShowPic
            // 
            this.btnShowPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnShowPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPic.FlatAppearance.BorderSize = 0;
            this.btnShowPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPic.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPic.ForeColor = System.Drawing.Color.White;
            this.btnShowPic.Location = new System.Drawing.Point(1080, 405);
            this.btnShowPic.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowPic.Name = "btnShowPic";
            this.btnShowPic.Size = new System.Drawing.Size(87, 41);
            this.btnShowPic.TabIndex = 190;
            this.btnShowPic.Text = "បង្ហាញរូប";
            this.btnShowPic.UseVisualStyleBackColor = false;
            this.btnShowPic.Click += new System.EventHandler(this.btnShowPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.fungetPatientImageByIDBindingSource, "pat_image", true));
            this.pictureBox1.Location = new System.Drawing.Point(1061, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 189;
            this.pictureBox1.TabStop = false;
            // 
            // fungetPatientImageByIDBindingSource
            // 
            this.fungetPatientImageByIDBindingSource.DataMember = "fun_getPatientImageByID";
            this.fungetPatientImageByIDBindingSource.DataSource = this.dentistDataSet;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(450, 274);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 29);
            this.label12.TabIndex = 188;
            this.label12.Text = "ឈ្មោះ(ឡាតាំង)";
            // 
            // txtLname
            // 
            this.txtLname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_lname", true));
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(592, 275);
            this.txtLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtLname.Name = "txtLname";
            this.txtLname.ReadOnly = true;
            this.txtLname.Size = new System.Drawing.Size(418, 26);
            this.txtLname.TabIndex = 184;
            this.txtLname.Tag = "សូមបញ្ចូលឈ្មោះ(ឡាតាំង)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(57, 272);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 29);
            this.label13.TabIndex = 187;
            this.label13.Text = "ត្រកូល(ឡាតាំង)";
            // 
            // txtFname
            // 
            this.txtFname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_fname", true));
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(177, 273);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFname.Name = "txtFname";
            this.txtFname.ReadOnly = true;
            this.txtFname.Size = new System.Drawing.Size(243, 26);
            this.txtFname.TabIndex = 183;
            this.txtFname.Tag = "សូមបញ្ចូលត្រកូល(ឡាតាំង)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(450, 228);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 29);
            this.label10.TabIndex = 186;
            this.label10.Text = "ឈ្មោះ(ខ្មែរ)";
            // 
            // txtKhLname
            // 
            this.txtKhLname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_kh_lname", true));
            this.txtKhLname.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhLname.Location = new System.Drawing.Point(592, 228);
            this.txtKhLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhLname.Name = "txtKhLname";
            this.txtKhLname.ReadOnly = true;
            this.txtKhLname.Size = new System.Drawing.Size(418, 33);
            this.txtKhLname.TabIndex = 182;
            this.txtKhLname.Tag = "សូមបញ្ចូលឈ្មោះ(ខ្មែរ)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(78, 228);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 29);
            this.label11.TabIndex = 185;
            this.label11.Text = "ត្រកូល(ខ្មែរ)";
            // 
            // txtKhFname
            // 
            this.txtKhFname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_kh_fname", true));
            this.txtKhFname.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhFname.Location = new System.Drawing.Point(177, 226);
            this.txtKhFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhFname.Name = "txtKhFname";
            this.txtKhFname.ReadOnly = true;
            this.txtKhFname.Size = new System.Drawing.Size(243, 33);
            this.txtKhFname.TabIndex = 181;
            this.txtKhFname.Tag = "សូមបញ្ចូលត្រកូល(ខ្មែរ)";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_gender", true));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(177, 312);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(243, 26);
            this.textBox4.TabIndex = 180;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_birthyear", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(592, 313);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(160, 26);
            this.textBox3.TabIndex = 179;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_nation", true));
            this.textBox2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(177, 400);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(193, 36);
            this.textBox2.TabIndex = 178;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(84, 358);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 29);
            this.label9.TabIndex = 177;
            this.label9.Text = "លេខទូរស័ព្ទ";
            // 
            // txt_Reg_Phone
            // 
            this.txt_Reg_Phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_tel", true));
            this.txt_Reg_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reg_Phone.Location = new System.Drawing.Point(177, 357);
            this.txt_Reg_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Reg_Phone.Name = "txt_Reg_Phone";
            this.txt_Reg_Phone.ReadOnly = true;
            this.txt_Reg_Phone.Size = new System.Drawing.Size(348, 26);
            this.txt_Reg_Phone.TabIndex = 176;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 403);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 29);
            this.label8.TabIndex = 175;
            this.label8.Text = "អាស័យដ្ឋាន/កន្លែងធ្វើការ";
            // 
            // txt_Reg_Address
            // 
            this.txt_Reg_Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_address", true));
            this.txt_Reg_Address.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reg_Address.Location = new System.Drawing.Point(592, 401);
            this.txt_Reg_Address.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Reg_Address.Name = "txt_Reg_Address";
            this.txt_Reg_Address.ReadOnly = true;
            this.txt_Reg_Address.Size = new System.Drawing.Size(418, 36);
            this.txt_Reg_Address.TabIndex = 174;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 29);
            this.label7.TabIndex = 173;
            this.label7.Text = "សញ្ជាតិ";
            // 
            // txt_Reg_Job
            // 
            this.txt_Reg_Job.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_job", true));
            this.txt_Reg_Job.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reg_Job.Location = new System.Drawing.Point(592, 354);
            this.txt_Reg_Job.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Reg_Job.Name = "txt_Reg_Job";
            this.txt_Reg_Job.ReadOnly = true;
            this.txt_Reg_Job.Size = new System.Drawing.Size(418, 36);
            this.txt_Reg_Job.TabIndex = 172;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 359);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 29);
            this.label6.TabIndex = 171;
            this.label6.Text = "មុខរបរ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 29);
            this.label5.TabIndex = 170;
            this.label5.Text = "ភេទ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 313);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 169;
            this.label1.Text = "ឆ្នាំកំណើត";
            // 
            // tabMd
            // 
            this.tabMd.Controls.Add(this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView);
            this.tabMd.Location = new System.Drawing.Point(4, 38);
            this.tabMd.Name = "tabMd";
            this.tabMd.Padding = new System.Windows.Forms.Padding(3);
            this.tabMd.Size = new System.Drawing.Size(1303, 629);
            this.tabMd.TabIndex = 5;
            this.tabMd.Text = "MedicalHistory";
            this.tabMd.UseVisualStyleBackColor = true;
            // 
            // fun_getActiveMedicalHistoryForSpecificPaientDataGridView
            // 
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.AllowUserToAddRows = false;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.AutoGenerateColumns = false;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.md_status});
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.DataSource = this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.EnableHeadersVisualStyles = false;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.Location = new System.Drawing.Point(3, 3);
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.Name = "fun_getActiveMedicalHistoryForSpecificPaientDataGridView";
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.ReadOnly = true;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.RowTemplate.Height = 30;
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.Size = new System.Drawing.Size(1297, 623);
            this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "md_name";
            this.dataGridViewTextBoxColumn5.FillWeight = 70F;
            this.dataGridViewTextBoxColumn5.HeaderText = "ឈ្មោះប្រវត្តិវេជ្ជសាស្រ្ត";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "md_description";
            this.dataGridViewTextBoxColumn3.HeaderText = "លំអិត";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // md_status
            // 
            this.md_status.DataPropertyName = "md_status";
            this.md_status.FillWeight = 30F;
            this.md_status.HeaderText = "ស្ថានភាព";
            this.md_status.Name = "md_status";
            this.md_status.ReadOnly = true;
            // 
            // fun_getActiveMedicalHistoryForSpecificPaientBindingSource
            // 
            this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource.DataMember = "fun_getActiveMedicalHistoryForSpecificPaient";
            this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource.DataSource = this.dentistDataSet;
            // 
            // tabXray
            // 
            this.tabXray.Controls.Add(this.dgvOne);
            this.tabXray.Location = new System.Drawing.Point(4, 38);
            this.tabXray.Name = "tabXray";
            this.tabXray.Padding = new System.Windows.Forms.Padding(3);
            this.tabXray.Size = new System.Drawing.Size(1303, 629);
            this.tabXray.TabIndex = 1;
            this.tabXray.Text = "X-Ray Code";
            this.tabXray.UseVisualStyleBackColor = true;
            // 
            // dgvOne
            // 
            this.dgvOne.AllowUserToAddRows = false;
            this.dgvOne.AllowUserToDeleteRows = false;
            this.dgvOne.AutoGenerateColumns = false;
            this.dgvOne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patxraydateDataGridViewTextBoxColumn,
            this.xnameDataGridViewTextBoxColumn,
            this.patxraycodeDataGridViewTextBoxColumn,
            this.xray_id});
            this.dgvOne.DataSource = this.fungetPatientXrayByPatIDBindingSource;
            this.dgvOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOne.Location = new System.Drawing.Point(3, 3);
            this.dgvOne.MultiSelect = false;
            this.dgvOne.Name = "dgvOne";
            this.dgvOne.ReadOnly = true;
            this.dgvOne.RowTemplate.Height = 30;
            this.dgvOne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOne.Size = new System.Drawing.Size(1297, 623);
            this.dgvOne.TabIndex = 117;
            this.dgvOne.Sorted += new System.EventHandler(this.dgvOne_Sorted);
            // 
            // patxraydateDataGridViewTextBoxColumn
            // 
            this.patxraydateDataGridViewTextBoxColumn.DataPropertyName = "pat_xray_date";
            this.patxraydateDataGridViewTextBoxColumn.FillWeight = 50F;
            this.patxraydateDataGridViewTextBoxColumn.HeaderText = "កាលបរិច្ឆេទ";
            this.patxraydateDataGridViewTextBoxColumn.Name = "patxraydateDataGridViewTextBoxColumn";
            this.patxraydateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xnameDataGridViewTextBoxColumn
            // 
            this.xnameDataGridViewTextBoxColumn.DataPropertyName = "x_name";
            this.xnameDataGridViewTextBoxColumn.FillWeight = 60F;
            this.xnameDataGridViewTextBoxColumn.HeaderText = "ឈ្មោះម៉ាស៊ីន";
            this.xnameDataGridViewTextBoxColumn.Name = "xnameDataGridViewTextBoxColumn";
            this.xnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patxraycodeDataGridViewTextBoxColumn
            // 
            this.patxraycodeDataGridViewTextBoxColumn.DataPropertyName = "pat_xray_code";
            this.patxraycodeDataGridViewTextBoxColumn.HeaderText = "លេខកូដ";
            this.patxraycodeDataGridViewTextBoxColumn.Name = "patxraycodeDataGridViewTextBoxColumn";
            this.patxraycodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xray_id
            // 
            this.xray_id.DataPropertyName = "xray_id";
            this.xray_id.HeaderText = "xray_id";
            this.xray_id.Name = "xray_id";
            this.xray_id.ReadOnly = true;
            this.xray_id.Visible = false;
            // 
            // fungetPatientXrayByPatIDBindingSource
            // 
            this.fungetPatientXrayByPatIDBindingSource.DataMember = "fun_getPatientXrayByPatID";
            this.fungetPatientXrayByPatIDBindingSource.DataSource = this.dentistDataSet;
            // 
            // tabDiag
            // 
            this.tabDiag.Location = new System.Drawing.Point(4, 38);
            this.tabDiag.Name = "tabDiag";
            this.tabDiag.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiag.Size = new System.Drawing.Size(1303, 629);
            this.tabDiag.TabIndex = 2;
            this.tabDiag.Text = "Diagnosis";
            this.tabDiag.UseVisualStyleBackColor = true;
            // 
            // tabTP
            // 
            this.tabTP.Controls.Add(this.dataGridView1);
            this.tabTP.Location = new System.Drawing.Point(4, 38);
            this.tabTP.Name = "tabTP";
            this.tabTP.Padding = new System.Windows.Forms.Padding(3);
            this.tabTP.Size = new System.Drawing.Size(1303, 629);
            this.tabTP.TabIndex = 3;
            this.tabTP.Text = "Treatment Plan";
            this.tabTP.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tpdateDataGridViewTextBoxColumn,
            this.sdnameDataGridViewTextBoxColumn,
            this.tp_amount,
            this.docnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fungetAllPatientServiceBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1297, 623);
            this.dataGridView1.TabIndex = 118;
            // 
            // fungetAllPatientServiceBindingSource
            // 
            this.fungetAllPatientServiceBindingSource.DataMember = "fun_getAllPatientService";
            this.fungetAllPatientServiceBindingSource.DataSource = this.dentistDataSet;
            // 
            // tabPs
            // 
            this.tabPs.Controls.Add(this.dataGridView2);
            this.tabPs.Location = new System.Drawing.Point(4, 38);
            this.tabPs.Name = "tabPs";
            this.tabPs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPs.Size = new System.Drawing.Size(1303, 629);
            this.tabPs.TabIndex = 4;
            this.tabPs.Text = "Prescription";
            this.tabPs.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.psdateDataGridViewTextBoxColumn,
            this.psdesDataGridViewTextBoxColumn,
            this.psunitDataGridViewTextBoxColumn,
            this.psamountDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fungetPrescriptionByPatIDBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1297, 623);
            this.dataGridView2.TabIndex = 119;
            // 
            // psdateDataGridViewTextBoxColumn
            // 
            this.psdateDataGridViewTextBoxColumn.DataPropertyName = "ps_date";
            this.psdateDataGridViewTextBoxColumn.FillWeight = 70F;
            this.psdateDataGridViewTextBoxColumn.HeaderText = "កាលបរិច្ឆេទ";
            this.psdateDataGridViewTextBoxColumn.Name = "psdateDataGridViewTextBoxColumn";
            this.psdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // psdesDataGridViewTextBoxColumn
            // 
            this.psdesDataGridViewTextBoxColumn.DataPropertyName = "ps_des";
            this.psdesDataGridViewTextBoxColumn.HeaderText = "ឈ្មោះថ្នាំ";
            this.psdesDataGridViewTextBoxColumn.Name = "psdesDataGridViewTextBoxColumn";
            this.psdesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // psunitDataGridViewTextBoxColumn
            // 
            this.psunitDataGridViewTextBoxColumn.DataPropertyName = "ps_unit";
            this.psunitDataGridViewTextBoxColumn.FillWeight = 40F;
            this.psunitDataGridViewTextBoxColumn.HeaderText = "ប្រភេទឯកតា";
            this.psunitDataGridViewTextBoxColumn.Name = "psunitDataGridViewTextBoxColumn";
            this.psunitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // psamountDataGridViewTextBoxColumn
            // 
            this.psamountDataGridViewTextBoxColumn.DataPropertyName = "ps_amount";
            this.psamountDataGridViewTextBoxColumn.FillWeight = 40F;
            this.psamountDataGridViewTextBoxColumn.HeaderText = "ចំនូន";
            this.psamountDataGridViewTextBoxColumn.Name = "psamountDataGridViewTextBoxColumn";
            this.psamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fungetPrescriptionByPatIDBindingSource
            // 
            this.fungetPrescriptionByPatIDBindingSource.DataMember = "fun_getPrescriptionByPatID";
            this.fungetPrescriptionByPatIDBindingSource.DataSource = this.dentistDataSet;
            // 
            // lblPatId
            // 
            this.lblPatId.AutoSize = true;
            this.lblPatId.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatId.Location = new System.Drawing.Point(187, 48);
            this.lblPatId.Name = "lblPatId";
            this.lblPatId.Size = new System.Drawing.Size(167, 29);
            this.lblPatId.TabIndex = 15;
            this.lblPatId.Text = "លេខសម្គាល់វេជ្ជបណ្ឌិតៈ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "លេខសម្គាល់អ្នកជំងឺៈ";
            // 
            // lblPatName
            // 
            this.lblPatName.AutoSize = true;
            this.lblPatName.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatName.Location = new System.Drawing.Point(187, 19);
            this.lblPatName.Name = "lblPatName";
            this.lblPatName.Size = new System.Drawing.Size(124, 29);
            this.lblPatName.TabIndex = 13;
            this.lblPatName.Text = "ឈ្មោះវេជ្ជបណ្ឌិតៈ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "ឈ្មោះអ្នកជំងឺៈ";
            // 
            // btnPatientDetail
            // 
            this.btnPatientDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btnPatientDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientDetail.FlatAppearance.BorderSize = 0;
            this.btnPatientDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientDetail.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDetail.ForeColor = System.Drawing.Color.White;
            this.btnPatientDetail.Location = new System.Drawing.Point(1155, 11);
            this.btnPatientDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatientDetail.Name = "btnPatientDetail";
            this.btnPatientDetail.Size = new System.Drawing.Size(163, 32);
            this.btnPatientDetail.TabIndex = 91;
            this.btnPatientDetail.Text = "ថយក្រោយ";
            this.btnPatientDetail.UseVisualStyleBackColor = false;
            this.btnPatientDetail.Click += new System.EventHandler(this.btnPatientDetail_Click);
            // 
            // fun_getPatientByIDTableAdapter
            // 
            this.fun_getPatientByIDTableAdapter.ClearBeforeFill = true;
            // 
            // fun_getPatientImageByIDTableAdapter
            // 
            this.fun_getPatientImageByIDTableAdapter.ClearBeforeFill = true;
            // 
            // fun_getActiveMedicalHistoryForSpecificPaientTableAdapter
            // 
            this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter.ClearBeforeFill = true;
            // 
            // fun_getPatientXrayByPatIDTableAdapter
            // 
            this.fun_getPatientXrayByPatIDTableAdapter.ClearBeforeFill = true;
            // 
            // fun_getAllPatientServiceTableAdapter
            // 
            this.fun_getAllPatientServiceTableAdapter.ClearBeforeFill = true;
            // 
            // fun_getPrescriptionByPatIDTableAdapter
            // 
            this.fun_getPrescriptionByPatIDTableAdapter.ClearBeforeFill = true;
            // 
            // TabTd
            // 
            this.TabTd.Controls.Add(this.richTextBox1);
            this.TabTd.Location = new System.Drawing.Point(4, 38);
            this.TabTd.Name = "TabTd";
            this.TabTd.Padding = new System.Windows.Forms.Padding(3);
            this.TabTd.Size = new System.Drawing.Size(1303, 629);
            this.TabTd.TabIndex = 6;
            this.TabTd.Text = "Treatment Detail";
            this.TabTd.UseVisualStyleBackColor = true;
            // 
            // tpdateDataGridViewTextBoxColumn
            // 
            this.tpdateDataGridViewTextBoxColumn.DataPropertyName = "tp_date";
            this.tpdateDataGridViewTextBoxColumn.FillWeight = 50F;
            this.tpdateDataGridViewTextBoxColumn.HeaderText = "កាលបរិច្ឆេទ";
            this.tpdateDataGridViewTextBoxColumn.Name = "tpdateDataGridViewTextBoxColumn";
            this.tpdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sdnameDataGridViewTextBoxColumn
            // 
            this.sdnameDataGridViewTextBoxColumn.DataPropertyName = "sd_name";
            this.sdnameDataGridViewTextBoxColumn.HeaderText = "សេវាកម្ម";
            this.sdnameDataGridViewTextBoxColumn.Name = "sdnameDataGridViewTextBoxColumn";
            this.sdnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tp_amount
            // 
            this.tp_amount.DataPropertyName = "tp_amount";
            this.tp_amount.HeaderText = "ចំនូន";
            this.tp_amount.Name = "tp_amount";
            this.tp_amount.ReadOnly = true;
            // 
            // docnameDataGridViewTextBoxColumn
            // 
            this.docnameDataGridViewTextBoxColumn.DataPropertyName = "doc_name";
            this.docnameDataGridViewTextBoxColumn.FillWeight = 70F;
            this.docnameDataGridViewTextBoxColumn.HeaderText = "ឈ្មោះវេជ្ជបណ្ឌិត";
            this.docnameDataGridViewTextBoxColumn.Name = "docnameDataGridViewTextBoxColumn";
            this.docnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientTdByPatIDBindingSource, "td_des", true));
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1297, 623);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // fungetPatientTdByPatIDBindingSource
            // 
            this.fungetPatientTdByPatIDBindingSource.DataMember = "fun_getPatientTdByPatID";
            this.fungetPatientTdByPatIDBindingSource.DataSource = this.dentistDataSet;
            // 
            // fun_getPatientTdByPatIDTableAdapter
            // 
            this.fun_getPatientTdByPatIDTableAdapter.ClearBeforeFill = true;
            // 
            // frm_patient_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 761);
            this.Controls.Add(this.btnPatientDetail);
            this.Controls.Add(this.lblPatId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPatName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TC);
            this.Name = "frm_patient_information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_patient_information";
            this.Load += new System.EventHandler(this.frm_patient_information_Load);
            this.TC.ResumeLayout(false);
            this.tabGI.ResumeLayout(false);
            this.tabGI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientByIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientImageByIDBindingSource)).EndInit();
            this.tabMd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fun_getActiveMedicalHistoryForSpecificPaientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getActiveMedicalHistoryForSpecificPaientBindingSource)).EndInit();
            this.tabXray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientXrayByPatIDBindingSource)).EndInit();
            this.tabTP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllPatientServiceBindingSource)).EndInit();
            this.tabPs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPrescriptionByPatIDBindingSource)).EndInit();
            this.TabTd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientTdByPatIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TC;
        private System.Windows.Forms.TabPage tabGI;
        private System.Windows.Forms.TabPage tabXray;
        private System.Windows.Forms.Label lblPatId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPatName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabMd;
        private System.Windows.Forms.TabPage tabDiag;
        private System.Windows.Forms.TabPage tabTP;
        private System.Windows.Forms.TabPage tabPs;
        private System.Windows.Forms.Button btnPatientDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource fungetPatientByIDBindingSource;
        private DentistDataSet dentistDataSet;
        private System.Windows.Forms.Button btnShowPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource fungetPatientImageByIDBindingSource;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKhLname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKhFname;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Reg_Phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Reg_Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Reg_Job;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DentistDataSetTableAdapters.fun_getPatientByIDTableAdapter fun_getPatientByIDTableAdapter;
        private DentistDataSetTableAdapters.fun_getPatientImageByIDTableAdapter fun_getPatientImageByIDTableAdapter;
        private System.Windows.Forms.BindingSource fun_getActiveMedicalHistoryForSpecificPaientBindingSource;
        private DentistDataSetTableAdapters.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter fun_getActiveMedicalHistoryForSpecificPaientTableAdapter;
        private System.Windows.Forms.DataGridView fun_getActiveMedicalHistoryForSpecificPaientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_status;
        private System.Windows.Forms.DataGridView dgvOne;
        private System.Windows.Forms.BindingSource fungetPatientXrayByPatIDBindingSource;
        private DentistDataSetTableAdapters.fun_getPatientXrayByPatIDTableAdapter fun_getPatientXrayByPatIDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patxraydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patxraycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xray_id;
        private System.Windows.Forms.BindingSource fungetAllPatientServiceBindingSource;
        private DentistDataSetTableAdapters.fun_getAllPatientServiceTableAdapter fun_getAllPatientServiceTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn psdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn psdesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn psunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn psamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fungetPrescriptionByPatIDBindingSource;
        private DentistDataSetTableAdapters.fun_getPrescriptionByPatIDTableAdapter fun_getPrescriptionByPatIDTableAdapter;
        private System.Windows.Forms.TabPage TabTd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn docnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource fungetPatientTdByPatIDBindingSource;
        private DentistDataSetTableAdapters.fun_getPatientTdByPatIDTableAdapter fun_getPatientTdByPatIDTableAdapter;
    }
}