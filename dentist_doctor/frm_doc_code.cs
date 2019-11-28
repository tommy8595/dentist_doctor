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
    public partial class frm_doc_code : Form
    {
        public frm_doc_code()
        {
            InitializeComponent();
        }
        DataTable dt;
        private void frm_doc_code_Load(object sender, EventArgs e)
        {
            try
            {
                txt_doc_code.KeyPress += new KeyPressEventHandler(EventHandlerr.TextBoxNumberOnly);
                this.fun_getAllPatientTableAdapter.Fill(this.dentistDataSet.fun_getAllPatient);
                this.fun_getAllPatientTableAdapter.Fill(this.dentistDataSet.fun_getAllPatient);
                lblDocName.Text = GlobalVariable._User_name;
                lblDocId.Text = GlobalVariable._User_id;
            }
            catch (Exception t )
            {
                GlobalMethod.HandleException("frm_doc_code + frm_doc_code_Load :" + t.Message + t.StackTrace);
            }
        }
        private void btn_doc_submit_Click(object sender, EventArgs e)
        {
            try
            {
                dt = this.fun_getPatientCodeTableAdapter.GetData(txt_doc_code.Text);
                if (dt.Rows.Count <= 0)
                {
                    MyMSB.Show("លេខដែលបានបញ្ចូលមិនត្រឹមត្រូវ ឫ ហួសកំណត់ការប្រើប្រាស់។", "0", false);
                    return;
                }
                else
                {
                    GlobalVariable._Pat_id = dt.Rows[0]["pat_id"].ToString();
                    GlobalVariable._Pat_name = string.Format("{0} | {1}", dt.Rows[0]["fullname"].ToString(), dt.Rows[0]["fullKHname"].ToString());
                    StoreProcedure.spd_clearPatientCode(txt_doc_code.Text);
                    this.Close();
                    Thread th = new Thread(openAction);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_doc_code + btn_doc_submit_Click :" + t.Message + t.StackTrace);
            }
            
        }

        private void openAction()
        {
            Application.Run(new frm_doc_action());
        }

        private void btn_Patient_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSearchChoice.SelectedIndex == 0)
                {
                    this.fun_getAllPatientTableAdapter.FillByPatTel(dentistDataSet.fun_getAllPatient, txtSearch.Text);
                }
                else if (cboSearchChoice.SelectedIndex == 1)
                {
                    this.fun_getAllPatientTableAdapter.FillByPatName(dentistDataSet.fun_getAllPatient, txtSearch.Text);
                }
                else if (cboSearchChoice.SelectedIndex == 2)
                {
                    this.fun_getAllPatientTableAdapter.FillByPatId(dentistDataSet.fun_getAllPatient, int.Parse(txtSearch.Text));
                }
                else if (cboSearchChoice.SelectedIndex == 3)
                {
                    this.fun_getAllPatientTableAdapter.FillByLatinName(dentistDataSet.fun_getAllPatient, txtSearch.Text);
                }
                if (dgvAllPatient.Rows.Count == 0) { MyMSB.Show("មិនមានពត៌មានទេ សូមពិនិត្យមើលទិន្នន័យដែលបានបញ្ចូលម្តងទៀត", "0", false); return; }
            }
            catch (Exception)
            {
                MyMSB.Show("សូមពិនិត្យមើលពត៌មានដែលបានបញ្ចូលឡើងវិញ", "0", false);
                return;
            }
        }

        private void btnPatientDetail_Click(object sender, EventArgs e)
        {
            if (dgvAllPatient.Rows.Count <= 0) { return; }
            GlobalVariable._Pat_id = dgvAllPatient.CurrentRow.Cells["pat_id"].Value.ToString();
            GlobalVariable._Pat_name = dgvAllPatient.CurrentRow.Cells["fullKhName"].Value.ToString();
            this.Close();
            Thread th = new Thread(openInformation);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openInformation()
        {   
            Application.Run(new frm_patient_information(GlobalVariable._Pat_id, GlobalVariable._Pat_name));
        }
    }
}
