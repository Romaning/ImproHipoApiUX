using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class ClaseActivo
{
    public int ClaseActivoId { get; set; }

    public string? Descripcion { get; set; }

    public int? Estado { get; set; }

    public decimal? Coeficiente { get; set; }

    public decimal? AnioVidaUtil { get; set; }

    public virtual ICollection<TipoActivo> TipoActivos { get; set; } = new List<TipoActivo>();

    public virtual ICollection<TipoDetalleActivo> TipoDetalleActivos { get; set; } = new List<TipoDetalleActivo>();
}
