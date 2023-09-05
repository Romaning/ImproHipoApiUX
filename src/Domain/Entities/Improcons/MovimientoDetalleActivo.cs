using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class MovimientoDetalleActivo
{
    public int MovimientoDetalleActivoId { get; set; }

    public int EstadoProductoId { get; set; }

    public int MovimientoActivoId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal? Costo { get; set; }

    public int? UsoProductoId { get; set; }

    public int ActivoId { get; set; }

    public string? Obs { get; set; }

    public int? UnidadIdSol { get; set; }

    public decimal? CostoIngreso { get; set; }

    public decimal? CostoAnterior { get; set; }

    public virtual MovimientoActivo MovimientoActivo { get; set; } = null!;
}
