using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Controllers;
using QLK_DongLuc.Models;
using System.Linq;

namespace QLK_DongLuc.Views.QuanlyKho.QuanLyTonKho
{
	public partial class frmTonDauKy : DevExpress.XtraEditors.XtraForm
	{
		public int ID_ton_dau_ky = 0;
		public frmTonDauKy()
		{
			InitializeComponent();
		}

		private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
		{

		}

		private void frmTonKho_Load(object sender, EventArgs e)
		{
			var db = new QuanLyKhoDongLucEntities();
			dtFrom.DateTime = DateTime.Now - TimeSpan.FromDays(30);
			dtTo.DateTime = DateTime.Now;
			if (ID_ton_dau_ky != 0)
			{
				var tondauky = db.STO_TonDauKy.First(t => t.ID_ton == ID_ton_dau_ky);
				if (tondauky != null)
				{
					ledKhoVT.EditValue = tondauky.ID_kho;
					ledTonDauKy.EditValue = tondauky.ID_ton;

				}
			}
		}


		private void btnLoadGrid_Click(object sender, EventArgs e)
		{
			int ID_ton = Convert.ToInt32(ledTonDauKy.EditValue);
			int ID_loai_vat_tu = Convert.ToInt32(ledLoaiVT.EditValue);
			gridView1.Columns.Clear();
			gridTonKho.DataSource = TonDauKy.ThongKe(ID_ton, ID_loai_vat_tu);
			gridView1.Columns[0].Width = 120;
		}

		private void dateRang_EditValueChanged(object sender, EventArgs e)
		{
			KhoVatTuCtrl.LoadLookUpEdit(ledKhoVT, dtFrom.DateTime, dtTo.DateTime);
		}

		private void ledKhoVT_EditValueChanged(object sender, EventArgs e)
		{
			TonDauKy.LoadLookUpEdit(ledTonDauKy, Convert.ToInt32(ledKhoVT.EditValue),dtFrom.DateTime,dtTo.DateTime);
		}

		private void ledTonDauKy_EditValueChanged(object sender, EventArgs e)
		{
			LoaiVatTu.LoadLookUpEditTonKho(ledLoaiVT, Convert.ToInt32(ledTonDauKy.EditValue));
		}
	}
}