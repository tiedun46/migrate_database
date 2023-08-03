using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MigrateDataPAKN.ModelsPostGre
{
    public partial class quanlyduanContext : DbContext
    {
        public quanlyduanContext()
        {
        }

        public quanlyduanContext(DbContextOptions<quanlyduanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anh2021> Anh2021s { get; set; } = null!;
        public virtual DbSet<Csdl12021> Csdl12021s { get; set; } = null!;
        public virtual DbSet<Csdl1a> Csdl1as { get; set; } = null!;
        public virtual DbSet<Csdl22021> Csdl22021s { get; set; } = null!;
        public virtual DbSet<Csdl2a> Csdl2as { get; set; } = null!;
        public virtual DbSet<Csdl32021> Csdl32021s { get; set; } = null!;
        public virtual DbSet<Csdl3a> Csdl3as { get; set; } = null!;
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
        public virtual DbSet<Test> Tests { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UsersRole> UsersRoles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;UserId=postgres;Password=040601;Database=quanlyduan;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("postgis");

            modelBuilder.Entity<Anh2021>(entity =>
            {
                entity.ToTable("anh_2021");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Duongdananh)
                    .HasMaxLength(1000)
                    .HasColumnName("duongdananh");

                entity.Property(e => e.Kinhdo).HasColumnName("kinhdo");

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

                entity.Property(e => e.Ngaythangnam).HasColumnName("ngaythangnam");

                entity.Property(e => e.Noidungbaocao)
                    .HasMaxLength(1000)
                    .HasColumnName("noidungbaocao");

                entity.Property(e => e.Thongtinanh)
                    .HasMaxLength(1000)
                    .HasColumnName("thongtinanh");

                entity.Property(e => e.Tieudeanh)
                    .HasMaxLength(200)
                    .HasColumnName("tieudeanh");

                entity.Property(e => e.Vido).HasColumnName("vido");
            });

            modelBuilder.Entity<Csdl12021>(entity =>
            {
                entity.ToTable("csdl1_2021");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Machitieu)
                    .HasMaxLength(50)
                    .HasColumnName("machitieu");

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(50)
                    .HasColumnName("machuongtrinh");

                entity.Property(e => e.Madiaban)
                    .HasMaxLength(50)
                    .HasColumnName("madiaban");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(50)
                    .HasColumnName("madonvi");

                entity.Property(e => e.Madonvitinh)
                    .HasMaxLength(50)
                    .HasColumnName("madonvitinh");

                entity.Property(e => e.Maduan)
                    .HasMaxLength(50)
                    .HasColumnName("maduan");

                entity.Property(e => e.Maloaisolieu)
                    .HasMaxLength(50)
                    .HasColumnName("maloaisolieu");

                entity.Property(e => e.Manoidungthanhphan)
                    .HasMaxLength(50)
                    .HasColumnName("manoidungthanhphan");

                entity.Property(e => e.Masolieuphatsinh)
                    .HasMaxLength(50)
                    .HasColumnName("masolieuphatsinh");

                entity.Property(e => e.Ngaythangnam).HasColumnName("ngaythangnam");

                entity.Property(e => e.Soluong).HasColumnName("soluong");
            });

            modelBuilder.Entity<Csdl1a>(entity =>
            {
                entity.ToTable("csdl1a");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Macap)
                    .HasMaxLength(50)
                    .HasColumnName("macap");

                entity.Property(e => e.Manguon)
                    .HasMaxLength(50)
                    .HasColumnName("manguon");

                entity.Property(e => e.Masolieuphatsinh)
                    .HasMaxLength(50)
                    .HasColumnName("masolieuphatsinh");

                entity.Property(e => e.Soluong).HasColumnName("soluong");
            });

            modelBuilder.Entity<Csdl22021>(entity =>
            {
                entity.ToTable("csdl2_2021");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Machitieu)
                    .HasMaxLength(50)
                    .HasColumnName("machitieu");

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(50)
                    .HasColumnName("machuongtrinh");

                entity.Property(e => e.Madiaban)
                    .HasMaxLength(50)
                    .HasColumnName("madiaban");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(50)
                    .HasColumnName("madonvi");

                entity.Property(e => e.Madonvitinh)
                    .HasMaxLength(50)
                    .HasColumnName("madonvitinh");

                entity.Property(e => e.Maduan)
                    .HasMaxLength(50)
                    .HasColumnName("maduan");

                entity.Property(e => e.Maloaisolieu)
                    .HasMaxLength(50)
                    .HasColumnName("maloaisolieu");

                entity.Property(e => e.Manoidungthanhphan)
                    .HasMaxLength(50)
                    .HasColumnName("manoidungthanhphan");

                entity.Property(e => e.Masolieunam)
                    .HasMaxLength(50)
                    .HasColumnName("masolieunam");

                entity.Property(e => e.Nam).HasColumnName("nam");

                entity.Property(e => e.Soluong).HasColumnName("soluong");
            });

            modelBuilder.Entity<Csdl2a>(entity =>
            {
                entity.ToTable("csdl2a");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Macap)
                    .HasMaxLength(50)
                    .HasColumnName("macap");

                entity.Property(e => e.Manguon)
                    .HasMaxLength(50)
                    .HasColumnName("manguon");

                entity.Property(e => e.Masolieunam)
                    .HasMaxLength(50)
                    .HasColumnName("masolieunam");

                entity.Property(e => e.Soluong).HasColumnName("soluong");
            });

            modelBuilder.Entity<Csdl32021>(entity =>
            {
                entity.ToTable("csdl3_2021");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Giaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("giaidoan");

                entity.Property(e => e.Machitieu)
                    .HasMaxLength(50)
                    .HasColumnName("machitieu");

                entity.Property(e => e.Machuongtrinh)
                    .HasMaxLength(50)
                    .HasColumnName("machuongtrinh");

                entity.Property(e => e.Madiaban)
                    .HasMaxLength(50)
                    .HasColumnName("madiaban");

                entity.Property(e => e.Madonvi)
                    .HasMaxLength(50)
                    .HasColumnName("madonvi");

                entity.Property(e => e.Madonvitinh)
                    .HasMaxLength(50)
                    .HasColumnName("madonvitinh");

                entity.Property(e => e.Maduan)
                    .HasMaxLength(50)
                    .HasColumnName("maduan");

                entity.Property(e => e.Magiaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("magiaidoan");

                entity.Property(e => e.Maloaisolieu)
                    .HasMaxLength(50)
                    .HasColumnName("maloaisolieu");

                entity.Property(e => e.Manoidungthanhphan)
                    .HasMaxLength(50)
                    .HasColumnName("manoidungthanhphan");

                entity.Property(e => e.Soluong).HasColumnName("soluong");
            });

            modelBuilder.Entity<Csdl3a>(entity =>
            {
                entity.ToTable("csdl3a");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Macap)
                    .HasMaxLength(50)
                    .HasColumnName("macap");

                entity.Property(e => e.Magiaidoan)
                    .HasMaxLength(50)
                    .HasColumnName("magiaidoan");

                entity.Property(e => e.Manguon)
                    .HasMaxLength(50)
                    .HasColumnName("manguon");

                entity.Property(e => e.Soluong).HasColumnName("soluong");
            });

            modelBuilder.Entity<Dm500>(entity =>
            {
                entity.ToTable("dm500");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Maloaisolieu)
                    .HasMaxLength(50)
                    .HasColumnName("maloaisolieu");

                entity.Property(e => e.Tenloaisolieu)
                    .HasMaxLength(50)
                    .HasColumnName("tenloaisolieu");
            });

            modelBuilder.Entity<Dm501>(entity =>
            {
                entity.ToTable("dm501");

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
                entity.ToTable("dm502");

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
                entity.ToTable("dm503");

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
                entity.ToTable("dm504");

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
                entity.ToTable("dm505");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kinhdo).HasColumnName("kinhdo");

                entity.Property(e => e.Mahuyen)
                    .HasMaxLength(3)
                    .HasColumnName("mahuyen");

                entity.Property(e => e.Mathon)
                    .HasMaxLength(50)
                    .HasColumnName("mathon");

                entity.Property(e => e.Matinh)
                    .HasMaxLength(2)
                    .HasColumnName("matinh");

                entity.Property(e => e.Maxa)
                    .HasMaxLength(5)
                    .HasColumnName("maxa");

                entity.Property(e => e.Tenhuyen)
                    .HasMaxLength(254)
                    .HasColumnName("tenhuyen");

                entity.Property(e => e.Tenthon)
                    .HasMaxLength(254)
                    .HasColumnName("tenthon");

                entity.Property(e => e.Tentinh)
                    .HasMaxLength(50)
                    .HasColumnName("tentinh");

                entity.Property(e => e.Tenxa)
                    .HasMaxLength(254)
                    .HasColumnName("tenxa");

                entity.Property(e => e.Vido).HasColumnName("vido");
            });

            modelBuilder.Entity<Dm506>(entity =>
            {
                entity.ToTable("dm506");

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
                entity.ToTable("dm507");

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
                entity.ToTable("dm508");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Macap)
                    .HasMaxLength(50)
                    .HasColumnName("macap");

                entity.Property(e => e.Tencap)
                    .HasMaxLength(100)
                    .HasColumnName("tencap");
            });

            modelBuilder.Entity<Dm509>(entity =>
            {
                entity.ToTable("dm509");

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
                entity.ToTable("dm510");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('xa_id_seq'::regclass)");

                entity.Property(e => e.Kinhdo).HasColumnName("kinhdo");

                entity.Property(e => e.Mahuyen)
                    .HasMaxLength(3)
                    .HasColumnName("mahuyen");

                entity.Property(e => e.Matinh)
                    .HasMaxLength(2)
                    .HasColumnName("matinh");

                entity.Property(e => e.Maxa)
                    .HasMaxLength(5)
                    .HasColumnName("maxa");

                entity.Property(e => e.Tenhuyen)
                    .HasMaxLength(50)
                    .HasColumnName("tenhuyen");

                entity.Property(e => e.Tentinh)
                    .HasMaxLength(30)
                    .HasColumnName("tentinh");

                entity.Property(e => e.Tenxa)
                    .HasMaxLength(100)
                    .HasColumnName("tenxa");

                entity.Property(e => e.Vido).HasColumnName("vido");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("test");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kinhdo)
                    .HasMaxLength(200)
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
                    .HasMaxLength(50)
                    .HasColumnName("tenhuyen");

                entity.Property(e => e.Tentinh)
                    .HasMaxLength(50)
                    .HasColumnName("tentinh");

                entity.Property(e => e.Tenxa)
                    .HasMaxLength(100)
                    .HasColumnName("tenxa");

                entity.Property(e => e.Vido)
                    .HasMaxLength(200)
                    .HasColumnName("vido");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(100)
                    .HasColumnName("dienthoai");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Maquyen).HasColumnName("maquyen");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(50)
                    .HasColumnName("matkhau");

                entity.Property(e => e.Quyen)
                    .HasMaxLength(50)
                    .HasColumnName("quyen");

                entity.Property(e => e.Ten)
                    .HasMaxLength(100)
                    .HasColumnName("ten");

                entity.Property(e => e.Tendaydu)
                    .HasMaxLength(200)
                    .HasColumnName("tendaydu");

                entity.Property(e => e.Tinhtrang)
                    .HasMaxLength(30)
                    .HasColumnName("tinhtrang");
            });

            modelBuilder.Entity<UsersRole>(entity =>
            {
                entity.ToTable("users_role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Maquyen).HasColumnName("maquyen");

                entity.Property(e => e.Tenquyen)
                    .HasMaxLength(50)
                    .HasColumnName("tenquyen");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
