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
    public static class KhachHangCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, Entities db = null)
        {
            if (db == null) db = new Entities();
            bindingSource.DataSource = db.CAT_KhachHang.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.ViewCboKhachHang.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho_ten", "Họ tên"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dia_chi", "Địa chỉ"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dien_thoai", "Điện thoại"));

            lookUpEdit.Properties.DisplayMember = "Ho_ten";
            lookUpEdit.Properties.ValueMember = "ID_khach_hang";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn khách hàng";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource = db.ViewCboKhachHang.ToList();
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho_ten", "Họ tên"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dia_chi", "Địa chỉ"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dien_thoai", "Điện thoại"));

            gridLookUpEdit.Properties.DisplayMember = "Ho_ten";
            gridLookUpEdit.Properties.ValueMember = "ID_khach_hang";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static int Insert(CAT_KhachHang khachHang, Entities db = null)
        {
            if (khachHang == null || khachHang.Ho_dem == null || khachHang.Ten == null) return 0;

            if (db == null) db = new Entities();

            db.CAT_KhachHang.Add(khachHang);

            return db.SaveChanges();
        }

        public static int Update(CAT_KhachHang khachHang, Entities db = null)
        {
            if (khachHang == null || khachHang.ID_khach_hang == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)khachHang.ID_khach_hang;
            var entity = db.CAT_KhachHang.FirstOrDefault(p => p.ID_khach_hang == khachHang.ID_khach_hang);

            if (entity == null) return 0;

            entity.Ho_dem = khachHang.Ho_dem;
            entity.Ten = khachHang.Ten;
            entity.Dien_thoai = khachHang.Dien_thoai;
            entity.Dia_chi = khachHang.Dia_chi;

            return db.SaveChanges();
        }

        public static int Delete(object ID_khach_hang, Entities db = null)
        {
            if (ID_khach_hang == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_khach_hang;
            var entity = db.CAT_KhachHang.FirstOrDefault(p => p.ID_khach_hang == id);

            if (entity == null) return 0;

            db.CAT_KhachHang.Remove(entity);

            return db.SaveChanges();
        }
    }
}
