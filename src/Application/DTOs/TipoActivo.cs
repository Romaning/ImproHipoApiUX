using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class TipoActivo
{
    public int TipoActivoId { get; set; }

    public int ClaseActivoId { get; set; }

    public string? Descripcion { get; set; }

    public int? Estado { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();

    public virtual ClaseActivo ClaseActivo { get; set; } = null!;
}
