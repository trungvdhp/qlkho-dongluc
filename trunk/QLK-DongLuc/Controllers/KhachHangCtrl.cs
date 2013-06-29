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
    public class KhachHangCtrl
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
        }

        public static int Insert(object Ho_dem, object Ten, object Dien_thoai, object Dia_chi, object ID_nguoi_tao, Entities db = null)
        {
            if (Ho_dem == null || Ten == null) return 0;

            if (db == null) db = new Entities();

            var entity = new CAT_KhachHang();

            entity.Ho_dem = Ho_dem.ToString().Trim();
            entity.Ten = Ten.ToString().Trim();
            entity.Dien_thoai = (Dien_thoai != null) ? Dien_thoai.ToString().Trim() : string.Empty;
            entity.Dia_chi = (Dia_chi != null) ? Dia_chi.ToString().Trim() : string.Empty;
            entity.ID_nguoi_tao = (int?)null;

            db.CAT_KhachHang.Add(entity);

            return db.SaveChanges();
        }

        public static int Update(object ID_khach_hang, object Ho_dem, object Ten, object Dien_thoai, object Dia_chi, object ID_nguoi_tao, Entities db = null)
        {
            if (ID_khach_hang == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_khach_hang;
            var entity = db.CAT_KhachHang.FirstOrDefault(p => p.ID_khach_hang == id);

            if (entity == null) return 0;

            entity.Ho_dem = Ho_dem.ToString().Trim();
            entity.Ten = Ten.ToString().Trim();
            entity.Dien_thoai = (Dien_thoai != null) ? Dien_thoai.ToString().Trim() : string.Empty;
            entity.Dia_chi = (Dia_chi != null) ? Dia_chi.ToString().Trim() : string.Empty;
            entity.ID_nguoi_tao = (int?)null;

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
