using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Views.DanhMuc
{
    public partial class frmVatTu : DevExpress.XtraEditors.XtraForm
    {
        private QLKContext db;

        public frmVatTu()
        {
            InitializeComponent();
            db = new QLKContext();
        }

        private void cmbNhomVatTu_Load()
        {
            var result = (from p in db.NhomVatTus select p).ToList();
            cmbNhomVatTu.DataSource = result;
            cmbNhomVatTu.DisplayMember = "TenNhom";
            cmbNhomVatTu.ValueMember = "MaNhom";
        }

        private void cmbKhoVatTu_Load()
        {
            var result = (from p in db.KhoVatTus select p).ToList();
            cmbKhoVatTu.DataSource = result;
            cmbKhoVatTu.DisplayMember = "TenKho";
            cmbKhoVatTu.ValueMember = "MaKho";
        }

        private void dataGrid_Load()
        {
            var lists = (from v in db.VatTus 
                          join l in db.LoaiVatTus on v.MaLoai equals l.MaLoai
                          join n in db.NhomVatTus on l.MaNhom equals n.MaNhom
                          join k in db.KhoVatTus on v.MaKho equals k.MaKho 
                          select new 
                          {
                              k.TenKho,
                              n.TenNhom,
                              l.TenLoai,
                              v.MaVatTu,
                              v.TenVatTu,
                              v.DonVi,
                          }).ToList();
            var result = lists.Select((x, index) => new
                                                        {
                                                            STT = index + 1,
                                                            x.TenKho,
                                                            x.TenNhom,
                                                            x.TenLoai,
                                                            x.MaVatTu,
                                                            x.TenVatTu,
                                                            x.DonVi,
                                                        }).ToList();

            dataGrid.DataSource = result;
        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            cmbNhomVatTu_Load();
            cmbKhoVatTu_Load();
            dataGrid_Load();
        }
    }
}