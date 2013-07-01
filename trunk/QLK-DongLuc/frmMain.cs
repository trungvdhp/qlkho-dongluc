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
    using QLK_DongLuc.Controllers;

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

        private void CloseAllForm()
        {
            List<DevExpress.XtraTab.XtraTabPage> collection = new List<DevExpress.XtraTab.XtraTabPage>();

            foreach (DevExpress.XtraTab.XtraTabPage tab in tabControl.TabPages)
            {
                collection.Add(tab);
            }

            foreach (DevExpress.XtraTab.XtraTabPage tab in collection)
            {
                tabControl.TabPages.Remove(tab);
            }
        }
        public static void CloseCurrentForm(Control parent)
        {
            DevExpress.XtraTab.XtraTabPage tabPage = parent as DevExpress.XtraTab.XtraTabPage;
            DevExpress.XtraTab.XtraTabControl tabControl = tabPage.Parent as DevExpress.XtraTab.XtraTabControl;
            tabControl.TabPages.Remove(tabPage);
        }
        #endregion

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thực sự muốn thoát khỏi hệ thống không!", "Thoát khỏi hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NguoiDungCtrl.Logout();
                Application.ExitThread();
            }
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

        private void barDanhSachPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanlyKho.QuanLyNhap.frmDanhSachPhieuNhap frm = new QuanlyKho.QuanLyNhap.frmDanhSachPhieuNhap();
            OpenForm(frm, tabControl);
        }

        private void btnNhapMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanlyKho.QuanLyNhap.frmLapPhieuNhapMoi frm = new QuanlyKho.QuanLyNhap.frmLapPhieuNhapMoi();
            OpenForm(frm, tabControl);
        }

		private void btnVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			QuanlyKho.QuanLyTonKho.frmTonKho frm = new QuanlyKho.QuanLyTonKho.frmTonKho();
			OpenForm(frm, tabControl);
		}

        private void btnQuanLyNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.frmQuanLyNguoiDung frm = new HeThong.frmQuanLyNguoiDung();
            OpenForm(frm, tabControl);
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.frmDangNhap frm = new HeThong.frmDangNhap();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                btnDangNhap.Enabled = false;
                btnDangXuat.Enabled = true;
                btnCapNhatTaiKhoan.Enabled = true;

                // Nếu là giám đốc
                if (Program.CurrentUser.ID_nhan_vien == null)
                {
                    // Chuc nang he thong
                    btnQuanLyNguoiDung.Enabled = true;
                    btnNhatKy.Enabled = true;
                    btnNhacNho.Enabled = true;
                    btnSaoLuu.Enabled = true;
                    btnCauHinh.Enabled = true;
                    btnPhucHoi.Enabled = true;

                    // Chuc nang quan ly kho
                    btnNhapMoi.Enabled = false;
                    btnNhapLai.Enabled = false;

                    // Chức năng quản lý danh mục
                    btnNhomVatTu.Enabled = true;
                    btnNhaCungCap.Enabled = true;
                    btnNhanVien.Enabled = true;

                    lblInfo.Caption = "giám đốc " + Program.CurrentUser.Ten_day_du != null ? Program.CurrentUser.Ten_day_du : "";
                }
                // Nếu là nhân viên
                else
                {
                    // Chuc nang he thong
                    btnQuanLyNguoiDung.Enabled = false; 
                    btnNhatKy.Enabled = false;
                    btnNhacNho.Enabled = false;
                    btnSaoLuu.Enabled = false;
                    btnCauHinh.Enabled = false;
                    btnPhucHoi.Enabled = false;

                    // Chuc nang quan ly kho
                    btnNhapMoi.Enabled = true;
                    btnNhapLai.Enabled = true;

                    // Chức năng quản lý danh mục
                    btnNhomVatTu.Enabled = false;
                    btnNhaCungCap.Enabled = false;
                    btnNhanVien.Enabled = false;

                    lblInfo.Caption = "nhân viên " + (Program.CurrentUser.Ten_day_du != null ? Program.CurrentUser.Ten_day_du : Program.CurrentUser.CAT_NhanVien.Ho_dem + " " + Program.CurrentUser.CAT_NhanVien.Ten);
                }
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NguoiDungCtrl.Logout();
            Program.CurrentUser = null;
            CloseAllForm();
            XtraMessageBox.Show("Đăng xuất thành công khỏi hệ thống!", "Đăng xuất thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnDangNhap.Enabled = true;
            btnDangNhap.PerformClick();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDangNhap.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //btnThoat.PerformClick();
            if (XtraMessageBox.Show("Bạn có thực sự muốn thoát khỏi hệ thống không!", "Thoát khỏi hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NguoiDungCtrl.Logout();
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnCapNhatTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.frmCapNhatTaiKhoanCaNhan frm = new HeThong.frmCapNhatTaiKhoanCaNhan();
            frm.ShowDialog();
        }

        private void btnNhapLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanlyKho.QuanLyNhap.frmLapPhieuNhapMoi frm = new QuanlyKho.QuanLyNhap.frmLapPhieuNhapMoi(2);
            frm.Text = "Lập phiếu nhập lại";
            OpenForm(frm, tabControl);
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanlyKho.QuanLyXuat.frmLapPhieuXuatMoi frm = new QuanlyKho.QuanLyXuat.frmLapPhieuXuatMoi();
            OpenForm(frm, tabControl);
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanlyKho.QuanLyXuat.frmDanhSachPhieuXuat frm = new QuanlyKho.QuanLyXuat.frmDanhSachPhieuXuat();
            OpenForm(frm, tabControl);
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuanlyKho.QuanLyXuat.frmXuatThanhLy frm = new QuanlyKho.QuanLyXuat.frmXuatThanhLy();
            OpenForm(frm, tabControl);
        }
    }
}