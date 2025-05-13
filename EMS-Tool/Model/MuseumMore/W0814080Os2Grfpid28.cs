using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.MuseumMore;

[Table("W0814080_OS2_GRFPID_28")]
public partial class W0814080Os2Grfpid28
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime Systeemtijd { get; set; }

    public int? Waarde { get; set; }

    public bool? AangevuldeData { get; set; }

    public bool? DataGemist { get; set; }

    public bool? IntervalGewijzigd { get; set; }
}
