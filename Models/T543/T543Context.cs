using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace pdc.Models.T543
{
    public partial class T543Context : DbContext
    {
        public T543Context()
        {
        }

        public T543Context(DbContextOptions<T543Context> options)
            : base(options)
        {
        }

        public virtual DbSet<BhinsgM> BhinsgMs { get; set; } = null!;
        public virtual DbSet<BhnameM> BhnameMs { get; set; } = null!;
        public virtual DbSet<CheckdF> CheckdFs { get; set; } = null!;
        public virtual DbSet<DaiodaM> DaiodaMs { get; set; } = null!;
        public virtual DbSet<DbbackF> DbbackFs { get; set; } = null!;
        public virtual DbSet<DokanrM> DokanrMs { get; set; } = null!;
        public virtual DbSet<JisekiF> JisekiFs { get; set; } = null!;
        public virtual DbSet<KokenjF> KokenjFs { get; set; } = null!;
        public virtual DbSet<MntstaF> MntstaFs { get; set; } = null!;
        public virtual DbSet<RtdateM> RtdateMs { get; set; } = null!;
        public virtual DbSet<SilenoF> SilenoFs { get; set; } = null!;
        public virtual DbSet<SystemM> SystemMs { get; set; } = null!;
        public virtual DbSet<TckanrM> TckanrMs { get; set; } = null!;
        public virtual DbSet<TyokutM> TyokutMs { get; set; } = null!;
        public virtual DbSet<UnitsgM> UnitsgMs { get; set; } = null!;
        public virtual DbSet<UnnameM> UnnameMs { get; set; } = null!;
        public virtual DbSet<WorkerM> WorkerMs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.1.10;User Id=sa;Password=cev@2017;Initial Catalog=T543;Trusted_connection=false;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BhinsgM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bhinsg_m");

                entity.Property(e => e.BhnCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("bhn_code")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.BhnPtan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("bhn_ptan")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.BhnType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("bhn_type")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<BhnameM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bhname_m");

                entity.Property(e => e.BhnCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("bhn_code")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.BhnName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("bhn_name")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<CheckdF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("checkd_f");

                entity.Property(e => e.CheData)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("che_data")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.CheType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("che_type")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<DaiodaM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("daioda_m");

                entity.Property(e => e.DaiBmj1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj1")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmj2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj2")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmj3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj3")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmj4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj4")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmj5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj5")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmj6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj6")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmj7)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj7")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmj8)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj8")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmj9)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj9")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmja)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmja")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmjb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjb")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmjc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmjd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmje)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmje")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmjf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjf")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmjg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmjh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmji)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmji")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmjj)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjj")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmjk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjk")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmp1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp1")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmp2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp2")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmp3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp3")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmp4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp4")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmp5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp5")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmp6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp6")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmp7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp7")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmp8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp8")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmp9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp9")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmpa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpa")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmpb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpb")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmpc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmpd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmpe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpe")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmpf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpf")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmpg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmph)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmph")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmpi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpi")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmpj)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpj")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmpk)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpk")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBms1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms1")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBms2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms2")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBms3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms3")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBms4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms4")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBms5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms5")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBms6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms6")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBms7)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms7")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBms8)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms8")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBms9)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms9")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmsa)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsa")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmsb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsb")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmsc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmsd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmse)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmse")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmsf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsf")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmsg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmsh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmsi)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsi")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmsj)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsj")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiBmsk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsk")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiDaio)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dai_daio")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiForm)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_form")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHb1s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hb1s")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHb2s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hb2s")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHb3s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hb3s")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHb4s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hb4s")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHb5s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hb5s")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHn1e)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn1e")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHn1s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn1s")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHn2e)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn2e")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHn2s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn2s")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHn3e)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn3e")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHn3s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn3s")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHn4e)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn4e")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHn4s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn4s")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHn5e)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn5e")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHn5s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn5s")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpd1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd1")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpd2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd2")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpd3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd3")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpd4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd4")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpd5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd5")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpd6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd6")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpd7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd7")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpd8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd8")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpd9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd9")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpda")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpdb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdb")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpdc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpdd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpde)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpde")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpdf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdf")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpdg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpdh)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpdi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdi")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpdj)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdj")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpdk)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdk")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiHpfg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpfg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiItfd)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("dai_itfd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiItfp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_itfp")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiLdhd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("dai_ldhd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_line")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiLstf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_lstf")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiModl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_modl")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiNafg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_nafg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_name")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiNbsu)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_nbsu")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiNdtp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_ndtp")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiNlbc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_nlbc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiNmip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_nmip")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiNplb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_nplb")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiObsu)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_obsu")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiOdai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dai_odai")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiOdtp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_odtp")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiOlbc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_olbc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiOmip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_omip")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiOplb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_oplb")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiRsv1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_rsv1")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiRsv2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_rsv2")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiToud)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_toud")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnj1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj1")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnj2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj2")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnj3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj3")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnj4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj4")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnj5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj5")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnj6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj6")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnj7)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj7")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnj8)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj8")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnj9)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj9")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnja)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unja")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnjb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjb")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnjc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnjd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnje)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unje")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnjf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjf")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnjg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnjh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnji)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unji")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnjj)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjj")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnjk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjk")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUns1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns1")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUns2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns2")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUns3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns3")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUns4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns4")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUns5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns5")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUns6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns6")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUns7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns7")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUns8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns8")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUns9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns9")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnsa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsa")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsb")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnsc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnsd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unse")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnsf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsf")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnsg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnsh)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnsi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsi")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnsj)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsj")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUnsk)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsk")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUpt1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt1")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUpt2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt2")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUpt3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt3")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUpt4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt4")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUpt5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt5")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUpt6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt6")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUpt7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt7")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUpt8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt8")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUpt9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt9")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUpta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upta")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUptb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptb")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUptc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUptd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUpte)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upte")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUptf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptf")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUptg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUpth)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upth")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUpti)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upti")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUptj)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptj")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DaiUptk)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptk")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<DbbackF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbback_f");

                entity.Property(e => e.DbbBksu)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("dbb_bksu")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DbbDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("dbb_date")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<DokanrM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dokanr_m");

                entity.Property(e => e.DonCono)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("don_cono")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DonCont)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("don_cont")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DonDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("don_date")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DonDono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("don_dono")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DonNeta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("don_neta")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DonNetd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("don_netd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.DonPlno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("don_plno")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<JisekiF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("jiseki_f");

                entity.HasIndex(e => e.JisSile, "idx_jiseki_f_01")
                    .IsUnique();

                entity.HasIndex(e => e.JisKpsd, "idx_jiseki_f_02");

                entity.HasIndex(e => e.JisSsno, "idx_jiseki_f_03");

                entity.HasIndex(e => e.JisPlno, "idx_jiseki_f_04");

                entity.HasIndex(e => e.JisTosd, "idx_jiseki_f_05");

                entity.HasIndex(e => e.JisKosd, "idx_jiseki_f_06");

                entity.Property(e => e.JisBody)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_body")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisCano)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_cano")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisCmnt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("jis_cmnt")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisCono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("jis_cono")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisDaio)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("jis_daio")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisIkan)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("jis_ikan")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKanc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_kanc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKand)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_kand")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKant)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("jis_kant")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKasd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_kasd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKast)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_kast")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKoft)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_koft")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKosd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_kosd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKosn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_kosn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKost)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_kost")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKoud)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_koud")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKout)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("jis_kout")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKpoc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_kpoc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKpod)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_kpod")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKpot)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("jis_kpot")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKpsd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_kpsd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisKpst)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_kpst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_line")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk1h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk1h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk1n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk1n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk2h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk2h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk2n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk2n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk3h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk3h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk3n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk3n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk4h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk4h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk4n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk4n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk5h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk5h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk5n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk5n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk6h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk6h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk6n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk6n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk7h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk7h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk7n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk7n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk8h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk8h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk8n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk8n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk9h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk9h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMk9n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk9n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkah)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkah")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkan)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkan")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkbh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkbh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkbn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkbn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkch)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkch")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkcn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkcn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkdh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkdh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkdn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkdn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkeh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkeh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMken)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mken")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkfh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkfh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkfn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkfn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkgh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkgh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkgn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkgn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkhh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkhh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkhn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkhn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkih)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkih")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkin)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkin")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkjh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkjh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkjn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkjn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkkh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkkh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkkn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkkn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkrd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkrd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkrt)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkrt")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMksd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_mksd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisMkst)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisNakd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_nakd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisNaks)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("jis_naks")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisNeta)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_neta")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisNetd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_netd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisOcar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_ocar")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisPlno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("jis_plno")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisPlse)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("jis_plse")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisPono)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("jis_pono")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisSile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_sile")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisSsno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_ssno")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisSstd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_sstd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisTosd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_tosd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisTost)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_tost")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisToud)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_toud")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisTout)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("jis_tout")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn1h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un1h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn1n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un1n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn2h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un2h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn2n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un2n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn3h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un3h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn3n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un3n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn4h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un4h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn4n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un4n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn5h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un5h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn5n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un5n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn6h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un6h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn6n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un6n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn7h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un7h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn7n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un7n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn8h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un8h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn8n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un8n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn9h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un9h")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUn9n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un9n")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnah)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unah")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unan")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnbh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unbh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnbn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unbn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnch)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unch")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUncn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_uncn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUndh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_undh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUndn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_undn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUneh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_uneh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unen")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnfh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unfh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnfn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unfn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUngh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_ungh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUngn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_ungn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnhh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unhh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnhn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unhn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnih)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unih")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unin")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnjh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unjh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnjn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unjn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnkh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unkh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnkn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unkn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnrd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_unrd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnrt)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("jis_unrt")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnsd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_unsd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisUnst)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_unst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.JisVers)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("jis_vers")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<KokenjF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kokenj_f");

                entity.Property(e => e.KokDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("kok_date")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.KokFtyo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kok_ftyo")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.KokKens)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kok_kens")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.KokLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("kok_line")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.KokTime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kok_time")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.KokTyok)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kok_tyok")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<MntstaF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mntsta_f");

                entity.Property(e => e.CheData)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("che_data")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.MntSta1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnt_sta1")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<RtdateM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rtdate_m");

                entity.Property(e => e.RtdEndd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("rtd_endd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.RtdStat)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("rtd_stat")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<SilenoF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sileno_f");

                entity.HasIndex(e => e.SilSile, "idx_sileno_f_01")
                    .IsUnique();

                entity.Property(e => e.SilBkfg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sil_bkfg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SilBody)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sil_body")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SilClfg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sil_clfg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SilDaio)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("sil_daio")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SilHpfg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sil_hpfg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SilLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sil_line")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SilSile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sil_sile")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<SystemM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("system_m");

                entity.Property(e => e.Sys1qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_1qed")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys1qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_1qst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys2qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_2qed")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys2qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_2qst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys3qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_3qed")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys3qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_3qst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys4qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_4qed")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys4qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_4qst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys5qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_5qed")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys5qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_5qst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SysBdck)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sys_bdck")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SysIkan)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("sys_ikan")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SysKyot)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sys_kyot")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SysLenc)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("sys_lenc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SysLenn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sys_lenn")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SysLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sys_line")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SysName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sys_name")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SysPack)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sys_pack")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SysPint)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_pint")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SysPlms)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("sys_plms")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SysPlno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("sys_plno")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<TckanrM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tckanr_m");

                entity.Property(e => e.TckBuh1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh1")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuh2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh2")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuh3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh3")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuh4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh4")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuh5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh5")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuh6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh6")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuh7)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh7")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuh8)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh8")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuh9)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh9")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuha)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buha")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuhb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhb")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuhc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuhd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuhe)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhe")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuhf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhf")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuhg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuhh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhh")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuhi)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhi")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuhj)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhj")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckBuhk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhk")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_line")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUnt1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt1")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUnt2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt2")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUnt3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt3")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUnt4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt4")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUnt5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt5")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUnt6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt6")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUnt7)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt7")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUnt8)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt8")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUnt9)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt9")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUnta)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unta")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUntb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untb")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUntc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untc")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUntd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untd")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUnte)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unte")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUntf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untf")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUntg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untg")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUnth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unth")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUnti)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unti")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUntj)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untj")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TckUntk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untk")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<TyokutM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tyokut_m");

                entity.Property(e => e.Sys1qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_1qed")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys1qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_1qst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys2qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_2qed")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys2qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_2qst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys3qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_3qed")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys3qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_3qst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys4qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_4qed")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys4qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_4qst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys5qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_5qed")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Sys5qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_5qst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.SysPint)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_pint")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Tyo1sed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_1sed")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Tyo1sst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_1sst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Tyo2sed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_2sed")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Tyo2sst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_2sst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Tyo3sed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_3sed")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Tyo3sst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_3sst")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TyoLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tyo_line")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TyoPint)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_pint")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.TyoType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tyo_type")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<UnitsgM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("unitsg_m");

                entity.Property(e => e.UniBuba)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("uni_buba")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.UniCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uni_code")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.UniPtan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("uni_ptan")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.UniType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uni_type")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<UnnameM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("unname_m");

                entity.Property(e => e.UnnCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("unn_code")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.UnnHpnm)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("unn_hpnm")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.UnnName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("unn_name")
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<WorkerM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("worker_m");

                entity.Property(e => e.WokCmnt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("wok_cmnt")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.WokCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("wok_code")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.WokName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("wok_name")
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.WokZoku)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("wok_zoku")
                    .UseCollation("Japanese_CI_AS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
