using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class ContactoProveedor
{
    public int ContactoProveedorId { get; set; }

    public string? Nombre { get; set; }

    public string? Cargo { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public int? FabricaId { get; set; }

    public int? TraderId { get; set; }

    public virtual Fabrica? Fabrica { get; set; }

    public virtual Trader? Trader { get; set; }
}
