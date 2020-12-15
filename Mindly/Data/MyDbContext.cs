using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EF
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual ISet<Testit> Testits { get; set; }
        public virtual DbSet<Vastaukset> Vastauksets { get; set; }
        public virtual DbSet<Yritykset> Yrityksets { get; set; }
        public virtual DbSet<YrityksetTestit> YrityksetTestits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=mindly;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Testit>(entity =>
            {
                entity.HasKey(e => e.TestitTunnus)
                    .HasName("PK__Testit__72B7ED4094DF2DD3");

                entity.ToTable("Testit");

                entity.Property(e => e.TestitTunnus)
                    .ValueGeneratedNever()
                    .HasColumnName("Testit_tunnus");

                entity.Property(e => e.Kysymys1)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Kysymys2)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vastaukset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Vastaukset");

                entity.Property(e => e.YrityksetTestitTunnus).HasColumnName("Yritykset_testit_tunnus");

                entity.HasOne(d => d.YrityksetTestitTunnusNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.YrityksetTestitTunnus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Vastaukse__Yrity__6383C8BA");
            });

            modelBuilder.Entity<Yritykset>(entity =>
            {
                entity.HasKey(e => e.YrityksetTunnus)
                    .HasName("PK__Yritykse__7A03F47CDFE9EB00");

                entity.ToTable("Yritykset");

                entity.Property(e => e.YrityksetTunnus).HasColumnName("Yritykset_tunnus");

                entity.Property(e => e.Nimi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YrityksetTestit>(entity =>
            {
                entity.HasKey(e => e.YrityksetTestitTunnus)
                    .HasName("PK__Yritykse__486939A1B3904229");

                entity.ToTable("Yritykset_testit");

                entity.Property(e => e.YrityksetTestitTunnus).HasColumnName("Yritykset_testit_tunnus");

                entity.Property(e => e.TestitTunnus).HasColumnName("Testit_tunnus");

                entity.Property(e => e.YrityksetTunnus).HasColumnName("Yritykset_tunnus");

                entity.HasOne(d => d.TestitTunnusNavigation)
                    .WithMany(p => p.YrityksetTestits)
                    .HasForeignKey(d => d.TestitTunnus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Yritykset__Testi__619B8048");

                entity.HasOne(d => d.YrityksetTunnusNavigation)
                    .WithMany(p => p.YrityksetTestits)
                    .HasForeignKey(d => d.YrityksetTunnus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Yritykset__Yrity__60A75C0F");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
