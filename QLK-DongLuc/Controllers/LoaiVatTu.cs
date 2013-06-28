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

		/// <summary>
		/// Load các loại vật tư tồn đầu kỳ 
		/// </summary>
		/// <param name="lookUpEdit"></param>
		/// <param name="ID_ton"></param>
		/// <param name="db"></param>
		public static void LoadLookUpEditTonKho(LookUpEdit lookUpEdit, int ID_ton, QuanLyKhoDongLucEntities db = null)
		{
			if (db == null) db = new QuanLyKhoDongLucEntities();
			lookUpEdit.Properties.Columns.Clear();
			lookUpEdit.Properties.DataSource = db.STO_TonDauKyCT.Where(t => t.ID_ton == ID_ton).Select(t=>new{
				ID_loai_vat_tu = t.STO_VatTu.ID_loai_vat_tu,
				Ten_loai_vat_tu = t.STO_VatTu.Ten_vat_tu,
			}).Distinct().ToList();
			lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_loai_vat_tu", "Loại vật tư"));
			lookUpEdit.Properties.DisplayMember = "Ten_loai_vat_tu";
			lookUpEdit.Properties.ValueMember = "ID_loai_vat_tu";
			lookUpEdit.Properties.NullText = "";
			lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn loại vật tư";
			lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
		}
	}
}
