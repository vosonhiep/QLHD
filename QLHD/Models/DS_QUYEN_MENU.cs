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
    
    public partial class DS_QUYEN_MENU
    {
        public int ID { get; set; }
        public Nullable<int> ID_MENU_CON { get; set; }
        public Nullable<int> ID_MENU_CHA { get; set; }
        public Nullable<int> USER_ID { get; set; }
    
        public virtual MENU_CON MENU_CON { get; set; }
        public virtual THANHVIEN THANHVIEN { get; set; }
        public virtual MENU_CHA MENU_CHA { get; set; }
    }
}
