using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.MuseumMore;

[Table("_kWh_WP_Uur")]
public partial class KWhWpUur
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime Systeemtijd { get; set; }

    public int? Waarde { get; set; }
}
