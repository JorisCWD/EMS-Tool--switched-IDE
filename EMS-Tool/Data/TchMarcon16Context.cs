using System;
using System.Collections.Generic;
using EMS_Tool.Model.Marcon;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Data;

public partial class TchMarcon16Context : DbContext
{
    public TchMarcon16Context()
    {
    }

    public TchMarcon16Context(DbContextOptions<TchMarcon16Context> options)
        : base(options)
    {
    }

    public virtual DbSet<History> Histories { get; set; }

    public virtual DbSet<Info> Infos { get; set; }

    public virtual DbSet<Marcon16Os100Grfdbx272> Marcon16Os100Grfdbx272s { get; set; }

    public virtual DbSet<Marcon16Os103Grfdbx486> Marcon16Os103Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os105Grfdbx486> Marcon16Os105Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os107Grfdbx486> Marcon16Os107Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os10Grfdbx349> Marcon16Os10Grfdbx349s { get; set; }

    public virtual DbSet<Marcon16Os10Grfdbx373> Marcon16Os10Grfdbx373s { get; set; }

    public virtual DbSet<Marcon16Os110Grfdbx486> Marcon16Os110Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os111Grfdbx486> Marcon16Os111Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os114Grfdbx486> Marcon16Os114Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os116Grfdbx787> Marcon16Os116Grfdbx787s { get; set; }

    public virtual DbSet<Marcon16Os118Grfdbx272> Marcon16Os118Grfdbx272s { get; set; }

    public virtual DbSet<Marcon16Os119Grfdbx486> Marcon16Os119Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os11Grfdbx349> Marcon16Os11Grfdbx349s { get; set; }

    public virtual DbSet<Marcon16Os11Grfdbx373> Marcon16Os11Grfdbx373s { get; set; }

    public virtual DbSet<Marcon16Os120Grfdbx486> Marcon16Os120Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os122Grfdbx486> Marcon16Os122Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os123Grfdbx486> Marcon16Os123Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os125Grfdbx486> Marcon16Os125Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os127Grfdbx486> Marcon16Os127Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os129Grfdbx486> Marcon16Os129Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os12Grfdbx349> Marcon16Os12Grfdbx349s { get; set; }

    public virtual DbSet<Marcon16Os12Grfdbx373> Marcon16Os12Grfdbx373s { get; set; }

    public virtual DbSet<Marcon16Os131Grfdbx486> Marcon16Os131Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os133Grfdbx568> Marcon16Os133Grfdbx568s { get; set; }

    public virtual DbSet<Marcon16Os134Grfdbx583> Marcon16Os134Grfdbx583s { get; set; }

    public virtual DbSet<Marcon16Os135Grfdbx486> Marcon16Os135Grfdbx486s { get; set; }

    public virtual DbSet<Marcon16Os13Grfdbx349> Marcon16Os13Grfdbx349s { get; set; }

    public virtual DbSet<Marcon16Os13Grfdbx373> Marcon16Os13Grfdbx373s { get; set; }

    public virtual DbSet<Marcon16Os14Grfdbx355> Marcon16Os14Grfdbx355s { get; set; }

    public virtual DbSet<Marcon16Os14Grfdbx379> Marcon16Os14Grfdbx379s { get; set; }

    public virtual DbSet<Marcon16Os15Grfdbx355> Marcon16Os15Grfdbx355s { get; set; }

    public virtual DbSet<Marcon16Os15Grfdbx379> Marcon16Os15Grfdbx379s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet10> Marcon16Os1Grfmet10s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet11> Marcon16Os1Grfmet11s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet12> Marcon16Os1Grfmet12s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet13> Marcon16Os1Grfmet13s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet14> Marcon16Os1Grfmet14s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet15> Marcon16Os1Grfmet15s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet17> Marcon16Os1Grfmet17s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet19> Marcon16Os1Grfmet19s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet36> Marcon16Os1Grfmet36s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet37> Marcon16Os1Grfmet37s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet42> Marcon16Os1Grfmet42s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet45> Marcon16Os1Grfmet45s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet48> Marcon16Os1Grfmet48s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet49> Marcon16Os1Grfmet49s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet50> Marcon16Os1Grfmet50s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet51> Marcon16Os1Grfmet51s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet52> Marcon16Os1Grfmet52s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet8> Marcon16Os1Grfmet8s { get; set; }

    public virtual DbSet<Marcon16Os1Grfmet9> Marcon16Os1Grfmet9s { get; set; }

    public virtual DbSet<Marcon16Os1Grfsys1> Marcon16Os1Grfsys1s { get; set; }

    public virtual DbSet<Marcon16Os1Grfsys31> Marcon16Os1Grfsys31s { get; set; }

    public virtual DbSet<Marcon16Os1Grfsys33> Marcon16Os1Grfsys33s { get; set; }

    public virtual DbSet<Marcon16Os271Grfdbx905> Marcon16Os271Grfdbx905s { get; set; }

    public virtual DbSet<Marcon16Os272Grfdbx905> Marcon16Os272Grfdbx905s { get; set; }

    public virtual DbSet<Marcon16Os273Grfdbx905> Marcon16Os273Grfdbx905s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet10> Marcon16Os2Grfmet10s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet105> Marcon16Os2Grfmet105s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet106> Marcon16Os2Grfmet106s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet107> Marcon16Os2Grfmet107s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet112> Marcon16Os2Grfmet112s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet12> Marcon16Os2Grfmet12s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet20> Marcon16Os2Grfmet20s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet21> Marcon16Os2Grfmet21s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet23> Marcon16Os2Grfmet23s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet28> Marcon16Os2Grfmet28s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet35> Marcon16Os2Grfmet35s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet36> Marcon16Os2Grfmet36s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet37> Marcon16Os2Grfmet37s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet39> Marcon16Os2Grfmet39s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet41> Marcon16Os2Grfmet41s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet42> Marcon16Os2Grfmet42s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet43> Marcon16Os2Grfmet43s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet49> Marcon16Os2Grfmet49s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet50> Marcon16Os2Grfmet50s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet52> Marcon16Os2Grfmet52s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet53> Marcon16Os2Grfmet53s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet54> Marcon16Os2Grfmet54s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet55> Marcon16Os2Grfmet55s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet6> Marcon16Os2Grfmet6s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet63> Marcon16Os2Grfmet63s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet64> Marcon16Os2Grfmet64s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet66> Marcon16Os2Grfmet66s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet7> Marcon16Os2Grfmet7s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet71> Marcon16Os2Grfmet71s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet78> Marcon16Os2Grfmet78s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet79> Marcon16Os2Grfmet79s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet80> Marcon16Os2Grfmet80s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet82> Marcon16Os2Grfmet82s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet84> Marcon16Os2Grfmet84s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet85> Marcon16Os2Grfmet85s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet86> Marcon16Os2Grfmet86s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet87> Marcon16Os2Grfmet87s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet88> Marcon16Os2Grfmet88s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet9> Marcon16Os2Grfmet9s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet95> Marcon16Os2Grfmet95s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet98> Marcon16Os2Grfmet98s { get; set; }

    public virtual DbSet<Marcon16Os2Grfmet99> Marcon16Os2Grfmet99s { get; set; }

    public virtual DbSet<Marcon16Os2Grfpid12> Marcon16Os2Grfpid12s { get; set; }

    public virtual DbSet<Marcon16Os2Grfpid13> Marcon16Os2Grfpid13s { get; set; }

    public virtual DbSet<Marcon16Os2Grfpid21> Marcon16Os2Grfpid21s { get; set; }

    public virtual DbSet<Marcon16Os2Grfpid28> Marcon16Os2Grfpid28s { get; set; }

    public virtual DbSet<Marcon16Os2Grfpid31> Marcon16Os2Grfpid31s { get; set; }

    public virtual DbSet<Marcon16Os2Grfpid33> Marcon16Os2Grfpid33s { get; set; }

    public virtual DbSet<Marcon16Os2Grfpid6> Marcon16Os2Grfpid6s { get; set; }

    public virtual DbSet<Marcon16Os2Grfsys1> Marcon16Os2Grfsys1s { get; set; }

    public virtual DbSet<Marcon16Os2Grfsys3> Marcon16Os2Grfsys3s { get; set; }

    public virtual DbSet<Marcon16Os2Mbf0> Marcon16Os2Mbf0s { get; set; }

    public virtual DbSet<Marcon16Os300Grfdbx801> Marcon16Os300Grfdbx801s { get; set; }

    public virtual DbSet<Marcon16Os301Grfdbx801> Marcon16Os301Grfdbx801s { get; set; }

    public virtual DbSet<Marcon16Os302Grfdbx801> Marcon16Os302Grfdbx801s { get; set; }

    public virtual DbSet<Marcon16Os305Grfdbx801> Marcon16Os305Grfdbx801s { get; set; }

    public virtual DbSet<Marcon16Os306Grfdbx641> Marcon16Os306Grfdbx641s { get; set; }

    public virtual DbSet<Marcon16Os308Grfdbx819> Marcon16Os308Grfdbx819s { get; set; }

    public virtual DbSet<Marcon16Os309Grfdbx819> Marcon16Os309Grfdbx819s { get; set; }

    public virtual DbSet<Marcon16Os310Grfdbx819> Marcon16Os310Grfdbx819s { get; set; }

    public virtual DbSet<Marcon16Os312Grfdbx429> Marcon16Os312Grfdbx429s { get; set; }

    public virtual DbSet<Marcon16Os313Grfdbx213> Marcon16Os313Grfdbx213s { get; set; }

    public virtual DbSet<Marcon16Os313Grfdbx677> Marcon16Os313Grfdbx677s { get; set; }

    public virtual DbSet<Marcon16Os314Grfdbx677> Marcon16Os314Grfdbx677s { get; set; }

    public virtual DbSet<Marcon16Os314Grfdbx690> Marcon16Os314Grfdbx690s { get; set; }

    public virtual DbSet<Marcon16Os316Grfdbx213> Marcon16Os316Grfdbx213s { get; set; }

    public virtual DbSet<Marcon16Os3Grfsys3> Marcon16Os3Grfsys3s { get; set; }

    public virtual DbSet<Marcon16Os3Grfsys4> Marcon16Os3Grfsys4s { get; set; }

    public virtual DbSet<Marcon16Os3Grfsys5> Marcon16Os3Grfsys5s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys105> Marcon16Os7Grfsys105s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys107> Marcon16Os7Grfsys107s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys108> Marcon16Os7Grfsys108s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys134> Marcon16Os7Grfsys134s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys136> Marcon16Os7Grfsys136s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys137> Marcon16Os7Grfsys137s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys147> Marcon16Os7Grfsys147s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys163> Marcon16Os7Grfsys163s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys165> Marcon16Os7Grfsys165s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys166> Marcon16Os7Grfsys166s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys19> Marcon16Os7Grfsys19s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys192> Marcon16Os7Grfsys192s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys194> Marcon16Os7Grfsys194s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys195> Marcon16Os7Grfsys195s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys221> Marcon16Os7Grfsys221s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys236> Marcon16Os7Grfsys236s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys26> Marcon16Os7Grfsys26s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys43> Marcon16Os7Grfsys43s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys45> Marcon16Os7Grfsys45s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys46> Marcon16Os7Grfsys46s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys7> Marcon16Os7Grfsys7s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys76> Marcon16Os7Grfsys76s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys78> Marcon16Os7Grfsys78s { get; set; }

    public virtual DbSet<Marcon16Os7Grfsys79> Marcon16Os7Grfsys79s { get; set; }

    public virtual DbSet<Punten> Puntens { get; set; }

    public virtual DbSet<PuntenExtern> PuntenExterns { get; set; }

    public virtual DbSet<PuntenExtraInfo> PuntenExtraInfos { get; set; }

    public virtual DbSet<PuntenOpcNativeLabel> PuntenOpcNativeLabels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=c2018484;Initial Catalog=TCH_MARCON16;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<History>(entity =>
        {
            entity.Property(e => e.DatabaseNaam).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Eenheid).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HistoryOmschrijving).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HistoryTabel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ProjectNaam).UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Info>(entity =>
        {
            entity.Property(e => e.Sinfo).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Sinfonaam).UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Marcon16Os100Grfdbx272>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS100_GRFDBX_272_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os103Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS103_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os105Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS105_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os107Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS107_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os10Grfdbx349>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("MARCON16_OS10_GRFDBX_349_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os10Grfdbx373>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS10_GRFDBX_373_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os110Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS110_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os111Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS111_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os114Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS114_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os116Grfdbx787>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS116_GRFDBX_787_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os118Grfdbx272>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS118_GRFDBX_272_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os119Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS119_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os11Grfdbx349>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS11_GRFDBX_349_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os11Grfdbx373>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS11_GRFDBX_373_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os120Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS120_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os122Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS122_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os123Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS123_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os125Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS125_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os127Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS127_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os129Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS129_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os12Grfdbx349>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS12_GRFDBX_349_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os12Grfdbx373>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS12_GRFDBX_373_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os131Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS131_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os133Grfdbx568>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS133_GRFDBX_568_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os134Grfdbx583>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS134_GRFDBX_583_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os135Grfdbx486>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS135_GRFDBX_486_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os13Grfdbx349>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS13_GRFDBX_349_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os13Grfdbx373>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS13_GRFDBX_373_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os14Grfdbx355>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS14_GRFDBX_355_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os14Grfdbx379>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS14_GRFDBX_379_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os15Grfdbx355>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS15_GRFDBX_355_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os15Grfdbx379>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS15_GRFDBX_379_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet15>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_15_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet17>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_17_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet19>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_19_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet36>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_36_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet37>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_37_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet42>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_42_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet45>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_45_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet48>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_48_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet49>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_49_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet50>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_50_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet51>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_51_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet52>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_52_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet8>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_8_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfmet9>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFMET_9_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfsys1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFSYS_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfsys31>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFSYS_31_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os1Grfsys33>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS1_GRFSYS_33_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os271Grfdbx905>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS271_GRFDBX_905_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os272Grfdbx905>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS272_GRFDBX_905_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os273Grfdbx905>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS273_GRFDBX_905_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet10>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_10_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet105>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_105_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet106>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_106_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet107>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_107_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet112>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_112_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet12>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_12_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet20>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_20_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet21>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_21_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet23>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_23_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet28>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_28_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet35>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_35_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet36>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_36_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet37>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_37_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet39>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_39_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet41>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_41_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet42>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_42_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet43>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_43_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet49>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_49_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet50>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_50_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet52>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_52_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet53>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_53_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet54>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_54_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet55>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_55_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet6>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_6_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet63>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_63_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet64>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_64_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet66>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_66_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet7>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_7_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet71>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_71_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet78>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_78_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet79>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_79_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet80>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_80_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet82>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_82_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet84>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_84_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet85>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_85_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet86>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_86_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet87>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_87_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet88>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_88_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet9>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_9_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet95>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_95_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet98>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_98_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfmet99>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFMET_99_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfpid12>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFPID_12_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfpid13>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFPID_13_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfpid21>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFPID_21_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfpid28>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFPID_28_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfpid31>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFPID_31_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfpid33>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFPID_33_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfpid6>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFPID_6_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfsys1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFSYS_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Grfsys3>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS2_GRFSYS_3_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os2Mbf0>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("Marcon16_OS2_MBF_0_ID")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os300Grfdbx801>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS300_GRFDBX_801_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os301Grfdbx801>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS301_GRFDBX_801_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os302Grfdbx801>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS302_GRFDBX_801_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os305Grfdbx801>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS305_GRFDBX_801_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os306Grfdbx641>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS306_GRFDBX_641_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os308Grfdbx819>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS308_GRFDBX_819_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os309Grfdbx819>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS309_GRFDBX_819_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os310Grfdbx819>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS310_GRFDBX_819_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os312Grfdbx429>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS312_GRFDBX_429_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os313Grfdbx213>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS313_GRFDBX_213_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os313Grfdbx677>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS313_GRFDBX_677_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os314Grfdbx677>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS314_GRFDBX_677_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os314Grfdbx690>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS314_GRFDBX_690_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os316Grfdbx213>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS316_GRFDBX_213_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os3Grfsys3>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS3_GRFSYS_3_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os3Grfsys4>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS3_GRFSYS_4_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os3Grfsys5>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS3_GRFSYS_5_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys105>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_105_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys107>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_107_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys108>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_108_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys134>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_134_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys136>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_136_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys137>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_137_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys147>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_147_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys163>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_163_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys165>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_165_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys166>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_166_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys19>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_19_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys192>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_192_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys194>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_194_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys195>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_195_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys221>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_221_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys236>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_236_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys26>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_26_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys43>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_43_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys45>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_45_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys46>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_46_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys7>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_7_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys76>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_76_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys78>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_78_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Marcon16Os7Grfsys79>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("Marcon16_OS7_GRFSYS_79_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Punten>(entity =>
        {
            entity.HasKey(e => e.PuntId)
                .HasName("Punten_Punt_ID")
                .IsClustered(false);

            entity.Property(e => e.Commentaar).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Label).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Omschrijving).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Project).UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<PuntenExtern>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PuntenExtraInfo>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
