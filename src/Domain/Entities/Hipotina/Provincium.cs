using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class Provincium
{
    public int ProvinciaId { get; set; }

    public string? Descripcion { get; set; }

    public int Local { get; set; }

    public virtual ICollection<DireccionNacional> DireccionNacionals { get; set; } = new List<DireccionNacional>();

    public virtual ICollection<DireccionProveedor> DireccionProveedors { get; set; } = new List<DireccionProveedor>();
}
