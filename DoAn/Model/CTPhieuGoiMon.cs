namespace DoAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPhieuGoiMon")]
    public partial class CTPhieuGoiMon
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPGM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaMon { get; set; }

        public int? SoLuong { get; set; }

        public virtual MonNuoc MonNuoc { get; set; }

        public virtual PhieuGoiMon PhieuGoiMon { get; set; }
    }
}
