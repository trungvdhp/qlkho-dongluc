//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLK_DongLuc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ViewPhieuXuat
    {
        public int ID_phieu_xuat { get; set; }
        public string Ma_hoa_don { get; set; }
        public int ID_loai_xuat { get; set; }
        public int ID_kho { get; set; }
        public Nullable<int> ID_san_pham { get; set; }
        public System.DateTime Ngay_xuat { get; set; }
        public int ID_nhan_vien { get; set; }
        public decimal Tong_tien { get; set; }
        public string Ghi_chu { get; set; }
        public int Trang_thai { get; set; }
        public Nullable<System.DateTime> Ngay_sua { get; set; }
        public Nullable<int> ID_nguoi_sua { get; set; }
        public string Ten_day_du { get; set; }
        public string Ten_san_pham { get; set; }
        public string Ten_loai_xuat { get; set; }
        public string Ten_kho { get; set; }
        public int Expr1 { get; set; }
        public string Ho_dem { get; set; }
        public string Ten { get; set; }
    }
}
