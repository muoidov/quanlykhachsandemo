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
    
    public partial class trangthaithuephong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trangthaithuephong()
        {
            this.bangthuephongs = new HashSet<bangthuephong>();
        }
    
        public int id { get; set; }
        public string ten { get; set; }
        public Nullable<int> roll { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bangthuephong> bangthuephongs { get; set; }
    }
}
