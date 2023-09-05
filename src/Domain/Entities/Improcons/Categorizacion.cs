using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Categorizacion
{
    public int CategorizacionId { get; set; }

    public int ClienteId { get; set; }

    public int TipoClienteId { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Observacion { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual TipoCliente TipoCliente { get; set; } = null!;
}
