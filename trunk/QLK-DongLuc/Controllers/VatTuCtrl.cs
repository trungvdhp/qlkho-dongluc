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

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, string Ten_loai_vat_tu, string Ten_nhom_vat_tu, Entities db = null)
        {
            if (db == null) db = new Entities();
            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.ViewCboVatTu.Where(t => t.Ten_loai_vat_tu.Contains(Ten_loai_vat_tu) && t.Ten_nhom_vat_tu.Contains(Ten_nhom_vat_tu)).ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));
           lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma_vat_tu", "Mã vật tư"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vat_tu", "Tên vật tư"));

            if (Ten_loai_vat_tu.Contains("NAN"))
            {
                lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Don_vi", "Đơn vị"));
                lookUpEdit.Properties.Columns["Don_vi"].FormatString = "N2";
                lookUpEdit.Properties.Columns["Don_vi"].FormatType = DevExpress.Utils.FormatType.Numeric;
            }

            lookUpEdit.Properties.DisplayMember = "Ten_vat_tu";
            lookUpEdit.Properties.ValueMember = "ID_vat_tu";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn " + Ten_loai_vat_tu != "" ? Ten_loai_vat_tu : Ten_nhom_vat_tu;
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

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, string Ten_loai_vat_tu, string Ten_nhom_vat_tu, Entities db = null)
        {
            if (db == null) db = new Entities();

            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource = db.ViewCboVatTu.Where(t => t.Ten_loai_vat_tu.Contains(Ten_loai_vat_tu) && t.Ten_nhom_vat_tu.Contains(Ten_nhom_vat_tu)).ToList();
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma_vat_tu", "Mã vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vat_tu", "Tên vật tư"));

            if (Ten_loai_vat_tu.Contains("NAN"))
            {
                gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Don_vi", "Đơn vị"));
                gridLookUpEdit.Properties.Columns["Don_vi"].FormatString = "N2";
                gridLookUpEdit.Properties.Columns["Don_vi"].FormatType = DevExpress.Utils.FormatType.Numeric;
                gridLookUpEdit.Properties.Columns["Don_vi"].Alignment = DevExpress.Utils.HorzAlignment.Near;
            }

            gridLookUpEdit.Properties.DisplayMember = "Ten_vat_tu";
            gridLookUpEdit.Properties.ValueMember = "ID_vat_tu";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.NullValuePrompt = "Chọn " + Ten_loai_vat_tu != "" ? Ten_loai_vat_tu : Ten_nhom_vat_tu;
            gridLookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            gridLookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static void LoadThieBiAustDoorKhac(RepositoryItemLookUpEdit gridLookUpEdit, Entities db = null)
        {
             if (db == null) db = new Entities();

            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource = db.ViewCboVatTu.Where(t => !t.Ten_loai_vat_tu.Contains("Thân cửa AustDoor") && !t.Ten_loai_vat_tu.Contains("Mô tơ cửa AustDoor") && t.Ten_nhom_vat_tu == "Cửa cuốn AustDoor").ToList();
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma_vat_tu", "Mã vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vat_tu", "Tên vật tư"));

            gridLookUpEdit.Properties.DisplayMember = "Ten_vat_tu";
            gridLookUpEdit.Properties.ValueMember = "ID_vat_tu";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.NullValuePrompt = "Chọn thiết bị cửa cuốn AustDoor";
            gridLookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
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
