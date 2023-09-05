using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class ProveedorProdRel
{
    public int ProveedorProdRelId { get; set; }

    public int ProdId { get; set; }

    public int ProveedorProductoId { get; set; }

    public virtual ProveedorProducto ProveedorProducto { get; set; } = null!;
}
