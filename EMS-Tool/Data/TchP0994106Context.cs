using System;
using System.Collections.Generic;
using EMS_Tool.Model.P0994106;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Data;

public partial class TchP0994106Context : DbContext
{
    public TchP0994106Context()
    {
    }

    public TchP0994106Context(DbContextOptions<TchP0994106Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Info> Infos { get; set; }

    public virtual DbSet<P0994106Os12Tabsys105> P0994106Os12Tabsys105s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys107> P0994106Os12Tabsys107s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys109> P0994106Os12Tabsys109s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys11> P0994106Os12Tabsys11s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys111> P0994106Os12Tabsys111s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys123> P0994106Os12Tabsys123s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys125> P0994106Os12Tabsys125s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys127> P0994106Os12Tabsys127s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys129> P0994106Os12Tabsys129s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys14> P0994106Os12Tabsys14s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys147> P0994106Os12Tabsys147s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys149> P0994106Os12Tabsys149s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys153> P0994106Os12Tabsys153s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys155> P0994106Os12Tabsys155s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys157> P0994106Os12Tabsys157s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys159> P0994106Os12Tabsys159s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys161> P0994106Os12Tabsys161s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys17> P0994106Os12Tabsys17s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys2> P0994106Os12Tabsys2s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys20> P0994106Os12Tabsys20s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys23> P0994106Os12Tabsys23s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys26> P0994106Os12Tabsys26s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys29> P0994106Os12Tabsys29s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys32> P0994106Os12Tabsys32s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys35> P0994106Os12Tabsys35s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys38> P0994106Os12Tabsys38s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys41> P0994106Os12Tabsys41s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys44> P0994106Os12Tabsys44s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys47> P0994106Os12Tabsys47s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys5> P0994106Os12Tabsys5s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys59> P0994106Os12Tabsys59s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys61> P0994106Os12Tabsys61s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys73> P0994106Os12Tabsys73s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys75> P0994106Os12Tabsys75s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys8> P0994106Os12Tabsys8s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys87> P0994106Os12Tabsys87s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys89> P0994106Os12Tabsys89s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys91> P0994106Os12Tabsys91s { get; set; }

    public virtual DbSet<P0994106Os12Tabsys93> P0994106Os12Tabsys93s { get; set; }

    public virtual DbSet<P0994106Os4Grfmet1> P0994106Os4Grfmet1s { get; set; }

    public virtual DbSet<P0994106Os4Grfmet2> P0994106Os4Grfmet2s { get; set; }

    public virtual DbSet<P0994106Os4Grfmet7> P0994106Os4Grfmet7s { get; set; }

    public virtual DbSet<P0994106Os4Grfmet8> P0994106Os4Grfmet8s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys108> P0994106Os4Tabsys108s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys112> P0994106Os4Tabsys112s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys116> P0994106Os4Tabsys116s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys122> P0994106Os4Tabsys122s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys128> P0994106Os4Tabsys128s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys134> P0994106Os4Tabsys134s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys140> P0994106Os4Tabsys140s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys146> P0994106Os4Tabsys146s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys215> P0994106Os4Tabsys215s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys217> P0994106Os4Tabsys217s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys219> P0994106Os4Tabsys219s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys221> P0994106Os4Tabsys221s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys223> P0994106Os4Tabsys223s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys225> P0994106Os4Tabsys225s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys227> P0994106Os4Tabsys227s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys229> P0994106Os4Tabsys229s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys231> P0994106Os4Tabsys231s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys233> P0994106Os4Tabsys233s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys235> P0994106Os4Tabsys235s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys237> P0994106Os4Tabsys237s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys239> P0994106Os4Tabsys239s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys241> P0994106Os4Tabsys241s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys243> P0994106Os4Tabsys243s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys245> P0994106Os4Tabsys245s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys54> P0994106Os4Tabsys54s { get; set; }

    public virtual DbSet<P0994106Os4Tabsys58> P0994106Os4Tabsys58s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys11> P0994106Os6Tabsys11s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys13> P0994106Os6Tabsys13s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys15> P0994106Os6Tabsys15s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys17> P0994106Os6Tabsys17s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys253> P0994106Os6Tabsys253s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys255> P0994106Os6Tabsys255s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys257> P0994106Os6Tabsys257s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys259> P0994106Os6Tabsys259s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys271> P0994106Os6Tabsys271s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys273> P0994106Os6Tabsys273s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys275> P0994106Os6Tabsys275s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys277> P0994106Os6Tabsys277s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys289> P0994106Os6Tabsys289s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys291> P0994106Os6Tabsys291s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys293> P0994106Os6Tabsys293s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys295> P0994106Os6Tabsys295s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys307> P0994106Os6Tabsys307s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys309> P0994106Os6Tabsys309s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys311> P0994106Os6Tabsys311s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys313> P0994106Os6Tabsys313s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys325> P0994106Os6Tabsys325s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys327> P0994106Os6Tabsys327s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys329> P0994106Os6Tabsys329s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys331> P0994106Os6Tabsys331s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys343> P0994106Os6Tabsys343s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys345> P0994106Os6Tabsys345s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys347> P0994106Os6Tabsys347s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys349> P0994106Os6Tabsys349s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys361> P0994106Os6Tabsys361s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys363> P0994106Os6Tabsys363s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys365> P0994106Os6Tabsys365s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys367> P0994106Os6Tabsys367s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys379> P0994106Os6Tabsys379s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys381> P0994106Os6Tabsys381s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys383> P0994106Os6Tabsys383s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys385> P0994106Os6Tabsys385s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys387> P0994106Os6Tabsys387s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys389> P0994106Os6Tabsys389s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys391> P0994106Os6Tabsys391s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys393> P0994106Os6Tabsys393s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys395> P0994106Os6Tabsys395s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys397> P0994106Os6Tabsys397s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys399> P0994106Os6Tabsys399s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys401> P0994106Os6Tabsys401s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys403> P0994106Os6Tabsys403s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys405> P0994106Os6Tabsys405s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys407> P0994106Os6Tabsys407s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys409> P0994106Os6Tabsys409s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys411> P0994106Os6Tabsys411s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys413> P0994106Os6Tabsys413s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys415> P0994106Os6Tabsys415s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys417> P0994106Os6Tabsys417s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys419> P0994106Os6Tabsys419s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys421> P0994106Os6Tabsys421s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys423> P0994106Os6Tabsys423s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys425> P0994106Os6Tabsys425s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys427> P0994106Os6Tabsys427s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys429> P0994106Os6Tabsys429s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys431> P0994106Os6Tabsys431s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys433> P0994106Os6Tabsys433s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys435> P0994106Os6Tabsys435s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys437> P0994106Os6Tabsys437s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys439> P0994106Os6Tabsys439s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys441> P0994106Os6Tabsys441s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys443> P0994106Os6Tabsys443s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys445> P0994106Os6Tabsys445s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys447> P0994106Os6Tabsys447s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys449> P0994106Os6Tabsys449s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys451> P0994106Os6Tabsys451s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys453> P0994106Os6Tabsys453s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys455> P0994106Os6Tabsys455s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys457> P0994106Os6Tabsys457s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys459> P0994106Os6Tabsys459s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys461> P0994106Os6Tabsys461s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys463> P0994106Os6Tabsys463s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys465> P0994106Os6Tabsys465s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys477> P0994106Os6Tabsys477s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys479> P0994106Os6Tabsys479s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys481> P0994106Os6Tabsys481s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys483> P0994106Os6Tabsys483s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys495> P0994106Os6Tabsys495s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys497> P0994106Os6Tabsys497s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys499> P0994106Os6Tabsys499s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys501> P0994106Os6Tabsys501s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys513> P0994106Os6Tabsys513s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys515> P0994106Os6Tabsys515s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys517> P0994106Os6Tabsys517s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys519> P0994106Os6Tabsys519s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys531> P0994106Os6Tabsys531s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys533> P0994106Os6Tabsys533s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys535> P0994106Os6Tabsys535s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys537> P0994106Os6Tabsys537s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys549> P0994106Os6Tabsys549s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys551> P0994106Os6Tabsys551s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys553> P0994106Os6Tabsys553s { get; set; }

    public virtual DbSet<P0994106Os6Tabsys555> P0994106Os6Tabsys555s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys1> P0994106Os7Tabsys1s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys101> P0994106Os7Tabsys101s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys103> P0994106Os7Tabsys103s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys105> P0994106Os7Tabsys105s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys107> P0994106Os7Tabsys107s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys109> P0994106Os7Tabsys109s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys11> P0994106Os7Tabsys11s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys111> P0994106Os7Tabsys111s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys113> P0994106Os7Tabsys113s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys117> P0994106Os7Tabsys117s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys119> P0994106Os7Tabsys119s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys121> P0994106Os7Tabsys121s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys123> P0994106Os7Tabsys123s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys125> P0994106Os7Tabsys125s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys127> P0994106Os7Tabsys127s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys129> P0994106Os7Tabsys129s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys13> P0994106Os7Tabsys13s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys133> P0994106Os7Tabsys133s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys135> P0994106Os7Tabsys135s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys137> P0994106Os7Tabsys137s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys139> P0994106Os7Tabsys139s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys141> P0994106Os7Tabsys141s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys143> P0994106Os7Tabsys143s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys145> P0994106Os7Tabsys145s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys149> P0994106Os7Tabsys149s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys15> P0994106Os7Tabsys15s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys151> P0994106Os7Tabsys151s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys153> P0994106Os7Tabsys153s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys155> P0994106Os7Tabsys155s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys157> P0994106Os7Tabsys157s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys159> P0994106Os7Tabsys159s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys161> P0994106Os7Tabsys161s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys165> P0994106Os7Tabsys165s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys167> P0994106Os7Tabsys167s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys169> P0994106Os7Tabsys169s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys17> P0994106Os7Tabsys17s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys171> P0994106Os7Tabsys171s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys173> P0994106Os7Tabsys173s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys175> P0994106Os7Tabsys175s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys177> P0994106Os7Tabsys177s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys181> P0994106Os7Tabsys181s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys183> P0994106Os7Tabsys183s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys185> P0994106Os7Tabsys185s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys187> P0994106Os7Tabsys187s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys189> P0994106Os7Tabsys189s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys19> P0994106Os7Tabsys19s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys191> P0994106Os7Tabsys191s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys193> P0994106Os7Tabsys193s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys197> P0994106Os7Tabsys197s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys199> P0994106Os7Tabsys199s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys201> P0994106Os7Tabsys201s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys209> P0994106Os7Tabsys209s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys213> P0994106Os7Tabsys213s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys225> P0994106Os7Tabsys225s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys229> P0994106Os7Tabsys229s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys23> P0994106Os7Tabsys23s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys241> P0994106Os7Tabsys241s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys245> P0994106Os7Tabsys245s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys25> P0994106Os7Tabsys25s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys257> P0994106Os7Tabsys257s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys261> P0994106Os7Tabsys261s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys27> P0994106Os7Tabsys27s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys273> P0994106Os7Tabsys273s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys277> P0994106Os7Tabsys277s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys289> P0994106Os7Tabsys289s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys29> P0994106Os7Tabsys29s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys293> P0994106Os7Tabsys293s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys3> P0994106Os7Tabsys3s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys305> P0994106Os7Tabsys305s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys309> P0994106Os7Tabsys309s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys31> P0994106Os7Tabsys31s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys321> P0994106Os7Tabsys321s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys325> P0994106Os7Tabsys325s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys33> P0994106Os7Tabsys33s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys337> P0994106Os7Tabsys337s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys341> P0994106Os7Tabsys341s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys35> P0994106Os7Tabsys35s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys353> P0994106Os7Tabsys353s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys357> P0994106Os7Tabsys357s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys369> P0994106Os7Tabsys369s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys373> P0994106Os7Tabsys373s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys385> P0994106Os7Tabsys385s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys389> P0994106Os7Tabsys389s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys39> P0994106Os7Tabsys39s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys401> P0994106Os7Tabsys401s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys405> P0994106Os7Tabsys405s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys41> P0994106Os7Tabsys41s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys417> P0994106Os7Tabsys417s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys421> P0994106Os7Tabsys421s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys43> P0994106Os7Tabsys43s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys433> P0994106Os7Tabsys433s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys437> P0994106Os7Tabsys437s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys449> P0994106Os7Tabsys449s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys45> P0994106Os7Tabsys45s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys453> P0994106Os7Tabsys453s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys465> P0994106Os7Tabsys465s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys469> P0994106Os7Tabsys469s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys47> P0994106Os7Tabsys47s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys481> P0994106Os7Tabsys481s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys485> P0994106Os7Tabsys485s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys49> P0994106Os7Tabsys49s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys497> P0994106Os7Tabsys497s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys501> P0994106Os7Tabsys501s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys513> P0994106Os7Tabsys513s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys517> P0994106Os7Tabsys517s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys529> P0994106Os7Tabsys529s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys53> P0994106Os7Tabsys53s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys533> P0994106Os7Tabsys533s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys545> P0994106Os7Tabsys545s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys549> P0994106Os7Tabsys549s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys55> P0994106Os7Tabsys55s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys561> P0994106Os7Tabsys561s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys565> P0994106Os7Tabsys565s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys57> P0994106Os7Tabsys57s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys577> P0994106Os7Tabsys577s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys581> P0994106Os7Tabsys581s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys59> P0994106Os7Tabsys59s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys593> P0994106Os7Tabsys593s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys597> P0994106Os7Tabsys597s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys609> P0994106Os7Tabsys609s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys61> P0994106Os7Tabsys61s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys613> P0994106Os7Tabsys613s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys625> P0994106Os7Tabsys625s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys627> P0994106Os7Tabsys627s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys63> P0994106Os7Tabsys63s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys641> P0994106Os7Tabsys641s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys643> P0994106Os7Tabsys643s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys65> P0994106Os7Tabsys65s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys657> P0994106Os7Tabsys657s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys659> P0994106Os7Tabsys659s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys673> P0994106Os7Tabsys673s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys675> P0994106Os7Tabsys675s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys689> P0994106Os7Tabsys689s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys69> P0994106Os7Tabsys69s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys691> P0994106Os7Tabsys691s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys693> P0994106Os7Tabsys693s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys695> P0994106Os7Tabsys695s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys697> P0994106Os7Tabsys697s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys699> P0994106Os7Tabsys699s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys7> P0994106Os7Tabsys7s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys701> P0994106Os7Tabsys701s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys705> P0994106Os7Tabsys705s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys707> P0994106Os7Tabsys707s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys709> P0994106Os7Tabsys709s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys71> P0994106Os7Tabsys71s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys711> P0994106Os7Tabsys711s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys713> P0994106Os7Tabsys713s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys715> P0994106Os7Tabsys715s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys717> P0994106Os7Tabsys717s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys721> P0994106Os7Tabsys721s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys723> P0994106Os7Tabsys723s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys725> P0994106Os7Tabsys725s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys727> P0994106Os7Tabsys727s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys729> P0994106Os7Tabsys729s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys73> P0994106Os7Tabsys73s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys731> P0994106Os7Tabsys731s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys733> P0994106Os7Tabsys733s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys737> P0994106Os7Tabsys737s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys739> P0994106Os7Tabsys739s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys741> P0994106Os7Tabsys741s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys743> P0994106Os7Tabsys743s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys745> P0994106Os7Tabsys745s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys747> P0994106Os7Tabsys747s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys749> P0994106Os7Tabsys749s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys75> P0994106Os7Tabsys75s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys753> P0994106Os7Tabsys753s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys757> P0994106Os7Tabsys757s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys759> P0994106Os7Tabsys759s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys761> P0994106Os7Tabsys761s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys763> P0994106Os7Tabsys763s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys765> P0994106Os7Tabsys765s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys767> P0994106Os7Tabsys767s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys769> P0994106Os7Tabsys769s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys77> P0994106Os7Tabsys77s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys773> P0994106Os7Tabsys773s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys775> P0994106Os7Tabsys775s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys777> P0994106Os7Tabsys777s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys779> P0994106Os7Tabsys779s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys781> P0994106Os7Tabsys781s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys783> P0994106Os7Tabsys783s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys785> P0994106Os7Tabsys785s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys789> P0994106Os7Tabsys789s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys79> P0994106Os7Tabsys79s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys799> P0994106Os7Tabsys799s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys801> P0994106Os7Tabsys801s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys805> P0994106Os7Tabsys805s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys807> P0994106Os7Tabsys807s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys809> P0994106Os7Tabsys809s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys81> P0994106Os7Tabsys81s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys811> P0994106Os7Tabsys811s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys813> P0994106Os7Tabsys813s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys815> P0994106Os7Tabsys815s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys817> P0994106Os7Tabsys817s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys821> P0994106Os7Tabsys821s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys823> P0994106Os7Tabsys823s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys825> P0994106Os7Tabsys825s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys827> P0994106Os7Tabsys827s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys829> P0994106Os7Tabsys829s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys831> P0994106Os7Tabsys831s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys833> P0994106Os7Tabsys833s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys835> P0994106Os7Tabsys835s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys837> P0994106Os7Tabsys837s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys839> P0994106Os7Tabsys839s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys841> P0994106Os7Tabsys841s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys843> P0994106Os7Tabsys843s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys845> P0994106Os7Tabsys845s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys847> P0994106Os7Tabsys847s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys849> P0994106Os7Tabsys849s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys85> P0994106Os7Tabsys85s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys853> P0994106Os7Tabsys853s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys855> P0994106Os7Tabsys855s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys857> P0994106Os7Tabsys857s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys859> P0994106Os7Tabsys859s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys861> P0994106Os7Tabsys861s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys863> P0994106Os7Tabsys863s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys865> P0994106Os7Tabsys865s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys869> P0994106Os7Tabsys869s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys87> P0994106Os7Tabsys87s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys871> P0994106Os7Tabsys871s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys873> P0994106Os7Tabsys873s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys875> P0994106Os7Tabsys875s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys877> P0994106Os7Tabsys877s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys879> P0994106Os7Tabsys879s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys881> P0994106Os7Tabsys881s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys885> P0994106Os7Tabsys885s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys887> P0994106Os7Tabsys887s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys889> P0994106Os7Tabsys889s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys89> P0994106Os7Tabsys89s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys891> P0994106Os7Tabsys891s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys893> P0994106Os7Tabsys893s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys895> P0994106Os7Tabsys895s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys897> P0994106Os7Tabsys897s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys9> P0994106Os7Tabsys9s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys901> P0994106Os7Tabsys901s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys903> P0994106Os7Tabsys903s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys905> P0994106Os7Tabsys905s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys907> P0994106Os7Tabsys907s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys91> P0994106Os7Tabsys91s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys93> P0994106Os7Tabsys93s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys95> P0994106Os7Tabsys95s { get; set; }

    public virtual DbSet<P0994106Os7Tabsys97> P0994106Os7Tabsys97s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys1> P0994106Os8Tabsys1s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys109> P0994106Os8Tabsys109s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys113> P0994106Os8Tabsys113s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys125> P0994106Os8Tabsys125s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys129> P0994106Os8Tabsys129s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys141> P0994106Os8Tabsys141s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys145> P0994106Os8Tabsys145s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys157> P0994106Os8Tabsys157s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys161> P0994106Os8Tabsys161s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys17> P0994106Os8Tabsys17s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys173> P0994106Os8Tabsys173s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys177> P0994106Os8Tabsys177s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys189> P0994106Os8Tabsys189s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys19> P0994106Os8Tabsys19s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys191> P0994106Os8Tabsys191s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys205> P0994106Os8Tabsys205s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys207> P0994106Os8Tabsys207s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys221> P0994106Os8Tabsys221s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys225> P0994106Os8Tabsys225s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys237> P0994106Os8Tabsys237s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys241> P0994106Os8Tabsys241s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys253> P0994106Os8Tabsys253s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys257> P0994106Os8Tabsys257s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys269> P0994106Os8Tabsys269s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys271> P0994106Os8Tabsys271s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys285> P0994106Os8Tabsys285s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys287> P0994106Os8Tabsys287s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys3> P0994106Os8Tabsys3s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys301> P0994106Os8Tabsys301s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys303> P0994106Os8Tabsys303s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys317> P0994106Os8Tabsys317s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys319> P0994106Os8Tabsys319s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys33> P0994106Os8Tabsys33s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys333> P0994106Os8Tabsys333s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys335> P0994106Os8Tabsys335s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys349> P0994106Os8Tabsys349s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys35> P0994106Os8Tabsys35s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys351> P0994106Os8Tabsys351s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys37> P0994106Os8Tabsys37s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys381> P0994106Os8Tabsys381s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys383> P0994106Os8Tabsys383s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys385> P0994106Os8Tabsys385s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys387> P0994106Os8Tabsys387s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys389> P0994106Os8Tabsys389s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys39> P0994106Os8Tabsys39s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys391> P0994106Os8Tabsys391s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys393> P0994106Os8Tabsys393s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys395> P0994106Os8Tabsys395s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys403> P0994106Os8Tabsys403s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys405> P0994106Os8Tabsys405s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys407> P0994106Os8Tabsys407s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys409> P0994106Os8Tabsys409s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys411> P0994106Os8Tabsys411s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys413> P0994106Os8Tabsys413s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys415> P0994106Os8Tabsys415s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys417> P0994106Os8Tabsys417s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys419> P0994106Os8Tabsys419s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys421> P0994106Os8Tabsys421s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys423> P0994106Os8Tabsys423s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys425> P0994106Os8Tabsys425s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys427> P0994106Os8Tabsys427s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys429> P0994106Os8Tabsys429s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys431> P0994106Os8Tabsys431s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys433> P0994106Os8Tabsys433s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys435> P0994106Os8Tabsys435s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys437> P0994106Os8Tabsys437s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys439> P0994106Os8Tabsys439s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys441> P0994106Os8Tabsys441s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys443> P0994106Os8Tabsys443s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys445> P0994106Os8Tabsys445s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys447> P0994106Os8Tabsys447s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys449> P0994106Os8Tabsys449s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys451> P0994106Os8Tabsys451s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys453> P0994106Os8Tabsys453s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys455> P0994106Os8Tabsys455s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys457> P0994106Os8Tabsys457s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys459> P0994106Os8Tabsys459s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys461> P0994106Os8Tabsys461s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys463> P0994106Os8Tabsys463s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys465> P0994106Os8Tabsys465s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys77> P0994106Os8Tabsys77s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys79> P0994106Os8Tabsys79s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys93> P0994106Os8Tabsys93s { get; set; }

    public virtual DbSet<P0994106Os8Tabsys97> P0994106Os8Tabsys97s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys1> P0994106Os9Tabsys1s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys11> P0994106Os9Tabsys11s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys13> P0994106Os9Tabsys13s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys15> P0994106Os9Tabsys15s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys17> P0994106Os9Tabsys17s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys19> P0994106Os9Tabsys19s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys21> P0994106Os9Tabsys21s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys23> P0994106Os9Tabsys23s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys25> P0994106Os9Tabsys25s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys27> P0994106Os9Tabsys27s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys29> P0994106Os9Tabsys29s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys3> P0994106Os9Tabsys3s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys31> P0994106Os9Tabsys31s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys33> P0994106Os9Tabsys33s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys35> P0994106Os9Tabsys35s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys37> P0994106Os9Tabsys37s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys39> P0994106Os9Tabsys39s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys49> P0994106Os9Tabsys49s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys5> P0994106Os9Tabsys5s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys7> P0994106Os9Tabsys7s { get; set; }

    public virtual DbSet<P0994106Os9Tabsys9> P0994106Os9Tabsys9s { get; set; }

    public virtual DbSet<Punten> Puntens { get; set; }

    public virtual DbSet<PuntenExtern> PuntenExterns { get; set; }

    public virtual DbSet<PuntenExtraInfo> PuntenExtraInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=C2018484;Initial Catalog=TCH_P0994106;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Info>(entity =>
        {
            entity.HasKey(e => e.Sinfonaam)
                .HasName("Info_Sinfonaam")
                .IsClustered(false);

            entity.Property(e => e.Sinfo).UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<P0994106Os12Tabsys105>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_105_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys107>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_107_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys109>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_109_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys11>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_11_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys111>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_111_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys123>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_123_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys125>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_125_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys127>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_127_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys129>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_129_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys14>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_14_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys147>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_147_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys149>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_149_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys153>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_153_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys155>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_155_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys157>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_157_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys159>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_159_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys161>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_161_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys17>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_17_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys2>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_2_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys20>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_20_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys23>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_23_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys26>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_26_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys29>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_29_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys32>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_32_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys35>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_35_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys38>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_38_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys41>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_41_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys44>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_44_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys47>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_47_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys5>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_5_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys59>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_59_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys61>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_61_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys73>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_73_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys75>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_75_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys8>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_8_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys87>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_87_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys89>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_89_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys91>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_91_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os12Tabsys93>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS12_TABSYS_93_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Grfmet1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_GRFMET_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Grfmet2>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_GRFMET_2_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Grfmet7>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_GRFMET_7_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Grfmet8>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_GRFMET_8_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys108>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_108_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys112>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_112_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys116>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_116_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys122>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_122_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys128>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_128_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys134>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_134_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys140>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_140_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys146>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_146_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys215>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_215_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys217>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_217_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys219>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_219_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys221>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_221_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys223>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_223_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys225>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_225_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys227>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_227_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys229>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_229_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys231>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_231_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys233>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_233_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys235>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_235_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys237>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_237_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys239>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_239_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys241>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_241_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys243>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_243_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys245>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_245_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys54>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_54_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os4Tabsys58>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS4_TABSYS_58_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys11>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_11_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys13>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_13_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys15>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_15_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys17>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_17_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys253>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_253_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys255>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_255_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys257>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_257_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys259>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_259_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys271>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_271_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys273>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_273_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys275>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_275_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys277>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_277_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys289>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_289_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys291>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_291_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys293>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_293_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys295>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_295_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys307>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_307_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys309>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_309_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys311>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_311_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys313>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_313_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys325>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_325_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys327>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_327_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys329>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_329_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys331>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_331_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys343>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_343_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys345>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_345_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys347>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_347_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys349>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_349_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys361>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_361_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys363>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_363_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys365>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_365_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys367>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_367_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys379>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_379_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys381>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_381_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys383>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_383_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys385>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_385_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys387>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_387_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys389>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_389_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys391>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_391_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys393>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_393_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys395>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_395_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys397>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_397_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys399>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_399_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys401>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_401_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys403>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_403_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys405>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_405_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys407>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_407_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys409>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_409_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys411>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_411_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys413>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_413_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys415>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_415_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys417>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_417_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys419>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_419_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys421>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_421_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys423>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_423_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys425>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_425_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys427>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_427_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys429>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_429_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys431>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_431_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys433>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_433_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys435>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_435_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys437>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_437_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys439>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_439_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys441>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_441_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys443>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_443_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys445>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_445_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys447>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_447_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys449>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_449_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys451>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_451_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys453>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_453_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys455>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_455_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys457>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_457_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys459>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_459_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys461>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_461_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys463>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_463_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys465>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_465_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys477>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_477_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys479>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_479_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys481>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_481_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys483>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_483_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys495>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_495_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys497>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_497_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys499>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_499_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys501>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_501_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys513>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_513_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys515>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_515_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys517>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_517_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys519>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_519_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys531>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_531_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys533>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_533_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys535>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_535_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys537>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_537_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys549>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_549_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys551>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_551_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys553>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_553_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os6Tabsys555>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS6_TABSYS_555_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys101>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_101_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys103>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_103_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys105>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_105_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys107>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_107_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys109>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_109_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys11>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_11_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys111>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_111_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys113>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_113_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys117>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_117_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys119>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_119_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys121>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_121_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys123>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_123_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys125>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_125_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys127>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_127_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys129>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_129_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys13>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_13_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys133>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_133_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys135>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_135_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys137>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_137_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys139>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_139_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys141>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_141_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys143>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_143_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys145>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_145_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys149>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_149_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys15>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_15_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys151>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_151_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys153>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_153_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys155>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_155_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys157>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_157_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys159>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_159_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys161>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_161_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys165>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_165_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys167>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_167_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys169>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_169_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys17>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_17_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys171>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_171_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys173>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_173_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys175>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_175_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys177>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_177_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys181>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_181_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys183>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_183_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys185>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_185_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys187>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_187_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys189>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_189_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys19>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_19_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys191>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_191_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys193>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_193_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys197>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_197_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys199>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_199_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys201>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_201_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys209>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_209_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys213>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_213_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys225>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_225_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys229>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_229_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys23>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_23_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys241>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_241_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys245>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_245_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys25>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_25_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys257>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_257_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys261>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_261_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys27>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_27_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys273>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_273_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys277>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_277_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys289>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_289_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys29>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_29_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys293>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_293_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys3>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_3_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys305>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_305_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys309>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_309_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys31>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_31_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys321>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_321_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys325>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_325_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys33>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_33_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys337>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_337_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys341>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_341_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys35>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_35_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys353>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_353_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys357>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_357_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys369>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_369_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys373>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_373_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys385>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_385_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys389>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_389_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys39>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_39_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys401>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_401_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys405>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_405_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys41>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_41_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys417>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_417_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys421>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_421_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys43>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_43_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys433>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_433_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys437>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_437_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys449>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_449_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys45>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_45_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys453>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_453_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys465>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_465_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys469>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_469_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys47>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_47_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys481>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_481_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys485>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_485_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys49>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_49_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys497>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_497_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys501>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_501_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys513>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_513_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys517>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_517_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys529>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_529_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys53>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_53_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys533>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_533_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys545>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_545_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys549>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_549_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys55>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_55_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys561>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_561_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys565>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_565_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys57>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_57_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys577>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_577_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys581>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_581_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys59>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_59_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys593>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_593_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys597>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_597_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys609>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_609_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys61>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_61_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys613>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_613_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys625>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_625_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys627>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_627_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys63>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_63_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys641>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_641_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys643>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_643_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys65>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_65_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys657>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_657_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys659>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_659_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys673>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_673_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys675>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_675_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys689>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_689_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys69>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_69_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys691>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_691_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys693>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_693_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys695>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_695_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys697>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_697_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys699>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_699_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys7>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_7_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys701>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_701_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys705>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_705_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys707>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_707_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys709>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_709_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys71>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_71_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys711>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_711_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys713>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_713_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys715>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_715_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys717>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_717_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys721>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_721_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys723>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_723_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys725>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_725_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys727>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_727_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys729>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_729_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys73>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_73_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys731>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_731_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys733>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_733_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys737>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_737_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys739>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_739_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys741>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_741_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys743>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_743_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys745>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_745_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys747>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_747_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys749>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_749_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys75>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_75_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys753>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_753_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys757>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_757_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys759>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_759_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys761>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_761_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys763>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_763_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys765>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_765_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys767>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_767_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys769>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_769_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys77>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_77_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys773>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_773_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys775>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_775_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys777>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_777_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys779>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_779_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys781>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_781_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys783>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_783_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys785>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_785_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys789>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_789_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys79>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_79_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys799>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_799_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys801>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_801_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys805>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_805_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys807>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_807_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys809>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_809_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys81>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_81_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys811>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_811_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys813>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_813_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys815>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_815_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys817>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_817_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys821>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_821_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys823>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_823_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys825>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_825_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys827>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_827_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys829>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_829_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys831>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_831_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys833>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_833_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys835>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_835_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys837>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_837_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys839>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_839_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys841>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_841_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys843>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_843_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys845>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_845_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys847>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_847_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys849>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_849_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys85>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_85_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys853>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_853_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys855>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_855_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys857>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_857_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys859>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_859_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys861>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_861_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys863>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_863_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys865>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_865_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys869>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_869_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys87>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_87_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys871>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_871_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys873>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_873_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys875>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_875_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys877>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_877_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys879>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_879_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys881>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_881_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys885>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_885_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys887>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_887_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys889>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_889_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys89>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_89_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys891>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_891_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys893>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_893_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys895>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_895_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys897>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_897_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys9>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_9_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys901>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_901_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys903>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_903_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys905>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_905_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys907>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_907_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys91>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_91_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys93>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_93_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys95>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_95_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os7Tabsys97>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS7_TABSYS_97_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys109>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_109_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys113>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_113_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys125>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_125_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys129>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_129_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys141>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_141_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys145>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_145_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys157>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_157_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys161>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_161_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys17>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_17_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys173>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_173_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys177>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_177_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys189>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_189_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys19>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_19_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys191>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_191_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys205>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_205_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys207>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_207_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys221>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_221_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys225>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_225_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys237>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_237_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys241>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_241_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys253>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_253_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys257>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_257_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys269>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_269_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys271>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_271_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys285>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_285_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys287>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_287_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys3>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_3_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys301>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_301_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys303>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_303_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys317>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_317_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys319>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_319_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys33>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_33_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys333>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_333_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys335>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_335_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys349>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_349_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys35>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_35_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys351>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_351_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys37>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_37_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys381>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_381_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys383>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_383_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys385>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_385_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys387>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_387_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys389>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_389_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys39>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_39_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys391>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_391_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys393>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_393_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys395>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_395_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys403>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_403_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys405>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_405_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys407>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_407_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys409>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_409_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys411>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_411_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys413>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_413_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys415>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_415_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys417>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_417_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys419>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_419_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys421>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_421_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys423>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_423_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys425>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_425_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys427>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_427_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys429>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_429_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys431>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_431_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys433>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_433_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys435>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_435_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys437>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_437_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys439>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_439_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys441>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_441_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys443>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_443_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys445>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_445_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys447>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_447_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys449>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_449_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys451>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_451_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys453>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_453_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys455>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_455_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys457>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_457_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys459>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_459_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys461>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_461_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys463>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_463_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys465>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_465_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys77>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_77_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys79>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_79_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys93>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_93_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os8Tabsys97>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS8_TABSYS_97_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys1>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_1_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys11>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_11_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys13>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_13_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys15>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_15_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys17>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_17_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys19>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_19_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys21>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_21_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys23>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_23_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys25>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_25_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys27>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_27_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys29>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_29_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys3>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_3_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys31>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_31_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys33>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_33_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys35>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_35_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys37>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_37_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys39>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_39_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys49>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_49_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys5>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_5_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys7>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_7_Systeemtijd")
                .IsClustered(false);
        });

        modelBuilder.Entity<P0994106Os9Tabsys9>(entity =>
        {
            entity.HasKey(e => e.Systeemtijd)
                .HasName("P0994106_OS9_TABSYS_9_Systeemtijd")
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
        });

        modelBuilder.Entity<PuntenExtern>(entity =>
        {
            entity.Property(e => e.Eenheid).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Element).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Gebouwdeel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HistoryOmschrijving).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HistoryTabel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Installatiedeel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Module).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NativeLabel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Omschrijving).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Onderstation).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.OpcLabel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WeergaveLabel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<PuntenExtraInfo>(entity =>
        {
            entity.Property(e => e.Eenheid).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Element).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Gebouwdeel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HistoryOmschrijving).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HistoryTabel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Installatiedeel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Module).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NativeLabel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Omschrijving).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Onderstation).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.OpcLabel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WeergaveLabel).UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
