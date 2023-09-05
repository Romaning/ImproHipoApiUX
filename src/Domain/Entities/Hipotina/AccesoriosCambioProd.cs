using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class AccesoriosCambioProd
{
    public int AccesoriosCambioProdId { get; set; }

    public int? ProdId { get; set; }

    public int TipoAccesorioCambioId { get; set; }

    public virtual Prod? Prod { get; set; }

    public virtual TipoAccesorioCambio TipoAccesorioCambio { get; set; } = null!;
}
