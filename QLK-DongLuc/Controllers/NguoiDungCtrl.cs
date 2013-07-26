using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using QLK_DongLuc.Helper;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Controllers
{
    public static class NguoiDungCtrl
    {
        public static void LoadBindingSource(BindingSource bs, Entities db = null)
        {
            if(db == null) db = new Entities();
            bs.DataSource = db.ViewNguoiDung.Where(t => t.ID_nguoi_dung != Program.CurrentUser.ID_nguoi_dung).ToList();
        }

        public static int Insert(object ID_nhan_vien, string Tai_khoan, string Mat_khau, string Ten_day_du, int ID_trang_thai, string Thoi_gian_cho, Entities db = null)
        {
            if (db == null) db = new Entities();

            var entity = db.SYS_NguoiDung.FirstOrDefault(t => t.Tai_khoan == Tai_khoan);

            if (entity == null) entity = new SYS_NguoiDung();
            else return -1;

            entity.Tai_khoan = Tai_khoan;
            entity.Ten_day_du = Ten_day_du;
            entity.ID_trang_thai = ID_trang_thai;
            entity.Thoi_gian_cho = TimeSpan.Parse(Thoi_gian_cho);
            entity.Mat_khau = SecurityHelper.CreateSHAHash(Mat_khau);

            if (ID_nhan_vien != null) entity.ID_nhan_vien = (int?)ID_nhan_vien;

            db.SYS_NguoiDung.Add(entity);

            return db.SaveChanges();
        }

        public static int Update(int ID_nguoi_dung, string Mat_khau, string Ten_day_du, int ID_trang_thai, string Thoi_gian_cho, Entities db = null)
        {
            if (db == null) db = new Entities();

            var entity = db.SYS_NguoiDung.FirstOrDefault(t => t.ID_nguoi_dung == ID_nguoi_dung);

            if (entity == null) return 0;

            entity.Ten_day_du = Ten_day_du;
            entity.ID_trang_thai = ID_trang_thai;
            entity.Thoi_gian_cho = TimeSpan.Parse(Thoi_gian_cho);

            if(Mat_khau != "") 
                entity.Mat_khau = SecurityHelper.CreateSHAHash(Mat_khau);

            return db.SaveChanges();
        }

        public static int Update(int ID_nguoi_dung, string Mat_khau, string Ten_day_du, Entities db = null)
        {
            if (db == null) db = new Entities();

            var entity = db.SYS_NguoiDung.FirstOrDefault(t => t.ID_nguoi_dung == ID_nguoi_dung);

            if (entity == null) return 0;

            entity.Ten_day_du = Ten_day_du;

            if (Mat_khau != "") 
                entity.Mat_khau = SecurityHelper.CreateSHAHash(Mat_khau);

            int rs = db.SaveChanges();

            if (rs != 0)
            {
                Program.CurrentUser = entity;
            }

            return rs;
        }

        public static int ChangeState(int ID_nguoi_dung, bool isLooked, Entities db = null)
        {
            if (db == null) db = new Entities();

            var entity = db.SYS_NguoiDung.FirstOrDefault(t => t.ID_nguoi_dung == ID_nguoi_dung);

            if (entity == null) return 0;

            entity.ID_trang_thai = isLooked ? 3 : 1;

            return db.SaveChanges();
        }

        public static int ChangeTimeOut(int ID_nguoi_dung, string Thoi_gian_cho, Entities db = null)
        {
            if (db == null) db = new Entities();

            var entity = db.SYS_NguoiDung.FirstOrDefault(t => t.ID_nguoi_dung == ID_nguoi_dung);

            if (entity == null) return 0;

            entity.Thoi_gian_cho = TimeSpan.Parse(Thoi_gian_cho);

            return db.SaveChanges();
        }

        public static int Login(string Tai_khoan, string Mat_khau, Entities db = null)
        {
            try
            {
                if (db == null) db = new Entities();

                string pass = SecurityHelper.CreateSHAHash(Mat_khau);

                var user = db.SYS_NguoiDung.FirstOrDefault(t => t.Tai_khoan == Tai_khoan && t.Mat_khau == pass);

                if (user != null)
                {
                    if (user.ID_trang_thai == 1)
                    {
                        user.ID_trang_thai = 2;
                        user.Lan_dang_nhap_cuoi = DatabaseHelper.GetDatabaseDate();
                        user.May_tram = MachineHelper.GetMachineInfo();
                        //Đăng nhập thành công
                        if (db.SaveChanges() > 0)
                        {
                            Program.CurrentUser = user;

                            return 1;
                        }

                        return 0;
                    }
                    else if (user.ID_trang_thai == 2 && user.ID_nhan_vien == null)
                    {
                        // Tài khoản với vai trò giám đốc đang đăng nhập
                        user.Lan_dang_nhap_cuoi = DatabaseHelper.GetDatabaseDate();
                        user.May_tram = MachineHelper.GetMachineInfo();

                        //Đăng nhập thành công
                        if (db.SaveChanges() > 0)
                        {
                            Program.CurrentUser = user;

                            return 2;
                        }

                        return 0;
                    }

                    return user.ID_trang_thai;
                }

                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int Logout(Entities db = null)
        {
            if (Program.CurrentUser == null) return 0;

            if (db == null) db = new Entities();

            var user = db.SYS_NguoiDung.FirstOrDefault(t => t.ID_nguoi_dung == Program.CurrentUser.ID_nguoi_dung);

            if (user != null)
            {
                if (user.ID_trang_thai == 1)
                    return 1;

                if (user.ID_trang_thai != 3)
                {
                    user.ID_trang_thai = 1;
                    return db.SaveChanges();
                }
            }

            return 0;
        }

        public static SYS_NguoiDung LayNguoiDungTheoID(int ID_nguoi_dung, Entities db = null)
        {
            if (db == null) db = new Entities();

            return db.SYS_NguoiDung.FirstOrDefault(t => t.ID_nguoi_dung == ID_nguoi_dung);
        }

        public static SYS_NguoiDung LayNguoiDungTheoTenDangNhap(string Tai_khoan, Entities db = null)
        {
            if (db == null) db = new Entities();

            return db.SYS_NguoiDung.FirstOrDefault(t => t.Tai_khoan == Tai_khoan);
        }
    }
}
