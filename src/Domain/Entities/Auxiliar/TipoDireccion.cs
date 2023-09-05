using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class TipoDireccion
{
    public int TipoDireccionId { get; set; }

    public string? Nombre { get; set; }

    public int Local { get; set; }

    public virtual ICollection<DireccionNacional> DireccionNacionals { get; set; } = new List<DireccionNacional>();

    public virtual ICollection<DireccionProveedor> DireccionProveedors { get; set; } = new List<DireccionProveedor>();
}
