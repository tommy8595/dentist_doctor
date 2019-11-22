using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist_doctor
{
    public static class StoreProcedure
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["dentist_doctor.Properties.Settings.DentistConnectionString"].ConnectionString;
        private static SqlCommand cmd;
        private static SqlConnection con;

        public static void spd_insert_patient_md(DataGridView dgv)
        {
            //TableStructure
            //pat_id | md_id | md_name | md_description | md_status
            try
            {
                DataTable dt;
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("[dbo].[spd_insert_patientMd]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@tempMd";
                dt = GlobalMethod.convertDGVtoDT(dgv);
                param.Value = dt;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("StoreProcedure / spd_insert_patient_diagnose : " + t.Message);
            }
        }

        public static void spd_update_mdHistoryByPatID(int pat_id, int md_id, string md_status, string md_description)
        {
            //@pat_id int,
            //@md_id int,
            //@md_status nvarchar(10)
            //@md_description nvarchar(max)

            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("dbo.spd_update_mdHistoryByPatID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pat_id", pat_id);
            cmd.Parameters.AddWithValue("@md_id", md_id);
            cmd.Parameters.AddWithValue("@md_status", md_status);
            cmd.Parameters.AddWithValue("@md_description", md_description);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void spd_update_patientTreatmentDetail(string pat_id,string td_des)
        {
            //@pat_id int,
            //@td_des nvarchar(max)
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("dbo.spd_update_patientTreatmentDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pat_id", pat_id);
            cmd.Parameters.AddWithValue("@td_des", td_des);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void spd_clearPatientCode(string code)
        {
            //@code
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("dbo.spd_clearPatientCode", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@code", code);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void spd_insert_patientXray(int pat_id, int xray_id, DateTime pat_xray_date, string @pat_xray_code)
        {
            // @pat_id int,
            //@xray_id int,
            //@pat_xray_date date,
            //@pat_xray_code nvarchar(max)
            con = new SqlConnection(connectionString);
            con.Open();
            cmd = new SqlCommand("dbo.spd_insert_patientXray", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pat_id", pat_id);
            cmd.Parameters.AddWithValue("@xray_id", xray_id);
            cmd.Parameters.AddWithValue("@pat_xray_date", pat_xray_date);
            cmd.Parameters.AddWithValue("@pat_xray_code", pat_xray_code);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void spd_insert_tp(DataGridView dgv)
        {
            //TableStructure
            //pat_id | [tp_date] | [sd_id] | [charge_amount] | [discount_amount] | [total_amount] | [doc_id] [int] NULL | [paid_status] | [tp_amount] decimal(18,0)
            try
            {
                DataTable dt;
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("[dbo].[spd_insert_tp]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@tempTp";
                dt = GlobalMethod.convertDGVtoDT(dgv);
                dt.Columns.Remove("service_name");
                dt.Columns.Remove("doc_name");
                dt.Columns["tp_amount"].SetOrdinal(8);
                param.Value = dt;           
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("StoreProcedure / spd_insert_tp : " + t.Message + t.StackTrace);
            }
        }
        public static void sp_prescript(DataGridView dgv)
        {
                //[pro_id][int] NULL,
                //[qty][int] NULL
                //@pres
            try
            {
                DataTable dt;
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("[dbo].[sp_prescript]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@pres";
                dt = GlobalMethod.convertDGVtoDT(dgv);
                dt.Columns.Remove("pat_id");
                dt.Columns.Remove("ps_date");
                dt.Columns.Remove("ps_unit");
                dt.Columns.Remove("ps_des");
                dt.Columns.Remove("ps_price");
                dt.Columns.Remove("ps_total");
                dt.Columns.Remove("ps_status");
                dt.Columns.Add("id");
                dt.Columns["id"].SetOrdinal(0);
                dt.Columns["p_id"].SetOrdinal(1);
                dt.Columns["ps_amount"].SetOrdinal(2);
                int i = 1;
                foreach (DataRow row in dt.Rows)
                {
                    row["id"] = i;
                    i++;
                }
                param.Value = dt;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("StoreProcedure / sp_prescript : " + t.Message);
            }
        }
        public static void spd_insert_prescription(DataGridView dgv)
        {       //Table Structure
                //[pat_id] [int] NULL,
                //[ps_date] [date] NULL,
                //[ps_des] [nvarchar](max) NULL,
                //[ps_unit] [nvarchar](max) NULL,
                //[ps_amount] [int] NULL,
                //[ps_price] [decimal](18, 0) NULL,
                //[ps_total] [decimal](18, 0) NULL,
                //[ps_status] [nvarchar](5) NULL
                //[pro_id] [int] NULL,
                //@tempPs
            try
            {
                DataTable dt;
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("[dbo].[spd_insert_prescription]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@tempPs";
                dt = GlobalMethod.convertDGVtoDT(dgv);
                param.Value = dt;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception t)
            {
                GlobalMethod.HandleException("StoreProcedure / spd_insert_tp : " + t.Message);
            }
        }
    }
}
