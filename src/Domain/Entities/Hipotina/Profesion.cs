using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class Profesion
{
    public int ProfesionId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
