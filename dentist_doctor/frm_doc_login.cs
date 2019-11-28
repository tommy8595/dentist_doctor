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
using System.Data.SqlClient;

namespace dentist_doctor
{
    public partial class frm_doc_login : Form
    {
        public frm_doc_login()
        {
            InitializeComponent();
        }
        SqlConnection con;
        DataTable dt;
        private void btn_doc_login_Click(object sender, EventArgs e)
        {

            try
            {
                GlobalMethod.TestConnection();
                //con = new SqlConnection(StoreProcedure.connectionString);
                //con.Open();
                //SqlCommand cmd = new SqlCommand("SELECT dbo.fn_check_login(@u,@p)", con);

                //cmd.Parameters.Add(new SqlParameter("@u", txt_doc_username.Text.Trim()));
                //cmd.Parameters.Add(new SqlParameter("@p", txt_doc_password.Text.Trim()));

                //bool HasUser = (bool)cmd.ExecuteScalar();
                dt = this.fun_getDoctorLoginTableAdapter.GetData(txt_doc_username.Text, txt_doc_password.Text);
                string role = dt.Rows[0]["emp_role"].ToString();
                if ((dt.Rows.Count >0 && role == "doctor") || role == "admin")
                {
                    GlobalVariable._User_name = dt.Rows[0]["emp_name"].ToString();
                    GlobalVariable._User_id = dt.Rows[0]["emp_id"].ToString();
                    GlobalVariable._User_role = dt.Rows[0]["emp_role"].ToString();
                    this.Close();
                    Thread th = new Thread(openCode);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    }
                else
                {
                    con.Close();
                    MyMSB.Show("ឈ្មោះ និង លេខសម្ងាត់មិនត្រឹមត្រូវ", "0", false);
                    txt_doc_password.Text = "";
                    txt_doc_username.Text = "";
                    txt_doc_username.Focus();
                }

            }
            catch (Exception t )
            {
                GlobalMethod.HandleException("frm_doc_login / btn_doc_login_Click :" + t.Message + t.StackTrace);
            }
        }

        private void openCode()
        {
            Application.Run(new frm_doc_code());
        }

        private void frm_doc_login_Load(object sender, EventArgs e)
        {
            txt_doc_password.PasswordChar = '*';
            this.AcceptButton = btn_doc_login;
        }
    }
}
