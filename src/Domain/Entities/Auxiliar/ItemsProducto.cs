using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class ItemsProducto
{
    public int ItemsProductoId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int ProdId { get; set; }

    public int PackProductoId { get; set; }

    public string? Observaciones { get; set; }

    public virtual PackProducto PackProducto { get; set; } = null!;

    public virtual Prod Prod { get; set; } = null!;
}
