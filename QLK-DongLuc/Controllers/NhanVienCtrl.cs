using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLK_DongLuc.Models;
using DevExpress.XtraEditors;

namespace QLK_DongLuc.Controllers
{
    public class NhanVienCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            bindingSource.DataSource = db.CAT_NhanVien.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.ViewCboNhanVien.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoTen","Họ tên"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Kho"));
            lookUpEdit.Properties.DisplayMember = "HoTen";
            lookUpEdit.Properties.ValueMember = "ID_nhan_vien";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhân viên";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }
    }
}
