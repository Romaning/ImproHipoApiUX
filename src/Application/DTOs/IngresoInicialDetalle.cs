using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class IngresoInicialDetalle
{
    public int IngresoInicialDetalleId { get; set; }

    public int DocumentoId { get; set; }

    public int AlmacenId { get; set; }

    public int MonedaId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int ProdId { get; set; }

    public int EstadoProductoId { get; set; }

    public int UsoProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public string? Observaciones { get; set; }

    public bool Recosteo { get; set; }

    public decimal PrecioLista { get; set; }

    public virtual EstadoProducto EstadoProducto { get; set; } = null!;

    public virtual Prod Prod { get; set; } = null!;

    public virtual UsoProducto UsoProducto { get; set; } = null!;
}
