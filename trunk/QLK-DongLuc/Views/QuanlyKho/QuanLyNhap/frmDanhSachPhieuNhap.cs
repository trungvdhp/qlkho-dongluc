using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Controllers;
using QLK_DongLuc.Helper;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Views.QuanlyKho.QuanLyNhap
{
    public partial class frmDanhSachPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            Entities db = new Entities();
            NhanVienCtrl.LoadLookUpEdit(rleNhanVienLap, db);
            NhanVienCtrl.LoadLookUpEdit(rleNhanVienNhap, db);
            TuyChonTimKiemCtrl.LoadLookUpEdit(ledTuyChon);
            VatTuCtrl.LoadLookUpEdit(rleVatTu, db);
            dteNgayBatDau.EditValue = DateTimeHelper.GetStartDateOfMonth(DatabaseHelper.GetDatabaseDate());
            VaiTroQuyenCtrl.ReconfigFormControls(this, db);
        }

        private void grvPhieuNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ViewPhieuNhap pn = (ViewPhieuNhap)grvPhieuNhap.GetFocusedRow();

            if(pn != null)
                PhieuNhapCTCtrl.LoadBindingSource(pn.ID_phieu_nhap, iMPPhieuNhapCTBindingSource);
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            frmLapPhieuNhapMoi frm = new frmLapPhieuNhapMoi();
            frm.ShowDialog();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            frmLapPhieuNhapLai frm = new frmLapPhieuNhapLai();
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ViewPhieuNhap pn = (ViewPhieuNhap)grvPhieuNhap.GetFocusedRow();

            if (pn == null) return;

            if(pn.ID_trang_thai != 0)
            {
                XtraMessageBox.Show("Phiếu nhập này bị khóa và hàng đã vào kho nên không thể xóa!", "Xóa phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (XtraMessageBox.Show("Các dữ liệu bị xóa sẽ không thể phục hồi!\nBạn có thực sự muốn xóa phiếu nhập này hay không?", "Xóa phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int rs = PhieuNhapCtrl.Delete(pn.ID_phieu_nhap);

                if (rs == 0)
                {
                    XtraMessageBox.Show("Xóa phiếu nhập không thành công!", "Xóa phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    XtraMessageBox.Show("Xóa phiếu nhập thành công!", "Xóa phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnTimKiem.PerformClick();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            IMP_PhieuNhap pn = (IMP_PhieuNhap)grvPhieuNhap.GetFocusedRow();

            if (pn != null)
            {
                if (pn.Trang_thai == -1)
                {
                    XtraMessageBox.Show("Phiếu nhập đã được xác thực nên không thể sửa!", "Sửa phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    frmSuaPhieuNhap frm = new frmSuaPhieuNhap(pn);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        btnTimKiem.PerformClick();
                        PhieuNhapCTCtrl.LoadBindingSource(pn.ID_phieu_nhap, iMPPhieuNhapCTBindingSource);
                    }
                }
            }
        }

        private void dteNgayBatDau_EditValueChanged(object sender, EventArgs e)
        {
            DateTime date = (DateTime)dteNgayBatDau.EditValue;

            if (ledTuyChon.EditValue.Equals(1))
            {
                dteNgayKetThuc.EditValue = date;
            }
            else if (ledTuyChon.EditValue.Equals(2))
            {
                dteNgayKetThuc.EditValue = date.AddDays(7);
            }
            else if (ledTuyChon.EditValue.Equals(3))
            {
                dteNgayKetThuc.EditValue = date.AddMonths(1);
            }
            else if (ledTuyChon.EditValue.Equals(4))
            {
                dteNgayKetThuc.EditValue = date.AddYears(1);
            }
        }

        private void ledTuyChon_EditValueChanged(object sender, EventArgs e)
        {
            dteNgayBatDau_EditValueChanged(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            PhieuNhapCtrl.LoadBindingSource(iMPPhieuNhapBindingSource, (DateTime)dteNgayBatDau.EditValue, (DateTime)dteNgayKetThuc.EditValue);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain.CloseCurrentForm(this.Parent);
        }

        private void dteNgayKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            btnTimKiem.PerformClick();
        }
    }
}