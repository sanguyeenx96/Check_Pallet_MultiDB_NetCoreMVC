using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace pdc.Models.L1231
{
    public partial class L1231Context : DbContext
    {
        public L1231Context()
        {
        }

        public L1231Context(DbContextOptions<L1231Context> options)
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
                optionsBuilder.UseSqlServer("Data Source=192.168.1.10;User Id=sa;Password=cev@2017;Initial Catalog=L1231;Trusted_connection=false;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Japanese_CI_AS");

            modelBuilder.Entity<BhinsgM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bhinsg_m");

                entity.Property(e => e.BhnCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("bhn_code");

                entity.Property(e => e.BhnPtan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("bhn_ptan");

                entity.Property(e => e.BhnType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("bhn_type");
            });

            modelBuilder.Entity<BhnameM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bhname_m");

                entity.Property(e => e.BhnCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("bhn_code");

                entity.Property(e => e.BhnName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("bhn_name");
            });

            modelBuilder.Entity<CheckdF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("checkd_f");

                entity.Property(e => e.CheData)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("che_data");

                entity.Property(e => e.CheType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("che_type");
            });

            modelBuilder.Entity<DaiodaM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("daioda_m");

                entity.Property(e => e.DaiBmj1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj1");

                entity.Property(e => e.DaiBmj2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj2");

                entity.Property(e => e.DaiBmj3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj3");

                entity.Property(e => e.DaiBmj4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj4");

                entity.Property(e => e.DaiBmj5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj5");

                entity.Property(e => e.DaiBmj6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj6");

                entity.Property(e => e.DaiBmj7)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj7");

                entity.Property(e => e.DaiBmj8)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj8");

                entity.Property(e => e.DaiBmj9)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmj9");

                entity.Property(e => e.DaiBmja)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmja");

                entity.Property(e => e.DaiBmjb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjb");

                entity.Property(e => e.DaiBmjc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjc");

                entity.Property(e => e.DaiBmjd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjd");

                entity.Property(e => e.DaiBmje)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmje");

                entity.Property(e => e.DaiBmjf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjf");

                entity.Property(e => e.DaiBmjg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjg");

                entity.Property(e => e.DaiBmjh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjh");

                entity.Property(e => e.DaiBmji)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmji");

                entity.Property(e => e.DaiBmjj)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjj");

                entity.Property(e => e.DaiBmjk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmjk");

                entity.Property(e => e.DaiBmp1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp1");

                entity.Property(e => e.DaiBmp2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp2");

                entity.Property(e => e.DaiBmp3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp3");

                entity.Property(e => e.DaiBmp4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp4");

                entity.Property(e => e.DaiBmp5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp5");

                entity.Property(e => e.DaiBmp6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp6");

                entity.Property(e => e.DaiBmp7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp7");

                entity.Property(e => e.DaiBmp8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp8");

                entity.Property(e => e.DaiBmp9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmp9");

                entity.Property(e => e.DaiBmpa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpa");

                entity.Property(e => e.DaiBmpb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpb");

                entity.Property(e => e.DaiBmpc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpc");

                entity.Property(e => e.DaiBmpd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpd");

                entity.Property(e => e.DaiBmpe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpe");

                entity.Property(e => e.DaiBmpf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpf");

                entity.Property(e => e.DaiBmpg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpg");

                entity.Property(e => e.DaiBmph)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmph");

                entity.Property(e => e.DaiBmpi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpi");

                entity.Property(e => e.DaiBmpj)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpj");

                entity.Property(e => e.DaiBmpk)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmpk");

                entity.Property(e => e.DaiBms1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms1");

                entity.Property(e => e.DaiBms2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms2");

                entity.Property(e => e.DaiBms3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms3");

                entity.Property(e => e.DaiBms4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms4");

                entity.Property(e => e.DaiBms5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms5");

                entity.Property(e => e.DaiBms6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms6");

                entity.Property(e => e.DaiBms7)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms7");

                entity.Property(e => e.DaiBms8)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms8");

                entity.Property(e => e.DaiBms9)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bms9");

                entity.Property(e => e.DaiBmsa)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsa");

                entity.Property(e => e.DaiBmsb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsb");

                entity.Property(e => e.DaiBmsc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsc");

                entity.Property(e => e.DaiBmsd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsd");

                entity.Property(e => e.DaiBmse)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmse");

                entity.Property(e => e.DaiBmsf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsf");

                entity.Property(e => e.DaiBmsg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsg");

                entity.Property(e => e.DaiBmsh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsh");

                entity.Property(e => e.DaiBmsi)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsi");

                entity.Property(e => e.DaiBmsj)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsj");

                entity.Property(e => e.DaiBmsk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_bmsk");

                entity.Property(e => e.DaiDaio)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dai_daio");

                entity.Property(e => e.DaiForm)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_form");

                entity.Property(e => e.DaiHb1s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hb1s");

                entity.Property(e => e.DaiHb2s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hb2s");

                entity.Property(e => e.DaiHb3s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hb3s");

                entity.Property(e => e.DaiHb4s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hb4s");

                entity.Property(e => e.DaiHb5s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hb5s");

                entity.Property(e => e.DaiHn1e)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn1e");

                entity.Property(e => e.DaiHn1s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn1s");

                entity.Property(e => e.DaiHn2e)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn2e");

                entity.Property(e => e.DaiHn2s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn2s");

                entity.Property(e => e.DaiHn3e)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn3e");

                entity.Property(e => e.DaiHn3s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn3s");

                entity.Property(e => e.DaiHn4e)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn4e");

                entity.Property(e => e.DaiHn4s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn4s");

                entity.Property(e => e.DaiHn5e)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn5e");

                entity.Property(e => e.DaiHn5s)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_hn5s");

                entity.Property(e => e.DaiHpd1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd1");

                entity.Property(e => e.DaiHpd2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd2");

                entity.Property(e => e.DaiHpd3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd3");

                entity.Property(e => e.DaiHpd4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd4");

                entity.Property(e => e.DaiHpd5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd5");

                entity.Property(e => e.DaiHpd6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd6");

                entity.Property(e => e.DaiHpd7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd7");

                entity.Property(e => e.DaiHpd8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd8");

                entity.Property(e => e.DaiHpd9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpd9");

                entity.Property(e => e.DaiHpda)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpda");

                entity.Property(e => e.DaiHpdb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdb");

                entity.Property(e => e.DaiHpdc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdc");

                entity.Property(e => e.DaiHpdd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdd");

                entity.Property(e => e.DaiHpde)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpde");

                entity.Property(e => e.DaiHpdf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdf");

                entity.Property(e => e.DaiHpdg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdg");

                entity.Property(e => e.DaiHpdh)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdh");

                entity.Property(e => e.DaiHpdi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdi");

                entity.Property(e => e.DaiHpdj)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdj");

                entity.Property(e => e.DaiHpdk)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpdk");

                entity.Property(e => e.DaiHpfg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_hpfg");

                entity.Property(e => e.DaiItfd)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("dai_itfd");

                entity.Property(e => e.DaiItfp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_itfp");

                entity.Property(e => e.DaiLdhd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("dai_ldhd");

                entity.Property(e => e.DaiLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_line");

                entity.Property(e => e.DaiLstf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_lstf");

                entity.Property(e => e.DaiModl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_modl");

                entity.Property(e => e.DaiNafg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_nafg");

                entity.Property(e => e.DaiName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_name");

                entity.Property(e => e.DaiNbsu)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_nbsu");

                entity.Property(e => e.DaiNdtp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_ndtp");

                entity.Property(e => e.DaiNlbc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_nlbc");

                entity.Property(e => e.DaiNmip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_nmip");

                entity.Property(e => e.DaiNplb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_nplb");

                entity.Property(e => e.DaiObsu)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_obsu");

                entity.Property(e => e.DaiOdai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("dai_odai");

                entity.Property(e => e.DaiOdtp)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_odtp");

                entity.Property(e => e.DaiOlbc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_olbc");

                entity.Property(e => e.DaiOmip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_omip");

                entity.Property(e => e.DaiOplb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_oplb");

                entity.Property(e => e.DaiRsv1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_rsv1");

                entity.Property(e => e.DaiRsv2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_rsv2");

                entity.Property(e => e.DaiToud)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dai_toud");

                entity.Property(e => e.DaiUnj1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj1");

                entity.Property(e => e.DaiUnj2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj2");

                entity.Property(e => e.DaiUnj3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj3");

                entity.Property(e => e.DaiUnj4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj4");

                entity.Property(e => e.DaiUnj5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj5");

                entity.Property(e => e.DaiUnj6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj6");

                entity.Property(e => e.DaiUnj7)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj7");

                entity.Property(e => e.DaiUnj8)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj8");

                entity.Property(e => e.DaiUnj9)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unj9");

                entity.Property(e => e.DaiUnja)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unja");

                entity.Property(e => e.DaiUnjb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjb");

                entity.Property(e => e.DaiUnjc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjc");

                entity.Property(e => e.DaiUnjd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjd");

                entity.Property(e => e.DaiUnje)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unje");

                entity.Property(e => e.DaiUnjf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjf");

                entity.Property(e => e.DaiUnjg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjg");

                entity.Property(e => e.DaiUnjh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjh");

                entity.Property(e => e.DaiUnji)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unji");

                entity.Property(e => e.DaiUnjj)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjj");

                entity.Property(e => e.DaiUnjk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("dai_unjk");

                entity.Property(e => e.DaiUns1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns1");

                entity.Property(e => e.DaiUns2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns2");

                entity.Property(e => e.DaiUns3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns3");

                entity.Property(e => e.DaiUns4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns4");

                entity.Property(e => e.DaiUns5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns5");

                entity.Property(e => e.DaiUns6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns6");

                entity.Property(e => e.DaiUns7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns7");

                entity.Property(e => e.DaiUns8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns8");

                entity.Property(e => e.DaiUns9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uns9");

                entity.Property(e => e.DaiUnsa)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsa");

                entity.Property(e => e.DaiUnsb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsb");

                entity.Property(e => e.DaiUnsc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsc");

                entity.Property(e => e.DaiUnsd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsd");

                entity.Property(e => e.DaiUnse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unse");

                entity.Property(e => e.DaiUnsf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsf");

                entity.Property(e => e.DaiUnsg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsg");

                entity.Property(e => e.DaiUnsh)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsh");

                entity.Property(e => e.DaiUnsi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsi");

                entity.Property(e => e.DaiUnsj)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsj");

                entity.Property(e => e.DaiUnsk)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_unsk");

                entity.Property(e => e.DaiUpt1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt1");

                entity.Property(e => e.DaiUpt2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt2");

                entity.Property(e => e.DaiUpt3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt3");

                entity.Property(e => e.DaiUpt4)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt4");

                entity.Property(e => e.DaiUpt5)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt5");

                entity.Property(e => e.DaiUpt6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt6");

                entity.Property(e => e.DaiUpt7)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt7");

                entity.Property(e => e.DaiUpt8)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt8");

                entity.Property(e => e.DaiUpt9)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upt9");

                entity.Property(e => e.DaiUpta)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upta");

                entity.Property(e => e.DaiUptb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptb");

                entity.Property(e => e.DaiUptc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptc");

                entity.Property(e => e.DaiUptd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptd");

                entity.Property(e => e.DaiUpte)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upte");

                entity.Property(e => e.DaiUptf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptf");

                entity.Property(e => e.DaiUptg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptg");

                entity.Property(e => e.DaiUpth)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upth");

                entity.Property(e => e.DaiUpti)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_upti");

                entity.Property(e => e.DaiUptj)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptj");

                entity.Property(e => e.DaiUptk)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dai_uptk");
            });

            modelBuilder.Entity<DbbackF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbback_f");

                entity.Property(e => e.DbbBksu)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("dbb_bksu");

                entity.Property(e => e.DbbDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("dbb_date");
            });

            modelBuilder.Entity<DokanrM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dokanr_m");

                entity.Property(e => e.DonCono)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("don_cono");

                entity.Property(e => e.DonCont)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("don_cont");

                entity.Property(e => e.DonDate)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("don_date");

                entity.Property(e => e.DonDono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("don_dono");

                entity.Property(e => e.DonNeta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("don_neta");

                entity.Property(e => e.DonNetd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("don_netd");

                entity.Property(e => e.DonPlno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("don_plno");
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
                    .HasColumnName("jis_body");

                entity.Property(e => e.JisCano)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_cano");

                entity.Property(e => e.JisCmnt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("jis_cmnt");

                entity.Property(e => e.JisCono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("jis_cono");

                entity.Property(e => e.JisDaio)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("jis_daio");

                entity.Property(e => e.JisIkan)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("jis_ikan");

                entity.Property(e => e.JisKanc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_kanc");

                entity.Property(e => e.JisKand)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_kand");

                entity.Property(e => e.JisKant)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("jis_kant");

                entity.Property(e => e.JisKasd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_kasd");

                entity.Property(e => e.JisKast)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_kast");

                entity.Property(e => e.JisKoft)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_koft");

                entity.Property(e => e.JisKosd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_kosd");

                entity.Property(e => e.JisKosn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_kosn");

                entity.Property(e => e.JisKost)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_kost");

                entity.Property(e => e.JisKoud)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_koud");

                entity.Property(e => e.JisKout)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("jis_kout");

                entity.Property(e => e.JisKpoc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_kpoc");

                entity.Property(e => e.JisKpod)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_kpod");

                entity.Property(e => e.JisKpot)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("jis_kpot");

                entity.Property(e => e.JisKpsd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_kpsd");

                entity.Property(e => e.JisKpst)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_kpst");

                entity.Property(e => e.JisLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_line");

                entity.Property(e => e.JisMk1h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk1h");

                entity.Property(e => e.JisMk1n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk1n");

                entity.Property(e => e.JisMk2h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk2h");

                entity.Property(e => e.JisMk2n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk2n");

                entity.Property(e => e.JisMk3h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk3h");

                entity.Property(e => e.JisMk3n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk3n");

                entity.Property(e => e.JisMk4h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk4h");

                entity.Property(e => e.JisMk4n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk4n");

                entity.Property(e => e.JisMk5h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk5h");

                entity.Property(e => e.JisMk5n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk5n");

                entity.Property(e => e.JisMk6h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk6h");

                entity.Property(e => e.JisMk6n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk6n");

                entity.Property(e => e.JisMk7h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk7h");

                entity.Property(e => e.JisMk7n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk7n");

                entity.Property(e => e.JisMk8h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk8h");

                entity.Property(e => e.JisMk8n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk8n");

                entity.Property(e => e.JisMk9h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk9h");

                entity.Property(e => e.JisMk9n)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mk9n");

                entity.Property(e => e.JisMkah)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkah");

                entity.Property(e => e.JisMkan)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkan");

                entity.Property(e => e.JisMkbh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkbh");

                entity.Property(e => e.JisMkbn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkbn");

                entity.Property(e => e.JisMkch)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkch");

                entity.Property(e => e.JisMkcn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkcn");

                entity.Property(e => e.JisMkdh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkdh");

                entity.Property(e => e.JisMkdn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkdn");

                entity.Property(e => e.JisMkeh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkeh");

                entity.Property(e => e.JisMken)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mken");

                entity.Property(e => e.JisMkfh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkfh");

                entity.Property(e => e.JisMkfn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkfn");

                entity.Property(e => e.JisMkgh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkgh");

                entity.Property(e => e.JisMkgn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkgn");

                entity.Property(e => e.JisMkhh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkhh");

                entity.Property(e => e.JisMkhn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkhn");

                entity.Property(e => e.JisMkih)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkih");

                entity.Property(e => e.JisMkin)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkin");

                entity.Property(e => e.JisMkjh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkjh");

                entity.Property(e => e.JisMkjn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkjn");

                entity.Property(e => e.JisMkkh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkkh");

                entity.Property(e => e.JisMkkn)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkkn");

                entity.Property(e => e.JisMkrd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkrd");

                entity.Property(e => e.JisMkrt)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkrt");

                entity.Property(e => e.JisMksd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_mksd");

                entity.Property(e => e.JisMkst)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_mkst");

                entity.Property(e => e.JisNakd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_nakd");

                entity.Property(e => e.JisNaks)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("jis_naks");

                entity.Property(e => e.JisNeta)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_neta");

                entity.Property(e => e.JisNetd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_netd");

                entity.Property(e => e.JisOcar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_ocar");

                entity.Property(e => e.JisPlno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("jis_plno");

                entity.Property(e => e.JisPlse)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("jis_plse");

                entity.Property(e => e.JisPono)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("jis_pono");

                entity.Property(e => e.JisSile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_sile");

                entity.Property(e => e.JisSsno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_ssno");

                entity.Property(e => e.JisSstd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_sstd");

                entity.Property(e => e.JisTosd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_tosd");

                entity.Property(e => e.JisTost)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_tost");

                entity.Property(e => e.JisToud)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_toud");

                entity.Property(e => e.JisTout)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("jis_tout");

                entity.Property(e => e.JisUn1h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un1h");

                entity.Property(e => e.JisUn1n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un1n");

                entity.Property(e => e.JisUn2h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un2h");

                entity.Property(e => e.JisUn2n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un2n");

                entity.Property(e => e.JisUn3h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un3h");

                entity.Property(e => e.JisUn3n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un3n");

                entity.Property(e => e.JisUn4h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un4h");

                entity.Property(e => e.JisUn4n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un4n");

                entity.Property(e => e.JisUn5h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un5h");

                entity.Property(e => e.JisUn5n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un5n");

                entity.Property(e => e.JisUn6h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un6h");

                entity.Property(e => e.JisUn6n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un6n");

                entity.Property(e => e.JisUn7h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un7h");

                entity.Property(e => e.JisUn7n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un7n");

                entity.Property(e => e.JisUn8h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un8h");

                entity.Property(e => e.JisUn8n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un8n");

                entity.Property(e => e.JisUn9h)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_un9h");

                entity.Property(e => e.JisUn9n)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_un9n");

                entity.Property(e => e.JisUnah)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unah");

                entity.Property(e => e.JisUnan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unan");

                entity.Property(e => e.JisUnbh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unbh");

                entity.Property(e => e.JisUnbn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unbn");

                entity.Property(e => e.JisUnch)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unch");

                entity.Property(e => e.JisUncn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_uncn");

                entity.Property(e => e.JisUndh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_undh");

                entity.Property(e => e.JisUndn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_undn");

                entity.Property(e => e.JisUneh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_uneh");

                entity.Property(e => e.JisUnen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unen");

                entity.Property(e => e.JisUnfh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unfh");

                entity.Property(e => e.JisUnfn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unfn");

                entity.Property(e => e.JisUngh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_ungh");

                entity.Property(e => e.JisUngn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_ungn");

                entity.Property(e => e.JisUnhh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unhh");

                entity.Property(e => e.JisUnhn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unhn");

                entity.Property(e => e.JisUnih)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unih");

                entity.Property(e => e.JisUnin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unin");

                entity.Property(e => e.JisUnjh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unjh");

                entity.Property(e => e.JisUnjn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unjn");

                entity.Property(e => e.JisUnkh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("jis_unkh");

                entity.Property(e => e.JisUnkn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jis_unkn");

                entity.Property(e => e.JisUnrd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_unrd");

                entity.Property(e => e.JisUnrt)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("jis_unrt");

                entity.Property(e => e.JisUnsd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("jis_unsd");

                entity.Property(e => e.JisUnst)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jis_unst");

                entity.Property(e => e.JisVers)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("jis_vers");
            });

            modelBuilder.Entity<KokenjF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kokenj_f");

                entity.Property(e => e.KokDate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("kok_date");

                entity.Property(e => e.KokFtyo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kok_ftyo");

                entity.Property(e => e.KokKens)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kok_kens");

                entity.Property(e => e.KokLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("kok_line");

                entity.Property(e => e.KokTime)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kok_time");

                entity.Property(e => e.KokTyok)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("kok_tyok");
            });

            modelBuilder.Entity<MntstaF>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mntsta_f");

                entity.Property(e => e.CheData)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("che_data");

                entity.Property(e => e.MntSta1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mnt_sta1");
            });

            modelBuilder.Entity<RtdateM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rtdate_m");

                entity.Property(e => e.RtdEndd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("rtd_endd");

                entity.Property(e => e.RtdStat)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("rtd_stat");
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
                    .HasColumnName("sil_bkfg");

                entity.Property(e => e.SilBody)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sil_body");

                entity.Property(e => e.SilClfg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sil_clfg");

                entity.Property(e => e.SilDaio)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("sil_daio");

                entity.Property(e => e.SilHpfg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sil_hpfg");

                entity.Property(e => e.SilLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sil_line");

                entity.Property(e => e.SilSile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sil_sile");
            });

            modelBuilder.Entity<SystemM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("system_m");

                entity.Property(e => e.Sys1qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_1qed");

                entity.Property(e => e.Sys1qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_1qst");

                entity.Property(e => e.Sys2qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_2qed");

                entity.Property(e => e.Sys2qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_2qst");

                entity.Property(e => e.Sys3qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_3qed");

                entity.Property(e => e.Sys3qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_3qst");

                entity.Property(e => e.Sys4qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_4qed");

                entity.Property(e => e.Sys4qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_4qst");

                entity.Property(e => e.Sys5qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_5qed");

                entity.Property(e => e.Sys5qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_5qst");

                entity.Property(e => e.SysBdck)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sys_bdck");

                entity.Property(e => e.SysIkan)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("sys_ikan");

                entity.Property(e => e.SysKyot)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sys_kyot");

                entity.Property(e => e.SysLenc)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("sys_lenc");

                entity.Property(e => e.SysLenn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sys_lenn");

                entity.Property(e => e.SysLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sys_line");

                entity.Property(e => e.SysName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sys_name");

                entity.Property(e => e.SysPack)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("sys_pack");

                entity.Property(e => e.SysPint)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_pint");

                entity.Property(e => e.SysPlms)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("sys_plms");

                entity.Property(e => e.SysPlno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("sys_plno");
            });

            modelBuilder.Entity<TckanrM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tckanr_m");

                entity.Property(e => e.TckBuh1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh1");

                entity.Property(e => e.TckBuh2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh2");

                entity.Property(e => e.TckBuh3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh3");

                entity.Property(e => e.TckBuh4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh4");

                entity.Property(e => e.TckBuh5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh5");

                entity.Property(e => e.TckBuh6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh6");

                entity.Property(e => e.TckBuh7)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh7");

                entity.Property(e => e.TckBuh8)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh8");

                entity.Property(e => e.TckBuh9)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buh9");

                entity.Property(e => e.TckBuha)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buha");

                entity.Property(e => e.TckBuhb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhb");

                entity.Property(e => e.TckBuhc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhc");

                entity.Property(e => e.TckBuhd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhd");

                entity.Property(e => e.TckBuhe)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhe");

                entity.Property(e => e.TckBuhf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhf");

                entity.Property(e => e.TckBuhg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhg");

                entity.Property(e => e.TckBuhh)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhh");

                entity.Property(e => e.TckBuhi)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhi");

                entity.Property(e => e.TckBuhj)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhj");

                entity.Property(e => e.TckBuhk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_buhk");

                entity.Property(e => e.TckLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_line");

                entity.Property(e => e.TckUnt1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt1");

                entity.Property(e => e.TckUnt2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt2");

                entity.Property(e => e.TckUnt3)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt3");

                entity.Property(e => e.TckUnt4)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt4");

                entity.Property(e => e.TckUnt5)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt5");

                entity.Property(e => e.TckUnt6)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt6");

                entity.Property(e => e.TckUnt7)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt7");

                entity.Property(e => e.TckUnt8)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt8");

                entity.Property(e => e.TckUnt9)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unt9");

                entity.Property(e => e.TckUnta)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unta");

                entity.Property(e => e.TckUntb)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untb");

                entity.Property(e => e.TckUntc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untc");

                entity.Property(e => e.TckUntd)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untd");

                entity.Property(e => e.TckUnte)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unte");

                entity.Property(e => e.TckUntf)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untf");

                entity.Property(e => e.TckUntg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untg");

                entity.Property(e => e.TckUnth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unth");

                entity.Property(e => e.TckUnti)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_unti");

                entity.Property(e => e.TckUntj)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untj");

                entity.Property(e => e.TckUntk)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tck_untk");
            });

            modelBuilder.Entity<TyokutM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tyokut_m");

                entity.Property(e => e.Sys1qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_1qed");

                entity.Property(e => e.Sys1qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_1qst");

                entity.Property(e => e.Sys2qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_2qed");

                entity.Property(e => e.Sys2qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_2qst");

                entity.Property(e => e.Sys3qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_3qed");

                entity.Property(e => e.Sys3qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_3qst");

                entity.Property(e => e.Sys4qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_4qed");

                entity.Property(e => e.Sys4qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_4qst");

                entity.Property(e => e.Sys5qed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_5qed");

                entity.Property(e => e.Sys5qst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_5qst");

                entity.Property(e => e.SysPint)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("sys_pint");

                entity.Property(e => e.Tyo1sed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_1sed");

                entity.Property(e => e.Tyo1sst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_1sst");

                entity.Property(e => e.Tyo2sed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_2sed");

                entity.Property(e => e.Tyo2sst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_2sst");

                entity.Property(e => e.Tyo3sed)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_3sed");

                entity.Property(e => e.Tyo3sst)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_3sst");

                entity.Property(e => e.TyoLine)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tyo_line");

                entity.Property(e => e.TyoPint)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("tyo_pint");

                entity.Property(e => e.TyoType)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("tyo_type");
            });

            modelBuilder.Entity<UnitsgM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("unitsg_m");

                entity.Property(e => e.UniBuba)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("uni_buba");

                entity.Property(e => e.UniCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uni_code");

                entity.Property(e => e.UniPtan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("uni_ptan");

                entity.Property(e => e.UniType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("uni_type");
            });

            modelBuilder.Entity<UnnameM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("unname_m");

                entity.Property(e => e.UnnCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("unn_code");

                entity.Property(e => e.UnnHpnm)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("unn_hpnm");

                entity.Property(e => e.UnnName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("unn_name");
            });

            modelBuilder.Entity<WorkerM>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("worker_m");

                entity.Property(e => e.WokCmnt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("wok_cmnt");

                entity.Property(e => e.WokCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("wok_code");

                entity.Property(e => e.WokName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("wok_name");

                entity.Property(e => e.WokZoku)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("wok_zoku");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
