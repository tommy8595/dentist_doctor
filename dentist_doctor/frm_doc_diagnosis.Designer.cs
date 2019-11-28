using dentist;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_middle = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.cbo_doc_diagnosis = new System.Windows.Forms.ComboBox();
            this.txt_doc_diagnosis = new System.Windows.Forms.TextBox();
            this.cbo_doc_diagnosis_detail = new System.Windows.Forms.ComboBox();
            this.btn_doc_diagnosis_submit = new System.Windows.Forms.Button();
            this.btn_doc_diagnosis_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.dgv_teeth = new dentist.Grid();
            this.dgv_doc_diagnosis = new dentist.Grid();
            this.teeth_orderr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teeth_location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teeth_con = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teeth_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teeth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doc_diagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(371, 19);
            this.btn_left.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(42, 191);
            this.btn_left.TabIndex = 0;
            this.btn_left.Text = "Left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(545, 19);
            this.btn_right.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(42, 191);
            this.btn_right.TabIndex = 1;
            this.btn_right.Text = "right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_middle
            // 
            this.btn_middle.Location = new System.Drawing.Point(417, 77);
            this.btn_middle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_middle.Name = "btn_middle";
            this.btn_middle.Size = new System.Drawing.Size(122, 80);
            this.btn_middle.TabIndex = 2;
            this.btn_middle.Text = "Middle";
            this.btn_middle.UseVisualStyleBackColor = true;
            this.btn_middle.Click += new System.EventHandler(this.btn_middle_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(417, 19);
            this.btn_up.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(122, 52);
            this.btn_up.TabIndex = 3;
            this.btn_up.Text = "Up";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(417, 163);
            this.btn_down.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(122, 47);
            this.btn_down.TabIndex = 4;
            this.btn_down.Text = "down";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // cbo_doc_diagnosis
            // 
            this.cbo_doc_diagnosis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_doc_diagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_doc_diagnosis.FormattingEnabled = true;
            this.cbo_doc_diagnosis.Items.AddRange(new object[] {
            "Deep",
            "Shallow"});
            this.cbo_doc_diagnosis.Location = new System.Drawing.Point(24, 61);
            this.cbo_doc_diagnosis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbo_doc_diagnosis.Name = "cbo_doc_diagnosis";
            this.cbo_doc_diagnosis.Size = new System.Drawing.Size(267, 32);
            this.cbo_doc_diagnosis.TabIndex = 1;
            this.cbo_doc_diagnosis.SelectedIndexChanged += new System.EventHandler(this.cbo_doc_diagnosis_SelectedIndexChanged);
            this.cbo_doc_diagnosis.Click += new System.EventHandler(this.cbo_doc_diagnosis_Click);
            // 
            // txt_doc_diagnosis
            // 
            this.txt_doc_diagnosis.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doc_diagnosis.Location = new System.Drawing.Point(656, 50);
            this.txt_doc_diagnosis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_doc_diagnosis.Multiline = true;
            this.txt_doc_diagnosis.Name = "txt_doc_diagnosis";
            this.txt_doc_diagnosis.Size = new System.Drawing.Size(477, 175);
            this.txt_doc_diagnosis.TabIndex = 3;
            this.txt_doc_diagnosis.Click += new System.EventHandler(this.txt_doc_diagnosis_Click);
            // 
            // cbo_doc_diagnosis_detail
            // 
            this.cbo_doc_diagnosis_detail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_doc_diagnosis_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbo_doc_diagnosis_detail.Location = new System.Drawing.Point(24, 138);
            this.cbo_doc_diagnosis_detail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbo_doc_diagnosis_detail.Name = "cbo_doc_diagnosis_detail";
            this.cbo_doc_diagnosis_detail.Size = new System.Drawing.Size(117, 32);
            this.cbo_doc_diagnosis_detail.TabIndex = 2;
            this.cbo_doc_diagnosis_detail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbo_doc_diagnosis_detail_KeyPress);
            // 
            // btn_doc_diagnosis_submit
            // 
            this.btn_doc_diagnosis_submit.Location = new System.Drawing.Point(486, 428);
            this.btn_doc_diagnosis_submit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_doc_diagnosis_submit.Name = "btn_doc_diagnosis_submit";
            this.btn_doc_diagnosis_submit.Size = new System.Drawing.Size(114, 33);
            this.btn_doc_diagnosis_submit.TabIndex = 8;
            this.btn_doc_diagnosis_submit.Text = "submit";
            this.btn_doc_diagnosis_submit.UseVisualStyleBackColor = true;
            this.btn_doc_diagnosis_submit.Click += new System.EventHandler(this.btn_doc_diagnosis_submit_Click);
            // 
            // btn_doc_diagnosis_back
            // 
            this.btn_doc_diagnosis_back.Location = new System.Drawing.Point(1019, 16);
            this.btn_doc_diagnosis_back.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_doc_diagnosis_back.Name = "btn_doc_diagnosis_back";
            this.btn_doc_diagnosis_back.Size = new System.Drawing.Size(114, 32);
            this.btn_doc_diagnosis_back.TabIndex = 11;
            this.btn_doc_diagnosis_back.Text = "Home";
            this.btn_doc_diagnosis_back.UseVisualStyleBackColor = true;
            this.btn_doc_diagnosis_back.Click += new System.EventHandler(this.btn_doc_diagnosis_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Teeth Detail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Teeth Condition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Teeth Order";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1019, 428);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(114, 33);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(24, 429);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(114, 33);
            this.BtnBack.TabIndex = 18;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // dgv_teeth
            // 
            this.dgv_teeth.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.dgv_teeth.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F);
            this.dgv_teeth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_teeth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_teeth.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_teeth.Location = new System.Drawing.Point(24, 267);
            this.dgv_teeth.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_teeth.MultiSelect = false;
            this.dgv_teeth.Name = "dgv_teeth";
            this.dgv_teeth.ReadOnly = true;
            this.dgv_teeth.RowTemplate.Height = 33;
            this.dgv_teeth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_teeth.Size = new System.Drawing.Size(1109, 156);
            this.dgv_teeth.TabIndex = 0;
            // 
            // dgv_doc_diagnosis
            // 
            this.dgv_doc_diagnosis.AllowUserToAddRows = false;
            this.dgv_doc_diagnosis.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(178)))), ((int)(((byte)(73)))));
            this.dgv_doc_diagnosis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_doc_diagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F);
            this.dgv_doc_diagnosis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_doc_diagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doc_diagnosis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teeth_orderr,
            this.teeth_location,
            this.teeth_con,
            this.teeth_detail});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_doc_diagnosis.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_doc_diagnosis.Location = new System.Drawing.Point(24, 468);
            this.dgv_doc_diagnosis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgv_doc_diagnosis.MultiSelect = false;
            this.dgv_doc_diagnosis.Name = "dgv_doc_diagnosis";
            this.dgv_doc_diagnosis.ReadOnly = true;
            this.dgv_doc_diagnosis.RowHeadersWidth = 51;
            this.dgv_doc_diagnosis.RowTemplate.Height = 30;
            this.dgv_doc_diagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_doc_diagnosis.Size = new System.Drawing.Size(1109, 198);
            this.dgv_doc_diagnosis.TabIndex = 10;
            this.dgv_doc_diagnosis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_doc_diagnosis_CellClick);
            // 
            // teeth_orderr
            // 
            this.teeth_orderr.HeaderText = "លេខលំដាប់ធ្មេញ";
            this.teeth_orderr.Name = "teeth_orderr";
            this.teeth_orderr.ReadOnly = true;
            // 
            // teeth_location
            // 
            this.teeth_location.HeaderText = "ទីតាំងលំអិតនៃធ្មេញ";
            this.teeth_location.Name = "teeth_location";
            this.teeth_location.ReadOnly = true;
            // 
            // teeth_con
            // 
            this.teeth_con.HeaderText = "ស្ថានភាពធ្មេញ";
            this.teeth_con.Name = "teeth_con";
            this.teeth_con.ReadOnly = true;
            // 
            // teeth_detail
            // 
            this.teeth_detail.HeaderText = "ពត៌មានលំអិត";
            this.teeth_detail.Name = "teeth_detail";
            this.teeth_detail.ReadOnly = true;
            // 
            // frm_doc_diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1155, 716);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_teeth);
            this.Controls.Add(this.btn_doc_diagnosis_back);
            this.Controls.Add(this.dgv_doc_diagnosis);
            this.Controls.Add(this.btn_doc_diagnosis_submit);
            this.Controls.Add(this.cbo_doc_diagnosis_detail);
            this.Controls.Add(this.txt_doc_diagnosis);
            this.Controls.Add(this.cbo_doc_diagnosis);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_middle);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frm_doc_diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_doc_diagnosis";
            this.Load += new System.EventHandler(this.frm_doc_diagnosis_Load);
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
        private System.Windows.Forms.Button btn_doc_diagnosis_back;
        private Grid dgv_teeth;
        private Grid dgv_doc_diagnosis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn teeth_orderr;
        private System.Windows.Forms.DataGridViewTextBoxColumn teeth_location;
        private System.Windows.Forms.DataGridViewTextBoxColumn teeth_con;
        private System.Windows.Forms.DataGridViewTextBoxColumn teeth_detail;
    }
}