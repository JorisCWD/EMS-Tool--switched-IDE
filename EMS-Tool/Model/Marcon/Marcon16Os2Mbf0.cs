using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Model.Marcon;

[Table("Marcon16_OS2_MBF_0")]
[Index("Systeemtijd", Name = "Marcon16_OS2_MBF_0_Systeemtijd")]
public partial class Marcon16Os2Mbf0
{
    [Precision(0)]
    public DateTime? Systeemtijd { get; set; }

    public int? Onderstation { get; set; }

    public int? MeldingSoort { get; set; }

    public int? MeldingNummer { get; set; }

    public int? Urgentie { get; set; }

    public bool? Toestand { get; set; }

    [Key]
    [Column("ID")]
    public int Id { get; set; }
}
