using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class TraspasoProductoDet
{
    public int TraspasoProductoDetId { get; set; }

    public int TraspasoProductoId { get; set; }

    public int AlmacenProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public virtual AlmacenProducto AlmacenProducto { get; set; } = null!;

    public virtual TraspasoProducto TraspasoProducto { get; set; } = null!;
}
