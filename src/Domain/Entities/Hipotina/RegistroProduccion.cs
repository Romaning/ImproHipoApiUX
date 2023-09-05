using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class RegistroProduccion
{
    public int RegistroProduccionId { get; set; }

    public int PedidoProduccionDetalleId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime? FechaProduccion { get; set; }

    public int Estado { get; set; }

    public virtual PedidoProduccionDetalle PedidoProduccionDetalle { get; set; } = null!;
}
