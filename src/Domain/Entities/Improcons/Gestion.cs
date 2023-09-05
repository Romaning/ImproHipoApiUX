using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Gestion
{
    public int GestionId { get; set; }

    public int Gestion1 { get; set; }

    public decimal? MinimoNacional { get; set; }

    public int? ToleranciaAtrasos { get; set; }

    public int Estado { get; set; }

    public string? Responsable { get; set; }
}
