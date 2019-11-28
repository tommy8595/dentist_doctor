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
    public partial class frm_patient_information : Form
    { string pat_id, pat_name;
        public frm_patient_information(string pat_id="", string pat_name="")
        {
            InitializeComponent();
            this.pat_id = pat_id;
            this.pat_name = pat_name;
        }

        private void TC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (TC.SelectedTab == tabMd)
                {
                    this.fun_getActiveMedicalHistoryForSpecificPaientTableAdapter.Fill(this.dentistDataSet.fun_getActiveMedicalHistoryForSpecificPaient, int.Parse(pat_id));
                }
                else if (TC.SelectedTab == tabXray)
                {
                    this.fun_getPatientXrayByPatIDTableAdapter.Fill(this.dentistDataSet.fun_getPatientXrayByPatID, int.Parse(pat_id));
                    ColorClass();
                }
                else if (TC.SelectedTab == tabTP)
                {
                    this.fun_getAllPatientServiceTableAdapter.Fill(this.dentistDataSet.fun_getAllPatientService, int.Parse(pat_id));
                }
                else if (TC.SelectedTab == tabPs)
                {
                    this.fun_getPrescriptionByPatIDTableAdapter.Fill(this.dentistDataSet.fun_getPrescriptionByPatID, int.Parse(pat_id));
                }
                else if (TC.SelectedTab == TabTd)
                {
                    this.fun_getPatientTdByPatIDTableAdapter.Fill(this.dentistDataSet.fun_getPatientTdByPatID, int.Parse(pat_id));
                }
                else if (TC.SelectedTab == tabDiag)
                {
                    this.fun_getPatientDiagnoseByIDTableAdapter.Fill(this.dentistDataSet.fun_getPatientDiagnoseByID, int.Parse(pat_id));
                }
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_patient_information + TC_SelectedIndexChanged:" + t.Message + t.StackTrace);
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

        private async void btnShowPic_Click(object sender, EventArgs e)
        {
            try
            {
                btnShowPic.Enabled = false;
                await Task.Run(() => this.fun_getPatientImageByIDTableAdapter.Fill(this.dentistDataSet.fun_getPatientImageByID, int.Parse(pat_id)));
                int rotateOrder = int.Parse(this.fun_getPatientImageByIDTableAdapter.GetData(int.Parse(GlobalVariable._Pat_id)).Rows[0]["pat_image_order"].ToString());
                for (int i = 0; i < rotateOrder; i++)
                {
                    GlobalMethod.rotateimage(pictureBox1);
                }
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_patient_information + btnShowPic_Click:" + t.Message + t.StackTrace);
            }
        }

        private void dgvOne_Sorted(object sender, EventArgs e)
        {
            ColorClass();
        }

        private void btnPatientDetail_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenAction);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenAction()
        {
            Application.Run(new frm_doc_code());
        }
        private void frm_patient_information_Load(object sender, EventArgs e)
        {
            try
            {
                this.fun_getPatientByIDTableAdapter.Fill(this.dentistDataSet.fun_getPatientByID, int.Parse(pat_id));
                lblPatName.Text = pat_name;
                lblPatId.Text = pat_id;
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_patient_information + frm_patient_information_Load:" + t.Message + t.StackTrace);
            }
        }
    }
}
