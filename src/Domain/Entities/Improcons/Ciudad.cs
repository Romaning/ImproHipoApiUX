using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Ciudad
{
    public int CiudadId { get; set; }

    public string? Descripcion { get; set; }

    public int Local { get; set; }

    public virtual ICollection<DireccionNacional> DireccionNacionals { get; set; } = new List<DireccionNacional>();

    public virtual ICollection<DireccionProveedor> DireccionProveedors { get; set; } = new List<DireccionProveedor>();
}
