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
    public class VatTuCtrl
    {
        public static void LoadBindingSource(BindingSource bs, Entities db = null)
        {
            if(db == null) db = new Entities();

            bs.DataSource = db.STO_VatTu.ToList();
        }

        public static void LoadBindingSource(BindingSource bs, int ID_loai_vat_tu, Entities db = null)
        {
            if (db == null) db = new Entities();

            bs.DataSource = db.STO_VatTu.Where(w => w.ID_loai_vat_tu == ID_loai_vat_tu).ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();
            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.ViewCboVatTu.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma_vat_tu", "Mã vật tư"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vat_tu", "Tên vật tư"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Don_vi", "Đơn vị"));
            lookUpEdit.Properties.Columns["Don_vi"].FormatString = "N2";
            lookUpEdit.Properties.Columns["Don_vi"].FormatType = DevExpress.Utils.FormatType.Numeric;


            lookUpEdit.Properties.DisplayMember = "Ten_vat_tu";
            lookUpEdit.Properties.ValueMember = "ID_vat_tu";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn vật tư";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, string Ma_nhom_vat_tu_lay, string Ma_loai_vat_tu_lay, List<string> Ma_nhom_vat_tu_bo = null, List<string> Ma_loai_vat_tu_bo = null, Entities db = null)
        {
            if (db == null) db = new Entities();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.ViewCboVatTu.Where(t => t.Ma_nhom_vat_tu.Contains(Ma_nhom_vat_tu_lay) && t.Ma_loai_vat_tu.Contains(Ma_loai_vat_tu_lay) && !Ma_nhom_vat_tu_bo.Contains(t.Ma_nhom_vat_tu) && !Ma_loai_vat_tu_bo.Contains(t.Ma_loai_vat_tu)).ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));
           lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma_vat_tu", "Mã vật tư"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vat_tu", "Tên vật tư"));

            if (Ma_nhom_vat_tu_lay.Contains("NAN"))
            {
                lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Don_vi", "Đơn vị"));
                lookUpEdit.Properties.Columns["Don_vi"].FormatString = "N2";
                lookUpEdit.Properties.Columns["Don_vi"].FormatType = DevExpress.Utils.FormatType.Numeric;
            }

            lookUpEdit.Properties.DisplayMember = "Ten_vat_tu";
            lookUpEdit.Properties.ValueMember = "ID_vat_tu";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn vật tư";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource =  db.ViewCboVatTu.Where(t => !t.Ten_loai_vat_tu.Contains("NAN")).ToList();

            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma_vat_tu", "Mã vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vat_tu", "Tên vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Don_vi", "Đơn vị"));
            gridLookUpEdit.Properties.Columns["Don_vi"].FormatString = "N2";
            gridLookUpEdit.Properties.Columns["Don_vi"].FormatType = DevExpress.Utils.FormatType.Numeric;
            gridLookUpEdit.Properties.Columns["Don_vi"].Alignment = DevExpress.Utils.HorzAlignment.Near;

            gridLookUpEdit.Properties.DisplayMember = "Ten_vat_tu";
            gridLookUpEdit.Properties.ValueMember = "ID_vat_tu";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.NullValuePrompt = "Chọn vật tư";
            gridLookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            gridLookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, string Ma_nhom_vat_tu_lay, string Ma_loai_vat_tu_lay, List<string> Ma_nhom_vat_tu_bo = null, List<string> Ma_loai_vat_tu_bo = null, Entities db = null)
        {
            if (db == null) db = new Entities();
            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource = db.ViewCboVatTu.Where(t => t.Ma_nhom_vat_tu.Contains(Ma_nhom_vat_tu_lay) && t.Ma_loai_vat_tu.Contains(Ma_loai_vat_tu_lay) && !Ma_nhom_vat_tu_bo.Any(x => t.Ma_nhom_vat_tu.Contains(x)) && !Ma_loai_vat_tu_bo.Any(x => t.Ma_loai_vat_tu.Contains(x))).ToList();
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma_vat_tu", "Mã vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vat_tu", "Tên vật tư"));

            if (Ma_nhom_vat_tu_lay.Contains("NAN") || Ma_nhom_vat_tu_lay.Contains("PROFILE"))
            {
                gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Don_vi", "Khẩu độ"));
                gridLookUpEdit.Properties.Columns["Don_vi"].FormatString = "N2";
                gridLookUpEdit.Properties.Columns["Don_vi"].FormatType = DevExpress.Utils.FormatType.Numeric;
            }

            gridLookUpEdit.Properties.DisplayMember = "Ten_vat_tu";
            gridLookUpEdit.Properties.ValueMember = "ID_vat_tu";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static int Insert(STO_VatTu vatTu, Entities db = null)
        {
            if (vatTu == null || vatTu.ID_loai_vat_tu == null || vatTu.Ten_vat_tu == null) return 0;

            if (db == null) db = new Entities();

            db.STO_VatTu.Add(vatTu);

            return db.SaveChanges();
        }

        public static int Update(STO_VatTu vatTu, Entities db = null)
        {
            if (vatTu == null || vatTu.ID_vat_tu == null || vatTu.ID_loai_vat_tu == null || vatTu.Ten_vat_tu == null) return 0;

            if (db == null) db = new Entities();

            var entity = db.STO_VatTu.FirstOrDefault(p => p.ID_vat_tu == vatTu.ID_vat_tu);

            if (entity == null) return 0;

            entity.ID_loai_vat_tu = vatTu.ID_loai_vat_tu;
            entity.Ten_vat_tu = vatTu.Ten_vat_tu;
            entity.Ma_vat_tu = vatTu.Ma_vat_tu;
            entity.Don_vi = vatTu.Don_vi;
            entity.Mo_ta = vatTu.Mo_ta;

            return db.SaveChanges();
        }

        public static int Delete(object ID_vat_tu, Entities db = null)
        {
            if (ID_vat_tu == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_vat_tu;
            var entity = db.STO_VatTu.FirstOrDefault(p => p.ID_vat_tu == id);

            if (entity == null) return 0;

            db.STO_VatTu.Remove(entity);

            return db.SaveChanges();
        }
    }
}
