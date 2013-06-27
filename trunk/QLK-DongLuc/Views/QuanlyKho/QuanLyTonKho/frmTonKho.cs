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

namespace QLK_DongLuc.Views.QuanlyKho.QuanLyTonKho
{
	public partial class frmTonKho : DevExpress.XtraEditors.XtraForm
	{
		public frmTonKho()
		{
			InitializeComponent();
		}

		private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
		{

		}

		private void frmTonKho_Load(object sender, EventArgs e)
		{
			KhoVatTuCtrl.LoadLookUpEdit(ledKhoVT);
			NhomVatTu.LoadLookUpEdit(ledNhomVT);
			LoaiVatTu.LoadLookUpEdit(ledLoaiVT);
		}

		private void ledNhomVT_TextChanged(object sender, EventArgs e)
		{
			LoaiVatTu.LoadLookUpEdit(ledLoaiVT, Convert.ToInt32(ledNhomVT.EditValue));
		}

		private void btnLoadGrid_Click(object sender, EventArgs e)
		{
			int ID_kho = Convert.ToInt32(ledKhoVT.EditValue);
			int ID_loai_vat_tu = Convert.ToInt32(ledLoaiVT.EditValue);

			gridTonKho.DataSource = Kho.TonKho(ID_kho, ID_loai_vat_tu);
			gridView1.Columns[0].Width = 120;
		}
	}
}