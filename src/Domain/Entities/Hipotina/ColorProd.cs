using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class ColorProd
{
    public int ColorProdId { get; set; }

    public int? ProdId { get; set; }

    public int? TipoColorProdId { get; set; }

    public virtual Prod? Prod { get; set; }

    public virtual TipoColorProd? TipoColorProd { get; set; }
}
