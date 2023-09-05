using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Parcial
{
    public int ParcialId { get; set; }

    public int AlmacenId { get; set; }

    public int? DocumentoAutorizacionId { get; set; }

    public int MonedaId { get; set; }

    public int Tipo { get; set; }

    public int TipoParcialId { get; set; }

    public string Operacion { get; set; } = null!;

    public int? FacturaId { get; set; }

    public string? Observaciones { get; set; }

    public decimal Total { get; set; }

    public decimal TotalPend { get; set; }

    public int UnidadId { get; set; }

    public int CustomerId { get; set; }

    public int Estado { get; set; }

    public int Util { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime FechaEntrega { get; set; }

    public DateTime? FechaConfirma { get; set; }
}
