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
    
    public partial class IMP_PhieuNhapCT
    {
        public int ID_phieu_nhap { get; set; }
        public int ID_vat_tu { get; set; }
        public double So_luong { get; set; }
        public Nullable<decimal> Don_gia { get; set; }
    
        public virtual IMP_PhieuNhap IMP_PhieuNhap { get; set; }
        public virtual STO_VatTu STO_VatTu { get; set; }
    }
}