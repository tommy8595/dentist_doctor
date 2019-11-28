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
    public partial class frm_patient_treamentDetail : Form
    {

        public frm_patient_treamentDetail()
        {
            InitializeComponent();
        }
        string str = "";
        private void frm_patient_treamentDetail_Load(object sender, EventArgs e)
        {
            this.fun_getPatientTdByPatIDTableAdapter.Fill(this.dentistDataSet.fun_getPatientTdByPatID, int.Parse(GlobalVariable._Pat_id));
            str = txtTD.Text;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (txtTD.Text != str)
            {
                if (!MyMSB.Show("អ្នកមិនទាន់បានធ្វើការ Save ទេ។ តើអ្នកពិតជាចង់បោះបង់មែនទេ?", "0", true))
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
            Application.Run(new frm_patient_prescription());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtTD.Text != str)
            {
                if (!MyMSB.Show("អ្នកមិនទាន់បានធ្វើការ Save ទេ។ តើអ្នកពិតជាចង់បោះបង់មែនទេ?", "0", true))
                {
                    return;
                }
            }
            this.Close();
            Thread th = new Thread(OpenTreatmentPlan);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenTreatmentPlan()
        {   
            Application.Run(new frm_doc_treatment());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTD.Text != str)
            {
                if (!MyMSB.Show("អ្នកមិនទាន់បានធ្វើការ Save ទេ។ តើអ្នកពិតជាចង់បោះបង់មែនទេ?", "0", true))
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StoreProcedure.spd_update_patientTreatmentDetail(GlobalVariable._Pat_id, txtTD.Text);
                MyMSB.Show("ការរក្សាទុកបានជោគជ័យ", "1", false);
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_patient_treamentDetail / btnSave_Click :" + t.Message + t.StackTrace);
            }
        }
    }
}
