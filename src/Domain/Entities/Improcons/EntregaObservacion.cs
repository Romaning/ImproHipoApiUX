using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class EntregaObservacion
{
    public int EntregaObservacionId { get; set; }

    public int DireccionClienteId { get; set; }

    public string? HoraDesde { get; set; }

    public string? HoraHasta { get; set; }

    public DateTime FechaObservacion { get; set; }

    public int AsignacionVehiculoChoferId { get; set; }

    public int TipoObservacion { get; set; }

    public bool WithTransportadora { get; set; }

    public string? DescrTransportadora { get; set; }
}
