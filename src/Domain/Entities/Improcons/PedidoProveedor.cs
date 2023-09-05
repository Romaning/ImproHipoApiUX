using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class PedidoProveedor
{
    public int PedidoProveedorId { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public int? Estado { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? Finalizado { get; set; }

    public int Activo { get; set; }

    public int ConcluidoPedido { get; set; }

    public string? ProformaProveedorId { get; set; }

    public int ProveedorId { get; set; }

    public string? Observaciones { get; set; }

    public virtual ICollection<PedidoProveedorItem> PedidoProveedorItems { get; set; } = new List<PedidoProveedorItem>();

    public virtual ICollection<RequerimientoPedido> RequerimientoPedidos { get; set; } = new List<RequerimientoPedido>();
}
