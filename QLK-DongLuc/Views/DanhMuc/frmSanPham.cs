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
using QLK_DongLuc.Helper;

namespace QLK_DongLuc.Views.DanhMuc
{
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        Entities db;

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            db = new Entities();
            KhachHangCtrl.LoadLookUpEdit(rleKhachHang, db);
            NhanVienCtrl.LoadLookUpEdit(rleNhanVienKinhDoanh, db);
            SanPhamCtrl.LoadBindingSource(cATSanPhamBindingSource, db);
            VaiTroQuyenCtrl.ReconfigFormControls(this, db);
            GridHelper.ReconfigGridView(gridView);
        }

        private void gridControl_Load()
        {
            db = new Entities();
            KhachHangCtrl.LoadLookUpEdit(rleKhachHang, db);
            NhanVienCtrl.LoadLookUpEdit(rleNhanVienKinhDoanh, db);
            SanPhamCtrl.LoadBindingSource(cATSanPhamBindingSource, db);
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

        private void InsertCommand()
        {
            var sanPham = (CAT_SanPham)gridView.GetFocusedRow();
            int rs = SanPhamCtrl.Insert(sanPham);

            if (rs == 0)
            {
                NotifyHelper.ShowInsertError();
                gridControl_Load();
            }
        }

        private void UpdateCommand()
        {
            var sanPham = (CAT_SanPham)gridView.GetFocusedRow();
            int rs = SanPhamCtrl.Update(sanPham);

            if (rs == 0)
            {
                NotifyHelper.ShowUpdateError();
                gridControl_Load();
            }
        }

        private void DeleteCommand()
        {
            if (gridView.FocusedRowHandle < 0) return;

            var result = NotifyHelper.ShowDeleteConfirm();

            if (result == DialogResult.Yes)
            {
                var sanPham = (CAT_SanPham)gridView.GetFocusedRow();
                int rs = SanPhamCtrl.Delete(sanPham.ID_san_pham);

                if (rs > 0)
                {
                    gridControl_Load();
                }
                else
                {
                    NotifyHelper.ShowDeleteError();
                }
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

            var Ma_san_pham = gridView.GetRowCellValue(e.RowHandle, colMa_san_pham);

            if (Ma_san_pham == null || Ma_san_pham.ToString().Trim() == "")
            {
                bError = true;
                gridView.SetColumnError(colMa_san_pham, Properties.Settings.Default.NullOrEmpty);
            }

            var ID_nhan_vien = gridView.GetRowCellValue(e.RowHandle, colID_nhan_vien);

            if (ID_nhan_vien == null || ID_nhan_vien.ToString().Trim() == "")
            {
                bError = true;
                gridView.SetColumnError(colID_nhan_vien, Properties.Settings.Default.NullOrEmpty);
            }

            var ID_khach_hang = gridView.GetRowCellValue(e.RowHandle, colID_khach_hang);

            if (ID_khach_hang == null || ID_khach_hang.ToString().Trim() == "")
            {
                bError = true;
                gridView.SetColumnError(colID_khach_hang, Properties.Settings.Default.NullOrEmpty);
            }

            if (bError)
            {
                e.Valid = false;
                return;
            }

            if (gridView.IsNewItemRow(e.RowHandle))
                InsertCommand();
            else
                UpdateCommand();
        }

        private void gridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridView.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing && gridView.OptionsBehavior.AllowDeleteRows == DevExpress.Utils.DefaultBoolean.True)
            {
                DeleteCommand();
            }

            if (e.KeyCode == Keys.Enter && gridView.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                gridView.CloseEditor();
                gridView.UpdateCurrentRow();
            }

            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.P)
            {
                if (!gridControl.IsPrintingAvailable)
                {
                    NotifyHelper.ShowPrintError();
                }

                gridControl.ShowPrintPreview();
            }
        }
    }
}