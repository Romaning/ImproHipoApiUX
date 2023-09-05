using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class RegistroBaja
{
    public int RegistroBajasId { get; set; }

    public int EmpleadoId { get; set; }

    public decimal? Dias { get; set; }

    public DateTime FecBaja { get; set; }
}
