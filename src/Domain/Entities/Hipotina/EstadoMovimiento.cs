using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class EstadoMovimiento
{
    public int EstadoMovimientoId { get; set; }

    public string? EstadoMovimientoChar { get; set; }

    public string? DescripcionEstadoMov { get; set; }

    public string? RelatoEstadoMov { get; set; }
}
