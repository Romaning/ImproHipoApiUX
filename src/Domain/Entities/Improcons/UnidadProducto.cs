using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class UnidadProducto
{
    public int UnidadProductoId { get; set; }

    public string? Descripcion { get; set; }

    public int Estado { get; set; }

    public DateTime? FechaAlta { get; set; }

    public int CodigoUniMedidaSin { get; set; }

    public string? DescUniMedidaSin { get; set; }

    public int IdUniMedidaSin { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();
}
