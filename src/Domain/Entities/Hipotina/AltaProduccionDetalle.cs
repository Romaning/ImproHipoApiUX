using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class AltaProduccionDetalle
{
    public int AltaProduccionDetalleId { get; set; }

    public int AltaProduccionId { get; set; }

    public int ProdId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public virtual AltaProduccion AltaProduccion { get; set; } = null!;
}
