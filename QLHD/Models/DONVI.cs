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
    
    public partial class DONVI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONVI()
        {
            this.HOPDONG_CHIPHI = new HashSet<HOPDONG_CHIPHI>();
            this.HOPDONG_DOANHTHU = new HashSet<HOPDONG_DOANHTHU>();
            this.HOPDONG_DT_CNTT = new HashSet<HOPDONG_DT_CNTT>();
            this.HOPDONG_NHANCONG = new HashSet<HOPDONG_NHANCONG>();
            this.QLDA_CNTT_TIENDO = new HashSet<QLDA_CNTT_TIENDO>();
        }
    
        public int DONVI_ID { get; set; }
        public string TEN_DV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG_CHIPHI> HOPDONG_CHIPHI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG_DOANHTHU> HOPDONG_DOANHTHU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG_DT_CNTT> HOPDONG_DT_CNTT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG_NHANCONG> HOPDONG_NHANCONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QLDA_CNTT_TIENDO> QLDA_CNTT_TIENDO { get; set; }
    }
}
