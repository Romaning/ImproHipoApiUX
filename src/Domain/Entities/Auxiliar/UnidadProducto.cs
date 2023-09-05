using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class UnidadProducto
{
    public int UnidadProductoId { get; set; }

    public string? Descripcion { get; set; }

    public int Estado { get; set; }

    public DateTime? FechaAlta { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();
}
