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
    
    public partial class HOPDONG_CHIPHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOPDONG_CHIPHI()
        {
            this.THANHTOAN_CHIPHI = new HashSet<THANHTOAN_CHIPHI>();
            this.PHULUC_HDCP = new HashSet<PHULUC_HDCP>();
            this.THANHLY_HDCHIPHI = new HashSet<THANHLY_HDCHIPHI>();
            this.PHULUCs = new HashSet<PHULUC>();
            this.TINHTRANG_SD_CHIPHI = new HashSet<TINHTRANG_SD_CHIPHI>();
        }
    
        public int HOPDONG_CHIPHI_ID { get; set; }
        public Nullable<int> HTTT_ID { get; set; }
        public Nullable<int> CHUKY_ID { get; set; }
        public Nullable<int> CHUKY2_ID { get; set; }
        public Nullable<int> NAM_HD_ID { get; set; }
        public Nullable<int> ID_LOAIHD_SUB { get; set; }
        public Nullable<int> THOIHAN_TT_ID { get; set; }
        public string SO_HD { get; set; }
        public Nullable<System.DateTime> NGAY_HD { get; set; }
        public string TEN_BT { get; set; }
        public string DIACHI_BT { get; set; }
        public string DIENTHOAI_BT { get; set; }
        public string FAX_BT { get; set; }
        public string TAIKHOAN_BT { get; set; }
        public string NGANHANG_BT { get; set; }
        public string MSTHUE_BT { get; set; }
        public string DAIDIEN_BT { get; set; }
        public string CMND_BT { get; set; }
        public Nullable<System.DateTime> NGAYCAP_CMND_BT { get; set; }
        public string NOICAP_BT { get; set; }
        public string CHUCVU_BT { get; set; }
        public Nullable<int> LOAI_CT { get; set; }
        public string TEN_CT { get; set; }
        public string DIACHI_CT { get; set; }
        public string CMND_CT { get; set; }
        public Nullable<System.DateTime> NGAYCAP_CT { get; set; }
        public string NOICAP_CT { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string DIENTHOAI_CT { get; set; }
        public string DAIDIEN_CT { get; set; }
        public string CHUCVU_CT { get; set; }
        public string TAIKHOAN_CT { get; set; }
        public string NGANHANG_CT { get; set; }
        public string MSTHUE_CT { get; set; }
        public string HOPDONG_DT { get; set; }
        public string SOLUONG_DT { get; set; }
        public string DIENTICH_DT { get; set; }
        public string CONGSUAT_DT { get; set; }
        public string CHUNGLOAI_DT { get; set; }
        public string CONGVIEC_DT { get; set; }
        public string TRAM_DT { get; set; }
        public string NOIDUNGKHAC_DT { get; set; }
        public Nullable<decimal> THANG_GT { get; set; }
        public Nullable<decimal> TONG_GT { get; set; }
        public Nullable<System.DateTime> NGAY_BD { get; set; }
        public Nullable<System.DateTime> NGAY_KT { get; set; }
        public string GHICHU { get; set; }
        public string File { get; set; }
        public string USER { get; set; }
        public Nullable<int> DONVI_ID { get; set; }
        public Nullable<decimal> THANG { get; set; }
        public Nullable<decimal> VAT { get; set; }
        public Nullable<int> SO_CHUKY { get; set; }
        public Nullable<int> TRANGTHAI { get; set; }
        public string BTS_ID { get; set; }
        public Nullable<decimal> THANG_GT_NHA { get; set; }
        public Nullable<decimal> THANG_GT_ANTEN { get; set; }
        public Nullable<decimal> THANG_GT_MPD { get; set; }
        public Nullable<decimal> THANG_GT_KHAC { get; set; }
        public Nullable<decimal> THANG_GT_NHA_ANTEN { get; set; }
        public Nullable<int> FILE_ID { get; set; }
    
        public virtual CHUKY_TT CHUKY_TT { get; set; }
        public virtual CHUKY_TT CHUKY_TT1 { get; set; }
        public virtual DONVI DONVI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THANHTOAN_CHIPHI> THANHTOAN_CHIPHI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHULUC_HDCP> PHULUC_HDCP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THANHLY_HDCHIPHI> THANHLY_HDCHIPHI { get; set; }
        public virtual NAM_HD NAM_HD { get; set; }
        public virtual THOIHAN_TT THOIHAN_TT { get; set; }
        public virtual TRANGTHAI_HD TRANGTHAI_HD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHULUC> PHULUCs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TINHTRANG_SD_CHIPHI> TINHTRANG_SD_CHIPHI { get; set; }
        public virtual HTTT HTTT { get; set; }
        public virtual LOAI_HD_SUB LOAI_HD_SUB { get; set; }
    }
}
