using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Models;
using QLK_DongLuc.Controllers;

namespace QLK_DongLuc.Views.DanhMuc
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        Entities db;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void gridControl_Load()
        {
            NhanVienCtrl.LoadBindingSource(cATNhanVienBindingSource);
        }

        private void InsertCommand()
        {
            int rs =
                 NhanVienCtrl.Insert(
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ho_dem"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Gioi_tinh"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ngay_sinh"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "CMND"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ngay_cap"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Noi_cap"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dien_thoai"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dia_chi"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Email"),
                 db);

            if (rs > 0)
                XtraMessageBox.Show("Thêm dữ liệu thành công.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("Thêm dữ liệu không thành công.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            gridControl_Load();
        }

        private void UpdateCommand()
        {
            int rs =
                NhanVienCtrl.Update(
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_nhan_vien"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ho_dem"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Gioi_tinh"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ngay_sinh"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "CMND"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ngay_cap"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Noi_cap"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dien_thoai"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dia_chi"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Email"),
                db);

            if (rs > 0)
                XtraMessageBox.Show("Sửa dữ liệu thành công.", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("Sửa dữ liệu không thành công.", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            gridControl_Load();
        }

        private void DeleteCommand()
        {
            if (gridView.FocusedRowHandle < 0) return;

            var result = XtraMessageBox.Show("Chắc chắn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            if (NhanVienCtrl.Delete(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_nhan_vien"), db) > 0)
                XtraMessageBox.Show("Xóa dữ liệu thành công.", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("Xóa dữ liệu không thành công.", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            gridControl_Load();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            db = new Entities();
            gridControl_Load();
            VaiTroQuyenCtrl.ReconfigFormControls(this, db);
        }

        private void gridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (gridView.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
                    DeleteCommand();

                e.Handled = true;
            }
        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;
            string sError = "";

            var Ho_dem = gridView.GetRowCellValue(e.RowHandle, "Ho_dem");

            if (Ho_dem == null || Ho_dem.ToString().Trim() == "")
            {
                bError = true;
                sError += "\n Chưa điền họ đệm nhân viên. ";
            }

            var Ten = gridView.GetRowCellValue(e.RowHandle, "Ten");

            if (Ten == null || Ten.ToString().Trim() == "")
            {
                bError = true;
                sError += "\n Chưa điền tên nhân viên. ";
            }

            var Ngay_sinh = gridView.GetRowCellValue(e.RowHandle, "Ngay_sinh");

            if (Ngay_sinh == null || (KetNoiCSDLCtrl.GetDatabaseDate().Year - ((DateTime)Ngay_sinh).Year <= 15))
            {
                bError = true;
                sError += "\n Nhập ngày tháng không đúng. ";
            }

            var CMND = gridView.GetRowCellValue(e.RowHandle, "CMND");

            if (CMND == null || CMND.ToString().Trim() == "")
            {
                bError = true;
                sError += "\n Chưa điền chứng minh của nhân viên. ";
            }

            var Dien_thoai = gridView.GetRowCellValue(e.RowHandle, "Dien_thoai");

            if (Dien_thoai == null || Dien_thoai.ToString().Trim() == "")
            {
                bError = true;
                sError += "\n Chưa điền điện thoại của nhân viên. ";
            }

            if (bError)
            {
                e.ErrorText = sError + "\n Bạn có muốn sửa lại không?\n";
                e.Valid = false;
                return;
            }

            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.IsNewItemRow(e.RowHandle))
                InsertCommand();
            else
                UpdateCommand();
        }

        private void gridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridView.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
                DeleteCommand();

            if (e.KeyCode == Keys.Enter && gridView.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                gridView.CloseEditor();
                gridView.UpdateCurrentRow();
            }

            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.P)
            {
                if (!gridControl.IsPrintingAvailable)
                {
                    XtraMessageBox.Show("Not available printing.", "Lỗi in dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                gridControl.ShowPrintPreview();
            }
        }
    }
}