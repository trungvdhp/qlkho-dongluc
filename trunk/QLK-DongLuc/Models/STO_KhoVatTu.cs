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
    
    public partial class STO_KhoVatTu
    {
        public STO_KhoVatTu()
        {
            this.CAT_NhanVien = new HashSet<CAT_NhanVien>();
            this.EXP_PhieuXuat = new HashSet<EXP_PhieuXuat>();
            this.IMP_PhieuNhap = new HashSet<IMP_PhieuNhap>();
            this.STO_KhoVatTuCT = new HashSet<STO_KhoVatTuCT>();
            this.STO_NhomVatTu = new HashSet<STO_NhomVatTu>();
            this.STO_TonDauKy = new HashSet<STO_TonDauKy>();
        }
    
        public int ID_kho { get; set; }
        public string Ma_kho { get; set; }
        public string Ten_kho { get; set; }
        public string Dia_diem { get; set; }
    
        public virtual ICollection<CAT_NhanVien> CAT_NhanVien { get; set; }
        public virtual ICollection<EXP_PhieuXuat> EXP_PhieuXuat { get; set; }
        public virtual ICollection<IMP_PhieuNhap> IMP_PhieuNhap { get; set; }
        public virtual ICollection<STO_KhoVatTuCT> STO_KhoVatTuCT { get; set; }
        public virtual ICollection<STO_NhomVatTu> STO_NhomVatTu { get; set; }
        public virtual ICollection<STO_TonDauKy> STO_TonDauKy { get; set; }
    }
}
