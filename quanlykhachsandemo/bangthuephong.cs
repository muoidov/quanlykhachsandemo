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
    
    public partial class bangthuephong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bangthuephong()
        {
            this.nguoiocungs = new HashSet<nguoiocung>();
        }
    
        public int id { get; set; }
        public string idphong { get; set; }
        public string idkhachhang { get; set; }
        public int idtrangthai { get; set; }
        public Nullable<System.DateTime> ngaydat { get; set; }
        public Nullable<System.DateTime> checkin { get; set; }
        public Nullable<System.DateTime> checkout { get; set; }
        public Nullable<int> soluongnguoilon { get; set; }
        public Nullable<int> soluongtreem { get; set; }
    
        public virtual khachhang khachhang { get; set; }
        public virtual trangthaithuephong trangthaithuephong { get; set; }
        public virtual phong phong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nguoiocung> nguoiocungs { get; set; }
        public virtual phanhoi phanhoi { get; set; }
        public virtual sudungdichvu sudungdichvu { get; set; }
    }
}
