using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class PedidoStock
{
    public int PedidoStockId { get; set; }

    public string? Observaciones { get; set; }

    public string? Descripcion { get; set; }

    public int Estado { get; set; }

    public string? UsuarioEmail { get; set; }

    public int UnidadId { get; set; }

    public DateTime FechaPedido { get; set; }

    public virtual ICollection<PedidoStockItem> PedidoStockItems { get; set; } = new List<PedidoStockItem>();
}
