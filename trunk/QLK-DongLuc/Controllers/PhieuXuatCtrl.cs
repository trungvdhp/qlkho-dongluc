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
    class PhieuXuatCtrl
    {
        // load  data cho các đối tượng lưới
        public static void LoadBindingSource(BindingSource bs, Entities db = null)
        {
            if (db == null) db = new Entities();

            var user = Program.CurrentUser;

            if (user.ID_nhan_vien == null)
                bs.DataSource = db.EXP_PhieuXuat.OrderByDescending(t => t.Ngay_xuat).ToList();
            else
                bs.DataSource = db.EXP_PhieuXuat.Where(t => t.ID_nhan_vien == user.ID_nhan_vien).OrderByDescending(t => t.Ngay_xuat).ToList();
        }

        public static void LoadLookUpEdit(LookUpEdit lookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            lookUpEdit.Properties.Columns.Clear();
            lookUpEdit.Properties.DataSource = db.ViewCboVatTu.ToList();
            lookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("", ""));

            lookUpEdit.Properties.DisplayMember = "";
            lookUpEdit.Properties.ValueMember = "";
            lookUpEdit.Properties.NullText = "";
            lookUpEdit.ToolTip = lookUpEdit.Properties.NullValuePrompt = "Chọn phiếu xuất";
            lookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }

        public static void LoadLookUpEdit(RepositoryItemLookUpEdit gridLookUpEdit, Entities db = null)
        {
            if (db == null) db = new Entities();

            gridLookUpEdit.Properties.Columns.Clear();
            gridLookUpEdit.Properties.DataSource = db.EXP_PhieuXuat.ToList();
            gridLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("", ""));
            gridLookUpEdit.Properties.DisplayMember = "";
            gridLookUpEdit.Properties.ValueMember = "";
            gridLookUpEdit.Properties.NullText = "";
            gridLookUpEdit.Properties.NullValuePrompt = "Chọn phiếu xuất";
            gridLookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
        }
        //insert phiếu xuất
        public static int Insert(object Ma_hoa_don, object ID_loai_xuat, object ID_kho, object ID_san_pham, object ID_nhan_vien, object Ngay_xuat, decimal Tong_tien,Object Ghi_chu, Object Trang_thai,Object ID_nguoi_sua, Entities db = null)
        {
            if (ID_kho == null || Ngay_xuat == null) return 0;

            if (db == null) db = new Entities();
            // tạo 1 đối tượng kiểu phiếu xuất
            var entity = new EXP_PhieuXuat();
            
            // gán các thuộc tính cho đối tượng, ID_loai_xuat=1 => xuất cho sản phẩm, ID_loai_xuat=2 => xuất thanh lý
            entity.Ma_hoa_don = Ma_hoa_don.ToString();
            entity.ID_loai_xuat = (int)ID_loai_xuat;
            entity.ID_kho = (int)ID_kho;
            if ((int)ID_loai_xuat == 2)
            {
                entity.ID_san_pham = null;
            }
            else if (ID_san_pham != null)
            {
                entity.ID_san_pham = (int?)ID_san_pham;
            }
            else
            {
                entity.ID_san_pham = null;
            }
            entity.ID_nhan_vien = (int)ID_nhan_vien;
            entity.Ngay_xuat = (DateTime)Ngay_xuat;
            entity.Tong_tien = Tong_tien;
            entity.Ghi_chu = Ghi_chu.ToString();
            entity.Trang_thai = (int)Trang_thai;
            entity.Ngay_sua = DateTime.Now;
            entity.ID_nguoi_sua = (int)ID_nguoi_sua;
           // add đôi tượng khởi tạo và trong model
            string st = "Ma hoa don:" + entity.Ma_hoa_don+"Loai xuat:"+entity.ID_loai_xuat+"Ngay xuat:"+entity.Ngay_xuat+"tong tien: "+entity.Tong_tien;
            var result = (EXP_PhieuXuat)db.EXP_PhieuXuat.Add(entity);
            // lưu lại sự thay đổi vào trong csdl
            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show(st);
            }
            // trả lại mã phiếu xuất.
            return result.ID_phieu_xuat;
        }
        // thêm chi tiết phiếu xuất
        public static int AddDetails(int ID_phieu_xuat, GridView gridViewDetails, Entities db = null)
        {
            if (ID_phieu_xuat < 1) return 0;

            if (db == null) db = new Entities();

            int n = gridViewDetails.RowCount;

            for (int i = 0; i < n; i++)
            {
                EXP_PhieuXuatCT entity = (EXP_PhieuXuatCT)gridViewDetails.GetRow(i);

                if (entity == null || entity.ID_vat_tu == 0 || entity.So_luong == 0 ) continue;

                if (entity.ID_phieu_xuat == 0)
                {
                    //Thêm mới chi tiết
                    entity.ID_phieu_xuat = ID_phieu_xuat;
                    db.EXP_PhieuXuatCT.Add(entity);
                }
                else
                {
                    //Cập nhật
                    var item = db.EXP_PhieuXuatCT.FirstOrDefault(t => t.ID_phieu_xuat == entity.ID_phieu_xuat && t.ID_vat_tu == entity.ID_vat_tu);
                    if (item != null)
                    {
                        item = entity;
                    }
                }
            }

            return db.SaveChanges();
        }

        /// <summary>
        /// Xóa phiếu xuất
        /// </summary>
        /// <param name="ID_phieu_nhap">ID phiếu nhập</param>
        /// <param name="db"></param>
        /// <returns>
        /// Trả về 0 nếu không tìm thấy phiếu nhập cần xóa hoặc có lỗi khi xóa phiếu nhập
        /// Trả về -1 nếu người dùng xóa một phiếu mà phiếu đó đã bị giám đốc khóa hoặc phiếu đó không do người dùng tạo hoặc 
        /// Trả về -2 nếu người dùng là giám đốc mà phiếu cần xóa đã được xác thực không thể xóa
        /// Trả về > 0 nếu xóa thành công.
        /// </returns>
        public static int Delete(int ID_phieu_xuat, Entities db = null)
        {
            if (db == null) db = new Entities();

            var entity = db.EXP_PhieuXuat.FirstOrDefault(t => t.ID_phieu_xuat == ID_phieu_xuat);

            if (entity == null)
                return 0;

            if (entity.Trang_thai == -1)
                return -1;

            // Nếu là nhân viên và phiếu cần xóa bị khóa hoặc nhân viên hiện tại không phải là người lập phiếu
            if (Program.CurrentUser.ID_nhan_vien != null)
            {
                if (entity.Trang_thai == 1 || Program.CurrentUser.ID_nhan_vien != entity.ID_nhan_vien)
                    return -2;
            }

            // Ngoài các trường hợp trên thì xóa được;
            db.EXP_PhieuXuatCT.RemoveRange(entity.EXP_PhieuXuatCT);
            db.EXP_PhieuXuat.Remove(entity);
            return db.SaveChanges();
        }

        //public static int Insert_(object Ngay_xuat,Entities db = null)
        //{
            
        //    var entity = new EXP_PhieuXuat();

        //    // gán các thuộc tính cho đối tượng, ID_loai_xuat=1 => xuất cho sản phẩm, ID_loai_xuat=2 => xuất thanh lý
        //    entity.Ma_hoa_don = "HDX001";
        //    entity.ID_loai_xuat = 1;
        //    entity.ID_kho = 3;
        //    entity.ID_san_pham = 2;
        //    entity.ID_nhan_vien = 1;
        //    entity.Ngay_xuat = (DateTime)Ngay_xuat;
        //    entity.Tong_tien = 0;
        //    entity.Ghi_chu = "Ghi chú";
        //    entity.Trang_thai = 1;
        //    entity.Ngay_sua = DateTime.Now;
        //    entity.ID_nguoi_sua = 1;
        //    // add đôi tượng khởi tạo và trong model
        //    var result = (EXP_PhieuXuat)db.EXP_PhieuXuat.Add(entity);
        //    // lưu lại sự thay đổi vào trong csdl
        //    db.SaveChanges();
        //    // trả lại mã phiếu xuất.
        //    return result.ID_phieu_xuat;
        //}

    }
}

