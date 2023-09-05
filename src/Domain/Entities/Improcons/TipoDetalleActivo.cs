using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class TipoDetalleActivo
{
    public int TipoDetalleActivoId { get; set; }

    public int ClaseActivoId { get; set; }

    public string? Descripcion { get; set; }

    public int? Estado { get; set; }

    public virtual ClaseActivo ClaseActivo { get; set; } = null!;
}
