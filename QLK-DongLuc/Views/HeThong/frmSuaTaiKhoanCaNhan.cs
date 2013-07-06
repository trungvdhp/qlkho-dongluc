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
    public partial class frmSuaTaiKhoanCaNhan : DevExpress.XtraEditors.XtraForm
    {
        Entities db;

        public frmSuaTaiKhoanCaNhan()
        {
            InitializeComponent();
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

                int rs = NguoiDungCtrl.Update(Program.CurrentUser.ID_nguoi_dung, txtMatKhauXacNhan.Text, txtTenDayDu.Text);

                if (rs == 0)
                {
                    XtraMessageBox.Show("Cập nhật thông tin cá nhân không thành công!\nCó thể do lỗi hệ thống hoặc không có thông tin gì thay đổi.", "Cập nhật thông tin cá nhân", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    XtraMessageBox.Show("Cập nhật thông tin cá nhân thành công.", "Cập nhật thông tin cá nhân", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamLai.PerformClick();
                }
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = txtMatKhauXacNhan.Text = "";
            txtTenDangNhap.Text = Program.CurrentUser.Tai_khoan;
            txtNhanVien.Text = Program.CurrentUser.ID_nhan_vien == null ? "Giám đốc" : Program.CurrentUser.CAT_NhanVien.Ho_dem + " " + Program.CurrentUser.CAT_NhanVien.Ten;
            chkNhanVien.Checked = Program.CurrentUser.ID_nhan_vien != null ? true : false;
            txtTenDayDu.Text = Program.CurrentUser.Ten_day_du;
            txtTenDayDu.Properties.ReadOnly = chkNhanVien.Checked;
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

        private void frmSuaTaiKhoanCaNhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmSuaTaiKhoanCaNhan_Load(object sender, EventArgs e)
        {
            db = new Entities();
            btnLamLai.PerformClick();
        }

        private void txtMatKhauXacNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSuaTaiKhoan.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtMatKhauXacNhan.Text = "";
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtMatKhau.SelectAll();
                txtMatKhau.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                btnSuaTaiKhoan.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhauXacNhan.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtMatKhau.Text = "";
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtTenDayDu.SelectAll();
                txtTenDayDu.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                txtMatKhauXacNhan.Focus();
            }
        }

        private void txtTenDayDu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtTenDayDu.Text = "";
            }
            else if (e.KeyCode == Keys.Down)
            {
                txtMatKhau.Focus();
            }
        }
    }
}