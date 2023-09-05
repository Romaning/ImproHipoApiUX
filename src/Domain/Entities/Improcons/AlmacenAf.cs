using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class AlmacenAf
{
    public int AlmacenAfid { get; set; }

    public int UnidadId { get; set; }

    public string? Nombre { get; set; }

    public string? NombreCorto { get; set; }

    public virtual ICollection<AlmacenActivo> AlmacenActivos { get; set; } = new List<AlmacenActivo>();

    public virtual ICollection<SolicitanteActivo> SolicitanteActivos { get; set; } = new List<SolicitanteActivo>();
}
