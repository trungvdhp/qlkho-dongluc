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
    
    public partial class LoaiVatTu
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public int MaNhom { get; set; }
    
        public virtual NhomVatTu NhomVatTu { get; set; }
    }
}