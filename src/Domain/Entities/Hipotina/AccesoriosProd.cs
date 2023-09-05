using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class AccesoriosProd
{
    public int AccesoriosProdId { get; set; }

    public int? ProdId { get; set; }

    public virtual Prod? Prod { get; set; }
}
