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
                XtraMessageBox.Show("1. Tên đăng nhập hoặc mật khẩu không đúng.\n\n2. Có thể tài khoản này đang đăng nhập hoặc đang bị khóa.\n\n3. Hoặc kết nối đến máy chủ không thành công\n\n* Vui lòng liên hệ giám đốc để kiểm tra lại *", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btnCauHinhKetNoi_Click(object sender, EventArgs e)
        {
            QLK_DongLuc.Views.HeThong.frmCauHinh frm = new QLK_DongLuc.Views.HeThong.frmCauHinh();
            frm.ShowDialog();
        }
    }
}