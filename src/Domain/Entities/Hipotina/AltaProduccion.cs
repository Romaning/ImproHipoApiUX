using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class AltaProduccion
{
    public int AltaProduccionId { get; set; }

    public int DocAutorizacionId { get; set; }

    public DateTime FechaCreado { get; set; }

    public string? Usuario { get; set; }

    public int Estado { get; set; }

    public int AlmacenId { get; set; }

    public int MonedaId { get; set; }

    public decimal CostoTotal { get; set; }

    public string? Obs { get; set; }

    public int BajaProduccionId { get; set; }

    public virtual ICollection<AltaProduccionDetalle> AltaProduccionDetalles { get; set; } = new List<AltaProduccionDetalle>();
}
