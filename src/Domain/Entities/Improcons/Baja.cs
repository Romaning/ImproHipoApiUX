using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Baja
{
    public int BajaId { get; set; }

    public int DocumentoId { get; set; }

    public int AlmacenId { get; set; }

    public int? MonedaId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaEstado { get; set; }

    public string? Observaciones { get; set; }

    public string Estado { get; set; } = null!;

    public virtual Almacen Almacen { get; set; } = null!;

    public virtual ICollection<BajaDetalle> BajaDetalles { get; set; } = new List<BajaDetalle>();

    public virtual Documento Documento { get; set; } = null!;

    public virtual Monedum? Moneda { get; set; }
}
