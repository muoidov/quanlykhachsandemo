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
    
    public partial class dichvu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dichvu()
        {
            this.sudungdichvus = new HashSet<sudungdichvu>();
        }
    
        public int id { get; set; }
        public string ten { get; set; }
        public int idloai { get; set; }
        public Nullable<decimal> gia { get; set; }
        public Nullable<System.DateTime> bdphucvu { get; set; }
        public Nullable<System.DateTime> ktphucvu { get; set; }
    
        public virtual loaidichvu loaidichvu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sudungdichvu> sudungdichvus { get; set; }
    }
}
