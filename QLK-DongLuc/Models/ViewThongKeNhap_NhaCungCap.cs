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
    
    public partial class ViewThongKeNhap_NhaCungCap
    {
        public int ID_phieu_nhap { get; set; }
        public string Ten_nha_cung_cap { get; set; }
        public System.DateTime Ngay_nhap { get; set; }
        public string So_chung_tu_goc { get; set; }
        public string Ten_vat_tu { get; set; }
        public double So_luong { get; set; }
        public Nullable<decimal> Don_gia { get; set; }
        public Nullable<double> Thanh_tien { get; set; }
    }
}