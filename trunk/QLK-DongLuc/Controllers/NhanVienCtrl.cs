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
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho_ten","Họ tên"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Kho"));
            lookUpEdit.Properties.DisplayMember = "Ho_ten";
            lookUpEdit.Properties.ValueMember = "ID_nhan_vien";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhân viên";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }

        public static int Insert(object Ho_dem, object Ten, object Gioi_tinh, object Ngay_sinh, object CMND, object Ngay_Cap, object Noi_cap, object Dien_thoai, object Dia_chi, object Email, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();

            var entity = new CAT_NhanVien();

            entity.ID_kho = (int?)null;

            entity.Ho_dem = Ho_dem.ToString().Trim();
            entity.Ten = Ten.ToString().Trim();
            entity.Gioi_tinh = (int)Gioi_tinh;
            entity.Ngay_sinh = DateTime.Parse(String.Format("{0:yyyy/MM/dd}", Ngay_sinh));
            entity.CMND = CMND.ToString().Trim();
            entity.Ngay_cap = (Ngay_Cap != null) ? DateTime.Parse(String.Format("{0:yyyy/MM/dd}", Ngay_Cap)) : (DateTime?)null;
            entity.Noi_cap = (Noi_cap != null) ? (string)Noi_cap : string.Empty;
            entity.Dien_thoai = Dien_thoai.ToString().Trim();
            entity.Dia_chi = (Dia_chi != null) ? (string)Dia_chi : string.Empty;
            entity.Email = (Email != null) ? (string)Email : string.Empty;
            entity.Trang_thai = (int)1;

            db.CAT_NhanVien.Add(entity);
            int result = 0;
            try
            {
                result = db.SaveChanges();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            return result;
        }

        public static int Update(object ID_nhan_vien, object Ho_dem, object Ten, object Gioi_tinh, object Ngay_sinh, object CMND, object Ngay_Cap, object Noi_cap, object Dien_thoai, object Dia_chi, object Email, QuanLyKhoDongLucEntities db = null)
        {
            if (ID_nhan_vien == null ) return 0;

            if (db == null) db = new QuanLyKhoDongLucEntities();

            int id = (int)ID_nhan_vien;
            var entity = db.CAT_NhanVien.FirstOrDefault(p => p.ID_nhan_vien == id);

            if (entity == null) return 0;

            entity.ID_kho = (int?)null;

            entity.Ho_dem = Ho_dem.ToString().Trim();
            entity.Ten = Ten.ToString().Trim();
            entity.Gioi_tinh = (int)Gioi_tinh;
            entity.Ngay_sinh = DateTime.Parse(String.Format("{0:yyyy/MM/dd}", Ngay_sinh));
            entity.CMND = CMND.ToString().Trim();
            entity.Ngay_cap = (Ngay_Cap != null) ? DateTime.Parse(String.Format("{0:yyyy/MM/dd}", Ngay_Cap)) : (DateTime?)null;
            entity.Noi_cap = (Noi_cap != null) ? (string)Noi_cap : string.Empty;
            entity.Dien_thoai = Dien_thoai.ToString().Trim();
            entity.Dia_chi = (Dia_chi != null) ? (string)Dia_chi : string.Empty;
            entity.Email = (Email != null) ? (string)Email : string.Empty;
            entity.Trang_thai = (int)1;

            return db.SaveChanges();
        }

        public static int Delete(object ID_nhan_vien, QuanLyKhoDongLucEntities db = null)
        {
            if (ID_nhan_vien == null) return 0;

            if (db == null) db = new QuanLyKhoDongLucEntities();

            int id = (int)ID_nhan_vien;
            var entity = db.CAT_NhanVien.FirstOrDefault(p => p.ID_nhan_vien == id);

            if (entity == null) return 0;

            db.CAT_NhanVien.Remove(entity);

            return db.SaveChanges();
        }
    }
}
