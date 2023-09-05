using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class Altum
{
    public int AltaId { get; set; }

    public int DocumentoId { get; set; }

    public int AlmacenId { get; set; }

    public int? MonedaId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaEstado { get; set; }

    public string? Observaciones { get; set; }

    public string Estado { get; set; } = null!;

    public string? TipoAlta { get; set; }

    public virtual Almacen Almacen { get; set; } = null!;

    public virtual ICollection<AltaDetalle> AltaDetalles { get; set; } = new List<AltaDetalle>();

    public virtual Documento Documento { get; set; } = null!;

    public virtual Monedum? Moneda { get; set; }
}
