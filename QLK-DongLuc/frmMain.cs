using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using QLK_DongLuc.Models;


namespace QLK_DongLuc
{
    using DanhMuc = QLK_DongLuc.Views.DanhMuc;
    using HeThong = QLK_DongLuc.Views.HeThong;
    using QuanlyKho = QLK_DongLuc.Views.QuanlyKho;

    public partial class frmMain : XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region function TabControl
        private void tabControl_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs arg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            (arg.Page as DevExpress.XtraTab.XtraTabPage).Dispose();
        }

        private void OpenForm(DevExpress.XtraEditors.XtraForm frm, DevExpress.XtraTab.XtraTabControl XTabControl)
        {
            foreach (DevExpress.XtraTab.XtraTabPage tab in tabControl.TabPages)
            {
                if (tab.Text == frm.Text)
                {
                    tabControl.SelectedTabPage = tab;
                    return;
                }
            }

            DevExpress.XtraTab.XtraTabPage XTabPage = new DevExpress.XtraTab.XtraTabPage { Text = frm.Text };
            XTabControl.TabPages.Add(XTabPage);
            XTabControl.SelectedTabPage = XTabPage;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Parent = XTabPage;
            frm.Show();
            frm.Dock = DockStyle.Fill;
        }
        #endregion

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.frmNhanVien frm = new DanhMuc.frmNhanVien();
            OpenForm(frm, tabControl);
        }

        private void btnSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.frmSanPham frm = new DanhMuc.frmSanPham();
            OpenForm(frm, tabControl);
        }

        private void btnNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.frmNhacCungCap frm = new DanhMuc.frmNhacCungCap();
            OpenForm(frm, tabControl);
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.frmKhachHang frm = new DanhMuc.frmKhachHang();
            OpenForm(frm, tabControl);
        }

        private void btnKhoVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.frmKhoVatTu frm = new DanhMuc.frmKhoVatTu();
            OpenForm(frm, tabControl);
        }

        private void btnNhomVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.frmNhomVatTu frm = new DanhMuc.frmNhomVatTu();
            OpenForm(frm, tabControl);
        }

        private void btnLoaiVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.frmLoaiVatTu frm = new DanhMuc.frmLoaiVatTu();
            OpenForm(frm, tabControl);
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DanhMuc.frmVatTu frm = new DanhMuc.frmVatTu();
            OpenForm(frm, tabControl);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanlyKho.QuanLyNhap.frmDanhSachPhieuNhap frm = new QuanlyKho.QuanLyNhap.frmDanhSachPhieuNhap();
            OpenForm(frm, tabControl);
        }

        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanlyKho.QuanLyNhap.frmLapPhieuNhapMoi frm = new QuanlyKho.QuanLyNhap.frmLapPhieuNhapMoi();
            OpenForm(frm, tabControl);
        }

		private void btnVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			QuanlyKho.QuanLyTonKho.frmTonKho frm = new QuanlyKho.QuanLyTonKho.frmTonKho();
			OpenForm(frm, tabControl);
		}
    }
}