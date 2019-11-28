namespace dentist_doctor
{
    partial class frm_patient_Xray
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboXray = new System.Windows.Forms.ComboBox();
            this.fungetXrayMachineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dentistDataSet = new dentist_doctor.DentistDataSet();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fun_getXrayMachineTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getXrayMachineTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvOne = new dentist.Grid();
            this.xray_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patxraydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patxraycodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fungetPatientXrayByPatIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fun_getPatientXrayByPatIDTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getPatientXrayByPatIDTableAdapter();
            this.btnNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fungetXrayMachineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientXrayByPatIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(71)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1265, 55);
            this.panel4.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(495, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 92;
            this.label3.Text = "X Ray Machine";
            // 
            // cboXray
            // 
            this.cboXray.DataSource = this.fungetXrayMachineBindingSource;
            this.cboXray.DisplayMember = "x_name";
            this.cboXray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXray.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboXray.FormattingEnabled = true;
            this.cboXray.Location = new System.Drawing.Point(127, 91);
            this.cboXray.Name = "cboXray";
            this.cboXray.Size = new System.Drawing.Size(226, 28);
            this.cboXray.TabIndex = 112;
            this.cboXray.ValueMember = "xray_id";
            // 
            // fungetXrayMachineBindingSource
            // 
            this.fungetXrayMachineBindingSource.DataMember = "fun_getXrayMachine";
            this.fungetXrayMachineBindingSource.DataSource = this.dentistDataSet;
            // 
            // dentistDataSet
            // 
            this.dentistDataSet.DataSetName = "DentistDataSet";
            this.dentistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(426, 91);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(402, 26);
            this.txtCode.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(374, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "Code";
            // 
            // fun_getXrayMachineTableAdapter
            // 
            this.fun_getXrayMachineTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 114;
            this.label2.Text = "Machine Type";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(834, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 115;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvOne
            // 
            this.dgvOne.AllowUserToAddRows = false;
            this.dgvOne.AllowUserToDeleteRows = false;
            this.dgvOne.AutoGenerateColumns = false;
            this.dgvOne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOne.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xray_id,
            this.patxraydateDataGridViewTextBoxColumn,
            this.xnameDataGridViewTextBoxColumn,
            this.patxraycodeDataGridViewTextBoxColumn});
            this.dgvOne.DataSource = this.fungetPatientXrayByPatIDBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOne.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOne.Location = new System.Drawing.Point(12, 166);
            this.dgvOne.MultiSelect = false;
            this.dgvOne.Name = "dgvOne";
            this.dgvOne.ReadOnly = true;
            this.dgvOne.RowTemplate.Height = 30;
            this.dgvOne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOne.Size = new System.Drawing.Size(897, 533);
            this.dgvOne.TabIndex = 116;
            // 
            // xray_id
            // 
            this.xray_id.DataPropertyName = "xray_id";
            this.xray_id.HeaderText = "xray_id";
            this.xray_id.Name = "xray_id";
            this.xray_id.ReadOnly = true;
            this.xray_id.Visible = false;
            // 
            // patxraydateDataGridViewTextBoxColumn
            // 
            this.patxraydateDataGridViewTextBoxColumn.DataPropertyName = "pat_xray_date";
            dataGridViewCellStyle2.Format = "dd / MM / yyyy";
            this.patxraydateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.patxraydateDataGridViewTextBoxColumn.HeaderText = "កាលបរិច្ឆេទ";
            this.patxraydateDataGridViewTextBoxColumn.Name = "patxraydateDataGridViewTextBoxColumn";
            this.patxraydateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xnameDataGridViewTextBoxColumn
            // 
            this.xnameDataGridViewTextBoxColumn.DataPropertyName = "x_name";
            this.xnameDataGridViewTextBoxColumn.HeaderText = "ឈ្មោះម៉ាស៊ីនស្កែន";
            this.xnameDataGridViewTextBoxColumn.Name = "xnameDataGridViewTextBoxColumn";
            this.xnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patxraycodeDataGridViewTextBoxColumn
            // 
            this.patxraycodeDataGridViewTextBoxColumn.DataPropertyName = "pat_xray_code";
            this.patxraycodeDataGridViewTextBoxColumn.HeaderText = "លេខកូដសម្គាល់";
            this.patxraycodeDataGridViewTextBoxColumn.Name = "patxraycodeDataGridViewTextBoxColumn";
            this.patxraycodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fungetPatientXrayByPatIDBindingSource
            // 
            this.fungetPatientXrayByPatIDBindingSource.DataMember = "fun_getPatientXrayByPatID";
            this.fungetPatientXrayByPatIDBindingSource.DataSource = this.dentistDataSet;
            // 
            // fun_getPatientXrayByPatIDTableAdapter
            // 
            this.fun_getPatientXrayByPatIDTableAdapter.ClearBeforeFill = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1178, 396);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 57);
            this.btnNext.TabIndex = 117;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1182, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 57);
            this.button1.TabIndex = 118;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_patient_Xray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 711);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvOne);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.cboXray);
            this.Controls.Add(this.panel4);
            this.Name = "frm_patient_Xray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_patient_Xray";
            this.Load += new System.EventHandler(this.frm_patient_Xray_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fungetXrayMachineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetPatientXrayByPatIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboXray;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private DentistDataSet dentistDataSet;
        private System.Windows.Forms.BindingSource fungetXrayMachineBindingSource;
        private DentistDataSetTableAdapters.fun_getXrayMachineTableAdapter fun_getXrayMachineTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvOne;
        private System.Windows.Forms.BindingSource fungetPatientXrayByPatIDBindingSource;
        private DentistDataSetTableAdapters.fun_getPatientXrayByPatIDTableAdapter fun_getPatientXrayByPatIDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn xray_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn patxraydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patxraycodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button1;
    }
}