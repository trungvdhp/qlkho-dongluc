using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Controllers
{
    public class ThuocTinhCtrl
    {
        public static void LoadBindingSource(BindingSource bs, object Loai_dieu_khien, Entities db = null)
        {
            if (db == null) db = new Entities();

            string tenLoaiDieuKhien = Loai_dieu_khien != null ? Loai_dieu_khien.ToString() : "";
            var loaiDieuKhien = db.SYS_LoaiDieuKhien.FirstOrDefault(t => t.Ky_hieu == tenLoaiDieuKhien);

            if (loaiDieuKhien != null)
                bs.DataSource = loaiDieuKhien.SYS_ThuocTinh.ToList();
            else
                bs.DataSource = null;
        }

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, object Loai_dieu_khien, Entities db = null)
        {
            if (db == null) db = new Entities();

            string tenLoaiDieuKhien = Loai_dieu_khien != null ? Loai_dieu_khien.ToString() : "";
            var loaiDieuKhien = db.SYS_LoaiDieuKhien.FirstOrDefault(t => t.Ky_hieu == tenLoaiDieuKhien);
            gridLookUpEdit.Properties.Columns.Clear();

            if (loaiDieuKhien != null)
                gridLookUpEdit.Properties.DataSource = loaiDieuKhien.SYS_ThuocTinh.ToList();
            else
                gridLookUpEdit.Properties.DataSource = null;

            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_thuoc_tinh", "Tên thuộc tính"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ky_hieu", "Ký hiệu"));

            gridLookUpEdit.Properties.DisplayMember = "Ten_thuoc_tinh";
            gridLookUpEdit.Properties.ValueMember = "ID_thuoc_tinh";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.NullValuePrompt = "Chọn thuộc tính";
            gridLookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            gridLookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }
    }
}
