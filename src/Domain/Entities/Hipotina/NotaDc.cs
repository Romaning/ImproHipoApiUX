using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class NotaDc
{
    public int NotaDcid { get; set; }

    public int Codigo { get; set; }

    public int NotasCreditoDebitoId { get; set; }

    public int DocumentoAutorizacionId { get; set; }

    public int EntregaId { get; set; }

    public int CustomerId { get; set; }

    public int Tipo { get; set; }

    public int NroNotaDc { get; set; }

    public DateTime FechaEmision { get; set; }

    public string? Nit { get; set; }

    public string? NombreRazonSocial { get; set; }

    public string? CodControl { get; set; }

    public int Activo { get; set; }

    public int UnidadId { get; set; }

    public int Util { get; set; }

    public int Anulada { get; set; }

    public long SiatAdid { get; set; }

    public string? Cuf { get; set; }

    public DateTime FechaSiat { get; set; }

    public string? Leyenda { get; set; }
}
