using DevExpress.XtraEditors;
using QLK_DongLuc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLK_DongLuc.Controllers
{
	class LoaiVatTu
	{
		public static void LoadLookUpEdit(LookUpEdit lookUpEdit, QuanLyKhoDongLucEntities db = null)
		{
			if (db == null) db = new QuanLyKhoDongLucEntities();
			lookUpEdit.Properties.Columns.Clear();
			lookUpEdit.Properties.DataSource = db.STO_LoaiVatTu.ToList();
			lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));
			lookUpEdit.Properties.DisplayMember = "Ten_loai_vat_tu";
			lookUpEdit.Properties.ValueMember = "ID_loai_vat_tu";
			lookUpEdit.Properties.NullText = "";
			lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn loại vật tư";
			lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
		}
		public static void LoadLookUpEdit(LookUpEdit lookUpEdit, int ID_nhom_vat_tu, QuanLyKhoDongLucEntities db = null)
		{
			if (db == null) db = new QuanLyKhoDongLucEntities();
			lookUpEdit.Properties.Columns.Clear();
			lookUpEdit.Properties.DataSource = db.STO_LoaiVatTu.Where(t=>t.ID_nhom_vat_tu==ID_nhom_vat_tu).ToList();
			lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));
			lookUpEdit.Properties.DisplayMember = "Ten_loai_vat_tu";
			lookUpEdit.Properties.ValueMember = "ID_loai_vat_tu";
			lookUpEdit.Properties.NullText = "";
			lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn loại vật tư";
			lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
		}
	}
}
