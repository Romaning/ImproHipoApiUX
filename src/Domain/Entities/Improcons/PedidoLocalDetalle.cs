using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class PedidoLocalDetalle
{
    public int PedidoLocalDetalleId { get; set; }

    public int PedidoLocalId { get; set; }

    public int ProdId { get; set; }

    public int EstadoProductoId { get; set; }

    public int UsoProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public decimal? CostoIngreso { get; set; }

    public string? Observaciones { get; set; }

    public bool Recosteo { get; set; }

    public int ProveedorId { get; set; }

    public decimal PrecioLista { get; set; }

    public virtual EstadoProducto EstadoProducto { get; set; } = null!;

    public virtual PedidoLocal PedidoLocal { get; set; } = null!;

    public virtual Prod Prod { get; set; } = null!;

    public virtual Proveedor Proveedor { get; set; } = null!;

    public virtual UsoProducto UsoProducto { get; set; } = null!;
}
