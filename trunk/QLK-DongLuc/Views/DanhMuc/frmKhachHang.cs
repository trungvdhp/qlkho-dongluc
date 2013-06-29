using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Controllers;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Views.DanhMuc
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        Entities db = new Entities();

        public frmKhachHang()
        {
            InitializeComponent();
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

        private void gridControl_Load()
        {
            KhachHangCtrl.LoadBindingSource(cATKhachHangBindingSource);
        }

        private void InsertCommand()
        {
            int rs =
                 KhachHangCtrl.Insert(
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ho_dem"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dien_thoai"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dia_chi"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_nguoi_tao"),
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
                KhachHangCtrl.Update(
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_khach_hang"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ho_dem"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dien_thoai"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dia_chi"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_nguoi_tao"),
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

            if (KhachHangCtrl.Delete(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_khach_hang"), db) > 0)
                XtraMessageBox.Show("Xóa dữ liệu thành công.", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("Xóa dữ liệu không thành công.", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            gridControl_Load();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            gridControl_Load();
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
                sError += "\n Chưa điền họ đệm khách hàng. ";
            }

            var Ten = gridView.GetRowCellValue(e.RowHandle, "Ten");

            if (Ten == null || Ten.ToString().Trim() == "")
            {
                bError = true;
                sError += "\n Chưa điền tên khách hàng. ";
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