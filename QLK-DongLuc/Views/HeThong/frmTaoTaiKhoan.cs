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
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        QuanLyKhoDongLucEntities db;

        public frmTaoTaiKhoan()
        {
            InitializeComponent();

            db = new QuanLyKhoDongLucEntities();
            NhanVienCtrl.LoadLookUpEdit(ledNhanVien, db);
        }

        private void chkNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            ledNhanVien.Enabled = chkNhanVien.Checked;
        }

        private void ledNhanVienNhap_Properties_EditValueChanged(object sender, EventArgs e)
        {
            txtTenDayDu.Text = ledNhanVien.Text;
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Length < 3)
            {
                XtraMessageBox.Show("Tên đăng nhập phải ít nhất là 3 ký tự.", "Nhập tên đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
            }
            else if (txtMatKhau.Text.Length < 6)
            {
                XtraMessageBox.Show("Mật khẩu phải ít nhất là 6 ký tự.", "Nhập mật khẩu đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int rs = NguoiDungCtrl.Insert(ledNhanVien.EditValue, txtTenDangNhap.Text, txtMatKhau.Text, txtTenDayDu.Text, chkKichHoatTaiKhoan.Checked ? 1 : 3, tedThoiGianCho.Text, db);

                if (rs == -1)
                {
                    XtraMessageBox.Show("Tài khoản này đã tồn tại.\nVui lòng chọn một tên đăng nhập khác!", "Tạo tài khoản người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (rs == 0)
                {
                    XtraMessageBox.Show("Tạo tài khoản người dùng mới không thành công.", "Tạo tài khoản người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    XtraMessageBox.Show("Tạo tài khoản người dùng mới thành công.", "Tạo tài khoản người dùng mới", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamLai.PerformClick();
                }
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
            txtTenDayDu.Text = "";
            ledNhanVien.EditValue = null;
            txtMatKhau.Text = "";
            txtMatKhauXacNhan.Text = "";
            tedThoiGianCho.EditValue = "08:00";
            chkKichHoatTaiKhoan.Checked = true;
            chkNhanVien.Checked = true;
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Length < 3)
            {
                XtraMessageBox.Show("Tên đăng nhập phải ít nhất là 3 ký tự", "Nhập tên đăng nhập",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Length < 6)
            {
                XtraMessageBox.Show("Mật khẩu phải ít nhất là 6 ký tự.", "Nhập mật khẩu đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
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

        private void frmTaoTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}