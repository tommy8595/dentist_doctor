namespace dentist_doctor
{
    partial class frm_doc_code
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_doc_code = new System.Windows.Forms.TextBox();
            this.btn_doc_submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDocName = new System.Windows.Forms.Label();
            this.lblDocId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dentistDataSet = new dentist_doctor.DentistDataSet();
            this.fun_getPatientCodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fun_getPatientCodeTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getPatientCodeTableAdapter();
            this.cboSearchChoice = new System.Windows.Forms.ComboBox();
            this.btn_Patient_Search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPatientDetail = new System.Windows.Forms.Button();
            this.dgvAllPatient = new System.Windows.Forms.DataGridView();
            this.fungetAllPatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fun_getAllPatientTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getAllPatientTableAdapter();
            this.pat_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullKhName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pat_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPatientCodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllPatientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 583);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "CODE:";
            // 
            // txt_doc_code
            // 
            this.txt_doc_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_code.Location = new System.Drawing.Point(96, 579);
            this.txt_doc_code.Margin = new System.Windows.Forms.Padding(2);
            this.txt_doc_code.Name = "txt_doc_code";
            this.txt_doc_code.Size = new System.Drawing.Size(149, 32);
            this.txt_doc_code.TabIndex = 2;
            this.txt_doc_code.Text = "15752";
            // 
            // btn_doc_submit
            // 
            this.btn_doc_submit.Location = new System.Drawing.Point(25, 616);
            this.btn_doc_submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_doc_submit.Name = "btn_doc_submit";
            this.btn_doc_submit.Size = new System.Drawing.Size(408, 66);
            this.btn_doc_submit.TabIndex = 5;
            this.btn_doc_submit.Text = "submit";
            this.btn_doc_submit.UseVisualStyleBackColor = true;
            this.btn_doc_submit.Click += new System.EventHandler(this.btn_doc_submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "ឈ្មោះវេជ្ជបណ្ឌិតៈ";
            // 
            // lblDocName
            // 
            this.lblDocName.AutoSize = true;
            this.lblDocName.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocName.Location = new System.Drawing.Point(183, 7);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(124, 29);
            this.lblDocName.TabIndex = 9;
            this.lblDocName.Text = "ឈ្មោះវេជ្ជបណ្ឌិតៈ";
            // 
            // lblDocId
            // 
            this.lblDocId.AutoSize = true;
            this.lblDocId.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocId.Location = new System.Drawing.Point(183, 36);
            this.lblDocId.Name = "lblDocId";
            this.lblDocId.Size = new System.Drawing.Size(167, 29);
            this.lblDocId.TabIndex = 11;
            this.lblDocId.Text = "លេខសម្គាល់វេជ្ជបណ្ឌិតៈ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "លេខសម្គាល់វេជ្ជបណ្ឌិតៈ";
            // 
            // dentistDataSet
            // 
            this.dentistDataSet.DataSetName = "DentistDataSet";
            this.dentistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fun_getPatientCodeBindingSource
            // 
            this.fun_getPatientCodeBindingSource.DataMember = "fun_getPatientCode";
            this.fun_getPatientCodeBindingSource.DataSource = this.dentistDataSet;
            // 
            // fun_getPatientCodeTableAdapter
            // 
            this.fun_getPatientCodeTableAdapter.ClearBeforeFill = true;
            // 
            // cboSearchChoice
            // 
            this.cboSearchChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchChoice.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearchChoice.FormattingEnabled = true;
            this.cboSearchChoice.Items.AddRange(new object[] {
            "តាមរយៈលេខទូរស័ព្ទ",
            "តាមរយៈឈ្មោះ(ខ្មែរ)",
            "តាមរយៈលេខសម្គាល់",
            "តាមរយៈឈ្មោះ(អង់គ្លេស)"});
            this.cboSearchChoice.Location = new System.Drawing.Point(542, 10);
            this.cboSearchChoice.Name = "cboSearchChoice";
            this.cboSearchChoice.Size = new System.Drawing.Size(196, 35);
            this.cboSearchChoice.TabIndex = 14;
            // 
            // btn_Patient_Search
            // 
            this.btn_Patient_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btn_Patient_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Patient_Search.FlatAppearance.BorderSize = 0;
            this.btn_Patient_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Patient_Search.Font = new System.Drawing.Font("Khmer OS Battambang", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Patient_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Patient_Search.Location = new System.Drawing.Point(1058, 11);
            this.btn_Patient_Search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Patient_Search.Name = "btn_Patient_Search";
            this.btn_Patient_Search.Size = new System.Drawing.Size(103, 32);
            this.btn_Patient_Search.TabIndex = 13;
            this.btn_Patient_Search.Text = "ស្វែងរក";
            this.btn_Patient_Search.UseVisualStyleBackColor = false;
            this.btn_Patient_Search.Click += new System.EventHandler(this.btn_Patient_Search_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(752, 9);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(299, 36);
            this.txtSearch.TabIndex = 12;
            // 
            // btnPatientDetail
            // 
            this.btnPatientDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btnPatientDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientDetail.FlatAppearance.BorderSize = 0;
            this.btnPatientDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientDetail.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDetail.ForeColor = System.Drawing.Color.White;
            this.btnPatientDetail.Location = new System.Drawing.Point(998, 49);
            this.btnPatientDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnPatientDetail.Name = "btnPatientDetail";
            this.btnPatientDetail.Size = new System.Drawing.Size(163, 32);
            this.btnPatientDetail.TabIndex = 90;
            this.btnPatientDetail.Text = "ពិនិត្យពត៌មានលំអិត ";
            this.btnPatientDetail.UseVisualStyleBackColor = false;
            this.btnPatientDetail.Click += new System.EventHandler(this.btnPatientDetail_Click);
            // 
            // dgvAllPatient
            // 
            this.dgvAllPatient.AllowUserToAddRows = false;
            this.dgvAllPatient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.dgvAllPatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllPatient.AutoGenerateColumns = false;
            this.dgvAllPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllPatient.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAllPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pat_id,
            this.fullKhName,
            this.fullname,
            this.pat_tel});
            this.dgvAllPatient.DataSource = this.fungetAllPatientBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllPatient.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAllPatient.Location = new System.Drawing.Point(14, 96);
            this.dgvAllPatient.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAllPatient.MultiSelect = false;
            this.dgvAllPatient.Name = "dgvAllPatient";
            this.dgvAllPatient.ReadOnly = true;
            this.dgvAllPatient.RowHeadersWidth = 51;
            this.dgvAllPatient.RowTemplate.Height = 30;
            this.dgvAllPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllPatient.Size = new System.Drawing.Size(1147, 422);
            this.dgvAllPatient.TabIndex = 89;
            // 
            // fungetAllPatientBindingSource
            // 
            this.fungetAllPatientBindingSource.DataMember = "fun_getAllPatient";
            this.fungetAllPatientBindingSource.DataSource = this.dentistDataSet;
            // 
            // fun_getAllPatientTableAdapter
            // 
            this.fun_getAllPatientTableAdapter.ClearBeforeFill = true;
            // 
            // pat_id
            // 
            this.pat_id.DataPropertyName = "pat_id";
            this.pat_id.HeaderText = "pat_id";
            this.pat_id.Name = "pat_id";
            this.pat_id.ReadOnly = true;
            this.pat_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pat_id.Visible = false;
            // 
            // fullKhName
            // 
            this.fullKhName.DataPropertyName = "fullKhName";
            this.fullKhName.HeaderText = "ឈ្មោះ";
            this.fullKhName.Name = "fullKhName";
            this.fullKhName.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.DataPropertyName = "fullname";
            this.fullname.HeaderText = "Name";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // pat_tel
            // 
            this.pat_tel.DataPropertyName = "pat_tel";
            this.pat_tel.HeaderText = "ល.ទូរស័ព្ទ";
            this.pat_tel.Name = "pat_tel";
            this.pat_tel.ReadOnly = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(941, 616);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(220, 66);
            this.btnBack.TabIndex = 91;
            this.btnBack.Text = "ត្រលប់ក្រោយ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frm_doc_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPatientDetail);
            this.Controls.Add(this.dgvAllPatient);
            this.Controls.Add(this.cboSearchChoice);
            this.Controls.Add(this.btn_Patient_Search);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblDocId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDocName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_doc_submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_doc_code);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frm_doc_code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_doc_code";
            this.Load += new System.EventHandler(this.frm_doc_code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getPatientCodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fungetAllPatientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_doc_code;
        private System.Windows.Forms.Button btn_doc_submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDocName;
        private System.Windows.Forms.Label lblDocId;
        private System.Windows.Forms.Label label4;
        private DentistDataSet dentistDataSet;
        private System.Windows.Forms.BindingSource fun_getPatientCodeBindingSource;
        private DentistDataSetTableAdapters.fun_getPatientCodeTableAdapter fun_getPatientCodeTableAdapter;
        private System.Windows.Forms.ComboBox cboSearchChoice;
        private System.Windows.Forms.Button btn_Patient_Search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPatientDetail;
        private System.Windows.Forms.DataGridView dgvAllPatient;
        private System.Windows.Forms.BindingSource fungetAllPatientBindingSource;
        private DentistDataSetTableAdapters.fun_getAllPatientTableAdapter fun_getAllPatientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullKhName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pat_tel;
        private System.Windows.Forms.Button btnBack;
    }
}