using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.P0994106;

[Keyless]
[Table("Punten_extern")]
public partial class PuntenExtern
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("Native_label")]
    [StringLength(400)]
    public string? NativeLabel { get; set; }

    [Column("OPC_Label")]
    [StringLength(400)]
    public string? OpcLabel { get; set; }

    [Column("History_tabel")]
    [StringLength(400)]
    public string? HistoryTabel { get; set; }

    [StringLength(400)]
    public string? Gebouwdeel { get; set; }

    [Column("onderstation")]
    [StringLength(400)]
    public string? Onderstation { get; set; }

    [Column("Onderstation_nummer")]
    public int? OnderstationNummer { get; set; }

    [StringLength(400)]
    public string? Installatiedeel { get; set; }

    [StringLength(400)]
    public string? Module { get; set; }

    [StringLength(400)]
    public string? Element { get; set; }

    [StringLength(400)]
    public string? Omschrijving { get; set; }

    [Column("History_Omschrijving")]
    [StringLength(1600)]
    public string? HistoryOmschrijving { get; set; }

    [StringLength(400)]
    public string? Eenheid { get; set; }

    [Column("Weergave_label")]
    [StringLength(400)]
    public string? WeergaveLabel { get; set; }
}
