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
        public static void LoadBindingSource(BindingSource bs, QuanLyKhoDongLucEntities db = null)
        {
            if(db == null) db = new QuanLyKhoDongLucEntities();
            bs.DataSource = db.STO_VatTu.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            lookUpEdit.Properties.DataSource = db.ViewCboVatTu.ToList();

            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vat_tu", "Tên vật tư"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Don_vi", "Đơn vị"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mo_ta", "Mô tả"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));

            lookUpEdit.Properties.DisplayMember = "Ten_vat_tu";
            lookUpEdit.Properties.ValueMember = "ID_vat_tu";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn vật tư";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            gridLookUpEdit.Properties.DataSource = db.ViewCboVatTu.ToList();

            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ma_vat_tu", "Mã vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_vat_tu", "Tên vật tư"));
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));

            gridLookUpEdit.Properties.DisplayMember = "Ten_vat_tu";
            gridLookUpEdit.Properties.ValueMember = "ID_vat_tu";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.NullValuePrompt = "Chọn vật tư";
            gridLookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }
    }
}
