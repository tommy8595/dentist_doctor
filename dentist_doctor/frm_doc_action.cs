using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace dentist_doctor
{
    public partial class frm_doc_action : Form
    {
        public frm_doc_action()
        {
            InitializeComponent();
        }
        private void frm_doc_action_Load(object sender, EventArgs e)
        {
            lblPatId.Text = GlobalVariable._Pat_id;
            lblPatName.Text = GlobalVariable._Pat_name;
        }
        private void btn_diagnosis_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openDiagnosis);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openDiagnosis()
        {
            Application.Run(new frm_doc_diagnosis());
        }

        private void btn_treatment_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openTreatment);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openTreatment()
        {
            Application.Run(new frm_doc_treatment());
        }

        private void btn_doc_action_back_Click(object sender, EventArgs e)
        {
            GlobalVariable._Pat_id = null;
            GlobalVariable._Pat_name = null;
            this.Close();
            Thread th = new Thread(openCode);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openCode()
        {
            Application.Run(new frm_doc_code());
        }
        private void btnPatDetail_Click(object sender, EventArgs e)
        {
            frm_patient_detail form = new frm_patient_detail();
            form.ShowDialog();
        }

        private void btnXray_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenXray);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenXray()
        {
            Application.Run(new frm_patient_Xray());
        }

        private void btbPre_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenPre);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenPre()
        {
            Application.Run(new frm_patient_prescription());
        }

        private void btnTD_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenTD);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenTD()
        {
            Application.Run(new frm_patient_treamentDetail());
        }
    }
}
