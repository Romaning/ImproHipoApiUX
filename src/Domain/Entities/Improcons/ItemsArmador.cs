using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class ItemsArmador
{
    public int ItemsArmadorId { get; set; }

    public int ProdId { get; set; }

    public int ArmadorId { get; set; }

    public string? FechaAlta { get; set; }

    public string? FechaBaja { get; set; }

    public string? Observaciones { get; set; }

    public virtual Armador Armador { get; set; } = null!;

    public virtual Prod Prod { get; set; } = null!;
}
