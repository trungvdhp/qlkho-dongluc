using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Controllers
{
    public class TuyChonTimKiemCtrl
    {
        public static void LoadBindingSource(BindingSource bs)
        {
            bs.DataSource = TuyChonTimKiem.DanhSachTuyChonMacDinh();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit)
        {
            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = TuyChonTimKiem.DanhSachTuyChonMacDinh();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_tuy_chon", "Tùy chọn"));
            lookUpEdit.Properties.ShowHeader = false;
            lookUpEdit.Properties.PopupWidth = lookUpEdit.Width;
            lookUpEdit.Properties.DisplayMember = "Ten_tuy_chon";
            lookUpEdit.Properties.ValueMember = "ID_tuy_chon";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Tùy chọn tìm kiếm";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.EditValue = 1;
        }
    }
}
