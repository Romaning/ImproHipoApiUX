using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class DeprecActActivo
{
    public int DeprecActActivoId { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Ufvinicial { get; set; }

    public decimal? Ufvfinal { get; set; }

    public DateTime? FechaAnterior { get; set; }

    public DateTime? FechaCierre { get; set; }

    public int Estado { get; set; }

    public decimal? TipoCambio { get; set; }

    public int? MonedaId { get; set; }

    public string? Observacion { get; set; }

    public virtual ICollection<DeprecActDetalleActivo> DeprecActDetalleActivos { get; set; } = new List<DeprecActDetalleActivo>();

    public virtual Monedum? Moneda { get; set; }
}
