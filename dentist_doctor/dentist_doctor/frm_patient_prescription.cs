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
    public partial class frm_patient_prescription : Form
    {
        public frm_patient_prescription()
        {
            InitializeComponent();
        }
        int pro_Id;
        private void frm_patient_prescription_Load(object sender, EventArgs e)
        {
            try
            {
                StartState();
                // TODO: This line of code loads data into the 'dentistDataSet.fun_getAllMedCategory' table. You can move, or remove it, as needed.
                this.fun_getAllMedCategoryTableAdapter.Fill(this.dentistDataSet.fun_getAllMedCategory);
                this.fun_getPrescriptionByPatIDTableAdapter.Fill(this.dentistDataSet.fun_getPrescriptionByPatID, int.Parse(GlobalVariable._Pat_id));
                dgvMed1.AllowUserToDeleteRows = true;
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_patient_prescription + frm_patient_prescription_Load:" + t.Message + t.StackTrace);
            }
            
        }

        private void StartState()
        {
            nudAmount.Enabled = false;
            btnAdd.Enabled = false;
            btnTotal.Enabled = false;
            btnSubmit.Enabled = false; 
        }

        void OperateState()
        {
            nudAmount.Enabled = true;
            btnAdd.Enabled = true;
            btnTotal.Enabled = true;
            btnSubmit.Enabled = true;
        }
        void ResetState()
        {
            nudAmount.Value = 1;
            txtTotal.Text = "0";
        }

        bool IsAddable()
        {
            if ((cboService.SelectedIndex != -1 && cboServiceDetail.SelectedIndex != -1) && nudAmount.Value != 0) { return true; } else { MyMSB.Show("មិនមានទំនិញក្នុងស្តុកដើម្បីធ្វើការលក់នោះទេ", "0", false);  return false;  }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnTotal.PerformClick();
            if (IsAddable())
            {
                foreach (DataGridViewRow row in dgvMed1.Rows)
                {
                    if (row.Cells["p_id"].Value.ToString() == pro_Id.ToString())
                    {   if (Convert.ToDecimal(row.Cells["ps_amount"].Value) + nudAmount.Value > Convert.ToDecimal(txtAmountLeft.Text)) { MyMSB.Show("មិនមានទំនិញគ្រប់គ្រាន់សម្រាប់ធ្វើការលក់នោះទេ", "0", false); return; }
                        row.Cells["ps_amount"].Value = Convert.ToDecimal(row.Cells["ps_amount"].Value)+ nudAmount.Value;
                        row.Cells["ps_total"].Value = Convert.ToDecimal(row.Cells["ps_amount"].Value) * nudPricePerUnit.Value;
                        ResetState();
                        return;
                    }
                }
                                 dgvMed1.Rows.Add(
                                 GlobalVariable._Pat_id,
                                 dtp.Value.ToString("dd/MMMM/yyyy"),
                                 GlobalMethod.getCboData(cboServiceDetail, "pro_name"),
                                 txtUnit.Text, nudAmount.Value.ToString(),
                                 nudPricePerUnit.Value.ToString(),
                                 txtTotal.Text,
                                 "no",
                                 pro_Id.ToString()
                                 );
                ResetState();
           }
        }

        private void cboServiceDetail_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                OperateState();
                if (cboServiceDetail.SelectedIndex == -1) { return; }
                string[] arr = cboServiceDetail.SelectedValue.ToString().Split('|');
                pro_Id = int.Parse(arr[0]);
                nudPricePerUnit.Value = Convert.ToDecimal(arr[1]);
                txtUnit.Text = arr[2];
                txtAmountLeft.Text = arr[3];
                ResetState();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_patient_prescription + cboServiceDetail_SelectedValueChanged:" + t.Message + t.StackTrace);
            }

        }
        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboService.SelectedIndex == -1) return;
                this.fun_getAllMedDetailbyCatIDTableAdapter.Fill(this.dentistDataSet.fun_getAllMedDetailbyCatID, (int)cboService.SelectedValue);
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_patient_prescription + cboService_SelectedIndexChanged :" + t.Message + t.StackTrace);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (nudPricePerUnit.Value * nudAmount.Value).ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMed1.Rows.Count <= 0) { return; }
                if (!MyMSB.Show("តើអ្នកពិតជាចង់រក្សាទុកមែនទេ?", "1", true)) { return; }
                StoreProcedure.spd_insert_prescription(dgvMed1);
                StoreProcedure.sp_prescript(dgvMed1);
                dgvMed1.Rows.Clear();
                MyMSB.Show("ការរក្សាទុកបានជោគជ័យ", "1", false);
                this.fun_getPrescriptionByPatIDTableAdapter.Fill(this.dentistDataSet.fun_getPrescriptionByPatID, int.Parse(GlobalVariable._Pat_id));
                btnBack.PerformClick();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_patient_prescription + btnSubmit_Click :" + t.Message + t.StackTrace);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (dgvMed1.Rows.Count > 0)
            {
                if (!MyMSB.Show("អ្នកមិនទាន់បានធ្វើការ Submit ទេ។ តើអ្នកពិតជាចង់បោះបង់មែនទេ?", "0", true))
                {
                    return;
                }
            }
            this.Close();
            Thread th = new Thread(OpenAction);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenAction()
        {
            Application.Run(new frm_doc_action());
        }

        private void nudPricePerUnit_ValueChanged(object sender, EventArgs e)
        {
            btnTotal.PerformClick();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvMed1.Rows.Count > 0)
            {
                if (!MyMSB.Show("អ្នកមិនទាន់បានធ្វើការ Submit ទេ។ តើអ្នកពិតជាចង់បោះបង់មែនទេ?", "0", true))
                {
                    return;
                }
            }
            this.Close();
            Thread th = new Thread(OpenTreatmentDetail);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenTreatmentDetail()
        {
            Application.Run(new frm_patient_treamentDetail());
        }
    }
}
