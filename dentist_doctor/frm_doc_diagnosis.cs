using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist_doctor
{
    public partial class frm_doc_diagnosis : Form
    {
      
        private int cus_id = 1;
        private DataTable dt = new DataTable();
        private void cbo_doc_diagnosis_Click(object sender, EventArgs e)
        {
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if(cbo_doc_diagnosis.Text!="" & cbo_doc_diagnosis_detail.Text!="")
            {
                dt.Rows.Add(int.Parse(cbo_doc_diagnosis_detail.Text),"Up",cbo_doc_diagnosis.Text,txt_doc_diagnosis.Text);
            }
            cbo_doc_diagnosis.SelectedIndex = -1;
     
            txt_doc_diagnosis.Text = "";
            
        }

        private void frm_doc_diagnosis_Load(object sender, EventArgs e)
        {
            this.dt.Columns.Add("Teeth Number", typeof(int));
            this.dt.Columns.Add("Teeth Point", typeof(string));
            this.dt.Columns.Add("Teeth Condition", typeof(string));
            this.dt.Columns.Add("Detail", typeof(string));
            dgv_teeth.DataSource = dt;
            dgv_teeth.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
            dgv_doc_diagnosis.DataSource = StoreProcedure.get_teeth(cus_id);
            dgv_doc_diagnosis.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewRow x in dgv_doc_diagnosis.Rows)
            {
                x.MinimumHeight = 50;
            }

        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (cbo_doc_diagnosis.Text != "" & cbo_doc_diagnosis_detail.Text != "")
            {
                dt.Rows.Add(int.Parse(cbo_doc_diagnosis_detail.Text), "Left", cbo_doc_diagnosis.Text, txt_doc_diagnosis.Text);
            }
            cbo_doc_diagnosis.SelectedIndex = -1;
        
            txt_doc_diagnosis.Text = "";
            
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (cbo_doc_diagnosis.Text != "" & cbo_doc_diagnosis_detail.Text != "")
            {
                dt.Rows.Add(int.Parse(cbo_doc_diagnosis_detail.Text), "Right", cbo_doc_diagnosis.Text, txt_doc_diagnosis.Text);
            }
            cbo_doc_diagnosis.SelectedIndex = -1;
        
            txt_doc_diagnosis.Text = "";
            
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (cbo_doc_diagnosis.Text != "" & cbo_doc_diagnosis_detail.Text != "")
            {
                dt.Rows.Add(int.Parse(cbo_doc_diagnosis_detail.Text), "Up", cbo_doc_diagnosis.Text, txt_doc_diagnosis.Text);
            }
            cbo_doc_diagnosis.SelectedIndex = -1;
        
            txt_doc_diagnosis.Text = "";
          
        }

        private void btn_doc_diagnosis_submit_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count>0)
                StoreProcedure.sp_insert_teeth(dt,cus_id);
            dt.Clear();
            dgv_doc_diagnosis.DataSource = StoreProcedure.get_teeth(cus_id);

        }

        private void btn_middle_Click(object sender, EventArgs e)
        {
            if (cbo_doc_diagnosis.Text != "" & cbo_doc_diagnosis_detail.Text != "")
            {
                dt.Rows.Add(int.Parse(cbo_doc_diagnosis_detail.Text), "Middle", cbo_doc_diagnosis.Text, txt_doc_diagnosis.Text);
            }
            cbo_doc_diagnosis.SelectedIndex = -1;
        
            txt_doc_diagnosis.Text = "";
            
        }


        public frm_doc_diagnosis()
        {
            InitializeComponent();
        }

        private void cbo_doc_diagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_doc_diagnosis_Click(object sender, EventArgs e)
        {
            
        }

        private void cbo_doc_diagnosis_detail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) == true || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete)))
            {
                e.Handled = true;
            }
           
        }

        private void dgv_doc_diagnosis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewBand band in dgv_doc_diagnosis.Columns)
            {
                band.ReadOnly = true;
            }
            dgv_doc_diagnosis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
