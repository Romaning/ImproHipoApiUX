using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class SolicitudTraspaso
{
    public int SolicitudTraspasoId { get; set; }

    public int DocumentoId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime FechaEstado { get; set; }

    public string? Obs { get; set; }

    public DateTime? FechaEnvio { get; set; }

    public DateTime? FechaArrivo { get; set; }

    public int? ConductorId { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual Conductor? Conductor { get; set; }

    public virtual Documento Documento { get; set; } = null!;

    public virtual ICollection<Solicitante> Solicitantes { get; set; } = new List<Solicitante>();
}
