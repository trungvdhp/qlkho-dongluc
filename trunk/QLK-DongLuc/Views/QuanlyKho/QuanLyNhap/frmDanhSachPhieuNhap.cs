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

namespace QLK_DongLuc.Views.QuanlyKho.QuanLyNhap
{
    public partial class frmDanhSachPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        Entities db;

        public frmDanhSachPhieuNhap()
        {
            InitializeComponent();
            db = new Entities();
            TuyChonTimKiemCtrl.LoadLookUpEdit(ledTuyChon);
            PhieuNhapCtrl.LoadBindingSource(viewPhieuNhapBindingSource);
            VatTuCtrl.LoadLookUpEdit(repositoryItemLookUpEdit1, db);
        }

        private void frmDanhSachPhieuNhap_Load(object sender, EventArgs e)
        {
            if (Program.CurrentUser.ID_nhan_vien != null)
            {
                colNhan_vien_lap.Visible = false;
                colTong_tien.Visible = false;
                colDon_gia.Visible = false;
            }
        }

        private void grvPhieuNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ViewPhieuNhap pn = (ViewPhieuNhap)grvPhieuNhap.GetFocusedRow();

            if(pn != null)
                PhieuNhapCTCtrl.LoadBindingSource(pn.ID_phieu_nhap, iMPPhieuNhapCTBindingSource, db);
        }
    }
}