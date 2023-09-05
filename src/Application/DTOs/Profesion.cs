using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Profesion
{
    public int ProfesionId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
