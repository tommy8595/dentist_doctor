using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist_doctor
{
    public partial class frm_doc_diagnosis : Form
    {

        private int pat_id = 0;
        private DataTable dt = new DataTable();
        private DataTable dt1 = new DataTable();
        public frm_doc_diagnosis()
        {
            InitializeComponent();
        }
        private void cbo_doc_diagnosis_Click(object sender, EventArgs e)
        {
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if(cbo_doc_diagnosis.Text!="" & cbo_doc_diagnosis_detail.Text!="")
            {
                dt.Rows.Add(int.Parse(cbo_doc_diagnosis_detail.Text),"Up",cbo_doc_diagnosis.Text,txt_doc_diagnosis.Text);
            }
            cbo_doc_diagnosis.SelectedIndex = 1;
     
            txt_doc_diagnosis.Text = "";
            
        }

        private void frm_doc_diagnosis_Load(object sender, EventArgs e)
        {
            pat_id = int.Parse(GlobalVariable._Pat_id);
            cbo_doc_diagnosis.SelectedIndex = 0;
            cbo_doc_diagnosis_detail.SelectedIndex = 0;
            this.dt.Columns.Add("លេខលំដាប់នៃធ្មេញ", typeof(int));
            this.dt.Columns.Add("ទីតាំងលំអិតនៃធ្មេញ", typeof(string));
            this.dt.Columns.Add("ស្ថានភាពធ្មេញ", typeof(string));
            this.dt.Columns.Add("ពត៌មានលំអិត", typeof(string));
            dgv_teeth.DataSource = dt;
            dgv_teeth.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
            dt1 = StoreProcedure.get_teeth(pat_id);
            foreach (DataRow row in dt1.Rows)
            {
                dgv_doc_diagnosis.Rows.Add(row[0],row[1], row[2], row[3]);
            }
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if (cbo_doc_diagnosis.Text != "" & cbo_doc_diagnosis_detail.Text != "")
            {
                dt.Rows.Add(int.Parse(cbo_doc_diagnosis_detail.Text), "Left", cbo_doc_diagnosis.Text, txt_doc_diagnosis.Text);
            }
            cbo_doc_diagnosis.SelectedIndex = 1;
        
            txt_doc_diagnosis.Text = "";
            
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (cbo_doc_diagnosis.Text != "" & cbo_doc_diagnosis_detail.Text != "")
            {
                dt.Rows.Add(int.Parse(cbo_doc_diagnosis_detail.Text), "Right", cbo_doc_diagnosis.Text, txt_doc_diagnosis.Text);
            }
            cbo_doc_diagnosis.SelectedIndex = 1;
        
            txt_doc_diagnosis.Text = "";
            
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (cbo_doc_diagnosis.Text != "" & cbo_doc_diagnosis_detail.Text != "")
            {
                dt.Rows.Add(int.Parse(cbo_doc_diagnosis_detail.Text), "Up", cbo_doc_diagnosis.Text, txt_doc_diagnosis.Text);
            }
            cbo_doc_diagnosis.SelectedIndex = 1;
        
            txt_doc_diagnosis.Text = "";
          
        }

        private void btn_doc_diagnosis_submit_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count>0)
            StoreProcedure.sp_insert_teeth(dt,pat_id);
            dt.Clear();
            if (MyMSB.Show("ការក្សាទុកបានជោគជ័យ។", "1", false)) { btnNext.PerformClick(); }

        }

        private void btn_middle_Click(object sender, EventArgs e)
        {
            if (cbo_doc_diagnosis.Text != "" & cbo_doc_diagnosis_detail.Text != "")
            {
                dt.Rows.Add(int.Parse(cbo_doc_diagnosis_detail.Text), "Middle", cbo_doc_diagnosis.Text, txt_doc_diagnosis.Text);
            }
            cbo_doc_diagnosis.SelectedIndex = 1;
        
            txt_doc_diagnosis.Text = "";
            
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

        private void btn_doc_diagnosis_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openCode);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openCode()
        {
            Application.Run(new frm_doc_action());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openTP);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openTP()
        {
            Application.Run(new frm_doc_treatment());
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openXray);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openXray()
        {
            Application.Run(new frm_patient_Xray());
        }
    }
}
