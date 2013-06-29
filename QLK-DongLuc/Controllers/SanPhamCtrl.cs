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
            bindingSource.DataSource = db.CAT_SanPham.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
        {
        }

        public static int Insert(object Ma_san_pham, object Ten_san_pham, object ID_nhan_vien, object ID_khach_hang, object Chi_phi_lap_dat, Entities db = null)
        {
            if (Ma_san_pham == null) return 0;

            if (db == null) db = new Entities();

            var entity = new CAT_SanPham();

            entity.Ma_san_pham = Ma_san_pham.ToString().Trim();
            entity.Ten_san_pham = (Ten_san_pham != null) ? Ten_san_pham.ToString().Trim() : "";
            entity.ID_nhan_vien = (int)ID_nhan_vien;
            entity.ID_khach_hang = (int)ID_khach_hang;
            entity.Chi_phi_lap_dat = (decimal)0;

            db.CAT_SanPham.Add(entity);

            return db.SaveChanges();
        }

        public static int Update(object ID_san_pham, object Ma_san_pham, object Ten_san_pham, object ID_nhan_vien, object ID_khach_hang, object Chi_phi_lap_dat, Entities db = null)
        {
            if (ID_san_pham == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_san_pham;
            var entity = db.CAT_SanPham.FirstOrDefault(p => p.ID_san_pham == id);

            if (entity == null) return 0;

            entity.Ma_san_pham = Ma_san_pham.ToString().Trim();
            entity.Ten_san_pham = (Ten_san_pham != null) ? Ten_san_pham.ToString().Trim() : "";
            entity.ID_nhan_vien = (int)ID_nhan_vien;
            entity.ID_khach_hang = (int)ID_khach_hang;
            entity.Chi_phi_lap_dat = (decimal)0;

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
