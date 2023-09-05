using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class TraspasoProducto
{
    public int TraspasoProductoId { get; set; }

    public int TraspasoNegociacionId { get; set; }

    public decimal CantidadSolicitada { get; set; }

    public decimal? CantidadAprobada { get; set; }

    public string? Obs { get; set; }

    public int Codigo { get; set; }

    public int EstadoProductoId { get; set; }

    public int UsoProductoId { get; set; }

    public bool Opcional { get; set; }

    public virtual EstadoProducto EstadoProducto { get; set; } = null!;

    public virtual TraspasoNegociacion TraspasoNegociacion { get; set; } = null!;

    public virtual ICollection<TraspasoProductoDet> TraspasoProductoDets { get; set; } = new List<TraspasoProductoDet>();

    public virtual UsoProducto UsoProducto { get; set; } = null!;
}
