namespace dentist_doctor
{
    partial class frm_patient_prescription
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvMed1 = new dentist.Grid();
            this.pat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ps_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTotal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboServiceDetail = new System.Windows.Forms.ComboBox();
            this.fungetAllMedDetailbyCatIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentistDataSet = new dentist_doctor.DentistDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPricePerUnit = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.fungetAllMedCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fun_getAllMedCategoryTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getAllMedCategoryTableAdapter();
            this.fun_getAllMedDetailbyCatIDTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getAllMedDetailbyCatIDTableAdapter();
            this.dataGridView1 = new dentist.Grid();
            this.psdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psdesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pspriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pstotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fungetPrescriptionByPatIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fungetAllMedDetailbyCatIDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fun_getPrescriptionByPatIDTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getPrescriptionByPatIDTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmountLeft = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllMedDetailbyCatIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllMedCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPrescriptionByPatIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllMedDetailbyCatIDBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1088, 83);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 37);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(556, 340);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 37);
            this.btnSubmit.TabIndex = 39;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvMed1
            // 
            this.dgvMed1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.dgvMed1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMed1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMed1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMed1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMed1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pat_id,
            this.ps_date,
            this.ps_des,
            this.ps_unit,
            this.ps_amount,
            this.ps_price,
            this.ps_total,
            this.ps_status,
            this.p_id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMed1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMed1.Location = new System.Drawing.Point(17, 134);
            this.dgvMed1.MultiSelect = false;
            this.dgvMed1.Name = "dgvMed1";
            this.dgvMed1.ReadOnly = true;
            this.dgvMed1.RowTemplate.Height = 30;
            this.dgvMed1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMed1.Size = new System.Drawing.Size(1162, 199);
            this.dgvMed1.TabIndex = 38;
            // 
            // pat_id
            // 
            this.pat_id.HeaderText = "pat_id";
            this.pat_id.Name = "pat_id";
            this.pat_id.ReadOnly = true;
            this.pat_id.Visible = false;
            // 
            // ps_date
            // 
            this.ps_date.FillWeight = 70F;
            this.ps_date.HeaderText = "កាលបរិច្ឆេទ";
            this.ps_date.Name = "ps_date";
            this.ps_date.ReadOnly = true;
            // 
            // ps_des
            // 
            this.ps_des.FillWeight = 130F;
            this.ps_des.HeaderText = "ឈ្មោះថ្នាំ";
            this.ps_des.Name = "ps_des";
            this.ps_des.ReadOnly = true;
            // 
            // ps_unit
            // 
            this.ps_unit.FillWeight = 50F;
            this.ps_unit.HeaderText = "ប្រភេទឯកតា";
            this.ps_unit.Name = "ps_unit";
            this.ps_unit.ReadOnly = true;
            // 
            // ps_amount
            // 
            this.ps_amount.FillWeight = 50F;
            this.ps_amount.HeaderText = "ចំនូន";
            this.ps_amount.Name = "ps_amount";
            this.ps_amount.ReadOnly = true;
            // 
            // ps_price
            // 
            this.ps_price.FillWeight = 60F;
            this.ps_price.HeaderText = "តំលៃរាយ($)";
            this.ps_price.Name = "ps_price";
            this.ps_price.ReadOnly = true;
            // 
            // ps_total
            // 
            this.ps_total.FillWeight = 60F;
            this.ps_total.HeaderText = "សរុប($)";
            this.ps_total.Name = "ps_total";
            this.ps_total.ReadOnly = true;
            // 
            // ps_status
            // 
            this.ps_status.HeaderText = "ps_status";
            this.ps_status.Name = "ps_status";
            this.ps_status.ReadOnly = true;
            this.ps_status.Visible = false;
            // 
            // p_id
            // 
            this.p_id.HeaderText = "p_id";
            this.p_id.Name = "p_id";
            this.p_id.ReadOnly = true;
            this.p_id.Visible = false;
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(665, 83);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 37);
            this.btnTotal.TabIndex = 37;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(720, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Med. Detail";
            // 
            // cboServiceDetail
            // 
            this.cboServiceDetail.DataSource = this.fungetAllMedDetailbyCatIDBindingSource;
            this.cboServiceDetail.DisplayMember = "pro_name";
            this.cboServiceDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServiceDetail.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServiceDetail.FormattingEnabled = true;
            this.cboServiceDetail.Location = new System.Drawing.Point(825, 28);
            this.cboServiceDetail.Name = "cboServiceDetail";
            this.cboServiceDetail.Size = new System.Drawing.Size(338, 37);
            this.cboServiceDetail.TabIndex = 35;
            this.cboServiceDetail.ValueMember = "Detail";
            this.cboServiceDetail.SelectedValueChanged += new System.EventHandler(this.cboServiceDetail_SelectedValueChanged);
            // 
            // fungetAllMedDetailbyCatIDBindingSource
            // 
            this.fungetAllMedDetailbyCatIDBindingSource.DataMember = "fun_getAllMedDetailbyCatID";
            this.fungetAllMedDetailbyCatIDBindingSource.DataSource = this.dentistDataSet;
            // 
            // dentistDataSet
            // 
            this.dentistDataSet.DataSetName = "DentistDataSet";
            this.dentistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(903, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 37);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(746, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Total($)";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(813, 89);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(85, 26);
            this.txtTotal.TabIndex = 32;
            this.txtTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Unit";
            // 
            // nudAmount
            // 
            this.nudAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Location = new System.Drawing.Point(556, 72);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(55, 26);
            this.nudAmount.TabIndex = 30;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Price per Unit($):";
            // 
            // nudPricePerUnit
            // 
            this.nudPricePerUnit.DecimalPlaces = 2;
            this.nudPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPricePerUnit.Location = new System.Drawing.Point(154, 89);
            this.nudPricePerUnit.Name = "nudPricePerUnit";
            this.nudPricePerUnit.ReadOnly = true;
            this.nudPricePerUnit.Size = new System.Drawing.Size(90, 26);
            this.nudPricePerUnit.TabIndex = 28;
            this.nudPricePerUnit.ValueChanged += new System.EventHandler(this.nudPricePerUnit_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Med. Category";
            // 
            // cboService
            // 
            this.cboService.DataSource = this.fungetAllMedCategoryBindingSource;
            this.cboService.DisplayMember = "cat_name";
            this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboService.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(406, 28);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(295, 37);
            this.cboService.TabIndex = 22;
            this.cboService.ValueMember = "cat_id";
            this.cboService.SelectedIndexChanged += new System.EventHandler(this.cboService_SelectedIndexChanged);
            // 
            // fungetAllMedCategoryBindingSource
            // 
            this.fungetAllMedCategoryBindingSource.DataMember = "fun_getAllMedCategory";
            this.fungetAllMedCategoryBindingSource.DataSource = this.dentistDataSet;
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "dd MMMM yyyy";
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(84, 31);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(188, 26);
            this.dtp.TabIndex = 21;
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Khmer OS Battambang", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(289, 85);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(85, 34);
            this.txtUnit.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Amount";
            // 
            // fun_getAllMedCategoryTableAdapter
            // 
            this.fun_getAllMedCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // fun_getAllMedDetailbyCatIDTableAdapter
            // 
            this.fun_getAllMedDetailbyCatIDTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.psdateDataGridViewTextBoxColumn,
            this.psdesDataGridViewTextBoxColumn,
            this.psunitDataGridViewTextBoxColumn,
            this.psamountDataGridViewTextBoxColumn,
            this.pspriceDataGridViewTextBoxColumn,
            this.pstotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fungetPrescriptionByPatIDBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(17, 384);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1162, 299);
            this.dataGridView1.TabIndex = 43;
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
            this.psdesDataGridViewTextBoxColumn.FillWeight = 130F;
            this.psdesDataGridViewTextBoxColumn.HeaderText = "ឈ្មោះថ្នាំ";
            this.psdesDataGridViewTextBoxColumn.Name = "psdesDataGridViewTextBoxColumn";
            this.psdesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // psunitDataGridViewTextBoxColumn
            // 
            this.psunitDataGridViewTextBoxColumn.DataPropertyName = "ps_unit";
            this.psunitDataGridViewTextBoxColumn.FillWeight = 60F;
            this.psunitDataGridViewTextBoxColumn.HeaderText = "ប្រភេទឯកតា";
            this.psunitDataGridViewTextBoxColumn.Name = "psunitDataGridViewTextBoxColumn";
            this.psunitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // psamountDataGridViewTextBoxColumn
            // 
            this.psamountDataGridViewTextBoxColumn.DataPropertyName = "ps_amount";
            this.psamountDataGridViewTextBoxColumn.FillWeight = 60F;
            this.psamountDataGridViewTextBoxColumn.HeaderText = "ចំនួន";
            this.psamountDataGridViewTextBoxColumn.Name = "psamountDataGridViewTextBoxColumn";
            this.psamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pspriceDataGridViewTextBoxColumn
            // 
            this.pspriceDataGridViewTextBoxColumn.DataPropertyName = "ps_price";
            this.pspriceDataGridViewTextBoxColumn.FillWeight = 60F;
            this.pspriceDataGridViewTextBoxColumn.HeaderText = "តំលៃរាយ($)";
            this.pspriceDataGridViewTextBoxColumn.Name = "pspriceDataGridViewTextBoxColumn";
            this.pspriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pstotalDataGridViewTextBoxColumn
            // 
            this.pstotalDataGridViewTextBoxColumn.DataPropertyName = "ps_total";
            this.pstotalDataGridViewTextBoxColumn.FillWeight = 60F;
            this.pstotalDataGridViewTextBoxColumn.HeaderText = "សរុប($)";
            this.pstotalDataGridViewTextBoxColumn.Name = "pstotalDataGridViewTextBoxColumn";
            this.pstotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fungetPrescriptionByPatIDBindingSource
            // 
            this.fungetPrescriptionByPatIDBindingSource.DataMember = "fun_getPrescriptionByPatID";
            this.fungetPrescriptionByPatIDBindingSource.DataSource = this.dentistDataSet;
            // 
            // fungetAllMedDetailbyCatIDBindingSource1
            // 
            this.fungetAllMedDetailbyCatIDBindingSource1.DataMember = "fun_getAllMedDetailbyCatID";
            this.fungetAllMedDetailbyCatIDBindingSource1.DataSource = this.dentistDataSet;
            // 
            // fun_getPrescriptionByPatIDTableAdapter
            // 
            this.fun_getPrescriptionByPatIDTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Amount Left In Stock";
            // 
            // txtAmountLeft
            // 
            this.txtAmountLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountLeft.Location = new System.Drawing.Point(556, 102);
            this.txtAmountLeft.Name = "txtAmountLeft";
            this.txtAmountLeft.ReadOnly = true;
            this.txtAmountLeft.Size = new System.Drawing.Size(55, 26);
            this.txtAmountLeft.TabIndex = 44;
            this.txtAmountLeft.Text = "0";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(17, 340);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 37);
            this.btnHome.TabIndex = 46;
            this.btnHome.Text = "Back";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Date";
            // 
            // frm_patient_prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmountLeft);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvMed1);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboServiceDetail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudPricePerUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.dtp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_patient_prescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_patient_prescription";
            this.Load += new System.EventHandler(this.frm_patient_prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllMedDetailbyCatIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPricePerUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllMedCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPrescriptionByPatIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllMedDetailbyCatIDBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboServiceDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPricePerUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label2;
        private DentistDataSet dentistDataSet;
        private System.Windows.Forms.BindingSource fungetAllMedCategoryBindingSource;
        private DentistDataSetTableAdapters.fun_getAllMedCategoryTableAdapter fun_getAllMedCategoryTableAdapter;
        private System.Windows.Forms.BindingSource fungetAllMedDetailbyCatIDBindingSource;
        private DentistDataSetTableAdapters.fun_getAllMedDetailbyCatIDTableAdapter fun_getAllMedDetailbyCatIDTableAdapter;
        private System.Windows.Forms.BindingSource fungetPrescriptionByPatIDBindingSource;
        private System.Windows.Forms.BindingSource fungetAllMedDetailbyCatIDBindingSource1;
        private DentistDataSetTableAdapters.fun_getPrescriptionByPatIDTableAdapter fun_getPrescriptionByPatIDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn psdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn psdesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn psunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn psamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pspriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pstotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmountLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ps_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_id;
        private System.Windows.Forms.Button btnHome;
        private dentist.Grid dgvMed1;
        private dentist.Grid dataGridView1;
        private System.Windows.Forms.Label label8;
    }
}