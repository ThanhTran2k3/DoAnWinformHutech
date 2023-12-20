namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDatBan")]
    public partial class PhieuDatBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuDatBan()
        {
            CTPhieuDatBan = new HashSet<CTPhieuDatBan>();
        }

        [Key]
        public int MaPDB { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngay { get; set; }

        [StringLength(1000)]
        public string GhiChu { get; set; }

        public int? MaKH { get; set; }

        public int? MaHD { get; set; }

        public TimeSpan? TGVao { get; set; }

        public TimeSpan? TGRa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuDatBan> CTPhieuDatBan { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
