namespace dentist_doctor
{
    partial class frm_doc_login
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
            this.txt_doc_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_doc_password = new System.Windows.Forms.TextBox();
            this.btn_doc_login = new System.Windows.Forms.Button();
            this.dentistDataSet = new dentist_doctor.DentistDataSet();
            this.fun_getDoctorLoginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fun_getDoctorLoginTableAdapter = new dentist_doctor.DentistDataSetTableAdapters.fun_getDoctorLoginTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getDoctorLoginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_doc_username
            // 
            this.txt_doc_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_username.Location = new System.Drawing.Point(364, 249);
            this.txt_doc_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_doc_username.Name = "txt_doc_username";
            this.txt_doc_username.Size = new System.Drawing.Size(409, 32);
            this.txt_doc_username.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txt_doc_password
            // 
            this.txt_doc_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_password.Location = new System.Drawing.Point(364, 303);
            this.txt_doc_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_doc_password.Name = "txt_doc_password";
            this.txt_doc_password.Size = new System.Drawing.Size(409, 32);
            this.txt_doc_password.TabIndex = 2;
            // 
            // btn_doc_login
            // 
            this.btn_doc_login.Location = new System.Drawing.Point(364, 364);
            this.btn_doc_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_doc_login.Name = "btn_doc_login";
            this.btn_doc_login.Size = new System.Drawing.Size(408, 66);
            this.btn_doc_login.TabIndex = 4;
            this.btn_doc_login.Text = "Login";
            this.btn_doc_login.UseVisualStyleBackColor = true;
            this.btn_doc_login.Click += new System.EventHandler(this.btn_doc_login_Click);
            // 
            // dentistDataSet
            // 
            this.dentistDataSet.DataSetName = "DentistDataSet";
            this.dentistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fun_getDoctorLoginBindingSource
            // 
            this.fun_getDoctorLoginBindingSource.DataMember = "fun_getDoctorLogin";
            this.fun_getDoctorLoginBindingSource.DataSource = this.dentistDataSet;
            // 
            // fun_getDoctorLoginTableAdapter
            // 
            this.fun_getDoctorLoginTableAdapter.ClearBeforeFill = true;
            // 
            // frm_doc_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 693);
            this.Controls.Add(this.btn_doc_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_doc_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_doc_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frm_doc_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.frm_doc_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fun_getDoctorLoginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_doc_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_doc_password;
        private System.Windows.Forms.Button btn_doc_login;
        private DentistDataSet dentistDataSet;
        private System.Windows.Forms.BindingSource fun_getDoctorLoginBindingSource;
        private DentistDataSetTableAdapters.fun_getDoctorLoginTableAdapter fun_getDoctorLoginTableAdapter;
    }
}

