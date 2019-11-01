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

        Thread th;

        private void btn_doc_submit_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openAction);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openAction()
        {
            Application.Run(new frm_doc_action());
        }
    }
}
