using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class EstadoMovimientoOperacion
{
    public int EstadoMovimientoOperacionId { get; set; }

    public string? EstadoMovimientoOperacionChar { get; set; }

    public string? DescripcionEstadoMovOp { get; set; }

    public string? RelatoEstadoMovOp { get; set; }
}
