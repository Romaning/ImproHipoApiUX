using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class TraspasoActivoDet
{
    public int TraspasoActivoDetId { get; set; }

    public int TraspasoActivoId { get; set; }

    public int AlmacenActivoId { get; set; }

    public decimal Cantidad { get; set; }

    public virtual AlmacenActivo AlmacenActivo { get; set; } = null!;

    public virtual TraspasoActivo TraspasoActivo { get; set; } = null!;
}
