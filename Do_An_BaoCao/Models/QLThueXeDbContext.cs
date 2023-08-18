using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Do_An_BaoCao.Models
{
    public partial class QLThueXeDbContext : DbContext
    {
        public QLThueXeDbContext()
            : base("name=ChuoiKetNoi")
        {
        }

        public virtual DbSet<BaoDuong> BaoDuongs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhongBan> PhongBans { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }
        public virtual DbSet<ThueXe> ThueXes { get; set; }
        public virtual DbSet<XeDap> XeDaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<PhongBan>()
                .HasMany(e => e.BaoDuongs)
                .WithRequired(e => e.PhongBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhongBan>()
                .HasMany(e => e.NhanViens)
                .WithRequired(e => e.PhongBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<XeDap>()
                .HasMany(e => e.BaoDuongs)
                .WithRequired(e => e.XeDap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<XeDap>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.XeDap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<XeDap>()
                .HasMany(e => e.ThueXes)
                .WithRequired(e => e.XeDap)
                .WillCascadeOnDelete(false);
        }
    }
}
