using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class TipoPosicionFaldon
{
    public int TipoPosicionFaldonId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public int? Estado { get; set; }

    public string? Ruta { get; set; }

    public virtual ICollection<PosicionFaldon> PosicionFaldons { get; set; } = new List<PosicionFaldon>();
}
