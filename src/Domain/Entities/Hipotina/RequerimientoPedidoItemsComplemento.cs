using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class RequerimientoPedidoItemsComplemento
{
    public int RequerimientoPedidoItemsComplementosId { get; set; }

    public int ProdId { get; set; }

    public int ProductoProveedorId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal PrecioUnitarioUsd { get; set; }

    public decimal TotalUsd { get; set; }

    public decimal TotalBs { get; set; }

    public int RequerimientoPedidoId { get; set; }

    public int RequerimientoPedidoItemsId { get; set; }

    public int AlmacenId { get; set; }

    public int EsBaja { get; set; }

    public decimal Pendiente { get; set; }

    public decimal Usado { get; set; }
}
