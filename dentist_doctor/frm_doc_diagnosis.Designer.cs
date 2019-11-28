namespace dentist_doctor
{
    partial class frm_doc_diagnosis
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
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_middle = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.cbo_doc_diagnosis = new System.Windows.Forms.ComboBox();
            this.txt_doc_diagnosis = new System.Windows.Forms.TextBox();
            this.cbo_doc_diagnosis_detail = new System.Windows.Forms.ComboBox();
            this.btn_doc_diagnosis_submit = new System.Windows.Forms.Button();
            this.dgv_add = new System.Windows.Forms.Panel();
            this.dgv_teeth = new System.Windows.Forms.DataGridView();
            this.dgv_doc_diagnosis = new System.Windows.Forms.DataGridView();
            this.btn_doc_diagnosis_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teeth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc_diagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(415, 126);
            this.btn_left.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(114, 212);
            this.btn_left.TabIndex = 0;
            this.btn_left.Text = "Left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(794, 126);
            this.btn_right.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(102, 212);
            this.btn_right.TabIndex = 1;
            this.btn_right.Text = "right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_middle
            // 
            this.btn_middle.Location = new System.Drawing.Point(538, 126);
            this.btn_middle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_middle.Name = "btn_middle";
            this.btn_middle.Size = new System.Drawing.Size(244, 212);
            this.btn_middle.TabIndex = 2;
            this.btn_middle.Text = "Middle";
            this.btn_middle.UseVisualStyleBackColor = true;
            this.btn_middle.Click += new System.EventHandler(this.btn_middle_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(538, 40);
            this.btn_up.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(244, 63);
            this.btn_up.TabIndex = 3;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(538, 348);
            this.btn_down.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(244, 59);
            this.btn_down.TabIndex = 4;
            this.btn_down.Text = "down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // cbo_doc_diagnosis
            // 
            this.cbo_doc_diagnosis.FormattingEnabled = true;
            this.cbo_doc_diagnosis.Items.AddRange(new object[] {
            "Strongly demaged",
            "A bit damaged"});
            this.cbo_doc_diagnosis.Location = new System.Drawing.Point(50, 56);
            this.cbo_doc_diagnosis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_doc_diagnosis.Name = "cbo_doc_diagnosis";
            this.cbo_doc_diagnosis.Size = new System.Drawing.Size(236, 33);
            this.cbo_doc_diagnosis.TabIndex = 1;
            this.cbo_doc_diagnosis.SelectedIndexChanged += new System.EventHandler(this.cbo_doc_diagnosis_SelectedIndexChanged);
            this.cbo_doc_diagnosis.Click += new System.EventHandler(this.cbo_doc_diagnosis_Click);
            // 
            // txt_doc_diagnosis
            // 
            this.txt_doc_diagnosis.Location = new System.Drawing.Point(960, 100);
            this.txt_doc_diagnosis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_doc_diagnosis.Multiline = true;
            this.txt_doc_diagnosis.Name = "txt_doc_diagnosis";
            this.txt_doc_diagnosis.Size = new System.Drawing.Size(900, 123);
            this.txt_doc_diagnosis.TabIndex = 3;
            this.txt_doc_diagnosis.Click += new System.EventHandler(this.txt_doc_diagnosis_Click);
            // 
            // cbo_doc_diagnosis_detail
            // 
            this.cbo_doc_diagnosis_detail.FormattingEnabled = true;
            this.cbo_doc_diagnosis_detail.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.cbo_doc_diagnosis_detail.Location = new System.Drawing.Point(50, 218);
            this.cbo_doc_diagnosis_detail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_doc_diagnosis_detail.Name = "cbo_doc_diagnosis_detail";
            this.cbo_doc_diagnosis_detail.Size = new System.Drawing.Size(236, 33);
            this.cbo_doc_diagnosis_detail.TabIndex = 2;
            this.cbo_doc_diagnosis_detail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_doc_diagnosis_detail_KeyPress);
            // 
            // btn_doc_diagnosis_submit
            // 
            this.btn_doc_diagnosis_submit.Location = new System.Drawing.Point(960, 261);
            this.btn_doc_diagnosis_submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_doc_diagnosis_submit.Name = "btn_doc_diagnosis_submit";
            this.btn_doc_diagnosis_submit.Size = new System.Drawing.Size(228, 62);
            this.btn_doc_diagnosis_submit.TabIndex = 8;
            this.btn_doc_diagnosis_submit.Text = "submit";
            this.btn_doc_diagnosis_submit.UseVisualStyleBackColor = true;
            this.btn_doc_diagnosis_submit.Click += new System.EventHandler(this.btn_doc_diagnosis_submit_Click);
            // 
            // dgv_add
            // 
            this.dgv_add.Controls.Add(this.dgv_teeth);
            this.dgv_add.Location = new System.Drawing.Point(50, 459);
            this.dgv_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_add.Name = "dgv_add";
            this.dgv_add.Size = new System.Drawing.Size(2218, 258);
            this.dgv_add.TabIndex = 9;
            // 
            // dgv_teeth
            // 
            this.dgv_teeth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teeth.Location = new System.Drawing.Point(3, 3);
            this.dgv_teeth.Name = "dgv_teeth";
            this.dgv_teeth.RowTemplate.Height = 33;
            this.dgv_teeth.Size = new System.Drawing.Size(2212, 255);
            this.dgv_teeth.TabIndex = 0;
            // 
            // dgv_doc_diagnosis
            // 
            this.dgv_doc_diagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doc_diagnosis.Location = new System.Drawing.Point(47, 765);
            this.dgv_doc_diagnosis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_doc_diagnosis.Name = "dgv_doc_diagnosis";
            this.dgv_doc_diagnosis.RowHeadersWidth = 51;
            this.dgv_doc_diagnosis.RowTemplate.Height = 24;
            this.dgv_doc_diagnosis.Size = new System.Drawing.Size(2218, 497);
            this.dgv_doc_diagnosis.TabIndex = 10;
            this.dgv_doc_diagnosis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_doc_diagnosis_CellClick);
            // 
            // btn_doc_diagnosis_back
            // 
            this.btn_doc_diagnosis_back.Location = new System.Drawing.Point(50, 1272);
            this.btn_doc_diagnosis_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_doc_diagnosis_back.Name = "btn_doc_diagnosis_back";
            this.btn_doc_diagnosis_back.Size = new System.Drawing.Size(228, 62);
            this.btn_doc_diagnosis_back.TabIndex = 11;
            this.btn_doc_diagnosis_back.Text = "back";
            this.btn_doc_diagnosis_back.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 735);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "History Of patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add New record";
            // 
            // frm_doc_diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2373, 1333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_doc_diagnosis_back);
            this.Controls.Add(this.dgv_doc_diagnosis);
            this.Controls.Add(this.dgv_add);
            this.Controls.Add(this.btn_doc_diagnosis_submit);
            this.Controls.Add(this.cbo_doc_diagnosis_detail);
            this.Controls.Add(this.txt_doc_diagnosis);
            this.Controls.Add(this.cbo_doc_diagnosis);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_middle);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_doc_diagnosis";
            this.Text = "frm_doc_diagnosis";
            this.Load += new System.EventHandler(this.frm_doc_diagnosis_Load);
            this.dgv_add.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teeth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc_diagnosis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_middle;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.ComboBox cbo_doc_diagnosis;
        private System.Windows.Forms.TextBox txt_doc_diagnosis;
        private System.Windows.Forms.ComboBox cbo_doc_diagnosis_detail;
        private System.Windows.Forms.Button btn_doc_diagnosis_submit;
        private System.Windows.Forms.Panel dgv_add;
        private System.Windows.Forms.DataGridView dgv_doc_diagnosis;
        private System.Windows.Forms.Button btn_doc_diagnosis_back;
        private System.Windows.Forms.DataGridView dgv_teeth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}