using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Controllers;

namespace QLK_DongLuc.Views.QuanlyKho.QuanLyXuat
{
    public partial class frmDanhSachPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmDanhSachPhieuXuat_Load(object sender, EventArgs e)
        {
            VaiTroQuyenCtrl.ReconfigFormControls(this);
        }
    }
}