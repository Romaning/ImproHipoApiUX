using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class PrecioClientePreferencial
{
    public int PrecioClientePreferencialId { get; set; }

    public int? ClienteId { get; set; }

    public int? TipoClienteId { get; set; }

    public int? PrecioDiferenciadoId { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public virtual PrecioDiferenciado? PrecioDiferenciado { get; set; }
}
