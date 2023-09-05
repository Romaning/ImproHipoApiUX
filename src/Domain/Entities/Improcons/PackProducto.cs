using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class PackProducto
{
    public int PackProductoId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime FechaBaja { get; set; }

    public string? Foto { get; set; }

    public decimal? Descuento { get; set; }

    public virtual ICollection<ItemsProducto> ItemsProductos { get; set; } = new List<ItemsProducto>();
}
