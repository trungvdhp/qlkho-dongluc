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
    public class NhaCungCapCtrl
    {
        public static void LoadBindingSource(BindingSource bs, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            bs.DataSource = db.CAT_NhaCungCap.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.CAT_NhaCungCap.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nha_cung_cap", "Nhà cung cấp"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nguoi_dai_dien", "Người đại diện"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dien_thoai", "Điện thoại"));

            lookUpEdit.Properties.DisplayMember = "Ten_nha_cung_cap";
            lookUpEdit.Properties.ValueMember = "ID_nha_cung_cap";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhà cung cấp";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }
    }
}
