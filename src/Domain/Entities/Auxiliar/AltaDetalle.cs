using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class AltaDetalle
{
    public int AltaDetalleId { get; set; }

    public int AltaId { get; set; }

    public int Codigo { get; set; }

    public int EstadoProductoId { get; set; }

    public int UsoProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public decimal? CostoIngreso { get; set; }

    public string? Obs { get; set; }

    public bool Recosteo { get; set; }

    public virtual Altum Alta { get; set; } = null!;

    public virtual EstadoProducto EstadoProducto { get; set; } = null!;

    public virtual UsoProducto UsoProducto { get; set; } = null!;
}
