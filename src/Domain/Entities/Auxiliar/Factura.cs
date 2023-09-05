using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class Factura
{
    public int FacturaId { get; set; }

    public int Codigo { get; set; }

    public int TalonarioId { get; set; }

    public int DocumentoAutorizacionId { get; set; }

    public int EntregaId { get; set; }

    public int CustomerId { get; set; }

    public int Tipo { get; set; }

    public int NroFactura { get; set; }

    public DateTime FechaEmision { get; set; }

    public string? Nit { get; set; }

    public string? NombreRazonSocial { get; set; }

    public string? CodControl { get; set; }

    public int Activo { get; set; }

    public int UnidadId { get; set; }

    public int Util { get; set; }

    public int Anulada { get; set; }
}
