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

namespace QLK_DongLuc.Views.QuanlyKho.QuanLyNhap
{
    public partial class frmLapPhieuNhapMoi : DevExpress.XtraEditors.XtraForm
    {
        public frmLapPhieuNhapMoi()
        {
            InitializeComponent();
            NhanVienCtrl.LoadLookUpEdit(ledNhanVienNhap);
            KhoVatTuCtrl.LoadLookUpEdit(ledKhoNhap);
            NhaCungCapCtrl.LoadLookUpEdit(ledNhaCungCap);
            VatTuCtrl.LoadLookUpEdit(repositoryItemLookUpEdit1);
        }
    }
}