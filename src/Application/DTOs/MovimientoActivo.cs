using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class MovimientoActivo
{
    public int MovimientoActivoId { get; set; }

    public int? DocumentoActivoId { get; set; }

    public int AlmacenAfid { get; set; }

    public int? DocumentoAutorizacionId { get; set; }

    public int MonedaId { get; set; }

    public int TipoMovimientoActivoId { get; set; }

    public DateTime FechaPendiente { get; set; }

    public bool Regular { get; set; }

    public string? Operacion { get; set; }

    public string? Observaciones { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaCambioManual { get; set; }

    public DateTime? Fecha { get; set; }

    public DateTime? FechaAnulacion { get; set; }

    public string? RazonAnulacion { get; set; }

    public string? UserName { get; set; }

    public virtual DocumentoActivo? DocumentoActivo { get; set; }

    public virtual ICollection<MovimientoDetalleActivo> MovimientoDetalleActivos { get; set; } = new List<MovimientoDetalleActivo>();

    public virtual TipoMovimientoActivo TipoMovimientoActivo { get; set; } = null!;
}
