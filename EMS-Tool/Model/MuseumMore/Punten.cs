using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.MuseumMore;

[Table("Punten")]
public partial class Punten
{
    [Key]
    [Column("Punt_ID")]
    public int PuntId { get; set; }

    [StringLength(400)]
    public string? Project { get; set; }

    public int? Onderstation { get; set; }

    public int? Volgnummer { get; set; }

    [StringLength(400)]
    public string? Label { get; set; }

    public int? WeergaveType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartSysteemtijd { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EindSysteemtijd { get; set; }

    public bool? Aktief { get; set; }

    [StringLength(2040)]
    public string? Omschrijving { get; set; }

    [StringLength(2040)]
    public string? Commentaar { get; set; }

    public int? Periode { get; set; }

    public int? Interval { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VolgendeOphaaltijd { get; set; }

    public int? WaardeGemisteData { get; set; }

    public bool? GemisteDataAanvullen { get; set; }

    public int? MaxVultijd { get; set; }
}
