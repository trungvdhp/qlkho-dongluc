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
        bool haveInsert = false;

        public frmKhoVatTu()
        {
            InitializeComponent();
        }
        private void Load_gridControl()
        {
            var list = db.STO_KhoVatTu.ToList();
            sTOKhoVatTuBindingSource.DataSource = list;
        }

        private void frmKhoVatTu_Load(object sender, EventArgs e)
        {
            Load_gridControl();
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
                sError += "Vui long điền tên kho. ";
            }

            if (bError)
            {
                e.Valid = false;
                MessageBox.Show(sError);
                return;
            }

            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view.IsNewItemRow(e.RowHandle))
            {
                string Ten_kho = gridView.GetRowCellValue(e.RowHandle, "Ten_kho").ToString().Trim();
                string Dia_diem = gridView.GetRowCellValue(e.RowHandle, "Ten_kho").ToString().Trim();

                db.STO_KhoVatTu.Add(new STO_KhoVatTu { Ten_kho = Ten_kho, Dia_diem = Dia_diem });

                if (db.SaveChanges() > 0)
                    MessageBox.Show("Thêm dữ liệu thành công.");

                Load_gridControl();
            }
            else
            {
                int ID_kho = int.Parse(gridView.GetRowCellValue(e.RowHandle, "ID_kho").ToString().Trim());
                var kho = db.STO_KhoVatTu.Where(p => p.ID_kho == ID_kho).First();
                kho.Ten_kho = gridView.GetRowCellValue(e.RowHandle, "Ten_kho").ToString().Trim();
                kho.Dia_diem = gridView.GetRowCellValue(e.RowHandle, "Dia_diem").ToString().Trim();
                
                if (db.SaveChanges() > 0)
                    MessageBox.Show("Sửa dữ liệu thành công.");

                Load_gridControl();
            }
        }

        private void DeleteCommand()
        {
            if (gridView.FocusedRowHandle < 0) return;

            var result = XtraMessageBox.Show("Chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int ID_kho = int.Parse(gridView.GetRowCellValue(gridView.FocusedRowHandle, "ID_kho").ToString().Trim());
            var kho = db.STO_KhoVatTu.Where(p => p.ID_kho == ID_kho).First();
            db.STO_KhoVatTu.Remove(kho);

            if (db.SaveChanges() > 0)
                MessageBox.Show("Xóa dữ liệu thành công.");

            Load_gridControl();
        }

        private void gridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gridView.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                DeleteCommand();

                //gridView.ShowPrintPreview(this);
            }
        }
    }
}