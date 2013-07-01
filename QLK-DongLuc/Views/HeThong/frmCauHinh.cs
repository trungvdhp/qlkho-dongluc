using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Controllers;
using QLK_DongLuc.Properties;

namespace QLK_DongLuc.Views.HeThong
{
    public partial class frmCauHinh : DevExpress.XtraEditors.XtraForm
    {
        public frmCauHinh()
        {
            InitializeComponent();
            txtTenMayChu.Text = Settings.Default.DS;
            txtTenDangNhap.Text = Settings.Default.UID;
        }

        private void btnKiemTraKetNoi_Click(object sender, EventArgs e)
        {
            if (txtTenMayChu.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập tên máy chủ!", "Kiểm tra kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTenDangNhap.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập tên đăng nhập!", "Kiểm tra kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMatKhau.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập mật khẩu!", "Kiểm tra kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var databases = KetNoiCSDLCtrl.GetDatabaseList(txtTenMayChu.Text, txtTenDangNhap.Text, txtMatKhau.Text);

            if (databases.Count == 0)
            {
                XtraMessageBox.Show("Không thể kết nối, vui lòng kiểm tra lại!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ledCoSoDuLieu.Properties.DataSource = databases;
                ledCoSoDuLieu.Properties.ShowHeader = false;

                XtraMessageBox.Show("Kết nối thành công!", "Kết nối cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKiemTraKetNoi.PerformClick();
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
                btnKiemTraKetNoi.Focus();
            }
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

        private void txtTenMayChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtTenDangNhap.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtTenMayChu.Text = "";
            }
        }

        private void ledCoSoDuLieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKetNoi.PerformClick();
            }
            else if (e.KeyCode == Keys.Down)
            {
                btnKetNoi.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                btnKiemTraKetNoi.Focus();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (txtTenMayChu.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập tên máy chủ!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTenDangNhap.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập tên đăng nhập!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMatKhau.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ledCoSoDuLieu.EditValue == null)
            {
                XtraMessageBox.Show("Chưa chọn cơ sở dữ liệu!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            int rs = KetNoiCSDLCtrl.ConnectDatabase(txtTenMayChu.Text, txtTenDangNhap.Text, txtMatKhau.Text, ledCoSoDuLieu.EditValue.ToString());

            if (rs == 0)
            {
                XtraMessageBox.Show("Không thể kết nối, vui lòng kiểm tra lại!", "Kết nối cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("Kết nối thành công!", "Kết nối cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Settings.Default.DS = txtTenMayChu.Text;
                Settings.Default.UID = txtTenDangNhap.Text;
                Settings.Default.DB = ledCoSoDuLieu.EditValue.ToString();
                Settings.Default.SSAP = KetNoiCSDLCtrl.EnCryptPass(txtMatKhau.Text);
                Settings.Default.Save();
            }
        }
    }
}