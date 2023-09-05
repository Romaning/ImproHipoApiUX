using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class ClasificacionActivo
{
    public int ClasificacionActivoId { get; set; }

    public string? Descripcion { get; set; }

    public int Estado { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? Observacion { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();
}
