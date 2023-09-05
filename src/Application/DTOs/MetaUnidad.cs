using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class MetaUnidad
{
    public int MetaUnidadId { get; set; }

    public decimal Meta { get; set; }

    public int Mes { get; set; }

    public int Anio { get; set; }

    public int UnidadId { get; set; }

    public int Estado { get; set; }
}
