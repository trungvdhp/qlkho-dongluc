using DevExpress.XtraEditors;
using QLK_DongLuc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLK_DongLuc.Controllers
{
	class NhomVatTu
	{
		public static void LoadLookUpEdit(LookUpEdit lookUpEdit, QuanLyKhoDongLucEntities db = null)
		{
			if (db == null) db = new QuanLyKhoDongLucEntities();
			lookUpEdit.Properties.Columns.Clear();
			lookUpEdit.Properties.DataSource = db.STO_NhomVatTu.ToList();
			lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nhom_vat_tu", "Nhóm vật tư"));
			lookUpEdit.Properties.DisplayMember = "Ten_nhom_vat_tu";
			lookUpEdit.Properties.ValueMember = "ID_nhom_vat_tu";
			lookUpEdit.Properties.NullText = "";
			lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn nhóm vật tư";
			lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
		}
	}
}
