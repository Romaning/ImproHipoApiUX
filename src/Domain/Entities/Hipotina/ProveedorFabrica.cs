using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class ProveedorFabrica
{
    public int ProveedorFabricaId { get; set; }

    public int? MarkId { get; set; }

    public int? ProveedorId { get; set; }

    public int? FabricaId { get; set; }

    public int Estado { get; set; }

    public virtual Fabrica? Fabrica { get; set; }

    public virtual Mark? Mark { get; set; }

    public virtual Proveedor? Proveedor { get; set; }
}
