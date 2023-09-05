using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class EstadoSolicitudTraspaso
{
    public int EstadoSolicitudTraspasoId { get; set; }

    public string? EstadoSolicitudChar { get; set; }

    public string? DescripcionEstadoSoli { get; set; }

    public string? RelatoEstadoSoli { get; set; }
}
