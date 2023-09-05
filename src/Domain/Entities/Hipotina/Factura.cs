using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

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

    public string? NumeroTarjeta { get; set; }

    public int MetodoPagoSiat { get; set; }

    public string? DescripcionPagoSiat { get; set; }

    public long? SiatInvoiceId { get; set; }

    public string? Cuf { get; set; }

    public DateTime FechaSiat { get; set; }

    public int TipoEmision { get; set; }

    public string? Leyenda { get; set; }
}
