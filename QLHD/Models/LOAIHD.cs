//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLHD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOAIHD
    {
        public LOAIHD()
        {
            this.LOAI_HD_SUB = new HashSet<LOAI_HD_SUB>();
        }
    
        public int IDLOAI_HD { get; set; }
        public string TEN_LOAIHD { get; set; }
    
        public virtual ICollection<LOAI_HD_SUB> LOAI_HD_SUB { get; set; }
    }
}
