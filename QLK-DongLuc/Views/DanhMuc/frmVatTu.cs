using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLK_DongLuc.Models;
using QLK_DongLuc.Controllers;

namespace QLK_DongLuc.Views.DanhMuc
{
    public partial class frmVatTu : DevExpress.XtraEditors.XtraForm
    {
        Entities db;

        public frmVatTu()
        {
            InitializeComponent();
        }

        private void gridControl_Load()
        {
            VatTuCtrl.LoadBindingSource(sTOVatTuBindingSource);
        }

        private void InsertCommand()
        {
            int rs =
                 VatTuCtrl.Insert(
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_loai_vat_tu"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten_vat_tu"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ma_vat_tu"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Don_vi"),
                 gridView.GetRowCellValue(gridView.FocusedRowHandle, "Mo_ta"),
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
                VatTuCtrl.Update(
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_vat_tu"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_loai_vat_tu"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten_vat_tu"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ma_vat_tu"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Don_vi"),
                gridView.GetRowCellValue(gridView.FocusedRowHandle, "Mo_ta"),
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

            if (VatTuCtrl.Delete(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_vat_tu"), db) > 0)
                XtraMessageBox.Show("Xóa dữ liệu thành công.", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("Xóa dữ liệu không thành công.", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            gridControl_Load();
        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            db = new Entities();
            gridControl_Load();
            LoaiVatTuCtrl.LoadLookUpEdit(repositoryItemLookUpEdit1, db);
        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;
            string sError = "";

            var ID_loai_vat_tu = gridView.GetRowCellValue(e.RowHandle, "ID_loai_vat_tu");

            if (ID_loai_vat_tu.Equals(0))
            {
                bError = true;
                sError += "\n Chưa chọn loại vật tư. ";
            }

            var Ten_vat_tu = gridView.GetRowCellValue(e.RowHandle, "Ten_vat_tu");

            if (Ten_vat_tu == null || Ten_vat_tu.ToString().Trim() == "")
            {
                bError = true;
                sError += "\n Chưa điền tên vật tư (chủng loại). ";
            }

            if (bError)
            {
                e.ErrorText = sError + "\n Bạn có muốn sửa lại không?\n";
                e.Valid = false;
                //XtraMessageBox.Show(sError, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void gridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if(gridView.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
                    DeleteCommand();

                e.Handled = true;
            }
        }
    }
}