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
    public partial class frmKhoVatTu : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoVatTu()
        {
            InitializeComponent();
        }

        private void frmKhoVatTu_Load(object sender, EventArgs e)
        {
            Entities db = new Entities();
            KhoVatTuCtrl.LoadBindingSource(sTOKhoVatTuBindingSource, db);
            VatTuCtrl.LoadLookUpEdit(rleVatTu, db);
            VaiTroQuyenCtrl.ReconfigFormControls(this, db);
            GridHelper.ReconfigGridView(grvKhoVatTu);
            GridHelper.ReconfigGridView(grvKhoVatTuCT);
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

        private void UpdateKhoVatTuCT()
        {
            STO_KhoVatTuCT khoCT = (STO_KhoVatTuCT)grvKhoVatTuCT.GetFocusedRow();
            var rs = KhoVatTuCTCtrl.Update(khoCT);

            if (rs == 0)
            {
                NotifyHelper.ShowUpdateError();
                grvKhoVatTuCT_Load();
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

        private void grvKhoVatTuCT_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            STO_KhoVatTuCT kho = (STO_KhoVatTuCT)grvKhoVatTuCT.GetFocusedRow();

            if (kho.STO_VatTu.STO_LoaiVatTu.Ma_loai_vat_tu == "NAN")
            {
                bool bError = false;
                string sError = "";

                var Don_gia_nhap = grvKhoVatTuCT.GetRowCellValue(e.RowHandle, colDon_gia_nhap);

                if (Don_gia_nhap != null)
                {
                    bError = true;
                    grvKhoVatTuCT.SetColumnError(colDon_gia_nhap, "Không nhập đơn giá nhập cho vật tư loại NAN");
                }

                var Don_gia_xuat = grvKhoVatTuCT.GetRowCellValue(e.RowHandle, colDon_gia_xuat);

                if (Don_gia_xuat != null)
                {
                    bError = true;
                    grvKhoVatTuCT.SetColumnError(colDon_gia_xuat, "Không nhập đơn giá xuất cho vật tư loại NAN");
                }

                if (bError)
                {
                    e.Valid = false;
                    return;
                }
            }

            if (grvKhoVatTuCT.IsNewItemRow(e.RowHandle))
            {
            }
            else
            {
                UpdateKhoVatTuCT();
            }
        }

        private void grdKhoVatTuCT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && grvKhoVatTuCT.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle)
            {
                grvKhoVatTuCT.CloseEditor();
                grvKhoVatTuCT.UpdateCurrentRow();
            }

            if (e.KeyCode == Keys.Control | e.KeyCode == Keys.P)
            {
                if (!grdKhoVatTuCT.IsPrintingAvailable)
                {
                    NotifyHelper.ShowPrintError();
                }

                grdKhoVatTuCT.ShowPrintPreview();
            }
        }

        private void grvKhoVatTuCT_DoubleClick(object sender, EventArgs e)
        {
            STO_KhoVatTuCT kho = (STO_KhoVatTuCT)grvKhoVatTuCT.GetFocusedRow();

            if (kho.ID_phieu_nhap != null)
            {
                QuanlyKho.QuanLyNhap.frmSuaPhieuNhap frm = new QuanlyKho.QuanLyNhap.frmSuaPhieuNhap(kho.IMP_PhieuNhap);
                frm.ShowDialog();
            }
        }

        private void grdKhoVatTu_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (grvKhoVatTu.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
                    DeleteKhoVatTu();

                e.Handled = true;
            }
        }

        private void grvKhoVatTu_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void grvKhoVatTuCT_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
    }
}