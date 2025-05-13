using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.Marcon;

[Table("Marcon16_OS7_GRFSYS_195")]
public partial class Marcon16Os7Grfsys195
{
    [Key]
    [Precision(0)]
    public DateTime Systeemtijd { get; set; }

    public int? Waarde { get; set; }

    public bool? AangevuldeData { get; set; }

    public bool? DataGemist { get; set; }

    public bool? IntervalGewijzigd { get; set; }
}
