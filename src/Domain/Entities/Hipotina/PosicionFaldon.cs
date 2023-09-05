using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class PosicionFaldon
{
    public int PosicionFaldonId { get; set; }

    public int? ProdId { get; set; }

    public int? TipoPosicionFaldonId { get; set; }

    public string? Observaciones { get; set; }

    public virtual Prod? Prod { get; set; }

    public virtual TipoPosicionFaldon? TipoPosicionFaldon { get; set; }
}
