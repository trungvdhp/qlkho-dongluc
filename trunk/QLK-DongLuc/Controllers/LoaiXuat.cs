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
    public static class LoaiXuat
    {
        public static void LoadBindingSource(BindingSource bs, Entities db = null)
        {
            if (db == null) db = new Entities();
            bs.DataSource = db.EXP_LoaiXuat.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.EXP_LoaiXuat.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_xuat", "Loại xuất"));

            lookUpEdit.Properties.DisplayMember = "Ten_loai_xuat";
            lookUpEdit.Properties.ValueMember = "ID_loai_xuat";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn loại xuất";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource = db.EXP_LoaiXuat.ToList();
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_xuat", "Loại xuất"));

            gridLookUpEdit.Properties.DisplayMember = "Ten_loai_xuat";
            gridLookUpEdit.Properties.ValueMember = "ID_loai_xuat";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.NullValuePrompt = "Chọn loại xuất";
            gridLookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            gridLookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }
    }
}
