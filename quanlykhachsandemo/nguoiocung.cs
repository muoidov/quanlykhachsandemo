//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace quanlykhachsandemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class nguoiocung
    {
        public int id { get; set; }
        public int idbangthuephong { get; set; }
        public string idnguoiocung { get; set; }
    
        public virtual bangthuephong bangthuephong { get; set; }
        public virtual khachhang khachhang { get; set; }
    }
}
