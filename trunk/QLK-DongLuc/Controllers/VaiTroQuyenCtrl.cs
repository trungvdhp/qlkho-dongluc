using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Controllers
{
    public class VaiTroQuyenCtrl
    {
        public static void LoadBindingSource(BindingSource bs, object ID_vai_tro, object ID_quyen, Entities db = null)
        {
            if (ID_quyen == null || ID_vai_tro == null)
                bs.DataSource = null;
            else
            {
                if (db == null) db = new Entities();

                var idQuyen = (int)ID_quyen;
                var idVaiTro = (int)ID_vai_tro;

                bs.DataSource = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == idVaiTro && t.ID_quyen == idQuyen).ToList();
            }
        }

        public static int Update(int ID_vai_tro, int ID_quyen, GridView gridViewDetails, Entities db = null)
        {
            if (db == null) db = new Entities();

            // Update details
            int n = gridViewDetails.RowCount;
            List<int> ct = new List<int>();

            // Thêm mới và cập nhật thuộc tính
            for (int i = 0; i < n; i++)
            {
                SYS_VaiTroQuyen entity = (SYS_VaiTroQuyen)gridViewDetails.GetRow(i);

                if (entity == null || entity.ID_thuoc_tinh == 0) continue;

                SYS_VaiTroQuyen item;
                item = db.SYS_VaiTroQuyen.FirstOrDefault(t => t.ID_vai_tro == ID_vai_tro && t.ID_quyen == ID_quyen && t.ID_thuoc_tinh == entity.ID_thuoc_tinh);

                if (item == null)
                {
                    // Thêm mới
                    db.SYS_VaiTroQuyen.Add(new SYS_VaiTroQuyen
                        {
                            ID_vai_tro = ID_vai_tro,
                            ID_quyen = ID_quyen,
                            ID_thuoc_tinh = entity.ID_thuoc_tinh,
                            Gia_tri = entity.Gia_tri
                        });
                }
                else
                {
                    //Cập nhật
                    item.Gia_tri = entity.Gia_tri;
                }

                ct.Add(entity.ID_thuoc_tinh);
            }

            // Xóa các thuộc tính không có trong danh sách thuộc tính mới
            var tmp = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == ID_vai_tro && t.ID_quyen == ID_quyen && !ct.Contains(t.ID_thuoc_tinh));
            db.SYS_VaiTroQuyen.RemoveRange(tmp);

            return db.SaveChanges();
        }

        public static int Inherit(int ID_parent, int ID_child, Entities db = null)
        {
            if (db == null) db = new Entities();

            var children = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == ID_child);
            var parent = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == ID_parent);

            foreach (var entity in parent)
            {
                if (children.FirstOrDefault(t => t.ID_quyen == entity.ID_quyen && t.ID_thuoc_tinh == entity.ID_thuoc_tinh) == null)
                {
                    db.SYS_VaiTroQuyen.Add(new SYS_VaiTroQuyen
                    {
                        ID_vai_tro = ID_child,
                        ID_quyen = entity.ID_quyen,
                        ID_thuoc_tinh = entity.ID_thuoc_tinh,
                        Gia_tri = entity.Gia_tri
                    });
                }
            }

            return db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID_parent"></param>
        /// <param name="ID_child"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public static int Copy(int ID_parent, int ID_child, Entities db = null)
        {
            if (db == null) db = new Entities();

            var children = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == ID_child);
            var parent = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == ID_parent);
            db.SYS_VaiTroQuyen.RemoveRange(children);

            foreach (var entity in parent)
            {
                db.SYS_VaiTroQuyen.Add(new SYS_VaiTroQuyen
                {
                    ID_vai_tro = ID_child,
                    ID_quyen = entity.ID_quyen,
                    ID_thuoc_tinh = entity.ID_thuoc_tinh,
                    Gia_tri = entity.Gia_tri
                });
            }

            return db.SaveChanges();
        }

        public static int Inherit(int ID_vai_tro, int ID_quyen, List<SYS_Quyen> quyens, Entities db = null)
        {
            if (db == null) db = new Entities();
            // Lấy quyền trong bảng quyền
            var quyen = quyens.First(t => t.ID_quyen == ID_quyen);
            // Lọc các quyền cùng loại với quyen
            List<int> ids = quyens.Where(t => t.ID_quyen != quyen.ID_quyen && t.Loai_dieu_khien == quyen.Loai_dieu_khien).Select(t => t.ID_quyen).ToList();
            // Lấy danh sách các thuộc tính của các quyền nằm trong danh sách quyens
            var t1 = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == ID_vai_tro && ids.Contains(t.ID_quyen));
            // Lấy danh sách các thuộc tính của quyền để kế thừa
            var t2 = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == ID_vai_tro && t.ID_quyen == ID_quyen);
            quyens = quyens.Where(t => t.ID_quyen != ID_quyen).ToList();
            // Gán các thuộc tính của quyền cho các quyền khác
            foreach (var entity in t2)
            {
                foreach(var id in ids)
                {
                    if (t1.FirstOrDefault(t => t.ID_quyen == id && t.ID_thuoc_tinh == entity.ID_thuoc_tinh) == null)
                    {
                        db.SYS_VaiTroQuyen.Add(new SYS_VaiTroQuyen
                        {
                            ID_vai_tro = ID_vai_tro,
                            ID_quyen = id,
                            ID_thuoc_tinh = entity.ID_thuoc_tinh,
                            Gia_tri = entity.Gia_tri
                        });
                    }
                }
            }

            return db.SaveChanges();
        }

        public static int Copy(int ID_vai_tro, int ID_quyen, List<SYS_Quyen> quyens, Entities db = null)
        {
            if (db == null) db = new Entities();
            // Lấy quyền trong bảng quyền
            var quyen = quyens.First(t => t.ID_quyen == ID_quyen);
            // Lọc các quyền cùng loại với quyen
            List<int> ids = quyens.Where(t => t.ID_quyen != quyen.ID_quyen && t.Loai_dieu_khien == quyen.Loai_dieu_khien).Select(t => t.ID_quyen).ToList();
            // Lấy danh sách các thuộc tính của các quyền nằm trong danh sách quyens
            var t1 = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == ID_vai_tro && ids.Contains(t.ID_quyen));
            // Lấy danh sách các thuộc tính của quyền để kế thừa
            var t2 = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == ID_vai_tro && t.ID_quyen == ID_quyen);
            quyens = quyens.Where(t => t.ID_quyen != ID_quyen).ToList();
            // Gán các thuộc tính của quyền cho các quyền khác

            foreach (var id in ids)
            {
                // Xóa hết các thuộc tính cũ
                db.SYS_VaiTroQuyen.RemoveRange(t1.Where(t => t.ID_quyen == id));
                // Thêm các thuộc tính mới
                foreach (var entity in t2)
                {
                    db.SYS_VaiTroQuyen.Add(new SYS_VaiTroQuyen
                    {
                        ID_vai_tro = ID_vai_tro,
                        ID_quyen = id,
                        ID_thuoc_tinh = entity.ID_thuoc_tinh,
                        Gia_tri = entity.Gia_tri
                    });
                }
            }

            return db.SaveChanges();
        }

        public static int ClearAllProperties(int ID_vai_tro, List<SYS_Quyen> quyens, Entities db = null)
        {
            if (db == null) db = new Entities();

            var t1 = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == ID_vai_tro);

            foreach (var quyen in quyens)
            {
                db.SYS_VaiTroQuyen.RemoveRange(t1.Where(t => t.ID_quyen == quyen.ID_quyen));
            }

            return db.SaveChanges();
        }

        public static void ReconfigFormControls(XtraForm form, Entities db = null)
        {
            if (db == null) db = new Entities();

            var vai_tro = Program.CurrentUser.SYS_VaiTro.FirstOrDefault();
            var quyen = db.SYS_Quyen.FirstOrDefault(t => t.Ma_quyen == form.Name);

            if (vai_tro == null || quyen == null) return;

            int ID_vai_tro = vai_tro.ID_vai_tro;
            int ID_quyen = quyen.ID_quyen;
            
            var vaitro_quyens = db.SYS_VaiTroQuyen.Where(t => t.ID_vai_tro == ID_vai_tro && t.SYS_Quyen.ID_goc == ID_quyen).ToList();
            int current = 0;
            object obj = form;

            foreach (var item in vaitro_quyens)
            {
                if (item.ID_quyen != current)
                {
                    obj = QLK_DongLuc.Helper.ControlHelper.FindControl(form, item.SYS_Quyen.Ma_quyen);
                    current = item.ID_quyen;
                }

                if (obj == null) continue;

                object value = true;

                if (item.SYS_ThuocTinh.Ky_hieu == "Visibility")
                {
                    if (item.Gia_tri == true)
                    {
                        value = BarItemVisibility.Always;
                    }
                    else
                    {
                        value = BarItemVisibility.Never;
                    }
                }
                else if(item.SYS_ThuocTinh.Ky_hieu == "OptionsView.ShowFilterPanelMode")
                {
                    if (item.Gia_tri == true)
                    {
                        value = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
                    }
                    else
                    {
                        value = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
                    }
                }
                else if (item.SYS_ThuocTinh.Loai_gia_tri == 1)
                {
                    if (item.Gia_tri == true)
                    {
                        value = DevExpress.Utils.DefaultBoolean.True;
                    }
                    else
                    {
                        value = DevExpress.Utils.DefaultBoolean.False;
                    }
                }
                else
                {
                    value = item.Gia_tri;
                }

                QLK_DongLuc.Helper.ControlHelper.SetValue(obj, item.SYS_ThuocTinh.Ky_hieu, value);
            }
        }
    }
}
