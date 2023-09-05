using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class PedidoProduccion
{
    public int PedidoProduccionId { get; set; }

    public int UnidadId { get; set; }

    public int ClienteId { get; set; }

    public DateTime FechaPedido { get; set; }

    public DateTime FechaEntrega { get; set; }

    public int Estado { get; set; }

    public int ProdId { get; set; }

    public string? Observaciones { get; set; }

    public int CotizacionId { get; set; }

    public int CotizacionItemsId { get; set; }

    public int CotizacionItemsOpid { get; set; }

    public int TipoPedido { get; set; }

    public int ProductoGraficoId { get; set; }

    public int TipoPosicionFaldonId { get; set; }

    public string? TonoExacto { get; set; }

    public virtual ICollection<PedidoProduccionDetalle> PedidoProduccionDetalles { get; set; } = new List<PedidoProduccionDetalle>();
}
