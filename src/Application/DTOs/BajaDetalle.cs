using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class BajaDetalle
{
    public int BajaDetalleId { get; set; }

    public int BajaId { get; set; }

    public int AlmacenProductoId { get; set; }

    public int Codigo { get; set; }

    public int EstadoProductoId { get; set; }

    public int UsoProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public string? Obs { get; set; }

    public virtual AlmacenProducto AlmacenProducto { get; set; } = null!;

    public virtual Baja Baja { get; set; } = null!;

    public virtual EstadoProducto EstadoProducto { get; set; } = null!;

    public virtual UsoProducto UsoProducto { get; set; } = null!;
}
