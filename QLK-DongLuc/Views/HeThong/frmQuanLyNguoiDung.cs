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
    public partial class frmQuanLyNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        Entities db = new Entities();

        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
            NguoiDungCtrl.LoadBindingSource(viewNguoiDungBindingSource, db);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmTaoTaiKhoan frm = new frmTaoTaiKhoan();

            if (frm.ShowDialog() == DialogResult.OK)
                NguoiDungCtrl.LoadBindingSource(viewNguoiDungBindingSource, db);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ViewNguoiDung user = (ViewNguoiDung)grvNguoiDung.GetFocusedRow();

            if (user != null)
            {
                frmSuaTaiKhoan frm = new frmSuaTaiKhoan(user);

                if (frm.ShowDialog() == DialogResult.OK)
                    NguoiDungCtrl.LoadBindingSource(viewNguoiDungBindingSource, db);
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn một tài khoản để sửa thông tin", "Sửa thông tin tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            ViewNguoiDung user = (ViewNguoiDung)grvNguoiDung.GetFocusedRow();

            if (user.ID_trang_thai == 3)
            {
                XtraMessageBox.Show("Tài khoản người dùng đã bị khóa.", "Khóa tài khoản người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rs = NguoiDungCtrl.ChangeState(user.ID_nguoi_dung, true, db);

            if (rs == 0)
            {
                XtraMessageBox.Show("Khóa tài khoản người dùng không thành công.", "Khóa tài khoản người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                XtraMessageBox.Show("Khóa tài khoản người dùng thành công.", "Khóa tài khoản người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            NguoiDungCtrl.LoadBindingSource(viewNguoiDungBindingSource, db);
        }

        private void btnMoTaiKhoan_Click(object sender, EventArgs e)
        {
            ViewNguoiDung user = (ViewNguoiDung)grvNguoiDung.GetFocusedRow();

            if (user.ID_trang_thai != 3)
            {
                XtraMessageBox.Show("Tài khoản người dùng không bị khóa.", "Mở khóa tài khoản người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rs = NguoiDungCtrl.ChangeState(user.ID_nguoi_dung, false, db);

            if (rs == 0)
            {
                XtraMessageBox.Show("Mở khóa tài khoản người dùng không thành công.", "Mở khóa tài khoản người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                XtraMessageBox.Show("Mở khóa tài khoản người dùng thành công.", "Mở khóa tài khoản người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);

                NguoiDungCtrl.LoadBindingSource(viewNguoiDungBindingSource, db);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NguoiDungCtrl.LoadBindingSource(viewNguoiDungBindingSource, db);
        }
    }
}