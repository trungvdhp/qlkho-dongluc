using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLK_DongLuc.Models;
using System.Data;
using DevExpress.XtraEditors;

namespace QLK_DongLuc.Controllers
{
	class TonDauKy
	{
		public static void Luu(int ID_kho, int ID_nhan_vien)
		{
			using (var db = new Entities())
			{
				STO_TonDauKy tondauky = new STO_TonDauKy()
				{
					ID_kho = ID_kho,
					ID_nhan_vien = ID_nhan_vien,
					Ky = DateTime.Now
				};
				var ton = db.STO_KhoVatTuCT.Where(t => t.ID_kho == ID_kho).ToList();
				foreach (var vt in ton)
				{
					tondauky.STO_TonDauKyCT.Add(new STO_TonDauKyCT()
					{
						ID_vat_tu = vt.ID_vat_tu,
						So_luong = vt.So_luong
					});
				}
				db.STO_TonDauKy.Add(tondauky);
				db.SaveChanges();
			}
		}

		public static DataTable ThongKe(int ID_ton,int ID_loai_vat_tu)
		{
			Entities db = new Entities();
			var list_vattu = db.STO_TonDauKyCT.Where(t => t.ID_ton == ID_ton && t.STO_VatTu.ID_loai_vat_tu == ID_loai_vat_tu).ToList();
			var dt = new DataTable();
			var list_title = new List<int>();
			var list_row = new List<double>();
			dt.Columns.Add("Don_vi", typeof(double));
			if (list_vattu != null)
			{
				foreach (var vattu in list_vattu)
				{
					if (!list_title.Contains(vattu.ID_vat_tu))
					{
						list_title.Add(vattu.ID_vat_tu);
						dt.Columns.Add(vattu.STO_VatTu.Ten_vat_tu, typeof(int));
					}
				}
				foreach (var vattu in list_vattu)
				{
					DataRow row;
					int i;
					if (!list_row.Contains((double)vattu.STO_VatTu.Don_vi))
					{
						list_row.Add((double)vattu.STO_VatTu.Don_vi);
						row = dt.Rows.Add();
						i = dt.Rows.IndexOf(row);
						dt.Rows[i]["Don_vi"] = (double)vattu.STO_VatTu.Don_vi;
						dt.Rows[i][vattu.STO_VatTu.Ten_vat_tu] = vattu.So_luong;
					}
					else
					{
						var rows = dt.Select("Don_vi = " + vattu.STO_VatTu.Don_vi);
						if (rows.Count() == 1)
						{
							row = rows[0];
							i = dt.Rows.IndexOf(row);
							dt.Rows[i][vattu.STO_VatTu.Ten_vat_tu] = vattu.So_luong;
						}
					}
				}
				dt.Columns["Don_vi"].ColumnName = @"Khẩu độ\Chủng loại";
				return dt;
			}
			return new DataTable();
		}

		public static void LoadLookUpEdit(LookUpEdit lookUpEdit, int ID_kho,DateTime From, DateTime To, Entities db = null)
		{
			if (db == null) db = new Entities();
			lookUpEdit.Properties.Columns.Clear();
			lookUpEdit.Properties.DataSource = db.STO_TonDauKy.Where(t => t.ID_kho == ID_kho && t.Ky >= From && t.Ky <= To).ToList();
			lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ky", "Kỳ"));
			lookUpEdit.Properties.Columns[0].FormatString = "dd/MM/yyyy";
			lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_nhan_vien", "Nhân viên"));
			lookUpEdit.Properties.DisplayMember = "Ky";
			lookUpEdit.Properties.ValueMember = "ID_ton";
			lookUpEdit.Properties.NullText = "";
			lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn kỳ";
			lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
		}
	}
}
