using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class CotizacionItemsOp
{
    public int CotizacionItemsOpid { get; set; }

    public int CotizacionItemsId { get; set; }

    public int CotizacionId { get; set; }

    public string? EspecificacionTecnica { get; set; }

    public string? Observaciones { get; set; }

    public string? Opexistentes { get; set; }

    public int? Opninicial { get; set; }

    public int? Opnfinal { get; set; }

    public decimal Pendiente { get; set; }

    public DateTime FechaEntrega { get; set; }

    public string? Mes { get; set; }

    public string? Anio { get; set; }

    public decimal Usado { get; set; }

    public int TipoPosicionFaldonId { get; set; }

    public int ProductoGraficoId { get; set; }

    public string? TonoExacto { get; set; }
}
