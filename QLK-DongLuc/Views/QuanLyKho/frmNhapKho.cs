using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Models;
using System.Linq;

namespace QLK_DongLuc.Views.QuanLyKho
{
    public partial class frmNhapKho : DevExpress.XtraEditors.XtraForm
    {
        private QLKContext db;

        public frmNhapKho()
        {
            InitializeComponent();
            db = new QLKContext();
        }

        private void cmbNhaCungCap_Load()
        {
            var result = (from p in db.NhaCungCaps select p).ToList();
            cmbNhaCungCap.DataSource = result;
            cmbNhaCungCap.DisplayMember = "TenNCC";
            cmbNhaCungCap.ValueMember = "MaNCC";
        }

        private void cmbKhoVatTu_Load()
        {
            var result = (from p in db.KhoVatTus select p).ToList();
            cmbKhoVatTu.DataSource = result;
            cmbKhoVatTu.DisplayMember = "TenKho";
            cmbKhoVatTu.ValueMember = "MaKho";
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            cmbNhaCungCap_Load();
            cmbKhoVatTu_Load();
            dtpNgayLap.DateTime = DateTime.Now;
        }

    }
}