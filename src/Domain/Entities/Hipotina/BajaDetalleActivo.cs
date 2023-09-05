using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class BajaDetalleActivo
{
    public int BajaDetalleActivoId { get; set; }

    public int BajaActivoId { get; set; }

    public int AlmacenActivoId { get; set; }

    public int ActivoId { get; set; }

    public int EstadoProductoId { get; set; }

    public int? UsoProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public string? Obs { get; set; }

    public virtual BajaActivo BajaActivo { get; set; } = null!;

    public virtual EstadoProducto EstadoProducto { get; set; } = null!;

    public virtual UsoProducto? UsoProducto { get; set; }
}
