using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_BaoCao.Labrary
{
    class ExistTabPage
    {
        public static bool ETP(TabControl control, string tabPageName)
        {
            bool check = false;
            for (int i = 0; i < control.TabPages.Count; i++)
            {
                if (control.TabPages[i].Name == tabPageName)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
    }
}
