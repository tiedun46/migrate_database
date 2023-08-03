using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MigrateDataPAKN.ModelsSQL
{
    public partial class PhanAnhKienNghiContext : DbContext
    {
        public PhanAnhKienNghiContext()
        {
        }

        public PhanAnhKienNghiContext(DbContextOptions<PhanAnhKienNghiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anh2021> Anh2021s { get; set; } = null!;
        public virtual DbSet<Dm500> Dm500s { get; set; } = null!;
        public virtual DbSet<Dm501> Dm501s { get; set; } = null!;
        public virtual DbSet<Dm502> Dm502s { get; set; } = null!;
        public virtual DbSet<Dm503> Dm503s { get; set; } = null!;
        public virtual DbSet<Dm504> Dm504s { get; set; } = null!;
        public virtual DbSet<Dm505> Dm505s { get; set; } = null!;
        public virtual DbSet<Dm506> Dm506s { get; set; } = null!;
        public virtual DbSet<Dm507> Dm507s { get; set; } = null!;
        public virtual DbSet<Dm508> Dm508s { get; set; } = null!;
        public virtual DbSet<Dm509> Dm509s { get; set; } = null!;
        public virtual DbSet<Dm510> Dm510s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=VCS57\\SQLEXPRESS;Database=PhanAnhKienNghi;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anh2021>(entity =>
            {
                entity.ToTable("ANH_2021");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Duongdananh).HasColumnName("duongdananh");

                entity.Property(e => e.Kinhdo)
                    .HasMaxLength(500)
                    .HasColumnName("kinhdo");

                entity.Property(e => e.Loaianh)
                    .HasMaxLength(50)
                    .HasColumnName("loaianh");

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(50)
                    .HasColumnName("machuongtrinh");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(50)
                    .HasColumnName("madonvi");

                entity.Property(e => e.Maduan)
                    .HasMaxLength(50)
                    .HasColumnName("maduan");

                entity.Property(e => e.Manoidungthanhphan)
                    .HasMaxLength(50)
                    .HasColumnName("manoidungthanhphan");

                entity.Property(e => e.Mathon)
                    .HasMaxLength(50)
                    .HasColumnName("mathon");

                entity.Property(e => e.Nam).HasColumnName("nam");

                entity.Property(e => e.Ngaythangnam)
                    .HasColumnType("date")
                    .HasColumnName("ngaythangnam");

                entity.Property(e => e.Noidungbaocao).HasColumnName("noidungbaocao");

                entity.Property(e => e.Thongtinanh).HasColumnName("thongtinanh");

                entity.Property(e => e.Tieudeanh)
                    .HasMaxLength(500)
                    .HasColumnName("tieudeanh");

                entity.Property(e => e.Vido)
                    .HasMaxLength(500)
                    .HasColumnName("vido");
            });

            modelBuilder.Entity<Dm500>(entity =>
            {
                entity.ToTable("DM500");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Maloaisolieu)
                    .HasMaxLength(50)
                    .HasColumnName("maloaisolieu");

                entity.Property(e => e.Tenloaisolieu)
                    .HasMaxLength(500)
                    .HasColumnName("tenloaisolieu");
            });

            modelBuilder.Entity<Dm501>(entity =>
            {
                entity.ToTable("DM501");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Loaichitieu)
                    .HasMaxLength(100)
                    .HasColumnName("loaichitieu");

                entity.Property(e => e.Machitieu)
                    .HasMaxLength(50)
                    .HasColumnName("machitieu");

                entity.Property(e => e.Madonvitinh)
                    .HasMaxLength(50)
                    .HasColumnName("madonvitinh");

                entity.Property(e => e.Maloaisolieu)
                    .HasMaxLength(50)
                    .HasColumnName("maloaisolieu");

                entity.Property(e => e.Tenchitieu)
                    .HasMaxLength(500)
                    .HasColumnName("tenchitieu");
            });

            modelBuilder.Entity<Dm502>(entity =>
            {
                entity.ToTable("DM502");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(50)
                    .HasColumnName("machuongtrinh");

                entity.Property(e => e.Tenchuongtrinh)
                    .HasMaxLength(500)
                    .HasColumnName("tenchuongtrinh");
            });

            modelBuilder.Entity<Dm503>(entity =>
            {
                entity.ToTable("DM503");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(50)
                    .HasColumnName("machuongtrinh");

                entity.Property(e => e.Maduan)
                    .HasMaxLength(50)
                    .HasColumnName("maduan");

                entity.Property(e => e.Tenduan)
                    .HasMaxLength(500)
                    .HasColumnName("tenduan");
            });

            modelBuilder.Entity<Dm504>(entity =>
            {
                entity.ToTable("DM504");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(50)
                    .HasColumnName("machuongtrinh");

                entity.Property(e => e.Maduan)
                    .HasMaxLength(50)
                    .HasColumnName("maduan");

                entity.Property(e => e.Manoidungthanhphan)
                    .HasMaxLength(50)
                    .HasColumnName("manoidungthanhphan");

                entity.Property(e => e.Tenthanhphan)
                    .HasMaxLength(500)
                    .HasColumnName("tenthanhphan");
            });

            modelBuilder.Entity<Dm505>(entity =>
            {
                entity.ToTable("DM505");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kinhdo)
                    .HasMaxLength(254)
                    .HasColumnName("kinhdo");

                entity.Property(e => e.Mahuyen)
                    .HasMaxLength(50)
                    .HasColumnName("mahuyen");

                entity.Property(e => e.Mathon)
                    .HasMaxLength(50)
                    .HasColumnName("mathon");

                entity.Property(e => e.Matinh)
                    .HasMaxLength(50)
                    .HasColumnName("matinh");

                entity.Property(e => e.Maxa)
                    .HasMaxLength(50)
                    .HasColumnName("maxa");

                entity.Property(e => e.Tenhuyen)
                    .HasMaxLength(254)
                    .HasColumnName("tenhuyen");

                entity.Property(e => e.Tenthon)
                    .HasMaxLength(254)
                    .HasColumnName("tenthon");

                entity.Property(e => e.Tentinh)
                    .HasMaxLength(100)
                    .HasColumnName("tentinh");

                entity.Property(e => e.Tenxa)
                    .HasMaxLength(254)
                    .HasColumnName("tenxa");

                entity.Property(e => e.Vido)
                    .HasMaxLength(254)
                    .HasColumnName("vido");
            });

            modelBuilder.Entity<Dm506>(entity =>
            {
                entity.ToTable("DM506");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Madonvitinh)
                    .HasMaxLength(50)
                    .HasColumnName("madonvitinh");

                entity.Property(e => e.Tendonvitinh)
                    .HasMaxLength(100)
                    .HasColumnName("tendonvitinh");
            });

            modelBuilder.Entity<Dm507>(entity =>
            {
                entity.ToTable("DM507");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Manguon)
                    .HasMaxLength(50)
                    .HasColumnName("manguon");

                entity.Property(e => e.Tennguon)
                    .HasMaxLength(500)
                    .HasColumnName("tennguon");
            });

            modelBuilder.Entity<Dm508>(entity =>
            {
                entity.ToTable("DM508");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Macap)
                    .HasMaxLength(50)
                    .HasColumnName("macap");

                entity.Property(e => e.Tencap)
                    .HasMaxLength(500)
                    .HasColumnName("tencap");
            });

            modelBuilder.Entity<Dm509>(entity =>
            {
                entity.ToTable("DM509");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(50)
                    .HasColumnName("madonvi");

                entity.Property(e => e.Tendonvi)
                    .HasMaxLength(500)
                    .HasColumnName("tendonvi");
            });

            modelBuilder.Entity<Dm510>(entity =>
            {
                entity.ToTable("DM510");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kinhdo)
                    .HasMaxLength(500)
                    .HasColumnName("kinhdo");

                entity.Property(e => e.Mahuyen)
                    .HasMaxLength(10)
                    .HasColumnName("mahuyen");

                entity.Property(e => e.Matinh)
                    .HasMaxLength(10)
                    .HasColumnName("matinh");

                entity.Property(e => e.Maxa)
                    .HasMaxLength(10)
                    .HasColumnName("maxa");

                entity.Property(e => e.Tenhuyen)
                    .HasMaxLength(200)
                    .HasColumnName("tenhuyen");

                entity.Property(e => e.Tentinh)
                    .HasMaxLength(200)
                    .HasColumnName("tentinh");

                entity.Property(e => e.Tenxa)
                    .HasMaxLength(200)
                    .HasColumnName("tenxa");

                entity.Property(e => e.Vido)
                    .HasMaxLength(500)
                    .HasColumnName("vido");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
