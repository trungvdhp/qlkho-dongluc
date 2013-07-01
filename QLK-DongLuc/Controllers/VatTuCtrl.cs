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
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vat_tu", "Tên vật tư"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Don_vi", "Đơn vị"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mo_ta", "Mô tả"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Don_vi", "Đơn vị"));
            lookUpEdit.Properties.Columns["Don_vi"].FormatString = "N2";
            lookUpEdit.Properties.Columns["Don_vi"].FormatType = DevExpress.Utils.FormatType.Numeric;

            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));

            lookUpEdit.Properties.DisplayMember = "Ten_vat_tu";
            lookUpEdit.Properties.ValueMember = "ID_vat_tu";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn vật tư";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource = db.ViewCboVatTu.ToList();
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma_vat_tu", "Mã vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vat_tu", "Tên vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Don_vi", "Đơn vị"));
            gridLookUpEdit.Properties.Columns["Don_vi"].FormatString = "N2";
            gridLookUpEdit.Properties.Columns["Don_vi"].FormatType = DevExpress.Utils.FormatType.Numeric;
            gridLookUpEdit.Properties.Columns["Don_vi"].Alignment = DevExpress.Utils.HorzAlignment.Near;
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));

            gridLookUpEdit.Properties.DisplayMember = "Ten_vat_tu";
            gridLookUpEdit.Properties.ValueMember = "ID_vat_tu";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.NullValuePrompt = "Chọn vật tư";
            gridLookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }

        public static int Insert(object ID_loai_vat_tu, object Ten_vat_tu, object Ma_vat_tu, object Don_vi, object Mo_ta, Entities db = null)
        {
            if (ID_loai_vat_tu == null || Ten_vat_tu == null) return 0;

            if (db == null) db = new Entities();

            var entity = new STO_VatTu();
            entity.ID_loai_vat_tu = (int)ID_loai_vat_tu;
            entity.Ten_vat_tu = Ten_vat_tu.ToString().Trim();

            if (Ma_vat_tu != null) entity.Ma_vat_tu = Ma_vat_tu.ToString().Trim();

            if (Don_vi != null)
            {
                double dv;
                double.TryParse(Don_vi.ToString(), out dv);
                if (dv == 0)
                    entity.Don_vi = null;
                else
                    entity.Don_vi = dv;
            }
            else
            {
                entity.Don_vi = null;
            }

            if (Mo_ta != null) entity.Mo_ta = Mo_ta.ToString().Trim();

            db.STO_VatTu.Add(entity);

            return db.SaveChanges();
        }

        public static int Update(object ID_vat_tu, object ID_loai_vat_tu, object Ten_vat_tu, object Ma_vat_tu, object Don_vi, object Mo_ta, Entities db = null)
        {
            if (ID_vat_tu == null || ID_loai_vat_tu == null || Ten_vat_tu == null) return 0;

            if (db == null) db = new Entities();

            int id = (int)ID_vat_tu;
            var entity = db.STO_VatTu.FirstOrDefault(p => p.ID_vat_tu == id);

            if (entity == null) return 0;

            entity.ID_loai_vat_tu = (int)ID_loai_vat_tu;
            entity.Ten_vat_tu = Ten_vat_tu.ToString().Trim();

            if (Ma_vat_tu != null) entity.Ma_vat_tu = Ma_vat_tu.ToString().Trim();

            if (Don_vi != null)
            {
                double dv;
                double.TryParse(Don_vi.ToString(), out dv);
                if (dv == 0)
                    entity.Don_vi = null;
                else
                    entity.Don_vi = dv;
            }
            else
            {
                entity.Don_vi = null;
            }

            if (Mo_ta != null) entity.Mo_ta = Mo_ta.ToString().Trim();

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
