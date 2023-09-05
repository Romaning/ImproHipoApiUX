using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class TipoPermiso
{
    public int TipoPermisoId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public int Estado { get; set; }

    public int Categoria { get; set; }

    public virtual ICollection<Permiso> Permisos { get; set; } = new List<Permiso>();
}
