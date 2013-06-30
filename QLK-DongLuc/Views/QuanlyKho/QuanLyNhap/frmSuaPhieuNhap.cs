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
using QLK_DongLuc.Views.DanhMuc;

namespace QLK_DongLuc.Views.QuanlyKho.QuanLyNhap
{
    public partial class frmSuaPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        Entities db;
        ViewPhieuNhap pn;

        public frmSuaPhieuNhap(ViewPhieuNhap phieu_nhap)
        {
            InitializeComponent();
            db = new Entities();
            pn = phieu_nhap;
            VatTuCtrl.LoadLookUpEdit(repositoryItemLookUpEdit1, db);
            NhanVienCtrl.LoadLookUpEdit(ledNhanVienNhap, db);
            KhoVatTuCtrl.LoadLookUpEdit(ledKhoNhap, db);

            if (pn.ID_loai_nhap == 1)
                NhaCungCapCtrl.LoadLookUpEdit(ledNhaCungCap, db);
            else
            {
                txtChungTuGoc.Enabled = false;
                ledNhaCungCap.Enabled = false;
            }

            VatTuCtrl.LoadLookUpEdit(repositoryItemLookUpEdit1, db);
        }

        private void frmSuaPhieuNhap_Load(object sender, EventArgs e)
        {
            ledNhanVienNhap.EditValue = pn.ID_nhan_vien_nhap;
            ledKhoNhap.EditValue = pn.ID_kho;
            mmoGhiChu.Text = pn.Ghi_chu;
            txtChungTuGoc.Text = pn.So_chung_tu_goc;
            ledNhaCungCap.EditValue = pn.ID_nha_cung_cap;
            dteNgayNhap.EditValue = pn.Ngay_nhap;


            PhieuNhapCTCtrl.LoadBindingSource(pn.ID_phieu_nhap, iMPPhieuNhapCTBindingSource, db);

            if (Program.CurrentUser.ID_nhan_vien == null)
            {
                // Khóa nhập
                ledNhanVienNhap.Properties.ReadOnly = true;
                ledKhoNhap.Properties.ReadOnly = true;
                ledNhaCungCap.Properties.ReadOnly = true;
                mmoGhiChu.Properties.ReadOnly = true;
                txtChungTuGoc.Properties.ReadOnly = true;
                dteNgayNhap.Properties.ReadOnly = true;

                // Khóa cột
                colID_vat_tu.ColumnEdit.ReadOnly = true;
                colSo_luong.ColumnEdit.ReadOnly = true;

                grvPhieuNhapCT.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            }
            else
            {
                // Khóa nút
                btnLuuVaKhoa.Enabled = false;
                btnXacThuc.Enabled = false;

                // Ẩn cột
                colDon_gia.Visible = false;
                colThanh_tien.Visible = false;
            }
        }

        private void grdPhieuNhapCT_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.CurrentUser.ID_nhan_vien != null && e.KeyCode == Keys.Delete && grvPhieuNhapCT.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
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
                    XtraMessageBox.Show("Not available printing.", "Lỗi in dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (pn.ID_loai_nhap == 1 && ledNhaCungCap.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một nhà cung cấp.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ledNhaCungCap.Focus();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int rs = 0;
            rs = PhieuNhapCtrl.UpdateDetails(pn.ID_phieu_nhap, 0, grvPhieuNhapCT, db);
            //KiemTraDuLieu(ref rs);

            //if (rs == 1)
            //{
            //    rs = PhieuNhapCtrl.Insert(ledNhanVienNhap.EditValue, ledNhaCungCap.EditValue, ledKhoNhap.EditValue, txtChungTuGoc.Text, dteNgayNhap.EditValue, mmoGhiChu.Text, Program.CurrentUser.ID_nguoi_dung, Program.CurrentUser.ID_nhan_vien, 0, pn.ID_loai_nhap, db);

            //    if (rs == 0)
            //    {
            //        XtraMessageBox.Show("Thêm phiếu nhập không thành công. Vui lòng thử lại!", "Thêm phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    rs = PhieuNhapCtrl.AddDetails(rs, grvPhieuNhapCT, db);

            //    if (rs == 0)
            //    {
            //        XtraMessageBox.Show("Thêm chi tiết phiếu nhập không thành công. Vui lòng thử lại!", "Thêm chi tiết phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //        PhieuNhapCtrl.Delete(rs, db);

            //        return;
            //    }

            //    XtraMessageBox.Show("Thêm phiếu nhập thành công.", "Thêm phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    btnLamLai.PerformClick();
            //}
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            frmSuaPhieuNhap_Load(sender, e);
        }

        private void btnThemVatTuMoi_Click(object sender, EventArgs e)
        {
            frmVatTu frm = new frmVatTu();
            frm.ShowDialog();
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
                //XtraMessageBox.Show(sError, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}