using DevExpress.XtraEditors;
using QLK_DongLuc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLK_DongLuc.Controllers
{
	public static class NhomVatTuCtrl
	{
        public static void LoadBindingSource(BindingSource bindingSource, Entities db = null)
        {
            if (db == null) db = new Entities();

            bindingSource.DataSource = db.STO_NhomVatTu.ToList();
        }

		public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
		{
			if (db == null) db = new Entities();
			lookUpEdit.Properties.Columns.Clear();
			lookUpEdit.Properties.DataSource = db.STO_NhomVatTu.ToList();
			lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nhom_vat_tu", "Nhóm vật tư"));
			lookUpEdit.Properties.DisplayMember = "Ten_nhom_vat_tu";
			lookUpEdit.Properties.ValueMember = "ID_nhom_vat_tu";
			lookUpEdit.Properties.NullText = "";
			lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhóm vật tư";
			lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
		}

        public static int Insert(object Ten_nhom_vat_tu, object Ghi_chu, object ID_kho, Entities db = null)
        {
            if (db == null) db = new Entities();

            if (Ten_nhom_vat_tu == null) return 0;

            db.STO_NhomVatTu.Add(new STO_NhomVatTu
            {
                Ten_nhom_vat_tu = Ten_nhom_vat_tu.ToString(),
                Ghi_chu = Ghi_chu.ToString(),
                ID_kho = (int?)ID_kho
            });

            return db.SaveChanges();
        }

        public static int Update(object ID_nhom_vat_tu, object Ten_nhom_vat_tu, object Ghi_chu, object ID_kho, Entities db = null)
        {
            if (ID_nhom_vat_tu == null || Ten_nhom_vat_tu == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_nhom_vat_tu;
            var entity = db.STO_NhomVatTu.FirstOrDefault(t => t.ID_nhom_vat_tu == id);

            if (entity == null) return 0;

            entity.Ten_nhom_vat_tu = Ten_nhom_vat_tu.ToString();
            entity.Ghi_chu = Ghi_chu.ToString();
            entity.ID_kho = (int?)ID_kho;

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

            return db.SaveChanges();
        }
	}
}
