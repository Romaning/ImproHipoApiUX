using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class UfvAnual
{
    public int UfvAnualId { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    public decimal? Valor { get; set; }
}
