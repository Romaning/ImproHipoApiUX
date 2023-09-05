using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class PedidoProveedorItem
{
    public int PedidoProveedorItemsId { get; set; }

    public int? ProdId { get; set; }

    public int? ProductoProveedorId { get; set; }

    public decimal? Cantidad { get; set; }

    public int? PedidoProveedorId { get; set; }

    public int? Util { get; set; }

    public decimal? Pendiente { get; set; }

    public decimal? Uso { get; set; }

    public virtual PedidoProveedor? PedidoProveedor { get; set; }
}
