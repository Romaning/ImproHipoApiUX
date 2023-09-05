using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class ComprobanteActivo
{
    public int ComprobanteActivoId { get; set; }

    public int MonedaId { get; set; }

    public int TipoComprobanteActivoId { get; set; }

    public DateTime Fecha { get; set; }

    public string? Descripcion { get; set; }

    public string? Numero { get; set; }

    public decimal? TipoCambio { get; set; }

    public decimal? Ufv { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();

    public virtual Monedum Moneda { get; set; } = null!;

    public virtual TipoComprobanteActivo TipoComprobanteActivo { get; set; } = null!;
}
