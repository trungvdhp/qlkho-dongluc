using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Controllers
{
    public class PhieuNhapCtrl
    {
        public static void LoadBindingSource(BindingSource bs, QuanLyKhoDongLucEntities db = null)
        {
            if(db == null) db = new QuanLyKhoDongLucEntities();
            bs.DataSource = db.IMP_PhieuNhap.ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.IMP_PhieuNhap.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("", ""));

            lookUpEdit.Properties.DisplayMember = "";
            lookUpEdit.Properties.ValueMember = "";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn phiếu nhập";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, QuanLyKhoDongLucEntities db = null)
        {
            if (db == null) db = new QuanLyKhoDongLucEntities();

            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource = db.ViewCboVatTu.ToList();
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("", ""));

            gridLookUpEdit.Properties.DisplayMember = "";
            gridLookUpEdit.Properties.ValueMember = "";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.NullValuePrompt = "Chọn phiếu nhập";
            gridLookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }

        public static int Insert(object ID_nhan_vien_nhap, object ID_nha_cung_cap, object ID_kho, object So_chung_tu_goc, object Ngay_nhap, object Ghi_chu, int ID_nguoi_sua, object ID_nhan_vien_lap = null, int Trang_thai = 0, int ID_loai_nhap = 1, QuanLyKhoDongLucEntities db = null)
        {
            if (ID_kho == null || Ngay_nhap == null) return 0;

            if (db == null) db = new QuanLyKhoDongLucEntities();

            var entity = new IMP_PhieuNhap();

            entity.ID_kho = (int)ID_kho;
            entity.Ngay_nhap = (DateTime)Ngay_nhap;
            entity.ID_nguoi_sua = ID_nguoi_sua;
            entity.Ngay_sua = DateTime.Now;
            entity.Trang_thai = Trang_thai;
            entity.ID_loai_nhap = ID_loai_nhap;

            if (ID_loai_nhap == 2)
            {
                entity.ID_nha_cung_cap = null;
                entity.So_chung_tu_goc = null;
            }
            else
            {
                if (ID_nha_cung_cap != null) entity.ID_nha_cung_cap = (int)ID_nha_cung_cap;
                if (So_chung_tu_goc != null) entity.So_chung_tu_goc = So_chung_tu_goc.ToString();
            }

            if (ID_nhan_vien_lap != null) entity.ID_nhan_vien_lap = (int)ID_nhan_vien_lap;
            if (ID_nhan_vien_nhap != null) entity.ID_nhan_vien_nhap = (int)ID_nhan_vien_nhap;
            if (Ghi_chu != null) entity.Ghi_chu = Ghi_chu.ToString();

            var pn = (IMP_PhieuNhap)db.IMP_PhieuNhap.Add(entity);
            db.SaveChanges();

            return pn.ID_phieu_nhap;
        }

        public static int AddDetails(int ID_phieu_nhap, GridView gridViewDetails, QuanLyKhoDongLucEntities db = null)
        {
            if(ID_phieu_nhap < 1) return 0;

            if (db == null) db = new QuanLyKhoDongLucEntities();

            int n = gridViewDetails.RowCount;

            for(int i = 0; i < n; i++)
            {
                IMP_PhieuNhapCT entity = (IMP_PhieuNhapCT)gridViewDetails.GetRow(i);

                if (entity == null || entity.ID_vat_tu == 0 || entity.So_luong == 0) continue;

                if (entity.ID_phieu_nhap == 0)
                {
                    //Thêm mới
                    entity.ID_phieu_nhap = ID_phieu_nhap;
                    db.IMP_PhieuNhapCT.Add(entity);
                }
                else
                {
                    //Cập nhật
                    var item = db.IMP_PhieuNhapCT.FirstOrDefault(t => t.ID_phieu_nhap == entity.ID_phieu_nhap && t.ID_vat_tu == entity.ID_vat_tu);
                    if (item != null)
                    {
                        item = entity;
                    }
                }
            }

            return db.SaveChanges();
        }

        //public static int Update(object ID_vat_tu, object ID_loai_vat_tu, object Ten_vat_tu, object Ma_vat_tu, object Don_vi, object Mo_ta, QuanLyKhoDongLucEntities db = null)
        //{
        //    if (ID_vat_tu == null || ID_loai_vat_tu == null || Ten_vat_tu == null) return 0;

        //    if (db == null) db = new QuanLyKhoDongLucEntities();

        //    int id = (int)ID_vat_tu;
        //    var entity = db.STO_VatTu.FirstOrDefault(p => p.ID_vat_tu == id);

        //    if (entity == null) return 0;

        //    entity.ID_loai_vat_tu = (int)ID_loai_vat_tu;
        //    entity.Ten_vat_tu = Ten_vat_tu.ToString().Trim();

        //    if (Ma_vat_tu != null) entity.Ma_vat_tu = Ma_vat_tu.ToString().Trim();

        //    if (Don_vi != null)
        //    {
        //        double dv;
        //        double.TryParse(Don_vi.ToString(), out dv);
        //        if (dv == 0)
        //            entity.Don_vi = null;
        //        else
        //            entity.Don_vi = dv;
        //    }
        //    else
        //    {
        //        entity.Don_vi = null;
        //    }

        //    if (Mo_ta != null) entity.Mo_ta = Mo_ta.ToString().Trim();

        //    return db.SaveChanges();
        //}

        //public static int Delete(object ID_vat_tu, QuanLyKhoDongLucEntities db = null)
        //{
        //    if (ID_vat_tu == null) return 0;

        //    if (db == null) db = new QuanLyKhoDongLucEntities();

        //    int id = (int)ID_vat_tu;
        //    var entity = db.STO_VatTu.FirstOrDefault(p => p.ID_vat_tu == id);

        //    if (entity == null) return 0;

        //    db.STO_VatTu.Remove(entity);

        //    return db.SaveChanges();
        //}
    }
}
