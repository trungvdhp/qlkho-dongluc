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
    public class KhoVatTuCtrl
    {
        public static void LoadBindingSource(BindingSource bs, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            bs.DataSource = db.STO_KhoVatTu.ToList();
        }

        public static void LoadComboBox(System.Windows.Forms.ComboBox cbo, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            cbo.DisplayMember = "Ten_kho";
            cbo.ValueMember = "ID_kho";
            cbo.DataSource = db.STO_KhoVatTu.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();
            lookUpEdit.Properties.DataSource = db.STO_KhoVatTu.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_kho", "Tên kho"));
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dia_diem", "Địa điểm"));
            lookUpEdit.Properties.DisplayMember = "Ten_kho";
            lookUpEdit.Properties.ValueMember = "ID_kho";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn kho";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }


    }
}
