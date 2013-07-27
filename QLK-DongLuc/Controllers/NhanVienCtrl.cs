using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLK_DongLuc.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;

namespace QLK_DongLuc.Controllers
{
    public static class NhanVienCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, Entities db = null)
        {
            if (db == null) db = new Entities();
            bindingSource.DataSource = db.CAT_NhanVien.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();
            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.ViewCboNhanVien.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho_ten","Họ tên"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Kho"));
            lookUpEdit.Properties.DisplayMember = "Ho_ten";
            lookUpEdit.Properties.ValueMember = "ID_nhan_vien";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhân viên";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource = db.ViewCboNhanVien.ToList();
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho_ten", "Họ tên"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Kho"));
            gridLookUpEdit.Properties.DisplayMember = "Ho_ten";
            gridLookUpEdit.Properties.ValueMember = "ID_nhan_vien";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static int Insert(CAT_NhanVien nv, Entities db = null)
        {
            if (db == null) db = new Entities();

            if (nv == null || nv.Ho_dem == null || nv.Ten == null || nv.Gioi_tinh == null || nv.Ngay_sinh == null || nv.CMND == null) return 0;

            nv.Trang_thai = 1;

            db.CAT_NhanVien.Add(nv);

            return db.SaveChanges();
        }

        public static int Update(CAT_NhanVien nv, Entities db = null)
        {
            if (nv == null || nv.ID_nhan_vien == null ) return 0;

            if (db == null) db = new Entities();

            var entity = db.CAT_NhanVien.FirstOrDefault(p => p.ID_nhan_vien == nv.ID_nhan_vien);

            if (entity == null) return 0;

            entity.ID_kho = nv.ID_kho;

            entity.Ho_dem = nv.Ho_dem;
            entity.Ten = nv.Ten;
            entity.Gioi_tinh = nv.Gioi_tinh;
            entity.Ngay_sinh = nv.Ngay_sinh;
            entity.CMND = nv.CMND;
            entity.Ngay_cap = nv.Ngay_cap;
            entity.Noi_cap = nv.Noi_cap;
            entity.Dien_thoai = nv.Dien_thoai;
            entity.Dia_chi = nv.Dia_chi;
            entity.Email = nv.Email;

            return db.SaveChanges();
        }

        public static int Delete(object ID_nhan_vien, Entities db = null)
        {
            if (ID_nhan_vien == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_nhan_vien;
            var entity = db.CAT_NhanVien.FirstOrDefault(p => p.ID_nhan_vien == id);

            if (entity == null) return 0;
 
            db.CAT_NhanVien.Remove(entity);

            return db.SaveChanges();
        }
        public static int GetIdkho(object ID_nhan_vien, Entities db = null)
        {
            if (ID_nhan_vien == null) return 0;
            if (db == null) db = new Entities();
            int id = (int)ID_nhan_vien;
            object id_kho_ = 0;
            int id_kho;
            var entity=db.CAT_NhanVien.FirstOrDefault(p=>p.ID_nhan_vien==id);
            id_kho_ = entity.ID_kho;
            id_kho = (int)id_kho_;
            return id_kho;
        }

        public static void LoadLookUpEdit_Nhanvien_Kho(LookUpEdit lookUpEdit,object makho, Entities db = null)
        {
            if (db == null) db = new Entities();
            lookUpEdit.Properties.Columns.Clear();
            int ma_kho;
            ma_kho = (int)makho;
            lookUpEdit.Properties.DataSource = db.ViewCboNhanVien.Where(p=> p.ID_kho == ma_kho).ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho_ten", "Họ tên"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Kho"));
            lookUpEdit.Properties.DisplayMember = "Ho_ten";
            lookUpEdit.Properties.ValueMember = "ID_nhan_vien";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhân viên";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }
    }
}
