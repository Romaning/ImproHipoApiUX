using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class OrdenProduccion
{
    public int OrdenProduccionId { get; set; }

    public string? NroOrdenProd { get; set; }

    public int Estado { get; set; }

    public DateTime FechaEntrega { get; set; }

    public int ProdId { get; set; }

    public decimal Cantidad { get; set; }

    public string? EspecificacionesTecnicas { get; set; }

    public string? Observaciones { get; set; }

    public int ProductoGraficoId { get; set; }

    public int TipoPosicionFaldonId { get; set; }

    public string? TonoExacto { get; set; }
}
