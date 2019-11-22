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
    public partial class frm_edit_medicalHistory : Form
    {
        string md_name, md_des, md_status;
        int pat_id, md_id;

        private void txtMdDes_TextChanged(object sender, EventArgs e)
        {
            if (txtMdDes.Text == "") { txtMdDes.Text = "បានកែប្រែទៅ មិនមានពត៌មាន"; }
        }

        public frm_edit_medicalHistory(string md_name, string md_des, string md_status, int pat_id, int md_id)
        {
            InitializeComponent();
            this.md_name = md_name;
            this.md_des = md_des;
            this.md_status = md_status;
            this.pat_id = pat_id;
            this.md_id = md_id;
        }

        private void frm_edit_medicalHistory_Load(object sender, EventArgs e)
        {
            txtMdDes.Text = md_des;
            txtMdName.Text = md_name;
            cboMdStatus.Text = md_status;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                StoreProcedure.spd_update_mdHistoryByPatID(pat_id, md_id, cboMdStatus.SelectedItem.ToString(), txtMdDes.Text);
                this.Hide();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("frm_Edit_Patient_Md / btnAdd_Click " + t.Message);
            }
        }
    }
}
