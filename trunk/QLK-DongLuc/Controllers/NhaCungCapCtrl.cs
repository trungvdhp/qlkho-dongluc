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
    public static class NhaCungCapCtrl
    {
        public static void LoadBindingSource(BindingSource bs, Entities db = null)
        {
            if (db == null) db = new Entities();
            bs.DataSource = db.CAT_NhaCungCap.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();
            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.CAT_NhaCungCap.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nha_cung_cap", "Nhà cung cấp"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nguoi_dai_dien", "Người đại diện"));
            //lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dien_thoai", "Điện thoại"));
            lookUpEdit.Properties.BestFit();
            lookUpEdit.Properties.DisplayMember = "Ten_nha_cung_cap";
            lookUpEdit.Properties.ValueMember = "ID_nha_cung_cap";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhà cung cấp";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }


        public static int Insert(CAT_NhaCungCap nhaCungCap, Entities db = null)
        {
            if (nhaCungCap == null || nhaCungCap.Ten_nha_cung_cap == null) return 0;

            if (db == null) db = new Entities();

            db.CAT_NhaCungCap.Add(nhaCungCap);

            return db.SaveChanges();
        }

        public static int Update(CAT_NhaCungCap nhaCungCap, Entities db = null)
        {
            if (nhaCungCap == null || nhaCungCap.ID_nha_cung_cap == null || nhaCungCap.Ten_nha_cung_cap == null) return 0;

            if (db == null) db = new Entities();

            var entity = db.CAT_NhaCungCap.FirstOrDefault(p => p.ID_nha_cung_cap == nhaCungCap.ID_nha_cung_cap);

            if (entity == null) return 0;

            entity.Ten_nha_cung_cap = nhaCungCap.Ten_nha_cung_cap;
            entity.Nguoi_dai_dien   = nhaCungCap.Nguoi_dai_dien;
            entity.Dien_thoai       = nhaCungCap.Dien_thoai;
            entity.Dia_chi          = nhaCungCap.Dia_chi;
            entity.Email            = nhaCungCap.Email;
            entity.So_tai_khoan     = nhaCungCap.So_tai_khoan;

            return db.SaveChanges();
        }

        public static int Delete(object ID_nha_cung_cap, Entities db = null)
        {
            if (ID_nha_cung_cap == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_nha_cung_cap;
            var entity = db.CAT_NhaCungCap.FirstOrDefault(p => p.ID_nha_cung_cap == id);

            if (entity == null) return 0;

            db.CAT_NhaCungCap.Remove(entity);

            return db.SaveChanges();
        }
    }
}
