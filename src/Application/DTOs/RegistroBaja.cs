using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class RegistroBaja
{
    public int RegistroBajasId { get; set; }

    public int EmpleadoId { get; set; }

    public decimal? Dias { get; set; }

    public DateTime FecBaja { get; set; }
}
