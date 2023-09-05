using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Entrega
{
    public int EntregaId { get; set; }

    public int DocumentoId { get; set; }

    public int EntregaObservacionId { get; set; }

    public DateTime FechaEntrega { get; set; }

    public int Codigo { get; set; }

    public int PrePedidoId { get; set; }

    public int Estado { get; set; }
}
