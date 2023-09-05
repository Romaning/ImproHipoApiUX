using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class AltaActivo
{
    public int AltaActivoId { get; set; }

    public int DocumentoActivoId { get; set; }

    public int AlmacenAfid { get; set; }

    public int? MonedaId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaEstado { get; set; }

    public string? Observaciones { get; set; }

    public string? Estado { get; set; }

    public string? TipoAltaActivo { get; set; }

    public virtual ICollection<AltaDetalleActivo> AltaDetalleActivos { get; set; } = new List<AltaDetalleActivo>();

    public virtual DocumentoActivo DocumentoActivo { get; set; } = null!;
}
