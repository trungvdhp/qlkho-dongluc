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
            gridControl_Load();
            VaiTroQuyenCtrl.ReconfigFormControls(this);
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
            int rs =
                 NhomVatTuCtrl.Insert(
                     nhom.Ten_nhom_vat_tu,
                     nhom.Ghi_chu,
                     nhom.ID_kho
                );

            if (rs > 0)
                XtraMessageBox.Show("Thêm dữ liệu thành công.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("Thêm dữ liệu không thành công.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            gridControl_Load();
        }

        private void UpdateCommand()
        {
            var nhom = (STO_NhomVatTu)gridView.GetFocusedRow();
            int rs =
                NhomVatTuCtrl.Update(
                    nhom.ID_nhom_vat_tu,
                    nhom.Ten_nhom_vat_tu,
                    nhom.Ghi_chu,
                    nhom.ID_kho
                );

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

            var nhom = (STO_NhomVatTu)gridView.GetFocusedRow();

            if (NhomVatTuCtrl.Delete(nhom.ID_nhom_vat_tu) > 0)
                XtraMessageBox.Show("Xóa dữ liệu thành công.", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("Xóa dữ liệu không thành công.", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            gridControl_Load();
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;
            string sError = "";

            if (gridView.GetRowCellValue(e.RowHandle, "Ten_nhom_vat_tu").ToString().Trim() == "")
            {
                bError = true;
                sError += "Vui lòng điền tên nhóm vật tư. ";
            }

            var ID_kho = gridView.GetRowCellValue(e.RowHandle, "ID_kho");

            if (ID_kho == null)
            {
                bError = true;
                sError += "\n Chưa chọn kho vật tư. ";
            }

            if (bError)
            {
                e.ErrorText = sError + "\n Bạn có muốn sửa lại không?\n";
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
                    XtraMessageBox.Show("Not available printing.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}