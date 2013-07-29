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
    public partial class frmNhapMoiCuaCuonDongBo : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapMoiCuaCuonDongBo()
        {
            InitializeComponent();
        }

        private void frmNhapMoiCuaCuonDongBo_Load(object sender, EventArgs e)
        {
            Entities db = new Entities();
            List<string> Ma_nhom_vat_tu_bo = new List<string>();
            List<string> Ma_loai_vat_tu_bo = new List<string>();
            NhanVienCtrl.LoadLookUpEdit(ledNhanVienNhap, db);
            KhoVatTuCtrl.LoadLookUpEdit(ledKhoNhap, "CCDB", db);
            NhaCungCapCtrl.LoadLookUpEdit(ledNhaCungCap, db);
            VatTuCtrl.LoadLookUpEdit(ledThanCuaCuon, "CCDB", "ThanCCDB", Ma_nhom_vat_tu_bo, Ma_loai_vat_tu_bo,db);
            VatTuCtrl.LoadLookUpEdit(ledMoToCuaCuon, "CCDB", "MoToCCDB", Ma_nhom_vat_tu_bo, Ma_loai_vat_tu_bo, db);
            VatTuCtrl.LoadLookUpEdit(ledKhoaCuaCuon, "CCDB", "KhoaCCDB", Ma_nhom_vat_tu_bo, Ma_loai_vat_tu_bo, db);
            VatTuCtrl.LoadLookUpEdit(ledChotCuaCuon, "CCDB", "ChotCCDB", Ma_nhom_vat_tu_bo, Ma_loai_vat_tu_bo, db);
            Ma_nhom_vat_tu_bo = new List<string>() { " "};
            Ma_loai_vat_tu_bo = new List<string>() { "ThanCCDB", "MoToCCDB", "KhoaCCDB", "ChotCCDB" };
            VatTuCtrl.LoadLookUpEdit(rleVatTu,"CCDB", "", Ma_nhom_vat_tu_bo, Ma_loai_vat_tu_bo, db);
            dteNgayNhap.EditValue = QLK_DongLuc.Helper.DatabaseHelper.GetDatabaseDate();
            VaiTroQuyenCtrl.ReconfigFormControls(this, db);
            GridHelper.ReconfigGridView(grvPhieuNhapCT);
        }

        private void btnThemVatTuMoi_Click(object sender, EventArgs e)
        {
            DanhMuc.frmVatTu frm = new DanhMuc.frmVatTu();
            frm.ShowDialog();
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
                XtraMessageBox.Show("Vui lòng chọn một nhân viên nhập.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ledNhanVienNhap.Focus();
                result = 0;
                return;
            }

            if (ledKhoNhap.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một kho cửa cuốn.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ledKhoNhap.Focus();
                result = 0;
                return;
            }

            if (ledNhaCungCap.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một nhà cung cấp.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ledNhaCungCap.Focus();
                result = 0;
                return;
            }

            if (dteNgayNhap.EditValue == "")
            {
                XtraMessageBox.Show("Vui lòng chọn một ngày nhập kho.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dteNgayNhap.Focus();
                result = 0;
                return;
            }

            if (ledThanCuaCuon.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một thân cửa cuốn.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ledThanCuaCuon.Focus();
                result = 0;
                return;
            }

            if (ledMoToCuaCuon.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một mô tơ cửa cuốn.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ledMoToCuaCuon.Focus();
                result = 0;
                return;
            }

            if (ledChotCuaCuon.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một chốt cửa cuốn.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ledChotCuaCuon.Focus();
                result = 0;
                return;
            }

            if (ledKhoaCuaCuon.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một khóa cửa cuốn.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ledKhoaCuaCuon.Focus();
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
                rs = PhieuNhapCtrl.Insert(ledNhanVienNhap.EditValue, ledNhaCungCap.EditValue, ledKhoNhap.EditValue, txtChungTuGoc.Text, dteNgayNhap.EditValue, mmoGhiChu.Text, 3);

                if (rs == 0)
                {
                    XtraMessageBox.Show("Thêm phiếu nhập không thành công. Vui lòng thử lại!", "Thêm phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rs = PhieuNhapCtrl.AddDetails(rs, Trang_thai, grvPhieuNhapCT, (int)ledThanCuaCuon.EditValue, (double)sedChieuDai.Value, (double)sedChieuRong.Value, (int)ledMoToCuaCuon.EditValue, (int)ledChotCuaCuon.EditValue, (int)ledKhoaCuaCuon.EditValue);

                if (rs == 0)
                {
                    XtraMessageBox.Show("Thêm chi tiết phiếu nhập không thành công. Vui lòng thử lại!", "Thêm chi tiết phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    PhieuNhapCtrl.Delete(rs);

                    return;
                }

                XtraMessageBox.Show("Thêm phiếu nhập thành công.", "Thêm phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnLamLai.PerformClick();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Luu(0);
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            frmNhapMoiCuaCuonDongBo_Load(sender, e);
            QLK_DongLuc.Helper.ControlHelper.ResetControls(this);
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