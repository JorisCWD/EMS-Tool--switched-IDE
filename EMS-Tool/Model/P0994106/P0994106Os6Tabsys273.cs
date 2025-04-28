using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.P0994106;

[Table("P0994106_OS6_TABSYS_273")]
public partial class P0994106Os6Tabsys273
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime Systeemtijd { get; set; }

    public int? Waarde { get; set; }

    public bool? AangevuldeData { get; set; }

    public bool? DataGemist { get; set; }

    public bool? IntervalGewijzigd { get; set; }
}
