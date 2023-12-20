namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuGoiMon")]
    public partial class PhieuGoiMon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuGoiMon()
        {
            CTPhieuDatBan = new HashSet<CTPhieuDatBan>();
            CTPhieuGoiMon = new HashSet<CTPhieuGoiMon>();
        }

        [Key]
        public int MaPGM { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuDatBan> CTPhieuDatBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuGoiMon> CTPhieuGoiMon { get; set; }
    }
}
