using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class TipoProveedor
{
    public int TipoProveedorId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
