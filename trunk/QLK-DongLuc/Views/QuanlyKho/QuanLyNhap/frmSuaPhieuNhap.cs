using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
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
        IMP_PhieuNhap pn;

        public frmSuaPhieuNhap()
        {
            InitializeComponent();
        }

        public frmSuaPhieuNhap(IMP_PhieuNhap phieuNhap)
        {
            InitializeComponent();
            pn = phieuNhap;
        }

        private void frmSuaPhieuNhap_Load(object sender, EventArgs e)
        {
            if (pn == null)
            {
                XtraMessageBox.Show("Có lỗi xảy ra, không tìm thấy phiếu nhập!", "Sửa phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }

            Entities db = new Entities();
            VaiTroQuyenCtrl.ReconfigFormControls(this, db);
            VatTuCtrl.LoadLookUpEdit(repositoryItemLookUpEdit1, db);
            NhanVienCtrl.LoadLookUpEdit(ledNhanVienNhap, db);
            KhoVatTuCtrl.LoadLookUpEdit(ledKhoNhap, db);

            if (pn.ID_loai_nhap == 1)
                NhaCungCapCtrl.LoadLookUpEdit(ledNhaCungCap, db);
            else
            {
                txtChungTuGoc.Properties.ReadOnly = true;
                ledNhaCungCap.Properties.ReadOnly = true;
            }

            ledNhanVienNhap.EditValue = pn.ID_nhan_vien_nhap;
            ledKhoNhap.EditValue = pn.ID_kho;
            mmoGhiChu.Text = pn.Ghi_chu;
            txtChungTuGoc.Text = pn.So_chung_tu_goc;
            ledNhaCungCap.EditValue = pn.ID_nha_cung_cap;
            dteNgayNhap.EditValue = pn.Ngay_nhap;

            PhieuNhapCTCtrl.LoadBindingSource(pn.ID_phieu_nhap, iMPPhieuNhapCTBindingSource, db);

            if (pn.Trang_thai != 0)
            {
                colID_vat_tu.OptionsColumn.ReadOnly = true;
                colSo_luong.OptionsColumn.ReadOnly = true;
                ledKhoNhap.Properties.ReadOnly = true;
                grvPhieuNhapCT.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                grvPhieuNhapCT.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            }
        }

        private void grdPhieuNhapCT_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.CurrentUser.ID_nhan_vien != null && e.KeyCode == Keys.Delete && grvPhieuNhapCT.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing && grvPhieuNhapCT.OptionsBehavior.AllowDeleteRows == DevExpress.Utils.DefaultBoolean.True)
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

            if(dteNgayNhap.EditValue == "")
            {
                XtraMessageBox.Show("Vui lòng chọn một ngày nhập kho.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dteNgayNhap.Focus();
                result = 0;
                return;
            }

            if (grvPhieuNhapCT.RowCount < 2 && Program.CurrentUser.ID_nhan_vien != null)
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
                rs = PhieuNhapCtrl.Update(pn.ID_phieu_nhap, grvPhieuNhapCT, ledNhanVienNhap.EditValue, ledNhaCungCap.EditValue, ledKhoNhap.EditValue, txtChungTuGoc.Text, dteNgayNhap.EditValue, mmoGhiChu.Text, pn.ID_loai_nhap, Trang_thai);

                if (rs == 0)
                {
                    XtraMessageBox.Show("Sửa phiếu nhập không thành công. Vui lòng thử lại!", "Sửa phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                XtraMessageBox.Show("Sửa phiếu nhập thành công!", "Sửa phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Luu(0);
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

            var Don_gia = grvPhieuNhapCT.GetRowCellValue(e.RowHandle, "Don_gia");

            if (Program.CurrentUser.ID_nhan_vien == null)
            {
                IMP_PhieuNhapCT pnct = (IMP_PhieuNhapCT)grvPhieuNhapCT.GetFocusedRow();

                if (pnct.STO_VatTu.STO_LoaiVatTu.Ten_loai_vat_tu.StartsWith("NAN"))
                {
                    if (Don_gia != null)
                    {
                        bError = true;
                        sError += "\n Vui lòng không nhập giá nhập cho vật tư loại NAN.";
                    }
                }
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
                        sError += "\n Không được chọn trùng vật tư.";
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

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            Luu(-1);
        }

        private void btnSinhMaPhieu_Click(object sender, EventArgs e)
        {
            txtChungTuGoc.Text = PhieuNhapCtrl.GetNextCode(dteNgayNhap.EditValue);
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            Luu(1);
        }
    }
}