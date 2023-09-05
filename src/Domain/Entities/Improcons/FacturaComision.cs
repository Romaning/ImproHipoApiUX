using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class FacturaComision
{
    public int FacturaComisionId { get; set; }

    public string? Sistema { get; set; }

    public string? FechaFactura { get; set; }

    public int NroFactura { get; set; }

    public string? NombreRazonSocial { get; set; }

    public string? Recomendador { get; set; }

    public decimal FacturaUsd { get; set; }

    public decimal DescuentUsd { get; set; }

    public decimal DescuentoPorcentaje { get; set; }

    public string? NumSalida { get; set; }

    public string? NumEntrega { get; set; }

    public string? EstadoSalidaAlmacen { get; set; }

    public string? EstadoCobranza { get; set; }

    public decimal CobranzaUsd { get; set; }

    public string? Vendedor { get; set; }

    public string? Comision { get; set; }

    public int Mes { get; set; }

    public int Anio { get; set; }

    public int UnidadId { get; set; }

    public int Estado { get; set; }
}
