namespace dentist_doctor
{
    partial class frm_doc_treatment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.fungetAllServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentistDataSet = new dentist_doctor.DentistDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.nudCharge = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.fun_getAllServiceTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getAllServiceTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.cboServiceDetail = new System.Windows.Forms.ComboBox();
            this.fungetAllServiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fun_getAllServiceDetailTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getAllServiceDetailTableAdapter();
            this.btnTotal = new System.Windows.Forms.Button();
            this.dataGridView1 = new dentist.Grid();
            this.pat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sd_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tp_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charge_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new dentist.Grid();
            this.tpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sd_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fungetAllPatientServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.fun_getAllPatientServiceTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getAllPatientServiceTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.btnHome = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllServiceDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllPatientServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "dd​ MMMM yyyy";
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(133, 44);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(177, 26);
            this.dtp.TabIndex = 0;
            // 
            // cboService
            // 
            this.cboService.DataSource = this.fungetAllServiceBindingSource;
            this.cboService.DisplayMember = "sc_name";
            this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboService.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(448, 41);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(295, 37);
            this.cboService.TabIndex = 1;
            this.cboService.ValueMember = "sc_id";
            this.cboService.SelectedIndexChanged += new System.EventHandler(this.cboService_SelectedIndexChanged);
            // 
            // fungetAllServiceBindingSource
            // 
            this.fungetAllServiceBindingSource.DataMember = "fun_getAllService";
            this.fungetAllServiceBindingSource.DataSource = this.dentistDataSet;
            // 
            // dentistDataSet
            // 
            this.dentistDataSet.DataSetName = "DentistDataSet";
            this.dentistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Service Category";
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(110, 99);
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(61, 26);
            this.txtMin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Min($)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max($)";
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(416, 97);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(61, 26);
            this.txtMax.TabIndex = 5;
            // 
            // nudCharge
            // 
            this.nudCharge.DecimalPlaces = 2;
            this.nudCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCharge.Location = new System.Drawing.Point(263, 99);
            this.nudCharge.Name = "nudCharge";
            this.nudCharge.Size = new System.Drawing.Size(84, 26);
            this.nudCharge.TabIndex = 7;
            this.nudCharge.ValueChanged += new System.EventHandler(this.nudCharge_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Charge($)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Discount";
            // 
            // nudDiscount
            // 
            this.nudDiscount.DecimalPlaces = 2;
            this.nudDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiscount.Location = new System.Drawing.Point(676, 97);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(83, 26);
            this.nudDiscount.TabIndex = 9;
            this.nudDiscount.Enter += new System.EventHandler(this.nudDiscount_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(834, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total($)";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(900, 97);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(85, 26);
            this.txtTotal.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(991, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // fun_getAllServiceTableAdapter
            // 
            this.fun_getAllServiceTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(755, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Service Detail";
            // 
            // cboServiceDetail
            // 
            this.cboServiceDetail.DataSource = this.fungetAllServiceDetailBindingSource;
            this.cboServiceDetail.DisplayMember = "sd_name";
            this.cboServiceDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServiceDetail.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServiceDetail.FormattingEnabled = true;
            this.cboServiceDetail.Location = new System.Drawing.Point(867, 41);
            this.cboServiceDetail.Name = "cboServiceDetail";
            this.cboServiceDetail.Size = new System.Drawing.Size(354, 37);
            this.cboServiceDetail.TabIndex = 14;
            this.cboServiceDetail.ValueMember = "Detail";
            this.cboServiceDetail.SelectedValueChanged += new System.EventHandler(this.cboServiceDetail_SelectedValueChanged);
            // 
            // fungetAllServiceDetailBindingSource
            // 
            this.fungetAllServiceDetailBindingSource.DataMember = "fun_getAllServiceDetail";
            this.fungetAllServiceDetailBindingSource.DataSource = this.dentistDataSet;
            // 
            // fun_getAllServiceDetailTableAdapter
            // 
            this.fun_getAllServiceDetailTableAdapter.ClearBeforeFill = true;
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(762, 90);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 37);
            this.btnTotal.TabIndex = 16;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pat_id,
            this.date,
            this.sd_id,
            this.service_name,
            this.tp_amount,
            this.charge_amount,
            this.discount,
            this.total,
            this.doc_name,
            this.doc_id,
            this.paid_status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(59, 147);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1162, 199);
            this.dataGridView1.TabIndex = 17;
            // 
            // pat_id
            // 
            this.pat_id.FillWeight = 80F;
            this.pat_id.HeaderText = "pat_id";
            this.pat_id.Name = "pat_id";
            this.pat_id.ReadOnly = true;
            this.pat_id.Visible = false;
            // 
            // date
            // 
            this.date.FillWeight = 60F;
            this.date.HeaderText = "កាលបរិច្ឆេទ";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // sd_id
            // 
            this.sd_id.HeaderText = "sd_id";
            this.sd_id.Name = "sd_id";
            this.sd_id.ReadOnly = true;
            this.sd_id.Visible = false;
            // 
            // service_name
            // 
            this.service_name.FillWeight = 110F;
            this.service_name.HeaderText = "សេវាកម្ម";
            this.service_name.Name = "service_name";
            this.service_name.ReadOnly = true;
            // 
            // tp_amount
            // 
            this.tp_amount.FillWeight = 30F;
            this.tp_amount.HeaderText = "ចំនួន";
            this.tp_amount.Name = "tp_amount";
            this.tp_amount.ReadOnly = true;
            // 
            // charge_amount
            // 
            this.charge_amount.FillWeight = 50F;
            this.charge_amount.HeaderText = "តំលៃ";
            this.charge_amount.Name = "charge_amount";
            this.charge_amount.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.FillWeight = 50F;
            this.discount.HeaderText = "បញ្ចុះតំលៃ";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // total
            // 
            this.total.FillWeight = 50F;
            this.total.HeaderText = "សរុប";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // doc_name
            // 
            this.doc_name.HeaderText = "ឈ្មោះវេជ្ជបណ្ឌិត";
            this.doc_name.Name = "doc_name";
            this.doc_name.ReadOnly = true;
            // 
            // doc_id
            // 
            this.doc_id.HeaderText = "doc_id";
            this.doc_id.Name = "doc_id";
            this.doc_id.ReadOnly = true;
            this.doc_id.Visible = false;
            // 
            // paid_status
            // 
            this.paid_status.HeaderText = "paid_status";
            this.paid_status.Name = "paid_status";
            this.paid_status.ReadOnly = true;
            this.paid_status.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tpdateDataGridViewTextBoxColumn,
            this.sd_name,
            this.chargeamountDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.discountamountDataGridViewTextBoxColumn,
            this.totalamountDataGridViewTextBoxColumn,
            this.docnameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fungetAllPatientServiceBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.Location = new System.Drawing.Point(59, 395);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1162, 283);
            this.dataGridView2.TabIndex = 18;
            // 
            // tpdateDataGridViewTextBoxColumn
            // 
            this.tpdateDataGridViewTextBoxColumn.DataPropertyName = "tp_date";
            this.tpdateDataGridViewTextBoxColumn.FillWeight = 60F;
            this.tpdateDataGridViewTextBoxColumn.HeaderText = "កាលបរិច្ឆេទ";
            this.tpdateDataGridViewTextBoxColumn.Name = "tpdateDataGridViewTextBoxColumn";
            this.tpdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sd_name
            // 
            this.sd_name.DataPropertyName = "sd_name";
            this.sd_name.FillWeight = 120F;
            this.sd_name.HeaderText = "សេវាកម្ម";
            this.sd_name.Name = "sd_name";
            this.sd_name.ReadOnly = true;
            // 
            // chargeamountDataGridViewTextBoxColumn
            // 
            this.chargeamountDataGridViewTextBoxColumn.DataPropertyName = "charge_amount";
            this.chargeamountDataGridViewTextBoxColumn.FillWeight = 50F;
            this.chargeamountDataGridViewTextBoxColumn.HeaderText = "តំលៃ";
            this.chargeamountDataGridViewTextBoxColumn.Name = "chargeamountDataGridViewTextBoxColumn";
            this.chargeamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tp_amount";
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ចំនូន";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // discountamountDataGridViewTextBoxColumn
            // 
            this.discountamountDataGridViewTextBoxColumn.DataPropertyName = "discount_amount";
            this.discountamountDataGridViewTextBoxColumn.FillWeight = 50F;
            this.discountamountDataGridViewTextBoxColumn.HeaderText = "បញ្ចុះតំលៃ";
            this.discountamountDataGridViewTextBoxColumn.Name = "discountamountDataGridViewTextBoxColumn";
            this.discountamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalamountDataGridViewTextBoxColumn
            // 
            this.totalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.FillWeight = 50F;
            this.totalamountDataGridViewTextBoxColumn.HeaderText = "សរុប";
            this.totalamountDataGridViewTextBoxColumn.Name = "totalamountDataGridViewTextBoxColumn";
            this.totalamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docnameDataGridViewTextBoxColumn
            // 
            this.docnameDataGridViewTextBoxColumn.DataPropertyName = "doc_name";
            this.docnameDataGridViewTextBoxColumn.FillWeight = 120F;
            this.docnameDataGridViewTextBoxColumn.HeaderText = "ឈ្មោះវេជ្ជបណ្ឌិត";
            this.docnameDataGridViewTextBoxColumn.Name = "docnameDataGridViewTextBoxColumn";
            this.docnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fungetAllPatientServiceBindingSource
            // 
            this.fungetAllPatientServiceBindingSource.DataMember = "fun_getAllPatientService";
            this.fungetAllPatientServiceBindingSource.DataSource = this.dentistDataSet;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(597, 353);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 37);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // fun_getAllPatientServiceTableAdapter
            // 
            this.fun_getAllPatientServiceTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 353);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(59, 37);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1222, 353);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 37);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Amount";
            // 
            // nudAmount
            // 
            this.nudAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(554, 97);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(46, 26);
            this.nudAmount.TabIndex = 22;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1156, 90);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(65, 37);
            this.btnHome.TabIndex = 24;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Date";
            // 
            // frm_doc_treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 690);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboServiceDetail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudCharge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.dtp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_doc_treatment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_doc_treatment";
            this.Load += new System.EventHandler(this.frm_doc_treatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllServiceDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllPatientServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.NumericUpDown nudCharge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAdd;
        private DentistDataSet dentistDataSet;
        private System.Windows.Forms.BindingSource fungetAllServiceBindingSource;
        private DentistDataSetTableAdapters.fun_getAllServiceTableAdapter fun_getAllServiceTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboServiceDetail;
        private System.Windows.Forms.BindingSource fungetAllServiceDetailBindingSource;
        private DentistDataSetTableAdapters.fun_getAllServiceDetailTableAdapter fun_getAllServiceDetailTableAdapter;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.BindingSource fungetAllPatientServiceBindingSource;
        private DentistDataSetTableAdapters.fun_getAllPatientServiceTableAdapter fun_getAllPatientServiceTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn sd_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tp_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn charge_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sd_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label9;
        private dentist.Grid dataGridView1;
        private dentist.Grid dataGridView2;
    }
}