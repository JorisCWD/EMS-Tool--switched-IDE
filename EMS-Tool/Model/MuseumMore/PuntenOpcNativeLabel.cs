using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.MuseumMore;

[Keyless]
[Table("Punten_OPC_Native_Labels")]
public partial class PuntenOpcNativeLabel
{
    [Column("OPC Label")]
    [StringLength(300)]
    public string? OpcLabel { get; set; }

    [StringLength(2400)]
    public string? Gebouwdeel { get; set; }

    [Column("onderstation nummer")]
    [StringLength(300)]
    public string? OnderstationNummer { get; set; }

    [Column("onderstation")]
    [StringLength(2400)]
    public string? Onderstation { get; set; }

    [StringLength(2400)]
    public string? Omschrijving { get; set; }

    [StringLength(2400)]
    public string? Installatiedeel { get; set; }

    [StringLength(2400)]
    public string? Module { get; set; }

    [StringLength(2400)]
    public string? Element { get; set; }

    [Column("Weergave Label")]
    [StringLength(300)]
    public string? WeergaveLabel { get; set; }

    [StringLength(2400)]
    public string? Weergave { get; set; }

    [StringLength(2400)]
    public string? Eenheid { get; set; }

    [StringLength(2400)]
    public string? Datatype { get; set; }

    [StringLength(2400)]
    public string? Installatiecode { get; set; }

    [StringLength(2400)]
    public string? Referentiecode { get; set; }

    [StringLength(2400)]
    public string? Klemnummer { get; set; }

    [StringLength(2400)]
    public string? Urgentie { get; set; }

    [Column("Native Label")]
    [StringLength(300)]
    public string? NativeLabel { get; set; }

    [Column("Onderstation ID")]
    [StringLength(300)]
    public string? OnderstationId { get; set; }
}
