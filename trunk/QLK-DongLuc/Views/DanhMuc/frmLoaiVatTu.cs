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
    public partial class frmLoaiVatTu : DevExpress.XtraEditors.XtraForm
    {
        QuanLyKhoDongLucEntities db = new QuanLyKhoDongLucEntities();

        public frmLoaiVatTu()
        {
            InitializeComponent();
        }


        private void gridControl_Load()
        {
            sTOLoaiVatTuBindingSource.DataSource = db.STO_LoaiVatTu.ToList();
        }

        private void InsertCommand()
        {
            string Ten_loai = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten_loai_vat_tu").ToString().Trim();
            int ID_nhom = int.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_nhom_vat_tu").ToString());
            string Ghi_chu = "";
            try
            {
                Ghi_chu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ghi_chu").ToString().Trim();
            }
            catch { }

            db.STO_LoaiVatTu.Add(new STO_LoaiVatTu { Ten_loai_vat_tu = Ten_loai, ID_nhom_vat_tu = ID_nhom, Ghi_chu = Ghi_chu });

            if (db.SaveChanges() > 0)
                XtraMessageBox.Show("Thêm dữ liệu thành công.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateCommand()
        {
            int ID_loai = int.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_loai_vat_tu").ToString().Trim());
            var loai = db.STO_LoaiVatTu.Where(p => p.ID_loai_vat_tu == ID_loai).First();

            loai.Ten_loai_vat_tu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten_loai_vat_tu").ToString().Trim();
            loai.ID_nhom_vat_tu = int.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_nhom_vat_tu").ToString());
            loai.Ghi_chu = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ghi_chu").ToString().Trim();

            if (db.SaveChanges() > 0)
                XtraMessageBox.Show("Sửa dữ liệu thành công.", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteCommand()
        {
            if (gridView.FocusedRowHandle < 0) return;

            var result = XtraMessageBox.Show("Chắc chắn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int ID_loai = int.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_loai_vat_tu").ToString().Trim());
            var loai = db.STO_LoaiVatTu.Where(p => p.ID_loai_vat_tu == ID_loai).First();

            db.STO_LoaiVatTu.Remove(loai);

            db.SaveChanges();
        }

        private void frmLoaiVatTu_Load(object sender, EventArgs e)
        {
            gridControl_Load();
            sTONhomVatTuBindingSource.DataSource = db.STO_NhomVatTu.ToList();
        }

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;
            string sError = "";

            if (gridView.GetRowCellValue(e.RowHandle, "Ten_loai_vat_tu").ToString().Trim() == "")
            {
                bError = true;
                sError += "\nnChưa điền tên loại vật tư. ";
            }

            if (gridView.GetRowCellValue(e.RowHandle, "ID_nhom_vat_tu").Equals(0))
            {
                bError = true;
                sError += "\nChưa chọn nhóm vật tư. ";
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

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
    }
}