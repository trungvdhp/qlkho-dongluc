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
    public partial class frmKhoVatTu : DevExpress.XtraEditors.XtraForm
    {
        QuanLyKhoDongLucEntities db = new QuanLyKhoDongLucEntities();

        public frmKhoVatTu()
        {
            InitializeComponent();
        }

        private void gridControl_Load()
        {
            sTOKhoVatTuBindingSource.DataSource = db.STO_KhoVatTu.ToList();
        }

        private void InsertCommand()
        {
            string Ten_kho = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten_kho").ToString().Trim();
            string Dia_diem = "";
            try
            {
                Dia_diem = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dia_diem").ToString().Trim();
            }
            catch { }

            db.STO_KhoVatTu.Add(new STO_KhoVatTu { Ten_kho = Ten_kho, Dia_diem = Dia_diem });

            if (db.SaveChanges() > 0)
                XtraMessageBox.Show("Thêm dữ liệu thành công.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateCommand()
        {
            int ID_kho = int.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_kho").ToString().Trim());
            var kho = db.STO_KhoVatTu.Where(p => p.ID_kho == ID_kho).First();
            kho.Ten_kho = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten_kho").ToString().Trim();
            kho.Dia_diem = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Dia_diem").ToString().Trim();

            if (db.SaveChanges() > 0)
                XtraMessageBox.Show("Sửa dữ liệu thành công.", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteCommand()
        {
            if (gridView.FocusedRowHandle < 0) return;

            var result = XtraMessageBox.Show("Chắc chắn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int ID_kho = int.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_kho").ToString().Trim());
            var kho = db.STO_KhoVatTu.Where(p => p.ID_kho == ID_kho).First();
            db.STO_KhoVatTu.Remove(kho);

            db.SaveChanges();
        }


        private void frmKhoVatTu_Load(object sender, EventArgs e)
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

            if (gridView.GetRowCellValue(e.RowHandle, "Ten_kho").ToString().Trim() == "")
            {
                bError = true;
                sError += "Vui lòng điền tên kho. ";
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