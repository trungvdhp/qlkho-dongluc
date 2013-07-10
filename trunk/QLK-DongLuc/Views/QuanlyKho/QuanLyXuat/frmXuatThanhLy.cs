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

namespace QLK_DongLuc.Views.QuanlyKho.QuanLyXuat
{
    public partial class frmXuatThanhLy : DevExpress.XtraEditors.XtraForm
    {
        Entities db;
        int ID_loai_xuat;

        public frmXuatThanhLy()
        {
            InitializeComponent();
        }

        public frmXuatThanhLy(int _ID_lx =2)
        {
            ID_loai_xuat = _ID_lx;
            InitForm();
        }

        private void InitForm()
        {
            InitializeComponent();
            txtMahoadon.Focus();
            db = new Entities();
            // đưa dữ liệu vào các đối tượng lookupedit
            NhanVienCtrl.LoadLookUpEdit(leNhanvienxuat, db);
            KhoVatTuCtrl.LoadLookUpEdit(leKhoxuat, db);
            //
            VatTuCtrl.LoadLookUpEdit(repositoryItemLookUpEdit1, db);
            dtNgayxuat.EditValue = DateTime.Now;
        }
        private void frmXuatThanhLy_Load(object sender, EventArgs e)
        {
            VaiTroQuyenCtrl.ReconfigFormControls(this);
        }

        private void grvPhieuxuatCT_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;
            string sError = "";

            var ID_vat_tu = grvPhieuxuatCT.GetRowCellValue(e.RowHandle, "ID_vat_tu");

            if (ID_vat_tu.Equals(0))
            {
                bError = true;
                sError += "\n Chưa chọn vật tư.";
            }

            var So_luong = grvPhieuxuatCT.GetRowCellValue(e.RowHandle, "So_luong");

            if (So_luong == null || double.Parse(So_luong.ToString()) == 0)
            {
                bError = true;
                sError += "\n Số lượng phải lớn hơn 0.";
            }
            var Don_gia = grvPhieuxuatCT.GetRowCellValue(e.RowHandle, "Don_gia");
            if (Don_gia == null || decimal.Parse(Don_gia.ToString()) != 0)
            {
                bError = true;
                sError += "\n Đơn giá phải bằng 0.";
            }

            int n = grvPhieuxuatCT.RowCount;
            //decimal tongtien = 0;
            for (int i = 0; i < n; i++)
            {
                if (i != e.RowHandle)
                {
                    var id = grvPhieuxuatCT.GetRowCellValue(i, "ID_vat_tu");
                    // var soluong = grvPhieuxuatCT.GetRowCellValue(i, "So_luong");
                    // var dongia = grvPhieuxuatCT.GetRowCellValue(i, "Don_gia");
                    if (ID_vat_tu.Equals(id))
                    {
                        bError = true;
                        sError += "\n Vật tư đã nhập phải khác với các vật tư đã chọn.";
                        break;
                    }
                    //else
                    //{
                    //    if (soluong != null && dongia != null)
                    //    {
                    //        int sl = int.Parse(soluong.ToString());
                    //        decimal dg = decimal.Parse(dongia.ToString());
                    //        tongtien = tongtien + sl * dg;
                    //        txtTongtien.Text = tongtien.ToString();
                    //    }
                    //    else
                    //    {
                    //       // XtraMessageBox.Show(sError, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //    }
                    //}
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

        private void KiemTraDuLieu(ref int result)
        {
            if (leNhanvienxuat.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một nhân viên xuất.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                leNhanvienxuat.Focus();
                result = 0;
                return;
            }

            if (leKhoxuat.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn một kho xuất.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                leKhoxuat.Focus();
                result = 0;
                return;
            }

            if (grvPhieuxuatCT.RowCount < 2)
            {
                XtraMessageBox.Show("Vui lòng nhập ít nhất một chi tiết phiếu xuất.", "Thêm chi tiết phiếu nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grvPhieuxuatCT.Focus();
                result = 0;
                return;
            }

            result = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int rs = 0;
            KiemTraDuLieu(ref rs);
            // thực hiện insert phiếu xuất và chi tiết phiếu xuất:
            if (rs == 1)
            {            
                rs = PhieuXuatCtrl.Insert(txtMahoadon.Text, 2, leKhoxuat.EditValue, null, leNhanvienxuat.EditValue, dtNgayxuat.EditValue, 0, mmGhichu.Text, 1, Program.CurrentUser.ID_nguoi_dung, db);
                if (rs == 0)
                {
                    XtraMessageBox.Show("Thêm phiếu xuất không thành công. Vui lòng thử lại!", "Thêm phiếu xuất", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                rs = PhieuXuatCtrl.AddDetails(rs, grvPhieuxuatCT, db);

                if (rs == 0)
                {
                    XtraMessageBox.Show("Thêm chi tiết phiếu xuất không thành công. Vui lòng thử lại!", "Thêm chi tiết phiếu xuất", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PhieuXuatCtrl.Delete(rs, db);
                    return;
                }

                XtraMessageBox.Show("Thêm phiếu xuất thành công.", "Thêm phiếu xuất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //
                btnLamlai.PerformClick();
            }
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtMahoadon.Text = "";
            txtMahoadon.Focus();
            leKhoxuat.Reset();
            leNhanvienxuat.Reset();
            mmGhichu.Text = "";
            grvPhieuxuatCT.RefreshData();
            dtNgayxuat.EditValue = DateTime.Now;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain.CloseCurrentForm(this.Parent);
        }

        private void dtNgayxuat_EditValueChanged(object sender, EventArgs e)
        {
            txtMahoadon.Text = PhieuXuatCtrl.GetNextCode(dtNgayxuat.EditValue, db);
        }

        private void leNhanvienxuat_EditValueChanged(object sender, EventArgs e)
        {
            object manv = leNhanvienxuat.EditValue;
            leKhoxuat.EditValue = NhanVienCtrl.GetIdkho(manv,db);
        }

        private void leKhoxuat_EditValueChanged(object sender, EventArgs e)
        {
            object makho = leKhoxuat.EditValue;
            NhanVienCtrl.LoadLookUpEdit_Nhanvien_Kho(leNhanvienxuat, makho, db);
        }
    }
}