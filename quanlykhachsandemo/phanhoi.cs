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
    
    public partial class phanhoi
    {
        public int idbangthuephong { get; set; }
        public Nullable<System.DateTime> ngay { get; set; }
        public string noidung { get; set; }
    
        public virtual bangthuephong bangthuephong { get; set; }
    }
}