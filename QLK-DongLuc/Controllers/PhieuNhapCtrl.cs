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
        public static void LoadBindingSource(BindingSource bs, Entities db = null)
        {
            if(db == null) db = new Entities();

            var user = Program.CurrentUser;

            if (user.ID_nhan_vien == null)
                bs.DataSource = db.ViewPhieuNhap.OrderByDescending(t => t.Ngay_nhap).ToList();
            else
                bs.DataSource = db.ViewPhieuNhap.Where(t => t.ID_nhan_vien_lap == user.ID_nhan_vien).OrderByDescending(t => t.Ngay_nhap).ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.IMP_PhieuNhap.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("", ""));

            lookUpEdit.Properties.DisplayMember = "";
            lookUpEdit.Properties.ValueMember = "";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn phiếu nhập";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource = db.ViewCboVatTu.ToList();
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("", ""));

            gridLookUpEdit.Properties.DisplayMember = "";
            gridLookUpEdit.Properties.ValueMember = "";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.NullValuePrompt = "Chọn phiếu nhập";
            gridLookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }

        public static int Insert(object ID_nhan_vien_nhap, object ID_nha_cung_cap, object ID_kho, object So_chung_tu_goc, object Ngay_nhap, object Ghi_chu, int ID_nguoi_sua, object ID_nhan_vien_lap = null, int ID_loai_nhap = 1, int Trang_thai = 0, Entities db = null)
        {
            if (ID_kho == null || Ngay_nhap == null) return 0;

            if (db == null) db = new Entities();

            var entity = new IMP_PhieuNhap();

            if(ID_kho != null) 
                entity.ID_kho = (int)ID_kho;
            if(Ngay_nhap != null)
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

        public static int AddDetails(int ID_phieu_nhap, GridView gridViewDetails, Entities db = null)
        {
            if(ID_phieu_nhap < 1) return 0;

            if (db == null) db = new Entities();

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

        public static int Update(int ID_phieu_nhap, object ID_nhan_vien_nhap, object ID_nha_cung_cap, object ID_kho, object So_chung_tu_goc, object Ngay_nhap, object Ghi_chu, int ID_nguoi_sua, int ID_loai_nhap = 1, int Trang_thai = 0, Entities db = null)
        {
            if (ID_kho == null || Ngay_nhap == null) return 0;

            if (db == null) db = new Entities();

            var entity = db.IMP_PhieuNhap.FirstOrDefault(t => t.ID_phieu_nhap == ID_phieu_nhap);

            if (entity == null) return 0;

            if(ID_kho != null)
                entity.ID_kho = (int)ID_kho;
            if(Ngay_nhap != null) 
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

            if (ID_nhan_vien_nhap != null) entity.ID_nhan_vien_nhap = (int)ID_nhan_vien_nhap;

            if (Ghi_chu != null) entity.Ghi_chu = Ghi_chu.ToString();

            return db.SaveChanges();
        }

        // Đang sửa
        public static int UpdateDetails(int ID_phieu_nhap, int Trang_thai, GridView gridViewDetails, Entities db = null)
        {
            if (ID_phieu_nhap < 1) return 0;

            if (db == null) db = new Entities();

            var pn = db.IMP_PhieuNhap.FirstOrDefault(t => t.ID_phieu_nhap == ID_phieu_nhap);

            if (pn == null) return 0;

            int n = gridViewDetails.RowCount;
            List<int> ct = new List<int>();

            // Thêm mới và cập nhật chi tiết
            for (int i = 0; i < n; i++)
            {
                IMP_PhieuNhapCT entity = (IMP_PhieuNhapCT)gridViewDetails.GetRow(i);

                if (entity == null || entity.ID_vat_tu == 0 || entity.So_luong == 0) continue;

                IMP_PhieuNhapCT item;

                if (entity.ID_phieu_nhap == 0)
                {
                    //Thêm mới
                    entity.ID_phieu_nhap = ID_phieu_nhap;
                    item = db.IMP_PhieuNhapCT.Add(entity);
                    ct.Add(item.ID_vat_tu);
                }
                else
                {
                    //Cập nhật
                    item = db.IMP_PhieuNhapCT.FirstOrDefault(t => t.ID_phieu_nhap == entity.ID_phieu_nhap && t.ID_vat_tu == entity.ID_vat_tu);

                    if (item != null)
                    {
                        item = entity;
                        ct.Add(item.ID_vat_tu);
                    }
                }
            }

            // Xóa các chi tiết không có trong danh sách chi tiết mới
            db.IMP_PhieuNhapCT.RemoveRange(pn.IMP_PhieuNhapCT.Where(t => !ct.Contains(t.ID_vat_tu)));

            // Cập nhật tổng tiền vào phiếu nhập
            pn.Tong_tien = (decimal)gridViewDetails.Columns["Thanh_tien"].SummaryItem.SummaryValue;

            // Cập nhật số lượng và đơn giá mới cho vật tư vào kho
            // Kiểm tra xem vật tư đã có trong kho hay chưa
            // Nếu có thì cập nhật số lượng và đơn giá mới
            // Nếu không có thì thêm vào

            // Cập nhật trạng thái phiếu nhập
            pn.Trang_thai = Trang_thai;


            return 0;
            //return db.SaveChanges();
        }

        public static int ChangeState(int ID_phieu_nhap, int Trang_thai, Entities db = null)
        {
            if (db == null) db = new Entities();

            var entity = db.IMP_PhieuNhap.FirstOrDefault(t => t.ID_phieu_nhap == ID_phieu_nhap);

            if (entity == null) return 0;

            entity.Trang_thai = Trang_thai;

            return db.SaveChanges();
        }

        /// <summary>
        /// Xóa phiếu nhập
        /// </summary>
        /// <param name="ID_phieu_nhap">ID phiếu nhập</param>
        /// <param name="db"></param>
        /// <returns>
        /// Trả về 0 nếu không tìm thấy phiếu nhập cần xóa hoặc có lỗi khi xóa phiếu nhập
        /// Trả về -1 nếu người dùng xóa một phiếu mà phiếu đó đã bị giám đốc khóa hoặc phiếu đó không do người dùng tạo hoặc 
        /// Trả về -2 nếu người dùng là giám đốc mà phiếu cần xóa đã được xác thực không thể xóa
        /// Trả về > 0 nếu xóa thành công.
        /// </returns>
        public static int Delete(int ID_phieu_nhap, Entities db = null)
        {
            if(db == null) db = new Entities();

            var entity = db.IMP_PhieuNhap.FirstOrDefault(t => t.ID_phieu_nhap == ID_phieu_nhap);

            if (entity == null) 
                return 0;

            if (entity.Trang_thai == -1) 
                return -1;

            // Nếu là nhân viên và phiếu cần xóa bị khóa hoặc nhân viên hiện tại không phải là người lập phiếu
            if(Program.CurrentUser.ID_nhan_vien != null)
            {
                if(entity.Trang_thai == 1 || Program.CurrentUser.ID_nhan_vien != entity.ID_nhan_vien_lap) 
                    return -2;
            }

            // Ngoài các trường hợp trên thì xóa được;
            db.IMP_PhieuNhapCT.RemoveRange(entity.IMP_PhieuNhapCT);
            db.IMP_PhieuNhap.Remove(entity);

            return db.SaveChanges();
        }
    }
}
