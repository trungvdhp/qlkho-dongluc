﻿using System;
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
                    NotifyHelper.ShowPrintError();
                }

                grdPhieuNhapCT.ShowPrintPreview();
            }
        }

        private void KiemTraDuLieu(ref int result)
        {
            if (ledNhanVienNhap.EditValue == null)
            {
                NotifyHelper.ShowError("Chưa chọn nhân viên nhập", "Lỗi thêm dữ liệu");
                ledNhanVienNhap.Focus();
                result = 0;
                return;
            }

            if (ledKhoNhap.EditValue == null)
            {
                NotifyHelper.ShowError("Chưa chọn nhân kho nhập", "Lỗi thêm dữ liệu");
                ledKhoNhap.Focus();
                result = 0;
                return;
            }

            if (ledNhaCungCap.EditValue == null)
            {
                NotifyHelper.ShowError("Chưa chọn nhà cung cấp", "Lỗi thêm dữ liệu");
                ledNhaCungCap.Focus();
                result = 0;
                return;
            }

            if (dteNgayNhap.EditValue == "")
            {
                NotifyHelper.ShowError("Chưa chọn ngày nhập kho", "Lỗi thêm dữ liệu");
                dteNgayNhap.Focus();
                result = 0;
                return;
            }

            if (ledThanCuaCuon.EditValue == null)
            {
                NotifyHelper.ShowError("Chưa chọn thân cửa cuốn", "Lỗi thêm dữ liệu");
                ledThanCuaCuon.Focus();
                result = 0;
                return;
            }

            if (ledMoToCuaCuon.EditValue == null)
            {
                NotifyHelper.ShowError("Chưa chọn mô tơ cửa cuốn", "Lỗi thêm dữ liệu");
                ledMoToCuaCuon.Focus();
                result = 0;
                return;
            }

            if (ledChotCuaCuon.EditValue == null)
            {
                NotifyHelper.ShowError("Chưa chọn chốt cửa cuốn", "Lỗi thêm dữ liệu");
                ledChotCuaCuon.Focus();
                result = 0;
                return;
            }

            if (ledKhoaCuaCuon.EditValue == null)
            {
                NotifyHelper.ShowError("Chưa chọn kháo cửa cuốn", "Lỗi thêm dữ liệu");
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
                    NotifyHelper.ShowError("Thêm phiếu nhập không thành công", "Lỗi thêm phiếu nhập");
                    return;
                }

                rs = PhieuNhapCtrl.AddDetails(rs, Trang_thai, grvPhieuNhapCT, (int)ledThanCuaCuon.EditValue, (double)sedChieuDai.Value, (double)sedChieuRong.Value, (int)ledMoToCuaCuon.EditValue, (int)ledChotCuaCuon.EditValue, (int)ledKhoaCuaCuon.EditValue);

                if (rs == 0)
                {
                    NotifyHelper.ShowError("Thêm các chi tiết phiếu nhập không thành công", "Lỗi thêm chi tiết phiếu nhập");

                    PhieuNhapCtrl.Delete(rs);

                    return;
                }

                NotifyHelper.ShowInfo("Thêm phiếu nhập thành công", "Thêm phiếu nhập");

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

            var ID_vat_tu = grvPhieuNhapCT.GetRowCellValue(e.RowHandle, colID_vat_tu);

            if (ID_vat_tu.Equals(0))
            {
                bError = true;
                grvPhieuNhapCT.SetColumnError(colID_vat_tu, Properties.Settings.Default.NullOrEmpty);
            }

            var So_luong = grvPhieuNhapCT.GetRowCellValue(e.RowHandle, colSo_luong);

            if (So_luong == null || double.Parse(So_luong.ToString()) == 0)
            {
                bError = true;
                grvPhieuNhapCT.SetColumnError(colSo_luong, Properties.Settings.Default.NotGreaterThanZero);
            }

            int n = grvPhieuNhapCT.RowCount;

            for (int i = 0; i < n; i++)
            {
                if (i != e.RowHandle)
                {
                    var id = grvPhieuNhapCT.GetRowCellValue(i,  colID_vat_tu);

                    if (ID_vat_tu.Equals(id))
                    {
                        bError = true;
                        grvPhieuNhapCT.SetColumnError(colID_vat_tu, Properties.Settings.Default.Duplicated);
                        break;
                    }
                }
            }

            if (bError)
            {
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