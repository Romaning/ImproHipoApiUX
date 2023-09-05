using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class EscalaDescuento
{
    public int EscalaDescuentosId { get; set; }

    public int? MinutosInicial { get; set; }

    public int? MinutosFinal { get; set; }

    public decimal? Dias { get; set; }

    public string? Responsable { get; set; }

    public int Estado { get; set; }
}
