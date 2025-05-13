using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.MuseumMore;

[Table("_kWh_WP_Maand")]
public partial class KWhWpMaand
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime Systeemtijd { get; set; }

    public int? Waarde { get; set; }
}
