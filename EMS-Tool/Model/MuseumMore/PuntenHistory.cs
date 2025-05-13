using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.MuseumMore;

[Keyless]
[Table("Punten_History")]
public partial class PuntenHistory
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("OS")]
    [StringLength(400)]
    public string? Os { get; set; }

    [StringLength(400)]
    public string? Omschrijving { get; set; }

    [Column("Inst.code")]
    [StringLength(50)]
    public string? InstCode { get; set; }

    [StringLength(400)]
    public string? Installatiedeel { get; set; }

    [StringLength(400)]
    public string? Waarde { get; set; }

    public int? Actief { get; set; }

    [StringLength(400)]
    public string? Begintijd { get; set; }

    [StringLength(400)]
    public string? Eindtijd { get; set; }

    [StringLength(400)]
    public string? Eenheid { get; set; }

    [Column("Weergave_label")]
    [StringLength(400)]
    public string? WeergaveLabel { get; set; }
}
