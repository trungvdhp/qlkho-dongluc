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

namespace QLK_DongLuc.Views.HeThong
{
    public partial class frmVaiTro : DevExpress.XtraEditors.XtraForm
    {
        Entities db;

        public frmVaiTro()
        {
            InitializeComponent();
        }

        private void grdVaiTro_Load()
        {
            db = new Entities();
            VaiTroCtrl.LoadBindingSource(sYSVaiTroBindingSource);
        }

        private void InsertCommand()
        {
            int rs =
                 VaiTroCtrl.Insert(
                 grvVaiTro.GetRowCellValue(grvVaiTro.FocusedRowHandle, "Ten_vai_tro"),
                 grvVaiTro.GetRowCellValue(grvVaiTro.FocusedRowHandle, "Mo_ta"),
                 db);

            if (rs > 0)
            {
                //XtraMessageBox.Show("Thêm dữ liệu thành công.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Thêm dữ liệu không thành công.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            grdVaiTro_Load();
        }

        private void UpdateCommand()
        {
            int rs =
                VaiTroCtrl.Update(
                grvVaiTro.GetRowCellValue(grvVaiTro.FocusedRowHandle, "ID_vai_tro"),
                grvVaiTro.GetRowCellValue(grvVaiTro.FocusedRowHandle, "Ten_vai_tro"),
                grvVaiTro.GetRowCellValue(grvVaiTro.FocusedRowHandle, "Mo_ta"),
                db);

            if (rs > 0)
            {
                //XtraMessageBox.Show("Sửa dữ liệu thành công.", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Sửa dữ liệu không thành công.", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            grdVaiTro_Load();
        }

        private void DeleteCommand()
        {
            if (grvVaiTro.FocusedRowHandle < 0) return;

            var result = XtraMessageBox.Show("Chắc chắn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            if (VaiTroCtrl.Delete(grvVaiTro.GetRowCellValue(grvVaiTro.FocusedRowHandle, "ID_vai_tro"), db) > 0)
            {
                //XtraMessageBox.Show("Xóa dữ liệu thành công.", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Xóa dữ liệu không thành công.", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            grdVaiTro_Load();
        }

        private void frmVaiTro_Load(object sender, EventArgs e)
        {
            grdVaiTro_Load();
        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;
            string sError = "";

            var Ten_vai_tro = grvVaiTro.GetRowCellValue(e.RowHandle, "Ten_vai_tro");

            if (Ten_vai_tro == null || Ten_vai_tro.ToString().Trim() == "")
            {
                bError = true;
                sError += "\n Chưa điền tên vai trò.";
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

        private void grdVaiTro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && grvVaiTro.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
                DeleteCommand();

            if (e.KeyCode == Keys.Enter && grvVaiTro.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                grvVaiTro.CloseEditor();
                grvVaiTro.UpdateCurrentRow();
            }

            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.P)
            {
                if (!grdVaiTro.IsPrintingAvailable)
                {
                    XtraMessageBox.Show("Không thể in.", "Lỗi in dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                grdVaiTro.ShowPrintPreview();
            }
        }

        private void grdVaiTro_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (grvVaiTro.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
                    DeleteCommand();

                e.Handled = true;
            }
        }
    }
}