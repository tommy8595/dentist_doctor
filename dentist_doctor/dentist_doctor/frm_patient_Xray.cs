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
    public partial class frm_patient_Xray : Form
    {
        public frm_patient_Xray()
        {
            InitializeComponent();
        }

        private void frm_patient_Xray_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dentistDataSet.fun_getXrayMachine' table. You can move, or remove it, as needed.
                this.fun_getXrayMachineTableAdapter.Fill(this.dentistDataSet.fun_getXrayMachine);
                this.fun_getPatientXrayByPatIDTableAdapter.Fill(this.dentistDataSet.fun_getPatientXrayByPatID, int.Parse(GlobalVariable._Pat_id));
                ColorClass();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_patient_Xray / frm_patient_Xray_Load : " + t.Message + t.StackTrace);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                StoreProcedure.spd_insert_patientXray(int.Parse(GlobalVariable._Pat_id), (int)cboXray.SelectedValue, DateTime.Now, txtCode.Text);
                this.fun_getPatientXrayByPatIDTableAdapter.Fill(this.dentistDataSet.fun_getPatientXrayByPatID, int.Parse(GlobalVariable._Pat_id));
                ColorClass();
            }
            catch (Exception t )
            {
                GlobalMethod.HandleException("frm_patient_Xray / btnAdd_Click : " + t.Message + t.StackTrace);
            }
        }
        void ColorClass()
        {
            foreach (DataGridViewRow row in dgvOne.Rows)
            {
                if (row.Cells["xray_id"].Value.ToString() == "1")
                {
                    row.DefaultCellStyle.BackColor = Color.AliceBlue;
                }
                else if (row.Cells["xray_id"].Value.ToString() == "2")
                {
                    row.DefaultCellStyle.BackColor = Color.Cornsilk;
                }
                else if (row.Cells["xray_id"].Value.ToString() == "3")
                {
                    row.DefaultCellStyle.BackColor = Color.Cyan;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Lavender;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenAction);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenAction()
        {
            Application.Run(new frm_doc_action());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenTreatmentPlan);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenTreatmentPlan()
        {
            Application.Run(new frm_doc_treatment());
        }
    }
}
