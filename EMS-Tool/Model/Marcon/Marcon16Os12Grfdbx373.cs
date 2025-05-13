using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.Marcon;

[Table("Marcon16_OS12_GRFDBX_373")]
public partial class Marcon16Os12Grfdbx373
{
    [Key]
    [Precision(0)]
    public DateTime Systeemtijd { get; set; }

    public int? Waarde { get; set; }

    public bool? AangevuldeData { get; set; }

    public bool? DataGemist { get; set; }

    public bool? IntervalGewijzigd { get; set; }
}
