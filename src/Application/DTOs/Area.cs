using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Area
{
    public int AreaId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public int Estado { get; set; }

    public int? UnidadId { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();

    public virtual ICollection<EstructuraPersonal> EstructuraPersonals { get; set; } = new List<EstructuraPersonal>();
}
