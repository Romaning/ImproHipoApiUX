using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class BajaProduccionDetalle
{
    public int BajaProduccionDetalleId { get; set; }

    public int BajaProduccionId { get; set; }

    public int ProdId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Costo { get; set; }

    public virtual BajaProduccion BajaProduccion { get; set; } = null!;
}
