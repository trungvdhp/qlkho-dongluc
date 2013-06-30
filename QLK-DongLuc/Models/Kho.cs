using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLK_DongLuc.Models
{
	class Kho
	{
		public static DataTable TonKho(int ID_kho, int ID_loai_vat_tu)
		{
			Entities db = new Entities();
			var list_vattu = db.STO_KhoVatTuCT.Where(t => t.ID_kho==ID_kho && t.STO_VatTu.ID_loai_vat_tu == ID_loai_vat_tu).ToList();
			var dt = new DataTable();
			var list_title = new List<int>();
			var list_row = new List<double>();
			dt.Columns.Add("Don_vi",typeof(double));
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
	}
}
