﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class NivelAcademico
{
    public int NivelAcademicoId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}
