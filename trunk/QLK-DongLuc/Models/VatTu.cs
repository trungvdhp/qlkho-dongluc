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
    
    public partial class VatTu
    {
        public VatTu()
        {
            this.PhieuNhapCTs = new HashSet<PhieuNhapCT>();
        }
    
        public int MaVatTu { get; set; }
        public string TenVatTu { get; set; }
        public int MaLoai { get; set; }
        public Nullable<decimal> SoLuong { get; set; }
        public string DonVi { get; set; }
        public decimal DonGia { get; set; }
        public int MaKho { get; set; }
    
        public virtual ICollection<PhieuNhapCT> PhieuNhapCTs { get; set; }
    }
}