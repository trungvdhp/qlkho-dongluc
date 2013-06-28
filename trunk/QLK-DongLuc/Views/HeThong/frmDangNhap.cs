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
                XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtTenDangNhap.Focus();
            }
            else
            {
                Program.CurrentUser = user;
                //XtraMessageBox.Show("Đăng nhập thành công vào hệ thống!", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}