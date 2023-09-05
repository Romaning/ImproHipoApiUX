using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class TipoMovimientoActivo
{
    public int TipoMovimientoActivoId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public bool Recosteo { get; set; }

    public virtual ICollection<MovimientoActivo> MovimientoActivos { get; set; } = new List<MovimientoActivo>();
}
