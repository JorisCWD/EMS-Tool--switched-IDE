using System;
using System.Collections.Generic;
using EMS_Tool.Model.MuseumMore;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Data;

public partial class TchW0814080Context : DbContext
{
    public TchW0814080Context()
    {
    }

    public TchW0814080Context(DbContextOptions<TchW0814080Context> options)
        : base(options)
    {
    }

    public virtual DbSet<History> Histories { get; set; }

    public virtual DbSet<Info> Infos { get; set; }

    public virtual DbSet<KWhWkoMaand> KWhWkoMaands { get; set; }

    public virtual DbSet<KWhWkoUur> KWhWkoUurs { get; set; }

    public virtual DbSet<KWhWpMaand> KWhWpMaands { get; set; }

    public virtual DbSet<KWhWpUur> KWhWpUurs { get; set; }

    public virtual DbSet<Punten> Puntens { get; set; }

    public virtual DbSet<PuntenExtern> PuntenExterns { get; set; }

    public virtual DbSet<PuntenExtraInfo> PuntenExtraInfos { get; set; }

    public virtual DbSet<PuntenHistory> PuntenHistories { get; set; }

    public virtual DbSet<PuntenOpcNativeLabel> PuntenOpcNativeLabels { get; set; }

    public virtual DbSet<QKTotMaand> QKTotMaands { get; set; }

    public virtual DbSet<QKTotUur> QKTotUurs { get; set; }

    public virtual DbSet<QWTotMaand> QWTotMaands { get; set; }

    public virtual DbSet<QWTotUur> QWTotUurs { get; set; }

    public virtual DbSet<W0814080Os1Grfmet1> W0814080Os1Grfmet1s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet13> W0814080Os1Grfmet13s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet18> W0814080Os1Grfmet18s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet21> W0814080Os1Grfmet21s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet22> W0814080Os1Grfmet22s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet23> W0814080Os1Grfmet23s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet24> W0814080Os1Grfmet24s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet25> W0814080Os1Grfmet25s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet30> W0814080Os1Grfmet30s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet31> W0814080Os1Grfmet31s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet36> W0814080Os1Grfmet36s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet39> W0814080Os1Grfmet39s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet40> W0814080Os1Grfmet40s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet41> W0814080Os1Grfmet41s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet42> W0814080Os1Grfmet42s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet43> W0814080Os1Grfmet43s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet46> W0814080Os1Grfmet46s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet48> W0814080Os1Grfmet48s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet50> W0814080Os1Grfmet50s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet58> W0814080Os1Grfmet58s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet6> W0814080Os1Grfmet6s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet60> W0814080Os1Grfmet60s { get; set; }

    public virtual DbSet<W0814080Os1Grfmet7> W0814080Os1Grfmet7s { get; set; }

    public virtual DbSet<W0814080Os1Grfpid1> W0814080Os1Grfpid1s { get; set; }

    public virtual DbSet<W0814080Os1Grfpid10> W0814080Os1Grfpid10s { get; set; }

    public virtual DbSet<W0814080Os1Grfpid15> W0814080Os1Grfpid15s { get; set; }

    public virtual DbSet<W0814080Os1Grfpid16> W0814080Os1Grfpid16s { get; set; }

    public virtual DbSet<W0814080Os1Grfpid17> W0814080Os1Grfpid17s { get; set; }

    public virtual DbSet<W0814080Os1Grfpid18> W0814080Os1Grfpid18s { get; set; }

    public virtual DbSet<W0814080Os1Grfpid19> W0814080Os1Grfpid19s { get; set; }

    public virtual DbSet<W0814080Os1Grfpid2> W0814080Os1Grfpid2s { get; set; }

    public virtual DbSet<W0814080Os1Grfpid20> W0814080Os1Grfpid20s { get; set; }

    public virtual DbSet<W0814080Os1Grfpid5> W0814080Os1Grfpid5s { get; set; }

    public virtual DbSet<W0814080Os1Grfpid6> W0814080Os1Grfpid6s { get; set; }

    public virtual DbSet<W0814080Os1Grfpid7> W0814080Os1Grfpid7s { get; set; }

    public virtual DbSet<W0814080Os1Grfpid8> W0814080Os1Grfpid8s { get; set; }

    public virtual DbSet<W0814080Os1Grfsys15> W0814080Os1Grfsys15s { get; set; }

    public virtual DbSet<W0814080Os1Grfsys2> W0814080Os1Grfsys2s { get; set; }

    public virtual DbSet<W0814080Os1Grfsys24> W0814080Os1Grfsys24s { get; set; }

    public virtual DbSet<W0814080Os1Grfsys27> W0814080Os1Grfsys27s { get; set; }

    public virtual DbSet<W0814080Os1Grfsys28> W0814080Os1Grfsys28s { get; set; }

    public virtual DbSet<W0814080Os1Grfsys31> W0814080Os1Grfsys31s { get; set; }

    public virtual DbSet<W0814080Os1Grfsys42> W0814080Os1Grfsys42s { get; set; }

    public virtual DbSet<W0814080Os1Grfsys6> W0814080Os1Grfsys6s { get; set; }

    public virtual DbSet<W0814080Os1Tabsys1> W0814080Os1Tabsys1s { get; set; }

    public virtual DbSet<W0814080Os1Tabsys10> W0814080Os1Tabsys10s { get; set; }

    public virtual DbSet<W0814080Os1Tabsys4> W0814080Os1Tabsys4s { get; set; }

    public virtual DbSet<W0814080Os1Tabsys55> W0814080Os1Tabsys55s { get; set; }

    public virtual DbSet<W0814080Os1Tabsys61> W0814080Os1Tabsys61s { get; set; }

    public virtual DbSet<W0814080Os1Tabsys7> W0814080Os1Tabsys7s { get; set; }

    public virtual DbSet<W0814080Os2Grfbuf1> W0814080Os2Grfbuf1s { get; set; }

    public virtual DbSet<W0814080Os2Grfbuf10> W0814080Os2Grfbuf10s { get; set; }

    public virtual DbSet<W0814080Os2Grfbuf11> W0814080Os2Grfbuf11s { get; set; }

    public virtual DbSet<W0814080Os2Grfbuf35> W0814080Os2Grfbuf35s { get; set; }

    public virtual DbSet<W0814080Os2Grfbuf36> W0814080Os2Grfbuf36s { get; set; }

    public virtual DbSet<W0814080Os2Grfbuf37> W0814080Os2Grfbuf37s { get; set; }

    public virtual DbSet<W0814080Os2Grfbuf38> W0814080Os2Grfbuf38s { get; set; }

    public virtual DbSet<W0814080Os2Grfbuf39> W0814080Os2Grfbuf39s { get; set; }

    public virtual DbSet<W0814080Os2Grfbuf4> W0814080Os2Grfbuf4s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet1> W0814080Os2Grfmet1s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet100> W0814080Os2Grfmet100s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet103> W0814080Os2Grfmet103s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet106> W0814080Os2Grfmet106s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet107> W0814080Os2Grfmet107s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet112> W0814080Os2Grfmet112s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet113> W0814080Os2Grfmet113s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet114> W0814080Os2Grfmet114s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet121> W0814080Os2Grfmet121s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet122> W0814080Os2Grfmet122s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet123> W0814080Os2Grfmet123s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet124> W0814080Os2Grfmet124s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet133> W0814080Os2Grfmet133s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet134> W0814080Os2Grfmet134s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet139> W0814080Os2Grfmet139s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet140> W0814080Os2Grfmet140s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet146> W0814080Os2Grfmet146s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet149> W0814080Os2Grfmet149s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet15> W0814080Os2Grfmet15s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet150> W0814080Os2Grfmet150s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet151> W0814080Os2Grfmet151s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet162> W0814080Os2Grfmet162s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet164> W0814080Os2Grfmet164s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet166> W0814080Os2Grfmet166s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet170> W0814080Os2Grfmet170s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet18> W0814080Os2Grfmet18s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet19> W0814080Os2Grfmet19s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet25> W0814080Os2Grfmet25s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet28> W0814080Os2Grfmet28s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet35> W0814080Os2Grfmet35s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet38> W0814080Os2Grfmet38s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet4> W0814080Os2Grfmet4s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet45> W0814080Os2Grfmet45s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet48> W0814080Os2Grfmet48s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet5> W0814080Os2Grfmet5s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet51> W0814080Os2Grfmet51s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet55> W0814080Os2Grfmet55s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet58> W0814080Os2Grfmet58s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet65> W0814080Os2Grfmet65s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet68> W0814080Os2Grfmet68s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet69> W0814080Os2Grfmet69s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet70> W0814080Os2Grfmet70s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet73> W0814080Os2Grfmet73s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet74> W0814080Os2Grfmet74s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet78> W0814080Os2Grfmet78s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet8> W0814080Os2Grfmet8s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet80> W0814080Os2Grfmet80s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet82> W0814080Os2Grfmet82s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet85> W0814080Os2Grfmet85s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet89> W0814080Os2Grfmet89s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet91> W0814080Os2Grfmet91s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet92> W0814080Os2Grfmet92s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet93> W0814080Os2Grfmet93s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet94> W0814080Os2Grfmet94s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet95> W0814080Os2Grfmet95s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet98> W0814080Os2Grfmet98s { get; set; }

    public virtual DbSet<W0814080Os2Grfmet99> W0814080Os2Grfmet99s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid1> W0814080Os2Grfpid1s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid11> W0814080Os2Grfpid11s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid13> W0814080Os2Grfpid13s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid18> W0814080Os2Grfpid18s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid19> W0814080Os2Grfpid19s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid28> W0814080Os2Grfpid28s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid29> W0814080Os2Grfpid29s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid3> W0814080Os2Grfpid3s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid30> W0814080Os2Grfpid30s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid32> W0814080Os2Grfpid32s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid38> W0814080Os2Grfpid38s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid42> W0814080Os2Grfpid42s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid43> W0814080Os2Grfpid43s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid47> W0814080Os2Grfpid47s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid48> W0814080Os2Grfpid48s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid49> W0814080Os2Grfpid49s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid5> W0814080Os2Grfpid5s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid50> W0814080Os2Grfpid50s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid52> W0814080Os2Grfpid52s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid53> W0814080Os2Grfpid53s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid54> W0814080Os2Grfpid54s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid55> W0814080Os2Grfpid55s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid56> W0814080Os2Grfpid56s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid7> W0814080Os2Grfpid7s { get; set; }

    public virtual DbSet<W0814080Os2Grfpid9> W0814080Os2Grfpid9s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys1> W0814080Os2Grfsys1s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys10> W0814080Os2Grfsys10s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys11> W0814080Os2Grfsys11s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys12> W0814080Os2Grfsys12s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys14> W0814080Os2Grfsys14s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys15> W0814080Os2Grfsys15s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys16> W0814080Os2Grfsys16s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys17> W0814080Os2Grfsys17s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys19> W0814080Os2Grfsys19s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys2> W0814080Os2Grfsys2s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys20> W0814080Os2Grfsys20s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys21> W0814080Os2Grfsys21s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys22> W0814080Os2Grfsys22s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys24> W0814080Os2Grfsys24s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys25> W0814080Os2Grfsys25s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys26> W0814080Os2Grfsys26s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys27> W0814080Os2Grfsys27s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys29> W0814080Os2Grfsys29s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys30> W0814080Os2Grfsys30s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys31> W0814080Os2Grfsys31s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys32> W0814080Os2Grfsys32s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys34> W0814080Os2Grfsys34s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys35> W0814080Os2Grfsys35s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys36> W0814080Os2Grfsys36s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys37> W0814080Os2Grfsys37s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys39> W0814080Os2Grfsys39s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys4> W0814080Os2Grfsys4s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys40> W0814080Os2Grfsys40s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys5> W0814080Os2Grfsys5s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys54> W0814080Os2Grfsys54s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys58> W0814080Os2Grfsys58s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys61> W0814080Os2Grfsys61s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys62> W0814080Os2Grfsys62s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys68> W0814080Os2Grfsys68s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys69> W0814080Os2Grfsys69s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys7> W0814080Os2Grfsys7s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys70> W0814080Os2Grfsys70s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys73> W0814080Os2Grfsys73s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys8> W0814080Os2Grfsys8s { get; set; }

    public virtual DbSet<W0814080Os2Grfsys9> W0814080Os2Grfsys9s { get; set; }

    public virtual DbSet<W0814080Os2Tabsys1> W0814080Os2Tabsys1s { get; set; }

    public virtual DbSet<W0814080Os2Tabsys19> W0814080Os2Tabsys19s { get; set; }

    public virtual DbSet<W0814080Os2Tabsys22> W0814080Os2Tabsys22s { get; set; }

    public virtual DbSet<W0814080Os2Tabsys4> W0814080Os2Tabsys4s { get; set; }

    public virtual DbSet<W0814080Os2Tabsys43> W0814080Os2Tabsys43s { get; set; }

    public virtual DbSet<W0814080Os2Tabsys49> W0814080Os2Tabsys49s { get; set; }

    public virtual DbSet<W0814080Os2Tabsys88> W0814080Os2Tabsys88s { get; set; }

    public virtual DbSet<W0814080Os2Tabsys94> W0814080Os2Tabsys94s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys100> W0814080Os3Tabsys100s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys103> W0814080Os3Tabsys103s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys104> W0814080Os3Tabsys104s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys116> W0814080Os3Tabsys116s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys120> W0814080Os3Tabsys120s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys126> W0814080Os3Tabsys126s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys130> W0814080Os3Tabsys130s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys131> W0814080Os3Tabsys131s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys135> W0814080Os3Tabsys135s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys137> W0814080Os3Tabsys137s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys138> W0814080Os3Tabsys138s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys142> W0814080Os3Tabsys142s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys144> W0814080Os3Tabsys144s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys145> W0814080Os3Tabsys145s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys148> W0814080Os3Tabsys148s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys149> W0814080Os3Tabsys149s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys161> W0814080Os3Tabsys161s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys165> W0814080Os3Tabsys165s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys17> W0814080Os3Tabsys17s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys171> W0814080Os3Tabsys171s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys175> W0814080Os3Tabsys175s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys187> W0814080Os3Tabsys187s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys189> W0814080Os3Tabsys189s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys19> W0814080Os3Tabsys19s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys199> W0814080Os3Tabsys199s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys201> W0814080Os3Tabsys201s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys215> W0814080Os3Tabsys215s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys217> W0814080Os3Tabsys217s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys227> W0814080Os3Tabsys227s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys229> W0814080Os3Tabsys229s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys241> W0814080Os3Tabsys241s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys247> W0814080Os3Tabsys247s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys29> W0814080Os3Tabsys29s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys297> W0814080Os3Tabsys297s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys303> W0814080Os3Tabsys303s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys31> W0814080Os3Tabsys31s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys311> W0814080Os3Tabsys311s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys317> W0814080Os3Tabsys317s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys327> W0814080Os3Tabsys327s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys329> W0814080Os3Tabsys329s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys339> W0814080Os3Tabsys339s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys341> W0814080Os3Tabsys341s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys351> W0814080Os3Tabsys351s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys357> W0814080Os3Tabsys357s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys361> W0814080Os3Tabsys361s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys362> W0814080Os3Tabsys362s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys368> W0814080Os3Tabsys368s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys372> W0814080Os3Tabsys372s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys41> W0814080Os3Tabsys41s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys43> W0814080Os3Tabsys43s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys5> W0814080Os3Tabsys5s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys53> W0814080Os3Tabsys53s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys56> W0814080Os3Tabsys56s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys57> W0814080Os3Tabsys57s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys58> W0814080Os3Tabsys58s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys62> W0814080Os3Tabsys62s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys64> W0814080Os3Tabsys64s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys65> W0814080Os3Tabsys65s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys7> W0814080Os3Tabsys7s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys97> W0814080Os3Tabsys97s { get; set; }

    public virtual DbSet<W0814080Os3Tabsys99> W0814080Os3Tabsys99s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=C2018484;Initial Catalog=TCH_W0814080;Integrated Security=True;Trust Server Certificate=True;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Info>(entity =>
        {
            entity.HasKey(e => e.Sinfonaam)
                .HasName("Info_Sinfonaam")
                .IsClustered(false);
        });

        modelBuilder.Entity<KWhWkoMaand>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W_kWh_WKO_Maand_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<KWhWkoUur>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W_kWh_WKO_Uur_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<KWhWpMaand>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W_kWh_WP_Maand_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<KWhWpUur>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W_kWh_WP_Uur_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<Punten>(entity =>
        {
            entity.HasKey(e => e.PuntId)
                .HasName("Punten_Punt_ID")
                .IsClustered(false);
        });

        modelBuilder.Entity<PuntenExtern>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PuntenExtraInfo>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PuntenHistory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<QKTotMaand>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("_Q_K_TOT_Maand_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<QKTotUur>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("_Q_K_TOT_Uur_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<QWTotMaand>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("_Q_W_TOT_Maand_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<QWTotUur>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("_Q_W_TOT_Uur_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet13>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_13_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet18>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_18_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet21>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_21_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet22>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_22_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet23>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_23_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet24>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_24_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet25>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_25_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet30>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_30_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet31>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_31_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet36>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_36_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet39>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_39_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet40>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_40_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet41>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_41_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet42>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_42_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet43>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_43_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet46>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_46_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet48>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_48_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet50>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_50_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet58>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_58_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet6>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_6_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet60>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_60_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfmet7>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFMET_7_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfpid1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFPID_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfpid10>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFPID_10_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfpid15>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFPID_15_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfpid16>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFPID_16_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfpid17>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFPID_17_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfpid18>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFPID_18_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfpid19>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFPID_19_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfpid2>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFPID_2_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfpid20>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFPID_20_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfpid5>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFPID_5_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfpid6>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFPID_6_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfpid7>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFPID_7_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfpid8>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFPID_8_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfsys15>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFSYS_15_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfsys2>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFSYS_2_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfsys24>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFSYS_24_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfsys27>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFSYS_27_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfsys28>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFSYS_28_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfsys31>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFSYS_31_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfsys42>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFSYS_42_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Grfsys6>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_GRFSYS_6_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Tabsys1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_TABSYS_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Tabsys10>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_TABSYS_10_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Tabsys4>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_TABSYS_4_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Tabsys55>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_TABSYS_55_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Tabsys61>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_TABSYS_61_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os1Tabsys7>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS1_TABSYS_7_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfbuf1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFBUF_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfbuf10>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFBUF_10_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfbuf11>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFBUF_11_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfbuf35>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFBUF_35_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfbuf36>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFBUF_36_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfbuf37>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFBUF_37_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfbuf38>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFBUF_38_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfbuf39>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFBUF_39_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfbuf4>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFBUF_4_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet100>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_100_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet103>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_103_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet106>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_106_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet107>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_107_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet112>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_112_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet113>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_113_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet114>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_114_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet121>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_121_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet122>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_122_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet123>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_123_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet124>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_124_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet133>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_133_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet134>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_134_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet139>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_139_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet140>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_140_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet146>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_146_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet149>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_149_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet15>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_15_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet150>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_150_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet151>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_151_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet162>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_162_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet164>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_164_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet166>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_166_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet170>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_170_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet18>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_18_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet19>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_19_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet25>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_25_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet28>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_28_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet35>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_35_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet38>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_38_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet4>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_4_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet45>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_45_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet48>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_48_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet5>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_5_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet51>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_51_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet55>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_55_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet58>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_58_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet65>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_65_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet68>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_68_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet69>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_69_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet70>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_70_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet73>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_73_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet74>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_74_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet78>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_78_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet8>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_8_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet80>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_80_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet82>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_82_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet85>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_85_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet89>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_89_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet91>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_91_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet92>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_92_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet93>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_93_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet94>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_94_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet95>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_95_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet98>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_98_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfmet99>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFMET_99_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid11>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_11_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid13>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_13_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid18>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_18_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid19>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_19_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid28>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_28_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid29>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_29_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid3>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_3_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid30>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_30_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid32>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_32_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid38>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_38_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid42>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_42_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid43>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_43_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid47>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_47_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid48>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_48_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid49>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_49_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid5>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_5_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid50>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_50_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid52>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_52_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid53>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_53_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid54>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_54_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid55>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_55_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid56>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_56_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid7>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_7_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfpid9>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFPID_9_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys10>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_10_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys11>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_11_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys12>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_12_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys14>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_14_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys15>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_15_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys16>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_16_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys17>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_17_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys19>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_19_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys2>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_2_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys20>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_20_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys21>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_21_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys22>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_22_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys24>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_24_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys25>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_25_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys26>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_26_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys27>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_27_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys29>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_29_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys30>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_30_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys31>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_31_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys32>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_32_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys34>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_34_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys35>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_35_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys36>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_36_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys37>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_37_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys39>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_39_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys4>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_4_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys40>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_40_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys5>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_5_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys54>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_54_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys58>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_58_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys61>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_61_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys62>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_62_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys68>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_68_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys69>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_69_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys7>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_7_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys70>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_70_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys73>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_73_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys8>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_8_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Grfsys9>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_GRFSYS_9_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Tabsys1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_TABSYS_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Tabsys19>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_TABSYS_19_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Tabsys22>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_TABSYS_22_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Tabsys4>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_TABSYS_4_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Tabsys43>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_TABSYS_43_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Tabsys49>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_TABSYS_49_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Tabsys88>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_TABSYS_88_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os2Tabsys94>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS2_TABSYS_94_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys100>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_100_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys103>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_103_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys104>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_104_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys116>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_116_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys120>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_120_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys126>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_126_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys130>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_130_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys131>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_131_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys135>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_135_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys137>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_137_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys138>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_138_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys142>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_142_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys144>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_144_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys145>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_145_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys148>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_148_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys149>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_149_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys161>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_161_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys165>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_165_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys17>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_17_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys171>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_171_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys175>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_175_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys187>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_187_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys189>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_189_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys19>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_19_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys199>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_199_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys201>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_201_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys215>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_215_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys217>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_217_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys227>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_227_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys229>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_229_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys241>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_241_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys247>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_247_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys29>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_29_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys297>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_297_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys303>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_303_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys31>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_31_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys311>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_311_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys317>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_317_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys327>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_327_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys329>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_329_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys339>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_339_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys341>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_341_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys351>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_351_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys357>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_357_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys361>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_361_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys362>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_362_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys368>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_368_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys372>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_372_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys41>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_41_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys43>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_43_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys5>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_5_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys53>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_53_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys56>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_56_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys57>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_57_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys58>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_58_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys62>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_62_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys64>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_64_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys65>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_65_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys7>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_7_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys97>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_97_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<W0814080Os3Tabsys99>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("W0814080_OS3_TABSYS_99_Systeemtijd")
                .IsClustered(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
