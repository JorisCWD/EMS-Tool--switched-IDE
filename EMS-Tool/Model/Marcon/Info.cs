using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.Marcon;

[Keyless]
[Table("Info")]
public partial class Info
{
    [StringLength(30)]
    public string Sinfonaam { get; set; } = null!;

    [StringLength(255)]
    public string? Sinfo { get; set; }
}
