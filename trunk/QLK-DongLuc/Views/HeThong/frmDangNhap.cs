using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Controllers;

namespace QLK_DongLuc.Views.HeThong
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var user = NguoiDungCtrl.Login(txtTenDangNhap.Text, txtMatKhau.Text);

            if (user == null)
            {
                XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!\nHoặc tài khoản này đã bị khóa!\nHoặc tài khoản này đã đang đăng nhập!\nVui lòng liên hệ giám đốc để kiểm tra lại.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtMatKhau.Focus();
                txtMatKhau.SelectAll();
            }
            else
            {
                Program.CurrentUser = user;
                //XtraMessageBox.Show("Đăng nhập thành công vào hệ thống!", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thực sự muốn thoát khỏi hệ thống không!", "Thoát khỏi hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NguoiDungCtrl.Logout();
                Application.ExitThread();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtMatKhau.Text = "";
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtTenDangNhap.SelectAll();
                txtTenDangNhap.Focus();
            }
            else if (e.KeyCode == Keys.Down)
            {
                btnDangNhap.Focus();
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult != DialogResult.OK)
                btnThoat.PerformClick();
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtMatKhau.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtTenDangNhap.Text = "";
            }
        }
    }
}