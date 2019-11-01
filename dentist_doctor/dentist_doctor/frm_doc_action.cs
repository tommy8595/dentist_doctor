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

        Thread th;

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
            this.Close();
            Thread th = new Thread(openPatient);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openPatient()
        {
            Application.Run(new frm_doc_patient_detail());
        }
    }
}
