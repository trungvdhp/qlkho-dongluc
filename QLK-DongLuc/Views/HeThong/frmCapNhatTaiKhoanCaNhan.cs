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
    public partial class frmCapNhatTaiKhoanCaNhan : DevExpress.XtraEditors.XtraForm
    {
        Entities db;

        public frmCapNhatTaiKhoanCaNhan()
        {
            InitializeComponent();
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
                    XtraMessageBox.Show("Cập nhật thông tin cá nhân không thành công.", "Cập nhật thông tin cá nhân", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void frmCapNhatTaiKhoanCaNhan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmCapNhatTaiKhoanCaNhan_Load(object sender, EventArgs e)
        {
            btnLamLai.PerformClick();
        }
    }
}