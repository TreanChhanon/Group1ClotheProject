using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClothesManagementSystem
{
    class ClearText
    {
        public void cleartext(Form frm)
        {
            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                }
                if (ctrl is ComboBox)
                {
                    ctrl.Text = string.Empty;
                }
            }

        }
    }
}
