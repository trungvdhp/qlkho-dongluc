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

namespace QLK_DongLuc.Views.DanhMuc
{
    public partial class frmNhomVatTu : DevExpress.XtraEditors.XtraForm
    {
        Entities db = new Entities();

        public frmNhomVatTu()
        {
            InitializeComponent();
        }

        private void gridControl_Load()
        {
            sTONhomVatTuBindingSource.DataSource = db.STO_NhomVatTu.ToList();
        }

        private void InsertCommand()
        {
            string Ten_nhom_vat_tu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten_nhom_vat_tu").ToString().Trim();
            string Ghi_chu = "";
            try
            {
                Ghi_chu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ghi_chu").ToString().Trim();
            }
            catch { }

            db.STO_NhomVatTu.Add(new STO_NhomVatTu { Ten_nhom_vat_tu = Ten_nhom_vat_tu, Ghi_chu = Ghi_chu });

            if (db.SaveChanges() > 0)
                XtraMessageBox.Show("Thêm dữ liệu thành công.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateCommand()
        {
            int ID_nhom_Vat_tu = int.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_nhom_vat_tu").ToString().Trim());
            var nhom = db.STO_NhomVatTu.Where(p => p.ID_nhom_vat_tu == ID_nhom_Vat_tu).First();
            nhom.Ten_nhom_vat_tu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten_nhom_vat_tu").ToString().Trim();
            nhom.Ghi_chu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ghi_chu").ToString().Trim();

            if (db.SaveChanges() > 0)
                XtraMessageBox.Show("Sửa dữ liệu thành công.", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteCommand()
        {
            if (gridView.FocusedRowHandle < 0) return;

            var result = XtraMessageBox.Show("Chắc chắn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int ID_nhom_Vat_tu = int.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_nhom_vat_tu").ToString().Trim());
            var nhom = db.STO_NhomVatTu.Where(p => p.ID_nhom_vat_tu == ID_nhom_Vat_tu).First();
            db.STO_NhomVatTu.Remove(nhom);

            db.SaveChanges();
        }


        private void frmNhomVatTu_Load(object sender, EventArgs e)
        {
            gridControl_Load();
        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
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

            if (bError)
            {
                e.Valid = false;
                XtraMessageBox.Show(sError, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (view.IsNewItemRow(e.RowHandle))
            {
                InsertCommand();
                gridControl_Load();
            }
            else
            {
                UpdateCommand();
                gridControl_Load();
            }
        }

        private void gridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridView.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                DeleteCommand();
                gridControl_Load();
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
    }
}