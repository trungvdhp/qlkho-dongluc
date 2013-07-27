using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLK_DongLuc.Helper
{
    public static class NotifyHelper
    {
        public static void ShowInsertError()
        {
            XtraMessageBox.Show(Properties.Settings.Default.InsertErrorText, Properties.Settings.Default.InsertErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowUpdateError()
        {
            XtraMessageBox.Show(Properties.Settings.Default.UpdateErrorText, Properties.Settings.Default.UpdateErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowDeleteError()
        {
            XtraMessageBox.Show(Properties.Settings.Default.DeleteErrorText, Properties.Settings.Default.DeleteErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowDeleteConfirm()
        {
            return XtraMessageBox.Show(Properties.Settings.Default.DeleteConfirmText, Properties.Settings.Default.DeleteErrorCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void ShowPrintError()
        {
            XtraMessageBox.Show(Properties.Settings.Default.PrintErrorText, Properties.Settings.Default.PringErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
