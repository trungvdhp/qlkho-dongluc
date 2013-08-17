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
    public partial class frmNhomVatTu : DevExpress.XtraEditors.XtraForm
    {
        public frmNhomVatTu()
        {
            InitializeComponent();
        }

        private void frmNhomVatTu_Load(object sender, EventArgs e)
        {
            Entities db = new Entities();
            KhoVatTuCtrl.LoadLookUpEdit(rleKhoVatTu, db);
            NhomVatTuCtrl.LoadBindingSource(sTONhomVatTuBindingSource, db);
            NhomVatTuCtrl.LoadLookUpEdit(lookUpEdit, db);
            VaiTroQuyenCtrl.ReconfigFormControls(this, db);
            GridHelper.ReconfigGridView(gridView);
            GridHelper.HAlignmentAllHeaderColumns(gridView);
            GridHelper.BestFitAllColumns(gridView);
        }

        private void gridControl_Load()
        {
            Entities db = new Entities();
            KhoVatTuCtrl.LoadLookUpEdit(rleKhoVatTu, db);
            NhomVatTuCtrl.LoadBindingSource(sTONhomVatTuBindingSource, db);
        }

        private void InsertCommand()
        {
            var nhom = (STO_NhomVatTu)gridView.GetFocusedRow();
            int rs = NhomVatTuCtrl.Insert(nhom);

            if (rs == 0)
            {
                NotifyHelper.ShowInsertError();
                gridControl_Load();
            }
        }

        private void UpdateCommand()
        {
            var nhom = (STO_NhomVatTu)gridView.GetFocusedRow();
            int rs = NhomVatTuCtrl.Update(nhom);

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
                var nhom = (STO_NhomVatTu)gridView.GetFocusedRow();
                int rs = NhomVatTuCtrl.Delete(nhom.ID_nhom_vat_tu);

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

            var Ten_nhom_vat_tu = gridView.GetRowCellValue(e.RowHandle, colTen_nhom_vat_tu);

            if (Ten_nhom_vat_tu == null || Ten_nhom_vat_tu.ToString().Trim() == "")
            {
                bError = true;
                gridView.SetColumnError(colTen_nhom_vat_tu, Properties.Settings.Default.NullOrEmpty);
            }

            var ID_kho = gridView.GetRowCellValue(e.RowHandle, colKho_vat_tu);

            if (ID_kho == null)
            {
                bError = true;
                gridView.SetColumnError(colKho_vat_tu, Properties.Settings.Default.NullOrEmpty);
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

        private void frmNhomVatTu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ID_nhom_vat_tu = (int)lookUpEdit.EditValue;
            Properties.Settings.Default.Save();
        }
    }
}