//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLHD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class THOIHAN_TT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THOIHAN_TT()
        {
            this.HOPDONG_CHIPHI = new HashSet<HOPDONG_CHIPHI>();
            this.HOPDONG_DOANHTHU = new HashSet<HOPDONG_DOANHTHU>();
            this.HOPDONG_NHANCONG = new HashSet<HOPDONG_NHANCONG>();
            this.HOPDONG_DT_CNTT = new HashSet<HOPDONG_DT_CNTT>();
            this.HOPDONG_DT_CNTT1 = new HashSet<HOPDONG_DT_CNTT>();
        }
    
        public int THOIHAN_TT_ID { get; set; }
        public string TEN_THOIHAN_TT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG_CHIPHI> HOPDONG_CHIPHI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG_DOANHTHU> HOPDONG_DOANHTHU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG_NHANCONG> HOPDONG_NHANCONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG_DT_CNTT> HOPDONG_DT_CNTT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG_DT_CNTT> HOPDONG_DT_CNTT1 { get; set; }
    }
}
