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
    public static class LoaiVatTuCtrl
    {
        public static void LoadBindingSource(BindingSource bs, Entities db = null)
        {
            if(db == null) db = new Entities();

            bs.DataSource = db.STO_LoaiVatTu.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.ViewCboLoaiVatTu.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Thuộc nhóm"));

            lookUpEdit.Properties.DisplayMember = "Ten_loai_vat_tu";
            lookUpEdit.Properties.ValueMember = "ID_loai_vat_tu";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn loại vật tư";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, int ID_nhom_vat_tu, Entities db = null)
        {
            if (db == null) db = new Entities();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.STO_LoaiVatTu.Where(t => t.ID_nhom_vat_tu == ID_nhom_vat_tu).ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));

            lookUpEdit.Properties.DisplayMember = "Ten_loai_vat_tu";
            lookUpEdit.Properties.ValueMember = "ID_loai_vat_tu";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn loại vật tư";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        /// <summary>
        /// Load các loại vật tư tồn đầu kỳ 
        /// </summary>
        /// <param name="lookUpEdit"></param>
        /// <param name="ID_ton"></param>
        /// <param name="db"></param>
        public static void LoadLookUpEditTonKho(LookUpEdit lookUpEdit, int ID_ton, Entities db = null)
        {
            if (db == null) db = new Entities();
            lookUpEdit.Properties.Columns.Clear();

            lookUpEdit.Properties.DataSource = db.STO_TonDauKyCT.Where(t => t.ID_ton == ID_ton).Select(t => new
            {
                ID_loai_vat_tu = t.STO_VatTu.ID_loai_vat_tu,
                Ten_loai_vat_tu = t.STO_VatTu.Ten_vat_tu,
            }).Distinct().ToList();

            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));
            lookUpEdit.Properties.DisplayMember = "Ten_loai_vat_tu";
            lookUpEdit.Properties.ValueMember = "ID_loai_vat_tu";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn loại vật tư";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource = db.ViewCboLoaiVatTu.ToList();
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Thuộc nhóm"));

            gridLookUpEdit.Properties.DisplayMember = "Ten_loai_vat_tu";
            gridLookUpEdit.Properties.ValueMember = "ID_loai_vat_tu";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static int Insert(STO_LoaiVatTu loaiVatTu, Entities db = null)
        {
            if (loaiVatTu == null || loaiVatTu.Ten_loai_vat_tu == null || loaiVatTu.ID_nhom_vat_tu == null)
                return 0;

            if (db == null) db = new Entities();

            db.STO_LoaiVatTu.Add(loaiVatTu);

            return db.SaveChanges();
        }

        public static int Update(STO_LoaiVatTu loaiVatTu, Entities db = null)
        {
            if (loaiVatTu == null || loaiVatTu.ID_loai_vat_tu == null || loaiVatTu.Ten_loai_vat_tu == null || loaiVatTu.ID_nhom_vat_tu == null) return 0;

            if (db == null) db = new Entities();

            var entity = db.STO_LoaiVatTu.FirstOrDefault(t => t.ID_loai_vat_tu == loaiVatTu.ID_loai_vat_tu);

            if (entity == null) return 0;

            entity.ID_nhom_vat_tu = loaiVatTu.ID_nhom_vat_tu;
            entity.Ten_loai_vat_tu = loaiVatTu.Ten_loai_vat_tu;
            entity.Ghi_chu = loaiVatTu.Ghi_chu;
            entity.Ma_loai_vat_tu = loaiVatTu.Ma_loai_vat_tu;

            return db.SaveChanges();
        }

        public static int Delete(object ID_loai_vat_tu, Entities db = null)
        {
            if (ID_loai_vat_tu == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_loai_vat_tu;
            var entity = db.STO_LoaiVatTu.FirstOrDefault(p => p.ID_loai_vat_tu == id);

            if (entity == null) return 0;

            db.STO_LoaiVatTu.Remove(entity);

            try
            {
                return db.SaveChanges();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
