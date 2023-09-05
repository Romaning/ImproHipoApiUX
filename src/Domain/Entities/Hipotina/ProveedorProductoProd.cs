﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class ProveedorProductoProd
{
    public int ProveedorProductoProdId { get; set; }

    public int? ProveedorProductoId { get; set; }

    public int? ProdId { get; set; }

    public virtual Prod? Prod { get; set; }

    public virtual ProveedorProducto? ProveedorProducto { get; set; }
}
