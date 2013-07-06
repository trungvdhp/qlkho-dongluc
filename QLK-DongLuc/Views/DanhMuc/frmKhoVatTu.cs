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

namespace QLK_DongLuc.Views.DanhMuc
{
    public partial class frmKhoVatTu : DevExpress.XtraEditors.XtraForm
    {
        Entities db;

        public frmKhoVatTu()
        {
            InitializeComponent();
        }

        private void grvKhoVatTu_Load()
        {
            sTOKhoVatTuBindingSource.DataSource = db.STO_KhoVatTu.ToList();
        }

        private void InsertKhoVatTu()
        {
            string Ten_kho = grvKhoVatTu.GetRowCellValue(grvKhoVatTu.FocusedRowHandle, "Ten_kho").ToString().Trim();
            string Dia_diem = "";
            try
            {
                Dia_diem = grvKhoVatTu.GetRowCellValue(grvKhoVatTu.FocusedRowHandle, "Dia_diem").ToString().Trim();
            }
            catch { }

            db.STO_KhoVatTu.Add(new STO_KhoVatTu { Ten_kho = Ten_kho, Dia_diem = Dia_diem });

            if (db.SaveChanges() > 0)
                XtraMessageBox.Show("Thêm dữ liệu thành công.", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateKhoVatTu()
        {
            int ID_kho = int.Parse(grvKhoVatTu.GetRowCellValue(grvKhoVatTu.FocusedRowHandle, "ID_kho").ToString().Trim());
            var kho = db.STO_KhoVatTu.Where(p => p.ID_kho == ID_kho).First();
            kho.Ten_kho = grvKhoVatTu.GetRowCellValue(grvKhoVatTu.FocusedRowHandle, "Ten_kho").ToString().Trim();
            kho.Dia_diem = grvKhoVatTu.GetRowCellValue(grvKhoVatTu.FocusedRowHandle, "Dia_diem").ToString().Trim();

            if (db.SaveChanges() == 0)
                XtraMessageBox.Show("Sửa dữ liệu không thành công.", "Sửa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateKhoVatTuCT()
        {
            STO_KhoVatTuCT kho = (STO_KhoVatTuCT)grvKhoVatTuCT.GetFocusedRow();
            var rs = KhoVatTuCTCtrl.Update(kho, db);

            if (rs == 0)
            {
                XtraMessageBox.Show("Không có thay đổi đơn giá nào được cập nhật.", "Sửa đơn giá", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                KhoVatTuCTCtrl.LoadBindingSource(kho.ID_kho, sTOKhoVatTuCTBindingSource);
            }

        }

        private void DeleteKhoVatTu()
        {
            if (grvKhoVatTu.FocusedRowHandle < 0) return;

            var result = XtraMessageBox.Show("Chắc chắn xóa dữ liệu này?", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            int ID_kho = int.Parse(grvKhoVatTu.GetRowCellValue(grvKhoVatTu.FocusedRowHandle, "ID_kho").ToString().Trim());
            var kho = db.STO_KhoVatTu.Where(p => p.ID_kho == ID_kho).First();
            db.STO_KhoVatTu.Remove(kho);

            db.SaveChanges();
        }


        private void frmKhoVatTu_Load(object sender, EventArgs e)
        {
            db = new Entities();
            grvKhoVatTu_Load();
            VatTuCtrl.LoadLookUpEdit(repositoryItemLookUpEdit1);

            if (Program.CurrentUser.ID_nhan_vien != null)
            {
                grvKhoVatTu.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                colTen_kho.OptionsColumn.AllowEdit = false;
                colDia_diem.OptionsColumn.AllowEdit = false;
                colDon_gia_nhap.Visible = false;
                colDon_gia_xuat.OptionsColumn.AllowEdit = false;
            }
            
        }

        private void grvKhoVatTu_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void grvKhoVatTu_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool bError = false;
            string sError = "";

            if (grvKhoVatTu.GetRowCellValue(e.RowHandle, "Ten_kho").ToString().Trim() == "")
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
                InsertKhoVatTu();
                grvKhoVatTu_Load();
            }
            else
            {
                UpdateKhoVatTu();
                grvKhoVatTu_Load();
            }
        }       

        private void grdKhoVatTu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && grvKhoVatTu.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                DeleteKhoVatTu();
                grvKhoVatTu_Load();
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
                    XtraMessageBox.Show("Không thể in.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                grdKhoVatTu.ShowPrintPreview();
            }
        }

        private void grvKhoVatTu_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            STO_KhoVatTu kho = (STO_KhoVatTu)grvKhoVatTu.GetFocusedRow();

            if (kho != null)
               KhoVatTuCTCtrl.LoadBindingSource(kho.ID_kho, sTOKhoVatTuCTBindingSource);
        }

        private void grvKhoVatTuCT_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
           

            if (Program.CurrentUser.ID_nhan_vien == null)
            {
                STO_KhoVatTuCT kho = (STO_KhoVatTuCT)grvKhoVatTuCT.GetFocusedRow();

                if (kho.STO_VatTu.STO_LoaiVatTu.Ten_loai_vat_tu.StartsWith("NAN"))
                {
                    bool bError = false;
                    string sError = "";

                    var Don_gia_nhap = grvKhoVatTuCT.GetRowCellValue(e.RowHandle, "Don_gia_nhap");

                    if (Don_gia_nhap != null)
                    {
                        bError = true;
                        sError += "\n Vui lòng không nhập đơn giá nhập cho vật tư loại NAN.";
                    }

                    var Don_gia_xuat = grvKhoVatTuCT.GetRowCellValue(e.RowHandle, "Don_gia_xuat");

                    if (Don_gia_xuat != null)
                    {
                        bError = true;
                        sError += "\n Vui lòng không nhập đơn giá xuất cho vật tư loại NAN.";
                    }

                    if (bError)
                    {
                        e.ErrorText = sError + "\n Bạn có muốn sửa lại không?\n";
                        e.Valid = false;
                        KhoVatTuCTCtrl.LoadBindingSource(kho.ID_kho, sTOKhoVatTuCTBindingSource);
                        //XtraMessageBox.Show(sError, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

                if (view.IsNewItemRow(e.RowHandle))
                {
                }
                else
                {
                    UpdateKhoVatTuCT();
                }
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
                    XtraMessageBox.Show("Không thể in.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                grdKhoVatTuCT.ShowPrintPreview();
            }
        }

        private void grvKhoVatTuCT_DoubleClick(object sender, EventArgs e)
        {
            STO_KhoVatTuCT kho = (STO_KhoVatTuCT)grvKhoVatTuCT.GetFocusedRow();

            if (kho.ID_phieu_nhap != null)
            {
                QuanlyKho.QuanLyNhap.frmSuaPhieuNhap frm = new QuanlyKho.QuanLyNhap.frmSuaPhieuNhap((int)kho.ID_phieu_nhap);
                frm.ShowDialog();
            }
        }
    }
}