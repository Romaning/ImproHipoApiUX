using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class PedidoCobranza
{
    public int PedidoCobranzaId { get; set; }

    public int DocAutorizacionPedido { get; set; }

    public int DocAutorizacionCobranza { get; set; }

    public decimal? SaldoCobranza { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int Estado { get; set; }
}
