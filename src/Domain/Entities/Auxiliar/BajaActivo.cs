using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class BajaActivo
{
    public int BajaActivoId { get; set; }

    public int DocumentoActivoId { get; set; }

    public int? MonedaId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaEstado { get; set; }

    public string? Observaciones { get; set; }

    public string? Estado { get; set; }

    public int AlmacenAfid { get; set; }

    public virtual ICollection<BajaDetalleActivo> BajaDetalleActivos { get; set; } = new List<BajaDetalleActivo>();

    public virtual DocumentoActivo DocumentoActivo { get; set; } = null!;
}
