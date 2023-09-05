using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class EquipamientoProd
{
    public int EquipamientoProdId { get; set; }

    public int ProdId { get; set; }

    public int EquipamientoId { get; set; }

    public virtual Equipamiento Equipamiento { get; set; } = null!;

    public virtual Prod Prod { get; set; } = null!;
}
