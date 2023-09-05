using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class PedidoStockItem
{
    public int PedidoStockItemsId { get; set; }

    public int PedidoStockId { get; set; }

    public string? EspecificacionTecnica { get; set; }

    public string? Observaciones { get; set; }

    public int Opninicial { get; set; }

    public int Opnfinal { get; set; }

    public decimal Pendiente { get; set; }

    public decimal Usado { get; set; }

    public decimal Cantidad { get; set; }

    public DateTime FechaEntrega { get; set; }

    public string? Mes { get; set; }

    public string? Anio { get; set; }

    public int ProdId { get; set; }

    public decimal PrecioBase { get; set; }

    public decimal Costo { get; set; }

    public int ProductoGraficoId { get; set; }

    public int TipoPosicionFaldonId { get; set; }

    public string? TonoExacto { get; set; }

    public int EsProduccion { get; set; }

    public virtual PedidoStock PedidoStock { get; set; } = null!;
}
