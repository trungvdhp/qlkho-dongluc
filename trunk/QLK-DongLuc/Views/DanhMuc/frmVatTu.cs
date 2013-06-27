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

namespace QLK_DongLuc.Views.DanhMuc
{
    public partial class frmVatTu : DevExpress.XtraEditors.XtraForm
    {
        QuanLyKhoDongLucEntities db = new QuanLyKhoDongLucEntities();

        public frmVatTu()
        {
            InitializeComponent();
        }


        private void gridControl_Load()
        {
            sTOVatTuBindingSource.DataSource = db.STO_VatTu.ToList();
        }

        private void InsertCommand()
        {
            string Ten_vat_tu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten_vat_tu").ToString().Trim();
            int ID_loai = int.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_loai_vat_tu").ToString());
            string Don_vi = "";
            try
            {
                Don_vi = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Don_vi").ToString().Trim();
            }
            catch { }

            string Ghi_chu = "";
            try
            {
                Ghi_chu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Mo_ta").ToString().Trim();
            }
            catch { }

            db.STO_VatTu.Add(new STO_VatTu { Ten_vat_tu = Ten_vat_tu, ID_loai_vat_tu = ID_loai, Don_vi = (Don_vi != "") ? double.Parse(Don_vi) : (double?)null, Mo_ta = Ghi_chu });

            if (db.SaveChanges() > 0)
                XtraMessageBox.Show("Thêm dữ liệu thành công.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateCommand()
        {
            int ID = int.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_vat_tu").ToString().Trim());
            var vat_tu = db.STO_VatTu.Where(p => p.ID_vat_tu == ID).First();

            string Don_vi = "";
            try
            {
                Don_vi = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Don_vi").ToString().Trim();
            }
            catch { }

            vat_tu.Ten_vat_tu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten_vat_tu").ToString().Trim();
            vat_tu.ID_loai_vat_tu = int.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_loai_vat_tu").ToString());
            vat_tu.Don_vi = (Don_vi != "") ? double.Parse(Don_vi) : (double?)null;
            vat_tu.Mo_ta = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Mo_ta").ToString().Trim();

            if (db.SaveChanges() > 0)
                XtraMessageBox.Show("Sửa dữ liệu thành công.", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteCommand()
        {
            if (gridView.FocusedRowHandle < 0) return;

            var result = XtraMessageBox.Show("Chắc chắn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int ID = int.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_vat_tu").ToString().Trim());
            var vat_tu = db.STO_VatTu.Where(p => p.ID_vat_tu == ID).First();

            db.STO_VatTu.Remove(vat_tu);

            db.SaveChanges();
        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            gridControl_Load();
            sTOLoaiVatTuBindingSource.DataSource = db.STO_LoaiVatTu.ToList();
        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;
            string sError = "";

            if (gridView.GetRowCellValue(e.RowHandle, "Ten_vat_tu").ToString().Trim() == "")
            {
                bError = true;
                sError += "\nnChưa điền tên vật tư (Chủng loại). ";
            }

            if (gridView.GetRowCellValue(e.RowHandle, "ID_loai_vat_tu").Equals(0))
            {
                bError = true;
                sError += "\nChưa chọn loại vật tư. ";
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