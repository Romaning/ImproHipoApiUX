using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Relacionador
{
    public int RelacionadorId { get; set; }

    public int ClienteId { get; set; }

    public int RelacionadorClienteId { get; set; }

    public int TipoRelacionadorId { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual TipoRelacionador TipoRelacionador { get; set; } = null!;
}
