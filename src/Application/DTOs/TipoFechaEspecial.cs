﻿using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class TipoFechaEspecial
{
    public int TipoFechaEspecialId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public virtual ICollection<FechaEspecial> FechaEspecials { get; set; } = new List<FechaEspecial>();
}
