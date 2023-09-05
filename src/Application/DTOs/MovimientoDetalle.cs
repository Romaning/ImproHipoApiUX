using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class MovimientoDetalle
{
    public int MovimientoDetalleId { get; set; }

    public int EstadoProductoId { get; set; }

    public int MovimientoId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal? Costo { get; set; }

    public int UsoProductoId { get; set; }

    public int Codigo { get; set; }

    public string? Obs { get; set; }

    public int? UnidadIdSol { get; set; }

    public decimal? CostoIngreso { get; set; }

    public decimal? CostoAnterior { get; set; }

    public virtual EstadoProducto EstadoProducto { get; set; } = null!;

    public virtual Movimiento Movimiento { get; set; } = null!;

    public virtual UsoProducto UsoProducto { get; set; } = null!;
}
