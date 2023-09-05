using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class Conductor
{
    public int ConductorId { get; set; }

    public int TransporteId { get; set; }

    public string Nombres { get; set; } = null!;

    public string Ci { get; set; } = null!;

    public virtual ICollection<SolicitudTraspaso> SolicitudTraspasos { get; set; } = new List<SolicitudTraspaso>();

    public virtual Transporte Transporte { get; set; } = null!;
}
