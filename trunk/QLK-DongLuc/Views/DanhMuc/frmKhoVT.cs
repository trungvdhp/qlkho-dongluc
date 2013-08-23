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
    public partial class frmKhoVT : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoVT()
        {
            InitializeComponent();
        }

        private void frmKhoVatTu_Load(object sender, EventArgs e)
        {
            Entities db = new Entities();
            try
            {
                KhoVatTuCtrl.LoadBindingSource(sTOKhoVatTuBindingSource, db);
                KhoVatTuCtrl.LoadLookUpEdit(lookUpEdit, db);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            GridHelper.ConfigGridView(grvKhoVatTu, null, null, false);
            GridHelper.HAlignmentAllHeaderColumns(grvKhoVatTu);
            GridHelper.BestFitAllColumns(grvKhoVatTu);
            //VatTuCtrl.LoadLookUpEdit(rleVatTu, db);
            VaiTroQuyenCtrl.ReconfigFormControls(this, db);
            GridHelper.ReconfigGridView(grvKhoVatTu);
            //GridHelper.ReconfigGridView(grvKhoVatTuCT);
        }

        private void grvKhoVatTu_Load()
        {
            KhoVatTuCtrl.LoadBindingSource(sTOKhoVatTuBindingSource);
        }

        private void grvKhoVatTuCT_Load()
        {
            STO_KhoVatTu kho = (STO_KhoVatTu)grvKhoVatTu.GetFocusedRow();

            if (kho != null)
                KhoVatTuCTCtrl.LoadBindingSource(sTOKhoVatTuCTBindingSource, kho.ID_kho);
        }

        private void InsertKhoVatTu()
        {
            var kho = (STO_KhoVatTu)grvKhoVatTu.GetFocusedRow();
            int rs = KhoVatTuCtrl.Insert(kho);

            if(rs == 0)
            {
                NotifyHelper.ShowInsertError();
                grvKhoVatTu_Load();
            }
        }

        private void UpdateKhoVatTu()
        {
            var kho = (STO_KhoVatTu)grvKhoVatTu.GetFocusedRow();
            int rs = KhoVatTuCtrl.Update(kho);

            if (rs == 0)
            {
                NotifyHelper.ShowUpdateError();
                grvKhoVatTu_Load();
            }
        }

        private void DeleteKhoVatTu()
        {
            if (grvKhoVatTu.FocusedRowHandle < 0) return;

            var result = NotifyHelper.ShowDeleteConfirm();

            if (result == DialogResult.Yes)
            {
                var kho = (STO_KhoVatTu)grvKhoVatTu.GetFocusedRow();
                int rs = KhoVatTuCtrl.Delete(kho.ID_kho);

                if (rs > 0)
                {
                    grvKhoVatTu_Load();
                }
                else
                {
                    NotifyHelper.ShowDeleteError();
                }
            }
        }

        private void grvKhoVatTu_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;

            var Ten_kho = grvKhoVatTu.GetRowCellValue(e.RowHandle, colTen_kho);

            if (Ten_kho == null || Ten_kho.ToString().Trim() == "")
            {
                bError = true;
                grvKhoVatTu.SetColumnError(colTen_kho, Properties.Settings.Default.NullOrEmpty);
            }

            if (bError)
            {
                e.Valid = false;
                return;
            }

            if (grvKhoVatTu.IsNewItemRow(e.RowHandle))
            {
                InsertKhoVatTu();
            }
            else
            {
                UpdateKhoVatTu();
            }
        }       

        private void grdKhoVatTu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && grvKhoVatTu.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing && grvKhoVatTu.OptionsBehavior.AllowDeleteRows == DevExpress.Utils.DefaultBoolean.True)
            {
                DeleteKhoVatTu();
            }

            if (e.KeyCode == Keys.Enter && grvKhoVatTu.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                grvKhoVatTu.CloseEditor();
                grvKhoVatTu.UpdateCurrentRow();
            }

            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.P)
            {
                if (!grdKhoVatTu.IsPrintingAvailable)
                {
                    NotifyHelper.ShowPrintError();
                }

                grdKhoVatTu.ShowPrintPreview();
            }
        }

        private void grvKhoVatTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            grvKhoVatTuCT_Load();
        }

        private void frmKhoVT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ID_kho = (int)lookUpEdit.EditValue;
            Properties.Settings.Default.Save();
        }
    }
}