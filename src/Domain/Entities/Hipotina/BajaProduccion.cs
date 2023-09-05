using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class BajaProduccion
{
    public int BajaProduccionId { get; set; }

    public int DocAutorizacionId { get; set; }

    public DateTime FechaCreado { get; set; }

    public string? Usuario { get; set; }

    public int Estado { get; set; }

    public int AlmacenId { get; set; }

    public int MonedaId { get; set; }

    public decimal CostoTotal { get; set; }

    public string? Obs { get; set; }

    public int Tipo { get; set; }

    public int PedidoProduccionDetalleId { get; set; }

    public virtual ICollection<BajaProduccionDetalle> BajaProduccionDetalles { get; set; } = new List<BajaProduccionDetalle>();
}
