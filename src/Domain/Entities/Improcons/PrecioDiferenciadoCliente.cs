using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class PrecioDiferenciadoCliente
{
    public int PrecioDiferenciadoClienteId { get; set; }

    public int TipoClienteId { get; set; }

    public int PrecioDiferenciadoId { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Observacion { get; set; }

    public virtual PrecioDiferenciado PrecioDiferenciado { get; set; } = null!;

    public virtual TipoCliente TipoCliente { get; set; } = null!;
}
