using System;
using System.Collections.Generic;
using System.Text;

using Infragistics.Win.UltraWinStatusBar;

namespace SPISA.Presentacion
{
    public static class StatusBarController
    {
        public static void ShowMessage(UltraStatusBar bar, string panelKey, string msg)
        {
            bar.Panels[panelKey].Text = msg;
        }
    }
}
