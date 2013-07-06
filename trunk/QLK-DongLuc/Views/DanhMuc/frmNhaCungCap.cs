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

namespace QLK_DongLuc.Views.DanhMuc
{
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        Entities db;

        public frmNhaCungCap()
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
            NhaCungCapCtrl.LoadBindingSource(cATNhaCungCapBindingSource);
        }

        private void InsertCommand()
        {
            int rs =
                 NhaCungCapCtrl.Insert(
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten_nha_cung_cap"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Nguoi_dai_dien"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dien_thoai"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dia_chi"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Email"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "So_tai_khoan"),
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
                NhaCungCapCtrl.Update(
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_nha_cung_cap"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten_nha_cung_cap"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Nguoi_dai_dien"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dien_thoai"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dia_chi"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Email"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "So_tai_khoan"),
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

            if (NhaCungCapCtrl.Delete(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_nha_cung_cap"), db) > 0)
                XtraMessageBox.Show("Xóa dữ liệu thành công.", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("Xóa dữ liệu không thành công.", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            gridControl_Load();
        }

        private void frmNhacCungCap_Load(object sender, EventArgs e)
        {
            db = new Entities();
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

            var Ten_nha_cung_cap = gridView.GetRowCellValue(e.RowHandle, "Ten_nha_cung_cap");

            if (Ten_nha_cung_cap == null || Ten_nha_cung_cap.ToString().Trim() == "")
            {
                bError = true;
                sError += "\nChưa điền tên nhà cung cấp. ";
            }

            if (bError)
            {
                e.Valid = false;
                XtraMessageBox.Show(sError, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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