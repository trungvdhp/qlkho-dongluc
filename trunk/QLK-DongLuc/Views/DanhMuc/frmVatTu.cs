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
using QLK_DongLuc.Helper;

namespace QLK_DongLuc.Views.DanhMuc
{
    public partial class frmVatTu : DevExpress.XtraEditors.XtraForm
    {
        public frmVatTu()
        {
            InitializeComponent();
        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            Entities db = new Entities();
            LoaiVatTuCtrl.LoadLookUpEdit(rleLoaiVatTu, db);
            
            VaiTroQuyenCtrl.ReconfigFormControls(this, db);
            GridHelper.ReconfigGridView(gridView);
            GridHelper.HAlignmentAllHeaderColumns(gridView);
            VatTuCtrl.LoadBindingSource(sTOVatTuBindingSource, db);
            GridHelper.BestFitAllColumns(gridView);
            //-------------------------------------------------------
            KhoVatTuCtrl.LoadLookUpEdit(ledKhoVatTu, db);
            NhomVatTuCtrl.LoadLookUpEdit(ledNhomVatTu, db);
            LoaiVatTuCtrl.LoadLookUpEdit(ledLoaiVatTu, db);
        }

        private void gridControl_Load()
        {
            Entities db = new Entities();
            LoaiVatTuCtrl.LoadLookUpEdit(rleLoaiVatTu, db);
            VatTuCtrl.LoadBindingSource(sTOVatTuBindingSource, db);
        }

        private void InsertCommand()
        {
            var vt = (STO_VatTu)gridView.GetFocusedRow();
            int rs = VatTuCtrl.Insert(vt);

            if (rs == 0)
            {
                NotifyHelper.ShowInsertError();
                gridControl_Load();
            }
        }

        private void UpdateCommand()
        {
            var vt = (STO_VatTu)gridView.GetFocusedRow();
            int rs = VatTuCtrl.Update(vt);

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
                var vt = (STO_VatTu)gridView.GetFocusedRow();
                int rs = VatTuCtrl.Delete(vt.ID_vat_tu);

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

            var ID_loai_vat_tu = gridView.GetRowCellValue(e.RowHandle, colID_loai_vat_tu);

            if (ID_loai_vat_tu.Equals(0))
            {
                bError = true;
                gridView.SetColumnError(colID_loai_vat_tu, Properties.Settings.Default.NullOrEmpty);
            }

            var Ten_vat_tu = gridView.GetRowCellValue(e.RowHandle, colTen_vat_tu);

            if (Ten_vat_tu == null || Ten_vat_tu.ToString().Trim() == "")
            {
                bError = true;
                gridView.SetColumnError(colTen_vat_tu, Properties.Settings.Default.NullOrEmpty);
            }

            if (bError)
            {
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ledLoaiVatTu_EditValueChanged(object sender, EventArgs e)
        {
            Entities db = new Entities();
            var ID_loai_vat_tu = int.Parse(ledLoaiVatTu.EditValue.ToString());
            VatTuCtrl.LoadBindingSource(sTOVatTuBindingSource, ID_loai_vat_tu, db);

            string[] Ma_nhom = { "NAN", "PROFILE" };

            var result = (from p in db.STO_LoaiVatTu
                              join p1 in db.STO_NhomVatTu on p.ID_nhom_vat_tu equals p1.ID_nhom_vat_tu 
                                  where p.ID_loai_vat_tu == ID_loai_vat_tu && Ma_nhom.Contains(p.Ma_loai_vat_tu)
                              select p).ToList();
            if (result.Any())
            {
                gridView.Columns["Don_vi"].Visible = true;
                gridView.Columns["Don_vi"].VisibleIndex = 2;
            }
            else
            {
                gridView.Columns["Don_vi"].Visible = false;
            }

            GridHelper.BestFitAllColumns(gridView);
        }

        private void ledKhoVatTu_EditValueChanged(object sender, EventArgs e)
        {
            NhomVatTuCtrl.LoadLookUpEdit(ledNhomVatTu, (int)ledKhoVatTu.EditValue ,null);
        }

        private void ledNhomVatTu_EditValueChanged(object sender, EventArgs e)
        {
            LoaiVatTuCtrl.LoadLookUpEdit(ledLoaiVatTu, (int)ledNhomVatTu.EditValue, null);
        }
    }
}