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

namespace QLK_DongLuc.Views.HeThong
{
    public partial class frmSuaTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        Entities db;
        public ViewNguoiDung user;

        public frmSuaTaiKhoan()
        {
            InitializeComponent();
        }

        public frmSuaTaiKhoan(ViewNguoiDung _user)
        {
            InitializeComponent();
            user = _user;
            db = new Entities();
        }

        private void btnSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Length < 6 && txtMatKhau.Text.Length > 0)
            {
                XtraMessageBox.Show("Mật khẩu phải ít nhất là 6 ký tự.", "Nhập mật khẩu đăng nhập mới", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
            }
            else if (txtMatKhauXacNhan.Text != txtMatKhau.Text)
            {
                XtraMessageBox.Show("Mật khẩu xác nhận không khớp.", "Xác nhận mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tedThoiGianCho.Text == "00:00")
            {
                XtraMessageBox.Show("Thời gian chờ phải từ 1 phút trở lên.", "Nhập thời gian chờ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tedThoiGianCho.Focus();
            }
            else
            {
                if (txtMatKhau.Text == "")
                {
                    if (XtraMessageBox.Show("Bạn chưa nhập mật khẩu mới.\nBạn có muốn giữ nguyên mật khẩu cũ không?", "Sửa tài khoản người dùng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    {
                        XtraMessageBox.Show("Vui lòng nhập mật khẩu mới.", "Nhập mật khẩu mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMatKhau.Focus();
                        return;
                    }
                }

                int rs = NguoiDungCtrl.Update(user.ID_nguoi_dung, txtMatKhauXacNhan.Text, txtTenDayDu.Text, chkKichHoatTaiKhoan.Checked ? 1 : 3, tedThoiGianCho.Text, db);

                if (rs == 0)
                {
                    XtraMessageBox.Show("Sửa tài khoản người dùng không thành công!\nCó thể do lỗi hệ thống hoặc không có thông tin gì thay đổi!", "Sửa tài khoản người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    XtraMessageBox.Show("Sửa tài khoản người dùng thành công.", "Sửa tài khoản người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //user.Ten_day_du = txtTenDayDu.Text;
                    //user.ID_trang_thai = chkKichHoatTaiKhoan.Checked ? 1 : 3;
                    //user.Thoi_gian_cho = TimeSpan.Parse(tedThoiGianCho.Text);
                    btnLamLai.PerformClick();
                }
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = txtMatKhauXacNhan.Text = "";
            txtTenDangNhap.Text = user.Tai_khoan;
            txtNhanVien.Text = user.Nhan_vien;
            chkNhanVien.Checked = user.ID_nhan_vien != null ? true : false;
            txtTenDayDu.Text = user.Ten_day_du;
            txtTenDayDu.Properties.ReadOnly = chkNhanVien.Checked;
            tedThoiGianCho.EditValue = new DateTime().Add(user.Thoi_gian_cho.Value);
            chkKichHoatTaiKhoan.Checked = user.ID_trang_thai == 3 ? false : true; 
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Length < 6)
            {
                XtraMessageBox.Show("Mật khẩu phải ít nhất là 6 ký tự.", "Nhập mật khẩu đăng nhập mới", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMatKhauXacNhan_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauXacNhan.Text != txtMatKhau.Text)
            {
                XtraMessageBox.Show("Mật khẩu xác nhận không khớp.", "Xác nhận mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tedThoiGianCho_Leave(object sender, EventArgs e)
        {
            if (tedThoiGianCho.Text == "00:00")
            {
                XtraMessageBox.Show("Thời gian chờ phải từ 1 phút trở lên.", "Nhập thời gian chờ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tedThoiGianCho.Focus();
            }
        }

        private void frmSuaTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            btnLamLai.PerformClick();
        }
    }
}