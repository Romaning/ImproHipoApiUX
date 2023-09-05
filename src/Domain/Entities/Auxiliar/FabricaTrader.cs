using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class FabricaTrader
{
    public int FabricaTraderId { get; set; }

    public int? FabricaId { get; set; }

    public int? TraderId { get; set; }

    public virtual Fabrica? Fabrica { get; set; }

    public virtual Trader? Trader { get; set; }
}
