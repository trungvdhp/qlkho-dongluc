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
                    obj = Utils.FindControl(form, item.SYS_Quyen.Ma_quyen);
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

                Utils.SetValue(obj, item.SYS_ThuocTinh.Ky_hieu, value);
            }
        }
    }
}
