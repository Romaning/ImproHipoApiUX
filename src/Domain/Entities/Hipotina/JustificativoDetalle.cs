using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class JustificativoDetalle
{
    public int JustificativoDetalleId { get; set; }

    public int EmpleadoId { get; set; }

    public string? FechaTurno { get; set; }

    public string? Observaciones { get; set; }

    public int Estado { get; set; }

    public int JustificativoId { get; set; }

    public virtual Justificativo Justificativo { get; set; } = null!;
}
