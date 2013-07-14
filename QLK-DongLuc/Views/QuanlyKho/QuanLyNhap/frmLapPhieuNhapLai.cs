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
    public partial class frmLapPhieuNhapLai : DevExpress.XtraEditors.XtraForm
    {
        public frmLapPhieuNhapLai()
        {
            InitializeComponent();
        }

        private void frmLapPhieuNhapLai_Load(object sender, EventArgs e)
        {
            Entities db = new Entities();
            NhanVienCtrl.LoadLookUpEdit(ledNhanVienNhap, db);
            KhoVatTuCtrl.LoadLookUpEdit(ledKhoNhap, db);
            VatTuCtrl.LoadLookUpEdit(repositoryItemLookUpEdit1, db);
            dteNgayNhap.EditValue = KetNoiCSDLCtrl.GetDatabaseDate();
            VaiTroQuyenCtrl.ReconfigFormControls(this, db);
            Utils.ReconfigGridView(grvPhieuNhapCT);
        }

        private void grdPhieuNhapCT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && grvPhieuNhapCT.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing && grvPhieuNhapCT.OptionsBehavior.AllowDeleteRows == DevExpress.Utils.DefaultBoolean.True)
            {
                grvPhieuNhapCT.DeleteRow(grvPhieuNhapCT.FocusedRowHandle);
            }

            if (e.KeyCode == Keys.Enter && grvPhieuNhapCT.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                grvPhieuNhapCT.CloseEditor();
                grvPhieuNhapCT.UpdateCurrentRow();
            }

            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.P)
            {
                if (!grdPhieuNhapCT.IsPrintingAvailable)
                {
                    XtraMessageBox.Show("Không in được.", "Lỗi in dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                grdPhieuNhapCT.ShowPrintPreview();
            }
        }

        private void KiemTraDuLieu(ref int result)
        {
            if (ledNhanVienNhap.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một nhân viên nhập.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ledNhanVienNhap.Focus();
                result = 0;
                return;
            }

            if (ledKhoNhap.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một kho nhập.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ledKhoNhap.Focus();
                result = 0;
                return;
            }

            if (dteNgayNhap.EditValue == "")
            {
                XtraMessageBox.Show("Vui lòng chọn một ngày nhập kho.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dteNgayNhap.Focus();
                result = 0;
                return;
            }

            if (grvPhieuNhapCT.RowCount < 2)
            {
                XtraMessageBox.Show("Vui lòng nhập ít nhất một chi tiết phiếu nhập.", "Thêm chi tiết phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grvPhieuNhapCT.Focus();
                result = 0;
                return;
            }

            result = 1;
        }

        private void Luu(int Trang_thai)
        {
            int rs = 0;
            KiemTraDuLieu(ref rs);

            if (rs == 1)
            {
                rs = PhieuNhapCtrl.Insert(ledNhanVienNhap.EditValue,null, ledKhoNhap.EditValue, null, dteNgayNhap.EditValue, mmoGhiChu.Text, 2);

                if (rs == 0)
                {
                    XtraMessageBox.Show("Thêm phiếu nhập lại không thành công. Vui lòng thử lại!", "Thêm phiếu nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rs = PhieuNhapCtrl.AddDetails(rs, Trang_thai, grvPhieuNhapCT);

                if (rs == 0)
                {
                    XtraMessageBox.Show("Thêm chi tiết phiếu nhập lại không thành công. Vui lòng thử lại!", "Thêm chi tiết phiếu nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    PhieuNhapCtrl.Delete(rs);

                    return;
                }

                XtraMessageBox.Show("Thêm phiếu nhập lại thành công.", "Thêm phiếu nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnLamLai.PerformClick();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Luu(0);
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            Utils.ResetControls(this);
        }

        private void grvPhieuNhapCT_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;
            string sError = "";

            var ID_vat_tu = grvPhieuNhapCT.GetRowCellValue(e.RowHandle, "ID_vat_tu");

            if (ID_vat_tu.Equals(0))
            {
                bError = true;
                sError += "\n Chưa chọn vật tư.";
            }

            var So_luong = grvPhieuNhapCT.GetRowCellValue(e.RowHandle, "So_luong");

            if (So_luong == null || double.Parse(So_luong.ToString()) == 0)
            {
                bError = true;
                sError += "\n Số lượng phải lớn hơn 0.";
            }

            int n = grvPhieuNhapCT.RowCount;

            for (int i = 0; i < n; i++)
            {
                if (i != e.RowHandle)
                {
                    var id = grvPhieuNhapCT.GetRowCellValue(i, "ID_vat_tu");

                    if (ID_vat_tu.Equals(id))
                    {
                        bError = true;
                        sError += "\n Vật tư đã nhập phải khác với các vật tư đã chọn.";
                        break;
                    }
                }
            }

            if (bError)
            {
                e.ErrorText = sError + "\n Bạn có muốn sửa lại không?\n";
                e.Valid = false;
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain.CloseCurrentForm(this.Parent);
        }

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            Luu(1);
        }
    }
}