using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace pdc.Models.Lichsu
{
    public partial class CheckPalletPDCContext : DbContext
    {
        public CheckPalletPDCContext()
        {
        }

        public CheckPalletPDCContext(DbContextOptions<CheckPalletPDCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dulieuthitruong> Dulieuthitruongs { get; set; } = null!;
        public virtual DbSet<Lichsu> Lichsus { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.1.254;User Id=sa;Password=123;Initial Catalog=CheckPalletPDC;Trusted_connection=false;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dulieuthitruong>(entity =>
            {
                entity.ToTable("dulieuthitruong");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mechandide)
                    .HasMaxLength(255)
                    .HasColumnName("mechandide");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .HasColumnName("model");
            });

            modelBuilder.Entity<Lichsu>(entity =>
            {
                entity.ToTable("lichsu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Bodyno).HasColumnName("bodyno");

                entity.Property(e => e.Datecheck)
                    .HasColumnType("datetime")
                    .HasColumnName("datecheck");

                entity.Property(e => e.Merchandide).HasColumnName("merchandide");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .HasColumnName("model");

                entity.Property(e => e.Numberpallet).HasColumnName("numberpallet");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
