using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using QLK_DongLuc.Controllers;
using QLK_DongLuc.Models;
using QLK_DongLuc.Views.DanhMuc;

namespace QLK_DongLuc.Views.QuanlyKho.QuanLyNhap
{
    public partial class frmLapPhieuNhapMoi : DevExpress.XtraEditors.XtraForm
    {
        QuanLyKhoDongLucEntities db;
        public frmLapPhieuNhapMoi()
        {
            InitializeComponent();
            db = new QuanLyKhoDongLucEntities();
            NhanVienCtrl.LoadLookUpEdit(ledNhanVienNhap, db);
            KhoVatTuCtrl.LoadLookUpEdit(ledKhoNhap, db);
            NhaCungCapCtrl.LoadLookUpEdit(ledNhaCungCap, db);
            VatTuCtrl.LoadLookUpEdit(repositoryItemLookUpEdit1, db);
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            //this.Refresh();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThemVatTuMoi_Click(object sender, EventArgs e)
        {
            frmVatTu frm = new frmVatTu();
            frm.ShowDialog();
        }
    }
}