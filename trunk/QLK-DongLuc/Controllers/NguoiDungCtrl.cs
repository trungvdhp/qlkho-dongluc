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
    public class NguoiDungCtrl
    {
        public static void LoadBindingSource(BindingSource bs, QuanLyKhoDongLucEntities db = null)
        {
            if(db == null) db = new QuanLyKhoDongLucEntities();
            bs.DataSource = db.ViewNguoiDung.ToList();
        }

        public static int Insert(object ID_nhan_vien, string Tai_khoan, string Mat_khau, string Ten_day_du, int ID_trang_thai, string Thoi_gian_cho, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();

            var entity = db.SYS_NguoiDung.FirstOrDefault(t => t.Tai_khoan == Tai_khoan);

            if (entity == null) entity = new SYS_NguoiDung();
            else return -1;

            entity.Tai_khoan = Tai_khoan;
            entity.Ten_day_du = Ten_day_du;
            entity.ID_trang_thai = ID_trang_thai;
            entity.Thoi_gian_cho = TimeSpan.Parse(Thoi_gian_cho);
            entity.Mat_khau = Utilities.CreateSHAHash(Mat_khau);

            if (ID_nhan_vien != null) entity.ID_nhan_vien = (int?)ID_nhan_vien;

            db.SYS_NguoiDung.Add(entity);

            return db.SaveChanges();
        }

        public static int Update(int ID_nguoi_dung, string Mat_khau, string Ten_day_du, int ID_trang_thai, string Thoi_gian_cho, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();

            var entity = db.SYS_NguoiDung.FirstOrDefault(t => t.ID_nguoi_dung == ID_nguoi_dung);

            if (entity == null) return 0;

            entity.Ten_day_du = Ten_day_du;
            entity.ID_trang_thai = ID_trang_thai;
            entity.Thoi_gian_cho = TimeSpan.Parse(Thoi_gian_cho);
            if(Mat_khau != "") entity.Mat_khau = Utilities.CreateSHAHash(Mat_khau);

            return db.SaveChanges();
        }

        public static int ChangeState(int ID_nguoi_dung, bool isLooked, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();

            var entity = db.SYS_NguoiDung.FirstOrDefault(t => t.ID_nguoi_dung == ID_nguoi_dung);

            if (entity == null) return 0;

            entity.ID_trang_thai = isLooked ? 3 : 1;

            return db.SaveChanges();
        }

        public static int ChangeTimeOut(int ID_nguoi_dung, string Thoi_gian_cho, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();

            var entity = db.SYS_NguoiDung.FirstOrDefault(t => t.ID_nguoi_dung == ID_nguoi_dung);

            if (entity == null) return 0;

            entity.Thoi_gian_cho = TimeSpan.Parse(Thoi_gian_cho);

            return db.SaveChanges();
        }

        public static SYS_NguoiDung Login(string Tai_khoan, string Mat_khau, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();

            string pass =  Utilities.CreateSHAHash(Mat_khau);

            return db.SYS_NguoiDung.FirstOrDefault(t => t.Tai_khoan == Tai_khoan && t.Mat_khau == pass);
        }
    }
}
