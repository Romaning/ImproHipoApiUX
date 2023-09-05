using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class ProveedorTrader
{
    public int ProveedorTraderId { get; set; }

    public int? ProveedorId { get; set; }

    public int? MarkId { get; set; }

    public int? TraderId { get; set; }

    public int Estado { get; set; }

    public virtual Mark? Mark { get; set; }

    public virtual Proveedor? Proveedor { get; set; }

    public virtual Trader? Trader { get; set; }
}
