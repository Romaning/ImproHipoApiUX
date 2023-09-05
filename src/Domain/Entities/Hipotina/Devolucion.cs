using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class Devolucion
{
    public int DevolucionId { get; set; }

    public int DocumentoAutorizacionId { get; set; }

    public int PedidoAutorizacionId { get; set; }

    public int PedidoNumero { get; set; }

    public int MovimientoInicioId { get; set; }

    public int MovimientoFinId { get; set; }

    public int FacturaId { get; set; }

    public string? Observaciones { get; set; }

    public int Estado { get; set; }

    public int Activo { get; set; }

    public int Util { get; set; }

    public int CustomerId { get; set; }

    public int UnidadId { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Total { get; set; }
}
