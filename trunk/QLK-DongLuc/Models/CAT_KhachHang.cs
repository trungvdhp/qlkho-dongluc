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
    
    public partial class CAT_KhachHang
    {
        public CAT_KhachHang()
        {
            this.CAT_SanPham = new HashSet<CAT_SanPham>();
        }
    
        public int ID_khach_hang { get; set; }
        public string Ho_dem { get; set; }
        public string Ten { get; set; }
        public string Dien_thoai { get; set; }
        public string Dia_chi { get; set; }
        public int ID_nhan_vien { get; set; }
    
        public virtual ICollection<CAT_SanPham> CAT_SanPham { get; set; }
    }
}
