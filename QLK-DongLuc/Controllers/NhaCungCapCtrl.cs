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
    public class NhaCungCapCtrl
    {
        public static void LoadBindingSource(BindingSource bs, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            bs.DataSource = db.CAT_NhaCungCap.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.CAT_NhaCungCap.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nha_cung_cap", "Nhà cung cấp"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nguoi_dai_dien", "Người đại diện"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dien_thoai", "Điện thoại"));

            lookUpEdit.Properties.DisplayMember = "Ten_nha_cung_cap";
            lookUpEdit.Properties.ValueMember = "ID_nha_cung_cap";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhà cung cấp";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }


        public static int Insert(object Ten_nha_cung_cap, object Nguoi_dai_dien, object Dien_thoai, object Dia_chi, object Email, object So_tai_khoan, QuanLyKhoDongLucEntities db = null)
        {
            if (Ten_nha_cung_cap == null) return 0;

            if (db == null) db = new QuanLyKhoDongLucEntities();

            var entity = new CAT_NhaCungCap();

            entity.Ten_nha_cung_cap = Ten_nha_cung_cap.ToString().Trim();
            entity.Nguoi_dai_dien   = (Nguoi_dai_dien != null)  ? Nguoi_dai_dien.ToString().Trim()  : string.Empty;
            entity.Dien_thoai       = (Dien_thoai != null)      ? Dien_thoai.ToString().Trim()      : string.Empty;
            entity.Dia_chi          = (Dia_chi != null)         ? Dia_chi.ToString().Trim()         : string.Empty;
            entity.Email            = (Email != null)           ? Email.ToString().Trim()           : string.Empty;
            entity.So_tai_khoan     = (So_tai_khoan != null)    ? So_tai_khoan.ToString().Trim()    : string.Empty;

            db.CAT_NhaCungCap.Add(entity);

            return db.SaveChanges();
        }

        public static int Update(object ID_nha_cung_cap, object Ten_nha_cung_cap, object Nguoi_dai_dien, object Dien_thoai, object Dia_chi, object Email, object So_tai_khoan, QuanLyKhoDongLucEntities db = null)
        {
            if (ID_nha_cung_cap == null || Ten_nha_cung_cap == null) return 0;

            if (db == null) db = new QuanLyKhoDongLucEntities();

            int id = (int)ID_nha_cung_cap;
            var entity = db.CAT_NhaCungCap.FirstOrDefault(p => p.ID_nha_cung_cap == id);

            if (entity == null) return 0;

            entity.Ten_nha_cung_cap = Ten_nha_cung_cap.ToString().Trim();
            entity.Nguoi_dai_dien   = (Nguoi_dai_dien != null)  ? Nguoi_dai_dien.ToString().Trim()  : string.Empty;
            entity.Dien_thoai       = (Dien_thoai != null)      ? Dien_thoai.ToString().Trim()      : string.Empty;
            entity.Dia_chi          = (Dia_chi != null)         ? Dia_chi.ToString().Trim()         : string.Empty;
            entity.Email            = (Email != null)           ? Email.ToString().Trim()           : string.Empty;
            entity.So_tai_khoan     = (So_tai_khoan != null)    ? So_tai_khoan.ToString().Trim()    : string.Empty;

            return db.SaveChanges();
        }

        public static int Delete(object ID_nha_cung_cap, QuanLyKhoDongLucEntities db = null)
        {
            if (ID_nha_cung_cap == null) return 0;

            if (db == null) db = new QuanLyKhoDongLucEntities();

            int id = (int)ID_nha_cung_cap;
            var entity = db.CAT_NhaCungCap.FirstOrDefault(p => p.ID_nha_cung_cap == id);

            if (entity == null) return 0;

            db.CAT_NhaCungCap.Remove(entity);

            return db.SaveChanges();
        }
    }
}
