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
    
    public partial class phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public phong()
        {
            this.bangthuephongs = new HashSet<bangthuephong>();
            this.phongvattus = new HashSet<phongvattu>();
        }
    
        public string id { get; set; }
        public string ten { get; set; }
        public string idloai { get; set; }
        public string idtinhtrang { get; set; }
        public Nullable<System.DateTime> ktphucvu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bangthuephong> bangthuephongs { get; set; }
        public virtual loaiphong loaiphong { get; set; }
        public virtual tinhtrang tinhtrang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phongvattu> phongvattus { get; set; }
    }
}
