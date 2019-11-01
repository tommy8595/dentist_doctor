namespace dentist_doctor
{
    partial class frm_doc_action
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
            this.btn_diagnosis = new System.Windows.Forms.Button();
            this.btn_treatment = new System.Windows.Forms.Button();
            this.btn_doc_action_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_diagnosis
            // 
            this.btn_diagnosis.Location = new System.Drawing.Point(192, 176);
            this.btn_diagnosis.Name = "btn_diagnosis";
            this.btn_diagnosis.Size = new System.Drawing.Size(206, 278);
            this.btn_diagnosis.TabIndex = 0;
            this.btn_diagnosis.Text = "diagnosis";
            this.btn_diagnosis.UseVisualStyleBackColor = true;
            this.btn_diagnosis.Click += new System.EventHandler(this.btn_diagnosis_Click);
            // 
            // btn_treatment
            // 
            this.btn_treatment.Location = new System.Drawing.Point(486, 176);
            this.btn_treatment.Name = "btn_treatment";
            this.btn_treatment.Size = new System.Drawing.Size(206, 278);
            this.btn_treatment.TabIndex = 1;
            this.btn_treatment.Text = "treatment";
            this.btn_treatment.UseVisualStyleBackColor = true;
            this.btn_treatment.Click += new System.EventHandler(this.btn_treatment_Click);
            // 
            // btn_doc_action_back
            // 
            this.btn_doc_action_back.Location = new System.Drawing.Point(49, 554);
            this.btn_doc_action_back.Name = "btn_doc_action_back";
            this.btn_doc_action_back.Size = new System.Drawing.Size(206, 76);
            this.btn_doc_action_back.TabIndex = 2;
            this.btn_doc_action_back.Text = "back";
            this.btn_doc_action_back.UseVisualStyleBackColor = true;
            this.btn_doc_action_back.Click += new System.EventHandler(this.btn_doc_action_back_Click);
            // 
            // frm_doc_action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 677);
            this.Controls.Add(this.btn_doc_action_back);
            this.Controls.Add(this.btn_treatment);
            this.Controls.Add(this.btn_diagnosis);
            this.Name = "frm_doc_action";
            this.Text = "frm_doc_action";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_diagnosis;
        private System.Windows.Forms.Button btn_treatment;
        private System.Windows.Forms.Button btn_doc_action_back;
    }
}