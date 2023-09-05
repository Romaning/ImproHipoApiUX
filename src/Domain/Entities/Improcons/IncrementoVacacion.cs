using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class IncrementoVacacion
{
    public int IncrementoId { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public decimal? Dias { get; set; }

    public decimal? Saldo { get; set; }

    public int? EmpleadoId { get; set; }

    public virtual Empleado? Empleado { get; set; }
}
