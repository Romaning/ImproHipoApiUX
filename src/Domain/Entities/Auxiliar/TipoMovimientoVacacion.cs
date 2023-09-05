using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class TipoMovimientoVacacion
{
    public int TipoMovimientoVacacionId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<Vacacion> Vacacions { get; set; } = new List<Vacacion>();
}
