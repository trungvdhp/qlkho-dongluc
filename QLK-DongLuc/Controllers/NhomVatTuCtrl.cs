using DevExpress.XtraEditors;
using QLK_DongLuc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

namespace QLK_DongLuc.Controllers
{
	public static class NhomVatTuCtrl
	{
        public static void LoadBindingSource(BindingSource bindingSource, Entities db = null)
        {
            if (db == null) db = new Entities();

            if (Properties.Settings.Default.ID_kho == 0)
                bindingSource.DataSource = db.STO_NhomVatTu.ToList();
            else
                bindingSource.DataSource = db.STO_NhomVatTu.Where(w => w.ID_kho == Properties.Settings.Default.ID_kho).ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, int ID_kho, Entities db = null)
        {
            if (db == null) db = new Entities();
            lookUpEdit.Properties.Columns.Clear();

            lookUpEdit.Properties.DataSource = db.STO_NhomVatTu.Where(w => w.ID_kho == ID_kho).ToList();

            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nhom_vat_tu", "Nhóm vật tư"));
            lookUpEdit.Properties.DisplayMember = "Ten_nhom_vat_tu";
            lookUpEdit.Properties.ValueMember = "ID_nhom_vat_tu";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhóm vật tư";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;

                lookUpEdit.ItemIndex = 0;
        }

		public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
		{
			if (db == null) db = new Entities();
			lookUpEdit.Properties.Columns.Clear();
            if (Properties.Settings.Default.ID_kho == 0)
                lookUpEdit.Properties.DataSource = db.STO_NhomVatTu.ToList();
            else
                lookUpEdit.Properties.DataSource = db.STO_NhomVatTu.Where(w => w.ID_kho == Properties.Settings.Default.ID_kho).ToList();
			
			lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nhom_vat_tu", "Nhóm vật tư"));
			lookUpEdit.Properties.DisplayMember = "Ten_nhom_vat_tu";
			lookUpEdit.Properties.ValueMember = "ID_nhom_vat_tu";
			lookUpEdit.Properties.NullText = "";
			lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhóm vật tư";
			lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;

            if (Properties.Settings.Default.ID_nhom_vat_tu != 0)
                lookUpEdit.EditValue = Properties.Settings.Default.ID_nhom_vat_tu;
            else
                lookUpEdit.ItemIndex = 0;
		}

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();
            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource = db.STO_NhomVatTu.ToList();
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nhom_vat_tu", "Nhóm vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STO_KhoVatTu.Ten_kho", "Kho"));
            gridLookUpEdit.Properties.DisplayMember = "Ten_nhom_vat_tu";
            gridLookUpEdit.Properties.ValueMember = "ID_nhom_vat_tu";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static int Insert(STO_NhomVatTu nhomVatTu, Entities db = null)
        {
            if (nhomVatTu == null || nhomVatTu.ID_kho == null || nhomVatTu.Ten_nhom_vat_tu == null) return 0;

            if (db == null) db = new Entities();

            db.STO_NhomVatTu.Add(nhomVatTu);

            return db.SaveChanges();
        }

        public static int Update(STO_NhomVatTu nhomVatTu, Entities db = null)
        {
            if (nhomVatTu == null || nhomVatTu.ID_nhom_vat_tu == null || nhomVatTu.ID_kho == null || nhomVatTu.Ten_nhom_vat_tu == null) return 0;

            if (db == null) db = new Entities();

            var entity = db.STO_NhomVatTu.FirstOrDefault(t => t.ID_nhom_vat_tu == nhomVatTu.ID_nhom_vat_tu);

            if (entity == null) return 0;

            entity.ID_kho = nhomVatTu.ID_kho;
            entity.Ten_nhom_vat_tu = nhomVatTu.Ten_nhom_vat_tu;
            entity.Ghi_chu = nhomVatTu.Ghi_chu;
            entity.Ma_nhom_vat_tu = nhomVatTu.Ma_nhom_vat_tu;

            return db.SaveChanges();
        }

        public static int Delete(object ID_nhom_vat_tu, Entities db = null)
        {
            if (ID_nhom_vat_tu == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_nhom_vat_tu;
            var entity = db.STO_NhomVatTu.FirstOrDefault(p => p.ID_nhom_vat_tu == id);

            if (entity == null) return 0;

            db.STO_NhomVatTu.Remove(entity);

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
