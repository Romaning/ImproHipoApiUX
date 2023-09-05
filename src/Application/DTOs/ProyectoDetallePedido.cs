using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class ProyectoDetallePedido
{
    public int ProyectoDetallePedidoId { get; set; }

    public int ProyectoId { get; set; }

    public int ProductId { get; set; }

    public int EstadoProducto { get; set; }

    public int UsoProducto { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Pendiente { get; set; }

    public decimal Usado { get; set; }

    public decimal PrecioBase { get; set; }

    public decimal Costo { get; set; }

    public int Estado { get; set; }

    public int Util { get; set; }

    public decimal CantFacturado { get; set; }

    public virtual Proyecto Proyecto { get; set; } = null!;
}
