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
        public static string GetNextCode(object date, Entities db = null)
        {
            if (db == null) db = new Entities();

            DateTime d;

            if(date == null || date.Equals("")) 
                d = KetNoiCSDLCtrl.GetDatabaseDate();
            else
                d = (DateTime)date;

            var countPN = db.IMP_PhieuNhap.Count(t => t.Ngay_nhap.Year == d.Year && t.Ngay_nhap.Month == d.Month) + 1;

            return string.Format("{0:yyyyMM}{1:00}", date, countPN);
        }

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
            lookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
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
            gridLookUpEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.True;
        }

        public static int Insert(object ID_nhan_vien_nhap, object ID_nha_cung_cap, object ID_kho, object So_chung_tu_goc, object Ngay_nhap, object Ghi_chu, int ID_loai_nhap = 1, Entities db = null)
        {
            if (ID_kho == null || Ngay_nhap == null) return 0;

            if (db == null) db = new Entities();

            var entity = new IMP_PhieuNhap();

            if(ID_kho != null) 
                entity.ID_kho = (int)ID_kho;

            if(Ngay_nhap != null)
                entity.Ngay_nhap = (DateTime)Ngay_nhap;

            entity.ID_nguoi_sua = Program.CurrentUser.ID_nguoi_dung;
            entity.Ngay_sua = KetNoiCSDLCtrl.GetDatabaseDate();
            entity.Trang_thai = 0;
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

            entity.ID_nhan_vien_lap = Program.CurrentUser.ID_nhan_vien;

            if (ID_nhan_vien_nhap != null) entity.ID_nhan_vien_nhap = (int)ID_nhan_vien_nhap;

            if (Ghi_chu != null) entity.Ghi_chu = Ghi_chu.ToString();

            var pn = (IMP_PhieuNhap)db.IMP_PhieuNhap.Add(entity);
            db.SaveChanges();

            return pn.ID_phieu_nhap;
        }

        public static int AddDetails(int ID_phieu_nhap, int Trang_thai, GridView gridViewDetails, Entities db = null)
        {
            if(ID_phieu_nhap < 1) return 0;

            if (db == null) db = new Entities();

            int n = gridViewDetails.RowCount;
            var pn = db.IMP_PhieuNhap.FirstOrDefault(t => t.ID_phieu_nhap == ID_phieu_nhap);

            for(int i = 0; i < n; i++)
            {
                IMP_PhieuNhapCT entity = (IMP_PhieuNhapCT)gridViewDetails.GetRow(i);

                if (entity == null || entity.ID_vat_tu == 0 || entity.So_luong == 0) continue;

                entity.ID_phieu_nhap = ID_phieu_nhap;
                db.IMP_PhieuNhapCT.Add(entity);

                // Cập nhật vật tư và số lượng vào kho
                if (pn.Trang_thai == 0 && Trang_thai == 1)
                {
                    // Kiểm tra xem trong kho có vật tư trong phiếu nhập chi tiết hay không
                    var vt = db.STO_KhoVatTuCT.FirstOrDefault(t => t.ID_kho == pn.ID_kho && t.ID_vat_tu == entity.ID_vat_tu);

                    if (vt == null)
                    {
                        // Vật tư này trong kho hiện không có nên thêm vào
                        db.STO_KhoVatTuCT.Add(new STO_KhoVatTuCT
                        {
                            ID_kho = pn.ID_kho,
                            ID_vat_tu = entity.ID_vat_tu,
                            So_luong = entity.So_luong,
                            ID_phieu_nhap = entity.ID_phieu_nhap
                        });
                    }
                    else
                    {
                        // Trong kho đã có vật tư này nên cập nhật số lượng 
                        vt.So_luong +=  entity.So_luong;
                        vt.ID_phieu_nhap = entity.ID_phieu_nhap;
                    }
                }
            }

            pn.Trang_thai = Trang_thai;

            return db.SaveChanges();
        }

        // Thêm chi tiết của phiếu nhập cửa cuốn AustDoor
        public static int AddDetails(int ID_phieu_nhap, int Trang_thai, GridView gridViewDetails, int ID_than_cua, double Chieu_dai_cua, double Chieu_rong_cua, int ID_mo_to, Entities db = null)
        {
            if (ID_phieu_nhap < 1) return 0;

            if (db == null) db = new Entities();

            int n = gridViewDetails.RowCount;
            var pn = db.IMP_PhieuNhap.FirstOrDefault(t => t.ID_phieu_nhap == ID_phieu_nhap);
            List<IMP_PhieuNhapCT> list = new List<IMP_PhieuNhapCT>();
            // Thêm thân cửa vào phiếu nhập chi tiết
            var than = new IMP_PhieuNhapCT
            {
                ID_phieu_nhap = ID_phieu_nhap,
                ID_vat_tu = ID_than_cua,
                So_luong = 1,
                Chieu_dai = Chieu_dai_cua,
                Chieu_rong = Chieu_rong_cua
            };

            list.Add(than);

            var moTo = new IMP_PhieuNhapCT
            {
                ID_phieu_nhap = ID_phieu_nhap,
                ID_vat_tu = ID_mo_to,
                So_luong = 1
            };

            list.Add(moTo);

            for (int i = 0; i < n; i++)
            {
                IMP_PhieuNhapCT entity = (IMP_PhieuNhapCT)gridViewDetails.GetRow(i);

                if (entity == null || entity.ID_vat_tu == 0 || entity.So_luong == 0) continue;

                entity.ID_phieu_nhap = ID_phieu_nhap;
                list.Add(entity);
            }

            n = list.Count;

            for (int i = 0; i < n; i++)
            {
                var entity = list[i];
                db.IMP_PhieuNhapCT.Add(entity);

                // Cập nhật vật tư và số lượng vào kho
                if (pn.Trang_thai == 0 && Trang_thai == 1)
                {
                    // Kiểm tra xem trong kho có vật tư trong phiếu nhập chi tiết hay không
                    var vt = db.STO_KhoVatTuCT.FirstOrDefault(t => t.ID_kho == pn.ID_kho && t.ID_vat_tu == entity.ID_vat_tu);

                    if (vt == null)
                    {
                        // Vật tư này trong kho hiện không có nên thêm vào
                        db.STO_KhoVatTuCT.Add(new STO_KhoVatTuCT
                        {
                            ID_kho = pn.ID_kho,
                            ID_vat_tu = entity.ID_vat_tu,
                            So_luong = entity.So_luong,
                            ID_phieu_nhap = entity.ID_phieu_nhap
                        });
                    }
                    else
                    {
                        // Trong kho đã có vật tư này nên cập nhật số lượng 
                        vt.So_luong += entity.So_luong;
                        vt.ID_phieu_nhap = entity.ID_phieu_nhap;
                    }
                }
            }

            pn.Trang_thai = Trang_thai;

            return db.SaveChanges();
        }

        public static int Update(int ID_phieu_nhap, GridView gridViewDetails, object ID_nhan_vien_nhap, object ID_nha_cung_cap, object ID_kho, object So_chung_tu_goc, object Ngay_nhap, object Ghi_chu, int ID_loai_nhap = 1, int Trang_thai = 0, Entities db = null)
        {
            if (db == null) db = new Entities();

            var pn = db.IMP_PhieuNhap.FirstOrDefault(t => t.ID_phieu_nhap == ID_phieu_nhap);

            if (pn == null) return 0;

            // Update Phieu nhap
            if (pn.Trang_thai != -1)
            {
                if (ID_kho == null || Ngay_nhap == null) return 0;

                if (pn.Trang_thai == 0 && ID_kho != null)
                    pn.ID_kho = (int)ID_kho;

                if (Ngay_nhap != null)
                    pn.Ngay_nhap = (DateTime)Ngay_nhap;

                pn.ID_nguoi_sua = Program.CurrentUser.ID_nguoi_dung;
                pn.Ngay_sua = KetNoiCSDLCtrl.GetDatabaseDate();
                //pn.ID_loai_nhap = ID_loai_nhap;

                if (ID_loai_nhap == 2)
                {
                    pn.ID_nha_cung_cap = null;
                    pn.So_chung_tu_goc = null;
                }
                else
                {
                    if (ID_nha_cung_cap != null) pn.ID_nha_cung_cap = (int)ID_nha_cung_cap;

                    if (So_chung_tu_goc != null) pn.So_chung_tu_goc = So_chung_tu_goc.ToString();
                }

                if (ID_nhan_vien_nhap != null) pn.ID_nhan_vien_nhap = (int)ID_nhan_vien_nhap;

                if (Ghi_chu != null) pn.Ghi_chu = Ghi_chu.ToString();
            }

            // Update details
            int n = gridViewDetails.RowCount;
            List<int> ct = new List<int>();

            // Thêm mới và cập nhật chi tiết
            for (int i = 0; i < n; i++)
            {
                IMP_PhieuNhapCT entity = (IMP_PhieuNhapCT)gridViewDetails.GetRow(i);

                if (entity == null || entity.ID_vat_tu == 0 || entity.So_luong == 0) continue;

                IMP_PhieuNhapCT item;
                item = pn.IMP_PhieuNhapCT.FirstOrDefault(t => t.ID_vat_tu == entity.ID_vat_tu);

                if (entity.ID_phieu_nhap == 0)
                    entity.ID_phieu_nhap = ID_phieu_nhap;

                if (item == null)
                {
                    // Thêm mới
                    item = db.IMP_PhieuNhapCT.Add(entity);
                }
                else
                {
                    //Cập nhật
                    item.So_luong = entity.So_luong;
                    item.Don_gia = entity.Don_gia;
                }

                ct.Add(item.ID_vat_tu);

                // Kiểm tra xem trong kho có vật tư trong phiếu nhập chi tiết hay không
                var vt = db.STO_KhoVatTuCT.FirstOrDefault(t => t.ID_kho == pn.ID_kho && t.ID_vat_tu == item.ID_vat_tu);

                // Cập nhật vật tư và số lượng vào kho
                if (pn.Trang_thai == 0 && Trang_thai == 1)
                {
                    if (vt == null)
                    {
                        // Vật tư này trong kho hiện không có nên thêm vào
                        db.STO_KhoVatTuCT.Add(new STO_KhoVatTuCT
                        {
                            ID_kho = pn.ID_kho,
                            ID_vat_tu = item.ID_vat_tu,
                            So_luong = item.So_luong
                        });
                    }
                    else
                    {
                        // Trong kho đã có vật tư này nên cập nhật số lượng 
                        vt.So_luong += item.So_luong;
                    }
                }

                // Xác thực thì cập nhật đơn giá nhập và phiếu nhập cuối và cập nhật tổng tiền vào kho
                if (pn.Trang_thai != -1 && Trang_thai == -1)
                {
                    pn.Tong_tien += (decimal)item.So_luong * (decimal)item.Don_gia;
                    vt.Don_gia_nhap = item.Don_gia;
                    vt.ID_phieu_nhap = item.ID_phieu_nhap;
                }
            }

            // Xóa các chi tiết không có trong danh sách chi tiết mới 
            if (pn.Trang_thai == 0 && Trang_thai == 0)
            {
                var tmp = pn.IMP_PhieuNhapCT.Where(t => !ct.Contains(t.ID_vat_tu));
                db.IMP_PhieuNhapCT.RemoveRange(tmp);
            }

            // Cập nhật trạng thái phiếu nhập
            pn.Trang_thai = Trang_thai;

            return db.SaveChanges();
        }

        /// <summary>
        /// Xóa phiếu nhập
        /// </summary>
        /// <param name="ID_phieu_nhap">ID phiếu nhập</param>
        /// <param name="db"></param>
        /// <returns>
        /// Trả về 0 nếu không tìm thấy phiếu nhập cần xóa hoặc có lỗi khi xóa phiếu nhập
        /// Trả về -1 nếu người dùng xóa một phiếu mà phiếu có trạng thái khác 0
        /// Trả về > 0 nếu xóa thành công.
        /// </returns>
        public static int Delete(int ID_phieu_nhap, Entities db = null)
        {
            if(db == null) db = new Entities();

            var entity = db.IMP_PhieuNhap.FirstOrDefault(t => t.ID_phieu_nhap == ID_phieu_nhap);

            // Trả về 0 nếu không tìm thấy phiếu nhập
            if (entity == null) 
                return 0;

            // Nếu trạng thái không phải là = 0 và ID nhân viên xóa khác với ID nhân viên lập thì trả về lỗi -1: ko xóa được
            if (entity.Trang_thai != 0 && Program.CurrentUser.ID_nhan_vien != entity.ID_nhan_vien_lap) 
                return -1;

            // Ngoài các trường hợp trên thì xóa được;
            db.IMP_PhieuNhapCT.RemoveRange(entity.IMP_PhieuNhapCT);
            db.IMP_PhieuNhap.Remove(entity);

            return db.SaveChanges();
        }
    }
}
