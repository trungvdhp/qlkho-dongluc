using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QLK_DongLuc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace QLK_DongLuc.Controllers
{
	class Utilities
	{
        public static void ResetControls(Control Parent)
        {
            foreach (var control in Parent.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = string.Empty;
                    (control as TextBox).Refresh();
                }
                else if (control is TextEdit)
                {
                    (control as TextEdit).Text = string.Empty;
                    (control as TextEdit).Refresh();
                }
                else if (control is MemoEdit)
                {
                    (control as MemoEdit).Text = string.Empty;
                    (control as MemoEdit).Refresh();
                }
                else if (control is LookUpEdit)
                {
                    (control as LookUpEdit).Reset();
                }
                else if (control is DateEdit)
                {
                    (control as DateEdit).EditValue = DateTime.Now;
                }
                else if (control is GridControl)
                {
                    (control as GridControl).RefreshDataSource();
                }
                else if (control is TableLayoutPanel || control is Panel || control is GroupControl)
                {
                    ResetControls((Control)control);
                }
            }

        }
	}
}
