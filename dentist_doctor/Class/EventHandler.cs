using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist_doctor
{
     class EventHandlerr
    {
        public static void TextBoxNumberOnly(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8 || e.KeyChar == '/')
            {
                return;
            }
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }
        public static void TextBoxNotLessThanZero(object sender, EventArgs e)
        {
            if (Convert.ToDecimal((sender as TextBox).Text) < 0) { (sender as TextBox).Text = "0"; }
        }
        public static void TextBoxTextOnly(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar > '0' && e.KeyChar < '9')
            {
                e.Handled = true;
            }
        }
        public static void TextBoxClearBackPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if ((sender as TextBox).Text == "មិនមានពត៌មាន")
                    (sender as TextBox).Clear();
            }
        }
        public static void TextBoxLeaveReturnDefalut(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                (sender as TextBox).Text = "មិនមានពត៌មាន";
            }
        }
        public static void nudSelectallClick(object sender, MouseEventArgs e)
        {
            (sender as NumericUpDown).Select(0, (sender as NumericUpDown).Text.Length);
        }
    }
}
