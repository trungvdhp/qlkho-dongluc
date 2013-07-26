using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLK_DongLuc.Helper
{
    public static class TabControlHelper
    {
        /// <summary>
        /// Close current tabpage
        /// </summary>
        /// <param name="parent">Parent control</param>
        public static void CloseCurrentTabPage(System.Windows.Forms.Control parent)
        {
            DevExpress.XtraTab.XtraTabPage tabPage = parent as DevExpress.XtraTab.XtraTabPage;
            DevExpress.XtraTab.XtraTabControl tabControl = tabPage.Parent as DevExpress.XtraTab.XtraTabControl;
            tabControl.TabPages.Remove(tabPage);
        }

        /// <summary>
        /// Close all tabpage
        /// </summary>
        /// <param name="tabControl">Tab control</param>
        public static void CloseAllTabPage(DevExpress.XtraTab.XtraTabControl tabControl)
        {
            List<DevExpress.XtraTab.XtraTabPage> tabPages = new List<DevExpress.XtraTab.XtraTabPage>();

            foreach (DevExpress.XtraTab.XtraTabPage tabPage in tabControl.TabPages)
            {
                tabPages.Add(tabPage);
            }

            foreach (DevExpress.XtraTab.XtraTabPage tabPage in tabPages)
            {
                tabControl.TabPages.Remove(tabPage);
            }
        }
    }
}
