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
    public class SanPhamCtrl
    {
        public static void LoadBindingSource(BindingSource bindingSource, Entities db = null)
        {
            if (db == null) db = new Entities();

            var user = Program.CurrentUser;

            if (user.ID_nhan_vien == null)
                bindingSource.DataSource = db.CAT_SanPham.OrderByDescending(t => t.ID_san_pham).ToList();
            else
                bindingSource.DataSource = db.CAT_SanPham.Where(t => t.ID_nhan_vien == user.ID_nhan_vien).OrderByDescending(o => o.ID_san_pham).ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();
            lookUpEdit.Properties.Columns.Clear();
            // lấy dữ liệu
            var sanpham = from sp in db.CAT_SanPham
                          join nv in db.CAT_NhanVien on sp.ID_nhan_vien equals nv.ID_nhan_vien
                          select new { sp.ID_san_pham, sp.Ten_san_pham, nv.Ho_dem, nv.Ten };
            lookUpEdit.Properties.DataSource = sanpham.ToList();
            // đẩy vào cột 
            //lookUpEdit.Properties.DataSource = db.ViewCatSanPham.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_san_pham", "Tên Sản Phẩm"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho_dem", "Họ Đệm"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Tên"));
            lookUpEdit.Properties.DisplayMember = "Ten_san_pham";
            lookUpEdit.Properties.ValueMember = "ID_san_pham";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn sản phẩm";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static int Insert(CAT_SanPham sanPham, Entities db = null)
        {
            if (sanPham == null || sanPham.Ma_san_pham == null) return 0;

            if (db == null) db = new Entities();

            db.CAT_SanPham.Add(sanPham);

            return db.SaveChanges();
        }

        public static int Update(CAT_SanPham sanPham, Entities db = null)
        {
            if (sanPham == null || sanPham.ID_san_pham == null || sanPham.Ma_san_pham == null) return 0;

            if (db == null) db = new Entities();

            var entity = db.CAT_SanPham.FirstOrDefault(p => p.ID_san_pham == sanPham.ID_san_pham);

            if (entity == null) return 0;

            entity.Ma_san_pham = sanPham.Ma_san_pham;
            entity.Ten_san_pham = sanPham.Ten_san_pham;
            entity.ID_nhan_vien = sanPham.ID_nhan_vien;
            entity.ID_khach_hang = sanPham.ID_khach_hang;
            entity.Chi_phi_lap_dat = sanPham.Chi_phi_lap_dat;

            return db.SaveChanges();
        }

        public static int Delete(object ID_san_pham, Entities db = null)
        {
            if (ID_san_pham == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_san_pham;
            var entity = db.CAT_SanPham.FirstOrDefault(p => p.ID_san_pham == id);

            if (entity == null) return 0;

            db.CAT_SanPham.Remove(entity);

            return db.SaveChanges();
        }
    }
}
