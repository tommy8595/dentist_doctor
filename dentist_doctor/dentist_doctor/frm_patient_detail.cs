
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
    public partial class frm_patient_detail : Form
    {
        public frm_patient_detail()
        {
            InitializeComponent();
        }

        private void frm_patient_detail_Load(object sender, EventArgs e)
        {   if (GlobalVariable._Pat_id != "")
            {
                RetreiveData(int.Parse(GlobalVariable._Pat_id));
                txtId.Text = GlobalVariable._Pat_id;
            }

            txtDes.KeyPress += new KeyPressEventHandler(EventHandlerr.TextBoxTextOnly);
            
        }
        private void RetreiveData(int pat_id)
        {
            try
            {
                DataTable dt;
                this.fun_getPatientByIDTableAdapter.Fill(dentistDataSet.fun_getPatientByID, pat_id);
                this.fun_getMedicalHistoryForSpecificPatientTableAdapter.Fill(dentistDataSet.fun_getMedicalHistoryForSpecificPatient, pat_id);
                dt = this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter.GetData(pat_id);
                foreach (DataRow row in dt.Rows)
                {
                    dgvMd.Rows.Add(
                        row["pat_id"].ToString(),
                        row["md_id"].ToString(),
                        row["md_name"].ToString(),
                        row["md_description"].ToString(),
                        row["md_status"].ToString()
                        );
                }
                GlobalMethod.getGreenRed("md_status", dgvMd, "Inactive");
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_patient_detail + RetreiveData :" + t.Message + t.StackTrace);
            }
        }

        private void btnShowPic_Click(object sender, EventArgs e)
        {
            try
            {
                this.fun_getPatientImageByIDTableAdapter.Fill(dentistDataSet.fun_getPatientImageByID, int.Parse(GlobalVariable._Pat_id));
                int rotateOrder = int.Parse(this.fun_getPatientImageByIDTableAdapter.GetData(int.Parse(GlobalVariable._Pat_id)).Rows[0]["pat_image_order"].ToString());
                for (int i = 0; i < rotateOrder; i++)
                {
                    GlobalMethod.rotateimage(pictureBox1);
                }
            }
            catch (Exception t )
            {

                GlobalMethod.HandleException("frm_patient_detail + btnShowPic_Click :" + t.Message + t.StackTrace);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMd.Rows)
            {
                if (row.Cells["md_id"].Value​​.ToString() == cboMd.SelectedValue.ToString())
                {
                    MyMSB.Show("ប្រវតិ្តវេជ្ជសាស្រ្តបានបញ្ចូលរួចហើយ", "0", false);
                    return;
                }
            }
            dgvMd.Rows.Add(txtId.Text, cboMd.SelectedValue, GlobalMethod.getCboData(cboMd, "md_name"), txtDes.Text, "Active");
            if (dgvMd.Rows.Count > 0) { StoreProcedure.spd_insert_patient_md(dgvMd); }
        }

        private void btnInactive_Click(object sender, EventArgs e)
        {
            try
            {
                string md_name, md_des, md_status;
                int md_id;
                md_id = int.Parse(dgvMd.CurrentRow.Cells["md_id"].Value.ToString());
                md_name = dgvMd.CurrentRow.Cells["md_name"].Value.ToString();
                md_des = dgvMd.CurrentRow.Cells["md_description"].Value.ToString();
                md_status = dgvMd.CurrentRow.Cells["md_status"].Value.ToString();
                frm_edit_medicalHistory form = new frm_edit_medicalHistory(md_name, md_des, md_status, int.Parse(txtId.Text), md_id);
                form.ShowDialog();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_patient_detail + btnInactive_Click :" + t.Message + t.StackTrace);
            }
        }

        private void frm_patient_detail_Activated(object sender, EventArgs e)
        {
            try
            {
                dgvMd.Rows.Clear();
                DataTable dt = this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter.GetData(int.Parse(txtId.Text));
                foreach (DataRow row in dt.Rows)
                {
                    dgvMd.Rows.Add(
                        row["pat_id"].ToString(),
                        row["md_id"].ToString(),
                        row["md_name"].ToString(),
                        row["md_description"].ToString(),
                        row["md_status"].ToString()
                        );
                }
                GlobalMethod.getGreenRed("md_status", dgvMd, "Inactive");
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_patient_detail + frm_patient_detail_Activated :" + t.Message + t.StackTrace);
            }
        }
        private void btn_Reg_Pat_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
