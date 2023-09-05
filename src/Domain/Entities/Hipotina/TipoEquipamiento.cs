using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class TipoEquipamiento
{
    public int TipoEquipamientoId { get; set; }

    public string? Descripcion { get; set; }

    public int? Estado { get; set; }

    public virtual ICollection<Equipamiento> Equipamientos { get; set; } = new List<Equipamiento>();
}
