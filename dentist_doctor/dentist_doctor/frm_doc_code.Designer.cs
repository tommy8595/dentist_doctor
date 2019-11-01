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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_doc_code = new System.Windows.Forms.TextBox();
            this.btn_doc_submit = new System.Windows.Forms.Button();
            this.txt_doc_search = new System.Windows.Forms.TextBox();
            this.btn_doc_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "code";
            // 
            // txt_doc_code
            // 
            this.txt_doc_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_code.Location = new System.Drawing.Point(594, 407);
            this.txt_doc_code.Name = "txt_doc_code";
            this.txt_doc_code.Size = new System.Drawing.Size(544, 38);
            this.txt_doc_code.TabIndex = 2;
            // 
            // btn_doc_submit
            // 
            this.btn_doc_submit.Location = new System.Drawing.Point(594, 480);
            this.btn_doc_submit.Name = "btn_doc_submit";
            this.btn_doc_submit.Size = new System.Drawing.Size(544, 81);
            this.btn_doc_submit.TabIndex = 5;
            this.btn_doc_submit.Text = "submit";
            this.btn_doc_submit.UseVisualStyleBackColor = true;
            this.btn_doc_submit.Click += new System.EventHandler(this.btn_doc_submit_Click);
            // 
            // txt_doc_search
            // 
            this.txt_doc_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_search.Location = new System.Drawing.Point(790, 46);
            this.txt_doc_search.Name = "txt_doc_search";
            this.txt_doc_search.Size = new System.Drawing.Size(544, 38);
            this.txt_doc_search.TabIndex = 6;
            // 
            // btn_doc_search
            // 
            this.btn_doc_search.Location = new System.Drawing.Point(1357, 46);
            this.btn_doc_search.Name = "btn_doc_search";
            this.btn_doc_search.Size = new System.Drawing.Size(203, 38);
            this.btn_doc_search.TabIndex = 7;
            this.btn_doc_search.Text = "submit";
            this.btn_doc_search.UseVisualStyleBackColor = true;
            // 
            // frm_doc_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.btn_doc_search);
            this.Controls.Add(this.txt_doc_search);
            this.Controls.Add(this.btn_doc_submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_doc_code);
            this.MaximizeBox = false;
            this.Name = "frm_doc_code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_doc_code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_doc_code;
        private System.Windows.Forms.Button btn_doc_submit;
        private System.Windows.Forms.TextBox txt_doc_search;
        private System.Windows.Forms.Button btn_doc_search;
    }
}