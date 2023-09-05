using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class UnidadComision
{
    public int UnidadComisionId { get; set; }

    public int Mes { get; set; }

    public int Anio { get; set; }

    public decimal BonoAdicional { get; set; }

    public decimal Bono { get; set; }

    public int Ci { get; set; }

    public int UnidadId { get; set; }
}
