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
    public partial class frm_doc_treatment : Form
    {
        public frm_doc_treatment()
        {
            InitializeComponent();
        }
        int service_id_detail;

        private void frm_doc_treatment_Load(object sender, EventArgs e)
        {
            StartState();
            // TODO: This line of code loads data into the 'dentistDataSet.fun_getAllService' table. You can move, or remove it, as needed.
            this.fun_getAllServiceTableAdapter.Fill(this.dentistDataSet.fun_getAllService);
            this.fun_getAllPatientServiceTableAdapter.Fill(this.dentistDataSet.fun_getAllPatientService, int.Parse(GlobalVariable._Pat_id));
            nudCharge.MouseClick += new MouseEventHandler(EventHandlerr.nudSelectallClick);
            nudDiscount.MouseClick += new MouseEventHandler(EventHandlerr.nudSelectallClick);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (IsAddable())
                {
                    btnTotal.PerformClick();
                    dataGridView1.Rows.Add(GlobalVariable._Pat_id, dtp.Value.ToString("dd/MMMM/yyyy"),
                    service_id_detail.ToString(),
                    GlobalMethod.getCboData(cboServiceDetail, "sd_name"),
                    nudAmount.Value.ToString(),
                    nudCharge.Value.ToString(),
                    nudDiscount.Value.ToString(),
                    txtTotal.Text,
                    GlobalVariable._User_name,
                    GlobalVariable._User_id, "no");
                    ResetState();
                }
            }
            catch (Exception t) 
            {
                GlobalMethod.HandleException("frm_doc_treatment + button1_Click :" + t.Message + t.StackTrace);
            }
        }
        bool IsAddable()
        {
            if (cboService.SelectedIndex != -1 && cboServiceDetail.SelectedIndex != -1 ) { return true; } else { return false; }
        }
        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cboService.SelectedIndex != -1)
                {
                    this.fun_getAllServiceDetailTableAdapter.Fill(dentistDataSet.fun_getAllServiceDetail, (int)cboService.SelectedValue);
                }
            }
            catch (Exception t )
            {
                GlobalMethod.HandleException("frm_doc_treatment + cboService_SelectedIndexChanged :" + t.Message + t.StackTrace);
            }
        }
        void StartState()
        {
            nudCharge.Enabled = false;
            nudAmount.Enabled = false;
            nudDiscount.Enabled = false;
            btnTotal.Enabled = false;
            btnSubmit.Enabled = false;
            btnAdd.Enabled = false;
        }
        void OperataState()
        {
            nudCharge.Enabled = true;
            nudAmount.Enabled = true;
            nudDiscount.Enabled = true;
            btnTotal.Enabled = true;
            btnSubmit.Enabled = true;
            btnAdd.Enabled = true;
        }
        void ResetState()
        {
            nudAmount.Value = 1;
            nudDiscount.Value = 0;
            txtTotal.Text = "0";
        }

        private void cboServiceDetail_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                OperataState();
                if (cboServiceDetail.SelectedIndex == -1) { return; }
                string[] arr;
                arr = cboServiceDetail.SelectedValue.ToString().Split('|');
                service_id_detail = int.Parse(arr[0]);
                txtMax.Text = arr[1];
                txtMin.Text = arr[2];
                nudCharge.Maximum = Convert.ToDecimal(txtMax.Text);
                nudCharge.Minimum = Convert.ToDecimal(txtMin.Text);
                nudDiscount.Maximum = Convert.ToDecimal(txtMax.Text);
                ResetState();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_doc_treatment + cboServiceDetail_SelectedValueChanged :" + t.Message + t.StackTrace);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            txtTotal.Text = ((nudCharge.Value​ * nudAmount.Value) - nudDiscount.Value).ToString();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.Rows.Count <= 0) { return; }
                if (!MyMSB.Show("តើអ្នកពិតជាចង់រក្សាទុកមែនទេ?", "1", true)) { return; }
                StoreProcedure.spd_insert_tp(dataGridView1);
                dataGridView1.Rows.Clear();
                MyMSB.Show("ការរក្សាទុកបានជោគជ័យ", "1", false);
                this.fun_getAllPatientServiceTableAdapter.Fill(this.dentistDataSet.fun_getAllPatientService, int.Parse(GlobalVariable._Pat_id));
                btnNext.PerformClick();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_doc_treatment + btnSubmit_Click :" + t.Message + t.StackTrace);
            }
        }

        private void nudCharge_ValueChanged(object sender, EventArgs e)
        {
            btnTotal.PerformClick();
            nudDiscount.Value = 0;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (!MyMSB.Show("អ្នកមិនទាន់បានធ្វើការ Submit ទេ។ តើអ្នកពិតជាចង់បោះបង់មែនទេ?", "0", true))
                {
                    return;
                }
            }
            this.Close();
            Thread th = new Thread(OpenXray);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenXray()
        {
            Application.Run(new frm_doc_diagnosis());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (!MyMSB.Show("អ្នកមិនទាន់បានធ្វើការ Submit ទេ។ តើអ្នកពិតជាចង់បោះបង់មែនទេ?", "0", true))
                {
                    return;
                }
            }
            this.Close();
            Thread th = new Thread(OpenPrescription);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenPrescription()
        {
            Application.Run(new frm_patient_treamentDetail());
        }
        private void OpenAction()
        {
            Application.Run(new frm_doc_action());
        }

        private void nudDiscount_Enter(object sender, EventArgs e)
        {
            nudDiscount.Maximum = (nudAmount.Value * nudCharge.Value);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
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
    }
}
