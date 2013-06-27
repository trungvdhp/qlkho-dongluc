using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using QLK_DongLuc.Controllers;
using QLK_DongLuc.Models;
using QLK_DongLuc.Views.DanhMuc;

namespace QLK_DongLuc.Views.QuanlyKho.QuanLyNhap
{
    public partial class frmLapPhieuNhapMoi : DevExpress.XtraEditors.XtraForm
    {
        QuanLyKhoDongLucEntities db;
        public frmLapPhieuNhapMoi()
        {
            InitializeComponent();
            db = new QuanLyKhoDongLucEntities();
            NhanVienCtrl.LoadLookUpEdit(ledNhanVienNhap, db);
            KhoVatTuCtrl.LoadLookUpEdit(ledKhoNhap, db);
            NhaCungCapCtrl.LoadLookUpEdit(ledNhaCungCap, db);
            VatTuCtrl.LoadLookUpEdit(repositoryItemLookUpEdit1, db);
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

            if (ledNhaCungCap.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một nhà cung cấp.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ledNhaCungCap.Focus();
                result = 0;
                return;
            }

            result = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int rs = 0;
            KiemTraDuLieu(ref rs);

            if (rs == 1)
            {
                rs = PhieuNhapCtrl.Insert(1, ledNhaCungCap.EditValue, ledKhoNhap.EditValue, txtChungTuNhap.Text, dteNgayNhap.EditValue, mmoGhiChu.Text, 1, 1, 0, 1, db);

                if (rs < 1)
                {
                    XtraMessageBox.Show("Thêm phiếu nhập mới không thành công. Vui lòng thử lại!", "Thêm phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                

            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            //this.Refresh();
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
    }
}