//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKho_DongLuc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_NguoiDung
    {
        public SYS_NguoiDung()
        {
            this.SYS_VaiTro = new HashSet<SYS_VaiTro>();
        }
    
        public int ID_nguoi_dung { get; set; }
        public Nullable<int> ID_nhan_vien { get; set; }
        public string Tai_khoan { get; set; }
        public string Mat_khau { get; set; }
        public string Ten_day_du { get; set; }
        public int Hoat_dong { get; set; }
        public Nullable<System.DateTime> Lan_dang_nhap_cuoi { get; set; }
        public Nullable<System.TimeSpan> Thoi_gian_cho { get; set; }
    
        public virtual ICollection<SYS_VaiTro> SYS_VaiTro { get; set; }
    }
}
