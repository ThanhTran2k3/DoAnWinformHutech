namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonNuoc")]
    public partial class MonNuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonNuoc()
        {
            CTPhieuGoiMon = new HashSet<CTPhieuGoiMon>();
        }

        [Key]
        [StringLength(10)]
        public string MaMon { get; set; }

        [StringLength(50)]
        public string TenMon { get; set; }

        [Column(TypeName = "money")]
        public decimal? Gia { get; set; }

        [StringLength(10)]
        public string MaTL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuGoiMon> CTPhieuGoiMon { get; set; }

        public virtual TheLoai TheLoai { get; set; }
    }
}
