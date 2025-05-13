using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.MuseumMore;

[Table("History")]
public partial class History
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("Projecten_ID")]
    public int? ProjectenId { get; set; }

    [Column("Project_naam")]
    [StringLength(200)]
    public string? ProjectNaam { get; set; }

    [Column("Database_naam")]
    [StringLength(50)]
    public string? DatabaseNaam { get; set; }

    [Column("History_tabel")]
    [StringLength(50)]
    public string? HistoryTabel { get; set; }

    [Column("History_omschrijving")]
    [StringLength(200)]
    public string? HistoryOmschrijving { get; set; }

    [Column("Onderstation_nummer")]
    public int? OnderstationNummer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Systeemtijd { get; set; }

    [Column("Waarde_INT")]
    public int? WaardeInt { get; set; }

    [Column("Factor_decimaal")]
    public double? FactorDecimaal { get; set; }

    public double? Waarde { get; set; }

    [StringLength(10)]
    public string? Eenheid { get; set; }
}
