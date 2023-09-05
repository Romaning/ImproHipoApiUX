using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class AltaDetalleActivo
{
    public int AltaDetalleActivoId { get; set; }

    public int AltaActivoId { get; set; }

    public int ActivoId { get; set; }

    public int EstadoProductoId { get; set; }

    public int? UsoProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public decimal? CostoIngreso { get; set; }

    public string? Obs { get; set; }

    public bool Recosteo { get; set; }

    public virtual AltaActivo AltaActivo { get; set; } = null!;

    public virtual EstadoProducto EstadoProducto { get; set; } = null!;

    public virtual UsoProducto? UsoProducto { get; set; }
}
