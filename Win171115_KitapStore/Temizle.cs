using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win171115_KitapStore
{
    public static class Temizle
    {
        public static void temizle(Form frm)
        {
            foreach(var item in frm.Controls)
            {
                if (item is TextBox)
                    (item as TextBox).Clear();
            }
        }


    }
}
