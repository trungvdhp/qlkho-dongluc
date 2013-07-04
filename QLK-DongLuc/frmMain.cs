using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
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
        TimeSpan ActiveTime;
        TimeSpan TotalTime;
        TimeSpan interval;
        int RemainingTime;
        bool waiting = false;

        public frmMain()
        {
            InitializeComponent();
            interval = TimeSpan.FromMilliseconds((double)(tmrDongHo.Interval));
        }

        #region TabControl
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
                    //btnCauHinh.Enabled = true;
                    btnPhucHoi.Enabled = true;

                    // Chuc nang quan ly kho
                    btnNhapMoi.Enabled = false;
                    btnNhapLai.Enabled = false;

                    // Chức năng quản lý danh mục
                    btnNhomVatTu.Enabled = true;
                    btnNhaCungCap.Enabled = true;
                    btnNhanVien.Enabled = true;

                    lblUser.Caption = "Giám đốc: " + (Program.CurrentUser.Ten_day_du != null ? Program.CurrentUser.Ten_day_du : "");
                }
                // Nếu là nhân viên
                else
                {
                    // Chuc nang he thong
                    btnQuanLyNguoiDung.Enabled = false; 
                    btnNhatKy.Enabled = false;
                    btnNhacNho.Enabled = false;
                    btnSaoLuu.Enabled = false;
                    //btnCauHinh.Enabled = false;
                    btnPhucHoi.Enabled = false;

                    // Chuc nang quan ly kho
                    btnNhapMoi.Enabled = true;
                    btnNhapLai.Enabled = true;

                    // Chức năng quản lý danh mục
                    btnNhomVatTu.Enabled = false;
                    btnNhaCungCap.Enabled = false;
                    btnNhanVien.Enabled = false;

                    lblUser.Caption = "Nhân viên: " + (Program.CurrentUser.Ten_day_du != null ? Program.CurrentUser.Ten_day_du : Program.CurrentUser.CAT_NhanVien.Ho_dem + " " + Program.CurrentUser.CAT_NhanVien.Ten);
                }

                CaiDatThongSoDongHo();

                if (Program.CurrentUser.Thoi_gian_cho != null)
                {
                    TotalTime = Program.CurrentUser.Thoi_gian_cho.Value;
                    TotalTime = TotalTime.Add(interval);
                    lblRemainingTimeMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    lblRemainingTime.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                }
                else
                {
                    TotalTime = TimeSpan.FromMilliseconds((double)(RemainingTime + 2 * tmrDongHo.Interval));
                    lblRemainingTimeMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    lblRemainingTime.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                }
                    
                ActiveTime = new TimeSpan(0, 0, 0);

                tmrDongHo.Start();
                tmrTracker.Start();
            }
        }

        private void CaiDatThongSoDongHo()
        {
            var t1 = ThongSoHeThongCtrl.LayThongSoHeThong("tmrTracker", "Interval");
            var t2 = ThongSoHeThongCtrl.LayThongSoHeThong("tmrTracker", "Remain");

            tmrTracker.Interval = int.Parse(t1.Gia_tri);
            RemainingTime = int.Parse(t2.Gia_tri);
        }

        private void tmrDongHo_Tick(object sender, EventArgs e)
        {
            if (waiting || Program.CurrentUser.Thoi_gian_cho != null)
            {
                TotalTime = TotalTime.Subtract(interval);
                string remain = TotalTime.ToString(@"hh\:mm\:ss");
                lblRemainingTime.Caption = remain;

                if (TotalTime.TotalMilliseconds > 0)
                {
                    if (TotalTime.TotalMilliseconds <= RemainingTime)
                    {
                        int t = ((int)TotalTime.TotalMilliseconds / tmrDongHo.Interval) % 2;
                        lblRemainingTime.Appearance.ForeColor = (t == 0 ? Color.Blue : Color.White);

                        if (TotalTime.TotalMilliseconds > RemainingTime - tmrDongHo.Interval)
                            XtraMessageBox.Show("Sau " + remain + " tài khoản sẽ tự động đăng xuất", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    btnDangXuat.PerformClick();
                }
            }

            ActiveTime = ActiveTime.Add(interval);
            lblActiveTime.Caption = ActiveTime.ToString(@"hh\:mm\:ss");
        }

        private void tmrTracker_Tick(object sender, EventArgs e)
        {
            // Cài đặt lại thông số đồng hồ
            CaiDatThongSoDongHo();
            // Kiểm tra lại thông tin người dùng
            var user = NguoiDungCtrl.LayNguoiDungTheoID(Program.CurrentUser.ID_nguoi_dung);

            if (user == null)
            {
                XtraMessageBox.Show("Không kết nối được đến tài khoản!", "Theo dõi tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnDangXuat.PerformClick();
                tmrTracker.Stop();
                tmrDongHo.Stop();
                return;
            }

            if (user.ID_trang_thai == 3)
            {
                if (TotalTime.TotalMilliseconds > RemainingTime + tmrDongHo.Interval)
                {
                    TotalTime = TimeSpan.FromMilliseconds((double)(RemainingTime + tmrDongHo.Interval));
                    lblRemainingTimeMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    lblRemainingTime.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    waiting = true;
                    XtraMessageBox.Show("Tài khoản đã bị giám đốc khóa!", "Theo dõi tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else if (user.ID_trang_thai == 1)
            {
                if (TotalTime.TotalMilliseconds > RemainingTime + tmrDongHo.Interval)
                {
                    TotalTime = TimeSpan.FromMilliseconds((double)(RemainingTime + tmrDongHo.Interval));
                    lblRemainingTimeMessage.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    lblRemainingTime.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                    waiting = true;
                    XtraMessageBox.Show("Tài khoản không còn đăng nhập!", "Theo dõi tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (NguoiDungCtrl.Logout() > 0)
            {
                tmrDongHo.Stop();
                tmrTracker.Stop();
                CloseAllForm();
                Program.CurrentUser = null;
                XtraMessageBox.Show("Đăng xuất thành công khỏi hệ thống!", "Đăng xuất thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDangNhap.Enabled = true;
                btnDangNhap.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Không thể đăng xuất khỏi hệ thống!", "Đăng xuất thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDangNhap.PerformClick();
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

        private void btnCauHinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.frmCauHinh frm = new HeThong.frmCauHinh();
            frm.ShowDialog();
        }

        private void iAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }



    }
}