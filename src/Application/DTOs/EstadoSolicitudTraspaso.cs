using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class EstadoSolicitudTraspaso
{
    public int EstadoSolicitudTraspasoId { get; set; }

    public string? EstadoSolicitudChar { get; set; }

    public string? DescripcionEstadoSoli { get; set; }

    public string? RelatoEstadoSoli { get; set; }
}
