using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class SolicitudTraspasoActivo
{
    public int SolicitudTraspasoActivoId { get; set; }

    public int DocumentoActivoId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public string? Estado { get; set; }

    public DateTime FechaEstado { get; set; }

    public string? Obs { get; set; }

    public DateTime? FechaEnvio { get; set; }

    public DateTime? FechaArrivo { get; set; }

    public int? ConductorId { get; set; }

    public string? Tipo { get; set; }

    public virtual DocumentoActivo DocumentoActivo { get; set; } = null!;

    public virtual ICollection<SolicitanteActivo> SolicitanteActivos { get; set; } = new List<SolicitanteActivo>();
}
