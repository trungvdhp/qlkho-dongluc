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

namespace QLK_DongLuc.Views.QuanlyKho.QuanLyNhap
{
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        Entities db;

        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            db = new Entities();
            TuyChonTimKiemCtrl.LoadLookUpEdit(ledTuyChon);
            PhieuNhapCtrl.LoadBindingSource(viewPhieuNhapBindingSource, db);
            VatTuCtrl.LoadLookUpEdit(repositoryItemLookUpEdit1, db);

            if (Program.CurrentUser.ID_nhan_vien != null)
            {
                colNhan_vien_lap.Visible = false;
                colTong_tien.Visible = false;
                colDon_gia.Visible = false;
            }
            else
            {
                btnNhapLai.Visible = false;
                btnNhapMoi.Visible = false;
            }

            dteNgayBatDau.EditValue = KetNoiCSDLCtrl.GetDatabaseDate();
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
            frmLapPhieuNhapMoi frm = new frmLapPhieuNhapMoi(2);
            frm.Text = "Lập phiếu nhập lại";
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ViewPhieuNhap pn = (ViewPhieuNhap)grvPhieuNhap.GetFocusedRow();

            if (XtraMessageBox.Show("Các dữ liệu bị xóa sẽ không thể phục hồi!\nBạn có thực sự muốn xóa phiếu nhập này hay không?", "Xóa phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int rs = PhieuNhapCtrl.Delete(pn.ID_phieu_nhap, db);

                if (rs == -1)
                {
                    XtraMessageBox.Show("Phiếu nhập này đã được xác thực hàng đã vào kho và không thể xóa!", "Xóa phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (rs == 0)
                {
                    XtraMessageBox.Show("Xóa phiếu nhập không thành công!", "Xóa phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    XtraMessageBox.Show("Xóa phiếu nhập thành công!", "Xóa phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PhieuNhapCtrl.LoadBindingSource(viewPhieuNhapBindingSource);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ViewPhieuNhap pn = (ViewPhieuNhap)grvPhieuNhap.GetFocusedRow();

            if (pn != null)
            {
                frmSuaPhieuNhap frm = new frmSuaPhieuNhap(pn.ID_phieu_nhap);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    PhieuNhapCtrl.LoadBindingSource(viewPhieuNhapBindingSource);
                    PhieuNhapCTCtrl.LoadBindingSource(pn.ID_phieu_nhap, iMPPhieuNhapCTBindingSource);
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
            var begin = (DateTime)dteNgayBatDau.EditValue;
            var beginYear = new DateTime(begin.Year, 1, 1);
            dteNgayBatDau.EditValue = beginYear;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grvPhieuNhap.ActiveFilterString = TuyChonTimKiemCtrl.GetDateFilterString(dteNgayBatDau.EditValue, dteNgayKetThuc.EditValue);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain.CloseCurrentForm(this.Parent);
        }
    }
}