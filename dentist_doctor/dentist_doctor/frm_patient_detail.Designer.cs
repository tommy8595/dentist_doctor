namespace dentist_doctor
{
    partial class frm_patient_detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_patient_detail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btn_Reg_Pat_Cancel = new System.Windows.Forms.Button();
            this.btnShowPic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fungetPatientImageByIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentistDataSet = new dentist_doctor.DentistDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.fungetPatientByIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnInactive = new System.Windows.Forms.Button();
            this.dgvMd = new System.Windows.Forms.DataGridView();
            this.pat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.md_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.cboMd = new System.Windows.Forms.ComboBox();
            this.fungetMedicalHistoryForSpecificPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.fun_getPatientByIDTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getPatientByIDTableAdapter();
            this.fun_getPatientImageByIDTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getPatientImageByIDTableAdapter();
            this.fungetActiveMedicalHistoryForSpecificPaientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter();
            this.fun_getMedicalHistoryForSpecificPatientTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getMedicalHistoryForSpecificPatientTableAdapter();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientImageByIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientByIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetMedicalHistoryForSpecificPatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetActiveMedicalHistoryForSpecificPaientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1173, 88);
            this.panel4.TabIndex = 115;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(2, 4);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(75, 81);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // btn_Reg_Pat_Cancel
            // 
            this.btn_Reg_Pat_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btn_Reg_Pat_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reg_Pat_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Reg_Pat_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reg_Pat_Cancel.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reg_Pat_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Reg_Pat_Cancel.Location = new System.Drawing.Point(916, 650);
            this.btn_Reg_Pat_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reg_Pat_Cancel.Name = "btn_Reg_Pat_Cancel";
            this.btn_Reg_Pat_Cancel.Size = new System.Drawing.Size(187, 41);
            this.btn_Reg_Pat_Cancel.TabIndex = 142;
            this.btn_Reg_Pat_Cancel.Text = "បោះបង់";
            this.btn_Reg_Pat_Cancel.UseVisualStyleBackColor = false;
            this.btn_Reg_Pat_Cancel.Click += new System.EventHandler(this.btn_Reg_Pat_Cancel_Click);
            // 
            // btnShowPic
            // 
            this.btnShowPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnShowPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPic.FlatAppearance.BorderSize = 0;
            this.btnShowPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPic.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPic.ForeColor = System.Drawing.Color.White;
            this.btnShowPic.Location = new System.Drawing.Point(1024, 288);
            this.btnShowPic.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowPic.Name = "btnShowPic";
            this.btnShowPic.Size = new System.Drawing.Size(87, 41);
            this.btnShowPic.TabIndex = 168;
            this.btnShowPic.Text = "បង្ហាញរូប";
            this.btnShowPic.UseVisualStyleBackColor = false;
            this.btnShowPic.Click += new System.EventHandler(this.btnShowPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.fungetPatientImageByIDBindingSource, "pat_image", true));
            this.pictureBox1.Location = new System.Drawing.Point(1005, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 167;
            this.pictureBox1.TabStop = false;
            // 
            // fungetPatientImageByIDBindingSource
            // 
            this.fungetPatientImageByIDBindingSource.DataMember = "fun_getPatientImageByID";
            this.fungetPatientImageByIDBindingSource.DataSource = this.dentistDataSet;
            // 
            // dentistDataSet
            // 
            this.dentistDataSet.DataSetName = "DentistDataSet";
            this.dentistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(394, 157);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 29);
            this.label12.TabIndex = 165;
            this.label12.Text = "ឈ្មោះ(ឡាតាំង)";
            // 
            // txtLname
            // 
            this.txtLname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_lname", true));
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(536, 158);
            this.txtLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtLname.Name = "txtLname";
            this.txtLname.ReadOnly = true;
            this.txtLname.Size = new System.Drawing.Size(418, 26);
            this.txtLname.TabIndex = 161;
            this.txtLname.Tag = "សូមបញ្ចូលឈ្មោះ(ឡាតាំង)";
            // 
            // fungetPatientByIDBindingSource
            // 
            this.fungetPatientByIDBindingSource.DataMember = "fun_getPatientByID";
            this.fungetPatientByIDBindingSource.DataSource = this.dentistDataSet;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1, 155);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 29);
            this.label13.TabIndex = 164;
            this.label13.Text = "ត្រកូល(ឡាតាំង)";
            // 
            // txtFname
            // 
            this.txtFname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_fname", true));
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(121, 156);
            this.txtFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtFname.Name = "txtFname";
            this.txtFname.ReadOnly = true;
            this.txtFname.Size = new System.Drawing.Size(243, 26);
            this.txtFname.TabIndex = 160;
            this.txtFname.Tag = "សូមបញ្ចូលត្រកូល(ឡាតាំង)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(394, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 29);
            this.label10.TabIndex = 163;
            this.label10.Text = "ឈ្មោះ(ខ្មែរ)";
            // 
            // txtKhLname
            // 
            this.txtKhLname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_kh_lname", true));
            this.txtKhLname.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhLname.Location = new System.Drawing.Point(536, 111);
            this.txtKhLname.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhLname.Name = "txtKhLname";
            this.txtKhLname.ReadOnly = true;
            this.txtKhLname.Size = new System.Drawing.Size(418, 33);
            this.txtKhLname.TabIndex = 159;
            this.txtKhLname.Tag = "សូមបញ្ចូលឈ្មោះ(ខ្មែរ)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 111);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 29);
            this.label11.TabIndex = 162;
            this.label11.Text = "ត្រកូល(ខ្មែរ)";
            // 
            // txtKhFname
            // 
            this.txtKhFname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_kh_fname", true));
            this.txtKhFname.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhFname.Location = new System.Drawing.Point(121, 109);
            this.txtKhFname.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhFname.Name = "txtKhFname";
            this.txtKhFname.ReadOnly = true;
            this.txtKhFname.Size = new System.Drawing.Size(243, 33);
            this.txtKhFname.TabIndex = 158;
            this.txtKhFname.Tag = "សូមបញ្ចូលត្រកូល(ខ្មែរ)";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_gender", true));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(121, 195);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(243, 26);
            this.textBox4.TabIndex = 157;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_birthyear", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(536, 196);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(160, 26);
            this.textBox3.TabIndex = 156;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_nation", true));
            this.textBox2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(121, 283);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(193, 36);
            this.textBox2.TabIndex = 155;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 241);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 29);
            this.label9.TabIndex = 153;
            this.label9.Text = "លេខទូរស័ព្ទ";
            // 
            // txt_Reg_Phone
            // 
            this.txt_Reg_Phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_tel", true));
            this.txt_Reg_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reg_Phone.Location = new System.Drawing.Point(121, 240);
            this.txt_Reg_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Reg_Phone.Name = "txt_Reg_Phone";
            this.txt_Reg_Phone.ReadOnly = true;
            this.txt_Reg_Phone.Size = new System.Drawing.Size(348, 26);
            this.txt_Reg_Phone.TabIndex = 152;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(364, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 29);
            this.label8.TabIndex = 151;
            this.label8.Text = "អាស័យដ្ឋាន/កន្លែងធ្វើការ";
            // 
            // txt_Reg_Address
            // 
            this.txt_Reg_Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_address", true));
            this.txt_Reg_Address.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reg_Address.Location = new System.Drawing.Point(536, 284);
            this.txt_Reg_Address.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Reg_Address.Name = "txt_Reg_Address";
            this.txt_Reg_Address.ReadOnly = true;
            this.txt_Reg_Address.Size = new System.Drawing.Size(418, 36);
            this.txt_Reg_Address.TabIndex = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 29);
            this.label7.TabIndex = 149;
            this.label7.Text = "សញ្ជាតិ";
            // 
            // txt_Reg_Job
            // 
            this.txt_Reg_Job.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fungetPatientByIDBindingSource, "pat_job", true));
            this.txt_Reg_Job.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reg_Job.Location = new System.Drawing.Point(536, 237);
            this.txt_Reg_Job.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Reg_Job.Name = "txt_Reg_Job";
            this.txt_Reg_Job.ReadOnly = true;
            this.txt_Reg_Job.Size = new System.Drawing.Size(418, 36);
            this.txt_Reg_Job.TabIndex = 148;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 29);
            this.label6.TabIndex = 147;
            this.label6.Text = "មុខរបរ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 195);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 29);
            this.label5.TabIndex = 146;
            this.label5.Text = "ភេទ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 145;
            this.label4.Text = "ឆ្នាំកំណើត";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(958, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 144;
            this.label1.Text = "លេខសម្គាល់";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(1063, 95);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(99, 26);
            this.txtId.TabIndex = 143;
            // 
            // btnInactive
            // 
            this.btnInactive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnInactive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInactive.FlatAppearance.BorderSize = 0;
            this.btnInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactive.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactive.ForeColor = System.Drawing.Color.White;
            this.btnInactive.Location = new System.Drawing.Point(6, 506);
            this.btnInactive.Margin = new System.Windows.Forms.Padding(2);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(107, 68);
            this.btnInactive.TabIndex = 176;
            this.btnInactive.Text = "ផ្លាស់ប្តូរ\r\nស្ថានភាពជម្ងឺ";
            this.btnInactive.UseVisualStyleBackColor = false;
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
            // 
            // dgvMd
            // 
            this.dgvMd.AllowUserToAddRows = false;
            this.dgvMd.AllowUserToDeleteRows = false;
            this.dgvMd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pat_id,
            this.md_id,
            this.md_name,
            this.md_description,
            this.md_status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMd.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMd.Location = new System.Drawing.Point(121, 418);
            this.dgvMd.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMd.MultiSelect = false;
            this.dgvMd.Name = "dgvMd";
            this.dgvMd.ReadOnly = true;
            this.dgvMd.RowTemplate.Height = 30;
            this.dgvMd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMd.Size = new System.Drawing.Size(982, 211);
            this.dgvMd.TabIndex = 175;
            // 
            // pat_id
            // 
            this.pat_id.HeaderText = "pat_id";
            this.pat_id.Name = "pat_id";
            this.pat_id.ReadOnly = true;
            this.pat_id.Visible = false;
            // 
            // md_id
            // 
            this.md_id.HeaderText = "md_id";
            this.md_id.Name = "md_id";
            this.md_id.ReadOnly = true;
            this.md_id.Visible = false;
            // 
            // md_name
            // 
            this.md_name.HeaderText = "ប្រវត្តិវេជ្ជសាស្រ្ត";
            this.md_name.Name = "md_name";
            this.md_name.ReadOnly = true;
            // 
            // md_description
            // 
            this.md_description.HeaderText = "ប្រវត្តិវេជ្ជសាស្រ្តលំអិត";
            this.md_description.Name = "md_description";
            this.md_description.ReadOnly = true;
            // 
            // md_status
            // 
            this.md_status.FillWeight = 30F;
            this.md_status.HeaderText = "ស្ថានភាព";
            this.md_status.Name = "md_status";
            this.md_status.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 174;
            this.label2.Text = "ប្រវត្តិវេជ្ជសាស្ត្រ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 382);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 173;
            this.label3.Text = "បរិយាយ";
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDes.Location = new System.Drawing.Point(121, 378);
            this.txtDes.Margin = new System.Windows.Forms.Padding(2);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(833, 33);
            this.txtDes.TabIndex = 170;
            this.txtDes.Tag = "";
            // 
            // cboMd
            // 
            this.cboMd.DataSource = this.fungetMedicalHistoryForSpecificPatientBindingSource;
            this.cboMd.DisplayMember = "md_name";
            this.cboMd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMd.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMd.FormattingEnabled = true;
            this.cboMd.Location = new System.Drawing.Point(121, 337);
            this.cboMd.Margin = new System.Windows.Forms.Padding(2);
            this.cboMd.Name = "cboMd";
            this.cboMd.Size = new System.Drawing.Size(833, 33);
            this.cboMd.TabIndex = 169;
            this.cboMd.Tag = "";
            this.cboMd.ValueMember = "md_id";
            // 
            // fungetMedicalHistoryForSpecificPatientBindingSource
            // 
            this.fungetMedicalHistoryForSpecificPatientBindingSource.DataMember = "fun_getMedicalHistoryForSpecificPatient";
            this.fungetMedicalHistoryForSpecificPatientBindingSource.DataSource = this.dentistDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(958, 356);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 34);
            this.btnAdd.TabIndex = 172;
            this.btnAdd.Text = "បន្ថែម";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(27, 428);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 58);
            this.label30.TabIndex = 171;
            this.label30.Text = "តារាងប្រវត្តិ\r\nវេជ្ជសាស្រ្ត";
            // 
            // fun_getPatientByIDTableAdapter
            // 
            this.fun_getPatientByIDTableAdapter.ClearBeforeFill = true;
            // 
            // fun_getPatientImageByIDTableAdapter
            // 
            this.fun_getPatientImageByIDTableAdapter.ClearBeforeFill = true;
            // 
            // fungetActiveMedicalHistoryForSpecificPaientBindingSource
            // 
            this.fungetActiveMedicalHistoryForSpecificPaientBindingSource.DataMember = "fun_getActiveMedicalHistoryForSpecificPaient";
            this.fungetActiveMedicalHistoryForSpecificPaientBindingSource.DataSource = this.dentistDataSet;
            // 
            // fun_getActiveMedicalHistoryForSpecificPaientTableAdapter
            // 
            this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter.ClearBeforeFill = true;
            // 
            // fun_getMedicalHistoryForSpecificPatientTableAdapter
            // 
            this.fun_getMedicalHistoryForSpecificPatientTableAdapter.ClearBeforeFill = true;
            // 
            // frm_patient_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 702);
            this.Controls.Add(this.btnInactive);
            this.Controls.Add(this.dgvMd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.cboMd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.btnShowPic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKhLname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtKhFname);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Reg_Phone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Reg_Address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Reg_Job);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_Reg_Pat_Cancel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_patient_detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_patient_detail";
            this.Activated += new System.EventHandler(this.frm_patient_detail_Activated);
            this.Load += new System.EventHandler(this.frm_patient_detail_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientImageByIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientByIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetMedicalHistoryForSpecificPatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetActiveMedicalHistoryForSpecificPaientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btn_Reg_Pat_Cancel;
        private System.Windows.Forms.Button btnShowPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.BindingSource fungetPatientByIDBindingSource;
        private DentistDataSet dentistDataSet;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private DentistDataSetTableAdapters.fun_getPatientByIDTableAdapter fun_getPatientByIDTableAdapter;
        private System.Windows.Forms.BindingSource fungetPatientImageByIDBindingSource;
        private DentistDataSetTableAdapters.fun_getPatientImageByIDTableAdapter fun_getPatientImageByIDTableAdapter;
        private System.Windows.Forms.Button btnInactive;
        private System.Windows.Forms.DataGridView dgvMd;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn md_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.ComboBox cboMd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.BindingSource fungetMedicalHistoryForSpecificPatientBindingSource;
        private System.Windows.Forms.BindingSource fungetActiveMedicalHistoryForSpecificPaientBindingSource;
        private DentistDataSetTableAdapters.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter fun_getActiveMedicalHistoryForSpecificPaientTableAdapter;
        private DentistDataSetTableAdapters.fun_getMedicalHistoryForSpecificPatientTableAdapter fun_getMedicalHistoryForSpecificPatientTableAdapter;
    }
}