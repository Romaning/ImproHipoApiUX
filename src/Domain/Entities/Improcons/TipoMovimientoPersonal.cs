using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class TipoMovimientoPersonal
{
    public int TipoMovimientoPersonalId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public string? Tipo { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<EstructuraPersonal> EstructuraPersonals { get; set; } = new List<EstructuraPersonal>();
}
