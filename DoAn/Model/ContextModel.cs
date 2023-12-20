using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn.Model
{
    public partial class ContextModel : DbContext
    {
        public ContextModel()
            : base("name=ContextModel")
        {
        }

        public virtual DbSet<Ban> Ban { get; set; }
        public virtual DbSet<CTPhieuDatBan> CTPhieuDatBan { get; set; }
        public virtual DbSet<CTPhieuGoiMon> CTPhieuGoiMon { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<MonNuoc> MonNuoc { get; set; }
        public virtual DbSet<PhieuDatBan> PhieuDatBan { get; set; }
        public virtual DbSet<PhieuGoiMon> PhieuGoiMon { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TheLoai> TheLoai { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .Property(e => e.MaBan)
                .IsFixedLength();

            modelBuilder.Entity<Ban>()
                .Property(e => e.TenBan)
                .IsFixedLength();

            modelBuilder.Entity<CTPhieuDatBan>()
                .Property(e => e.MaBan)
                .IsFixedLength();

            modelBuilder.Entity<CTPhieuGoiMon>()
                .Property(e => e.MaMon)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.PhieuDatBan)
                .WithOptional(e => e.HoaDon)
                .WillCascadeOnDelete();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.GioiTinh)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuDatBan)
                .WithOptional(e => e.KhachHang)
                .WillCascadeOnDelete();

            modelBuilder.Entity<MonNuoc>()
                .Property(e => e.MaMon)
                .IsFixedLength();

            modelBuilder.Entity<MonNuoc>()
                .Property(e => e.TenMon)
                .IsFixedLength();

            modelBuilder.Entity<MonNuoc>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MonNuoc>()
                .Property(e => e.MaTL)
                .IsFixedLength();

            modelBuilder.Entity<PhieuDatBan>()
                .Property(e => e.GhiChu)
                .IsFixedLength();

            modelBuilder.Entity<PhieuGoiMon>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PhieuGoiMon>()
                .HasMany(e => e.CTPhieuDatBan)
                .WithOptional(e => e.PhieuGoiMon)
                .WillCascadeOnDelete();

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.MaTL)
                .IsFixedLength();

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.TenTL)
                .IsFixedLength();

            modelBuilder.Entity<TheLoai>()
                .HasMany(e => e.MonNuoc)
                .WithOptional(e => e.TheLoai)
                .WillCascadeOnDelete();
        }
    }
}
