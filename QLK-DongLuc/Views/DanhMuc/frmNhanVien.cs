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
using QLK_DongLuc.Helper;

namespace QLK_DongLuc.Views.DanhMuc
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            Entities db = new Entities();
            KhoVatTuCtrl.LoadLookUpEdit(rleKhoVatTu, db);
            NhanVienCtrl.LoadBindingSource(cATNhanVienBindingSource, db);
            VaiTroQuyenCtrl.ReconfigFormControls(this, db);
            GridHelper.ReconfigGridView(gridView);
        }

        private void gridControl_Load()
        {
            Entities db = new Entities();
            KhoVatTuCtrl.LoadLookUpEdit(rleKhoVatTu, db);
            NhanVienCtrl.LoadBindingSource(cATNhanVienBindingSource, db);
        }

        private void InsertCommand()
        {
            var nhanVien = (CAT_NhanVien)gridView.GetFocusedRow();
            int rs = NhanVienCtrl.Insert(nhanVien);

            if (rs == 0)
            {
                NotifyHelper.ShowInsertError();
                gridControl_Load();
            }
        }

        private void UpdateCommand()
        {
            var nhanVien = (CAT_NhanVien)gridView.GetFocusedRow();
            int rs = NhanVienCtrl.Update(nhanVien);

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
                var nhanVien = (CAT_NhanVien)gridView.GetFocusedRow();
                int rs = NhanVienCtrl.Delete(nhanVien.ID_nhan_vien);

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

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;

            var Ho_dem = gridView.GetRowCellValue(e.RowHandle, colHo_dem);

            if (Ho_dem == null || Ho_dem.ToString().Trim() == "")
            {
                bError = true;
                gridView.SetColumnError(colHo_dem, Properties.Settings.Default.NullOrEmpty);
            }

            var Ten = gridView.GetRowCellValue(e.RowHandle, colTen);

            if (Ten == null || Ten.ToString().Trim() == "")
            {
                bError = true;
                gridView.SetColumnError(colTen, Properties.Settings.Default.NullOrEmpty);
            }

            var Ngay_sinh = gridView.GetRowCellValue(e.RowHandle, colNgay_sinh);

            if (Ngay_sinh == null || (QLK_DongLuc.Helper.DatabaseHelper.GetDatabaseDate().Year - ((DateTime)Ngay_sinh).Year <= 15) || ((DateTime)Ngay_sinh).Year < 1900)
            {
                bError = true;
                gridView.SetColumnError(colNgay_sinh, Properties.Settings.Default.InvalidDate);
            }

            var CMND = gridView.GetRowCellValue(e.RowHandle, colCMND);

            if (CMND == null || CMND.ToString().Trim() == "")
            {
                bError = true;
                gridView.SetColumnError(colCMND, Properties.Settings.Default.NullOrEmpty);
            }

            var Ngay_cap = gridView.GetRowCellValue(e.RowHandle, colNgay_cap);

            if (Ngay_cap != null && ((DateTime)Ngay_cap).Year < 1900)
            {
                bError = true;
                gridView.SetColumnError(colNgay_cap, Properties.Settings.Default.InvalidDate);
            }

            var Dien_thoai = gridView.GetRowCellValue(e.RowHandle, colDien_thoai);

            if (Dien_thoai == null || Dien_thoai.ToString().Trim() == "")
            {
                bError = true;
                gridView.SetColumnError(colNgay_sinh, Properties.Settings.Default.NullOrEmpty);
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
    }
}