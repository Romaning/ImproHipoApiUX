using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class NoConformidad
{
    public int NoConformidadId { get; set; }

    public int MovimientoDetalleId { get; set; }

    public decimal Cantidad { get; set; }

    public DateTime Fecha { get; set; }

    public string Detalle { get; set; } = null!;

    public DateTime? FechaResuelto { get; set; }

    public string? ObsResuelto { get; set; }

    public byte[] Imagen1 { get; set; } = null!;

    public byte[]? Imagen2 { get; set; }

    public virtual MovimientoDetalle MovimientoDetalle { get; set; } = null!;
}
