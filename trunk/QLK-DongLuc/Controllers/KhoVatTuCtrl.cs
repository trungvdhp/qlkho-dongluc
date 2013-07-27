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
    public static class KhoVatTuCtrl
    {
        public static void LoadBindingSource(BindingSource bs, Entities db = null)
        {
            if (db == null) db = new Entities();

            bs.DataSource = db.STO_KhoVatTu.ToList();
        }

        public static void LoadComboBox(System.Windows.Forms.ComboBox cbo, Entities db = null)
        {
            if (db == null) db = new Entities();

            cbo.DisplayMember = "Ten_kho";
            cbo.ValueMember = "ID_kho";
            cbo.DataSource = db.STO_KhoVatTu.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.STO_KhoVatTu.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Tên kho"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dia_diem", "Địa điểm"));
            lookUpEdit.Properties.DisplayMember = "Ten_kho";
            lookUpEdit.Properties.ValueMember = "ID_kho";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn kho";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource = db.STO_KhoVatTu.ToList();
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Tên kho"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dia_diem", "Địa điểm"));
            gridLookUpEdit.Properties.DisplayMember = "Ten_kho";
            gridLookUpEdit.Properties.ValueMember = "ID_kho";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, string Ten_kho, Entities db = null)
        {
            if (db == null) db = new Entities();
            lookUpEdit.Properties.Columns.Clear();
            var kho = db.STO_KhoVatTu.Where(t => t.Ten_kho.Contains(Ten_kho)).ToList();
            lookUpEdit.Properties.DataSource = kho;
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Tên kho"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dia_diem", "Địa điểm"));
            lookUpEdit.Properties.DisplayMember = "Ten_kho";
            lookUpEdit.Properties.ValueMember = "ID_kho";
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;

            if (kho.Count > 0) lookUpEdit.ItemIndex = 0;
        }

		/// <summary>
		/// Load các kho trong tồn đầu kỳ
		/// </summary>
		/// <param name="lookUpEdit"></param>
		/// <param name="From"></param>
		/// <param name="To"></param>
		/// <param name="db"></param>
		public static void LoadLookUpEdit(LookUpEdit lookUpEdit, DateTime From, DateTime To, Entities db = null)
		{
			if (db == null) db = new Entities();
			lookUpEdit.Properties.Columns.Clear();
			lookUpEdit.Properties.DataSource = db.STO_TonDauKy.Where(t => t.Ky >= From && t.Ky <= To).Select(t => new 
            { 
				Ten_kho = t.STO_KhoVatTu.Ten_kho,
				ID_kho = t.ID_kho,
				Dia_diem = t.STO_KhoVatTu.Dia_diem,
			}).Distinct().ToList();
			lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Tên kho"));
			lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dia_diem", "Địa điểm"));
			lookUpEdit.Properties.DisplayMember = "Ten_kho";
			lookUpEdit.Properties.ValueMember = "ID_kho";
			lookUpEdit.Properties.NullText = "";
			lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn kho";
			lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
		}

        public static int Insert(STO_KhoVatTu kho, Entities db = null)
        {
            if (kho == null || kho.Ten_kho == null) return 0;

            if (db == null) db = new Entities();

            db.STO_KhoVatTu.Add(kho);

            return db.SaveChanges();
        }

        public static int Update(STO_KhoVatTu kho, Entities db = null)
        {
            if (kho == null || kho.ID_kho == null || kho.Ten_kho == null) return 0;

            if (db == null) db = new Entities();

            var entity = db.STO_KhoVatTu.FirstOrDefault(t => t.ID_kho == kho.ID_kho);

            if (entity == null) return 0;

            entity.Ten_kho = kho.Ten_kho;
            entity.Dia_diem = kho.Dia_diem;
            entity.Ma_kho = kho.Ma_kho;

            return db.SaveChanges();
        }

        public static int Delete(object ID_kho, Entities db = null)
        {
            if (ID_kho == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_kho;
            var entity = db.STO_KhoVatTu.FirstOrDefault(p => p.ID_kho == id);

            if (entity == null) return 0;

            db.STO_KhoVatTu.Remove(entity);

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
