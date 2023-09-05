using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class AjusteDetalle
{
    public int AjusteDetalleId { get; set; }

    public int AjusteId { get; set; }

    public string TipoAjuste { get; set; } = null!;

    public int AlmacenProductoId { get; set; }

    public int Codigo { get; set; }

    public int EstadoProductoId { get; set; }

    public int UsoProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public int? NuevoCodigo { get; set; }

    public int? NuevoEstadoProductoId { get; set; }

    public int? NuevoUsoProductoId { get; set; }

    public decimal? NuevoCosto { get; set; }

    public string? Obs { get; set; }

    public decimal? CostoIngreso { get; set; }

    public bool Recosteo { get; set; }

    public string? Tajuste { get; set; }

    public virtual Ajuste Ajuste { get; set; } = null!;

    public virtual AlmacenProducto AlmacenProducto { get; set; } = null!;

    public virtual EstadoProducto EstadoProducto { get; set; } = null!;

    public virtual UsoProducto UsoProducto { get; set; } = null!;
}
