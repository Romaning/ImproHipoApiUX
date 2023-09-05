using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class UfvAnual
{
    public int UfvAnualId { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public int? Dia { get; set; }

    public decimal? Valor { get; set; }
}
