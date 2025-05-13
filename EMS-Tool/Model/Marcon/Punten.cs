using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.Marcon;

[Table("Punten")]
[Index("Aktief", Name = "Punten_Aktief")]
[Index("Onderstation", Name = "Punten_Onderstation")]
[Index("Project", Name = "Punten_Project")]
[Index("VolgendeOphaaltijd", Name = "Punten_VolgendeOphaaltijd")]
public partial class Punten
{
    [Key]
    [Column("Punt_ID")]
    public int PuntId { get; set; }

    [StringLength(50)]
    public string? Project { get; set; }

    public int? Onderstation { get; set; }

    public int? Volgnummer { get; set; }

    [StringLength(50)]
    public string? Label { get; set; }

    public int? WeergaveType { get; set; }

    [Precision(0)]
    public DateTime? StartSysteemtijd { get; set; }

    [Precision(0)]
    public DateTime? EindSysteemtijd { get; set; }

    public bool? Aktief { get; set; }

    [StringLength(50)]
    public string? Omschrijving { get; set; }

    [StringLength(255)]
    public string? Commentaar { get; set; }

    public int? Periode { get; set; }

    public int? Interval { get; set; }

    [Precision(0)]
    public DateTime? VolgendeOphaaltijd { get; set; }

    public int? WaardeGemisteData { get; set; }

    public bool? GemisteDataAanvullen { get; set; }

    public int? MaxVultijd { get; set; }
}
