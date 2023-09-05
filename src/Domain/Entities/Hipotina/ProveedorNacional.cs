using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class ProveedorNacional
{
    public int ProveedorNacionalId { get; set; }

    public int? MarkId { get; set; }

    public int? ProveedorId { get; set; }

    public int? NacionalId { get; set; }

    public virtual Mark? Mark { get; set; }

    public virtual Nacional? Nacional { get; set; }

    public virtual Proveedor? Proveedor { get; set; }
}
