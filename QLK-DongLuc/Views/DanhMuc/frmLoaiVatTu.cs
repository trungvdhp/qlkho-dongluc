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
    public partial class frmLoaiVatTu : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiVatTu()
        {
            InitializeComponent();
        }

        private void frmLoaiVatTu_Load(object sender, EventArgs e)
        {
            Entities db = new Entities();
            NhomVatTuCtrl.LoadLookUpEdit(rleNhomVatTu, db);
            LoaiVatTuCtrl.LoadBindingSource(sTOLoaiVatTuBindingSource, db);
            VaiTroQuyenCtrl.ReconfigFormControls(this, db);
            GridHelper.ReconfigGridView(gridView);
        }

        private void gridControl_Load()
        {
            Entities db = new Entities();
            NhomVatTuCtrl.LoadLookUpEdit(rleNhomVatTu, db);
            LoaiVatTuCtrl.LoadBindingSource(sTOLoaiVatTuBindingSource, db);
        }

        private void InsertCommand()
        {
            var loai = (STO_LoaiVatTu)gridView.GetFocusedRow();
            int rs = LoaiVatTuCtrl.Insert(loai);

            if (rs == 0)
            {
                NotifyHelper.ShowInsertError();
                gridControl_Load();
            }
        }

        private void UpdateCommand()
        {
            var loai = (STO_LoaiVatTu)gridView.GetFocusedRow();
            int rs = LoaiVatTuCtrl.Update(loai);

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
                var loai = (STO_LoaiVatTu)gridView.GetFocusedRow();
                int rs = LoaiVatTuCtrl.Delete(loai.ID_loai_vat_tu);

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

            var Ten_loai_vat_tu = gridView.GetRowCellValue(e.RowHandle, colTen_loai_vat_tu);

            if (Ten_loai_vat_tu == null || Ten_loai_vat_tu.ToString().Trim() == "")
            {
                bError = true;
                gridView.SetColumnError(colTen_loai_vat_tu, Properties.Settings.Default.NullOrEmpty);
            }

            var ID_nhom_vat_tu = gridView.GetRowCellValue(e.RowHandle, colID_nhom_vat_tu);

            if (ID_nhom_vat_tu == null)
            {
                bError = true;
                gridView.SetColumnError(colID_nhom_vat_tu, Properties.Settings.Default.NullOrEmpty);
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