using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class ProveedorProdRel
{
    public int ProveedorProdRelId { get; set; }

    public int ProdId { get; set; }

    public int ProveedorProductoId { get; set; }
}
