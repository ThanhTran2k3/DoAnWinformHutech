namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPhieuDatBan")]
    public partial class CTPhieuDatBan
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPDB { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaBan { get; set; }

        public int? MaPGM { get; set; }

        public virtual Ban Ban { get; set; }

        public virtual PhieuDatBan PhieuDatBan { get; set; }

        public virtual PhieuGoiMon PhieuGoiMon { get; set; }
    }
}
