using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class TraspasoActivo
{
    public int TraspasoActivoId { get; set; }

    public int TraspasoNegociacionActivoId { get; set; }

    public decimal CantidadSolicitada { get; set; }

    public decimal? CantidadAprobada { get; set; }

    public string? Obs { get; set; }

    public int ActivoId { get; set; }

    public int EstadoProductoId { get; set; }

    public int? UsoProductoId { get; set; }

    public bool Opcional { get; set; }

    public virtual EstadoProducto EstadoProducto { get; set; } = null!;

    public virtual ICollection<TraspasoActivoDet> TraspasoActivoDets { get; set; } = new List<TraspasoActivoDet>();

    public virtual TraspasoNegociacionActivo TraspasoNegociacionActivo { get; set; } = null!;

    public virtual UsoProducto? UsoProducto { get; set; }
}
