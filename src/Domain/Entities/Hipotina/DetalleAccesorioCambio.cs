using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class DetalleAccesorioCambio
{
    public int DetalleAccesorioCambioId { get; set; }

    public int AccesoriosCambioProdId { get; set; }

    public decimal Cantidad { get; set; }

    public int ProdId { get; set; }

    public string? Observaciones { get; set; }
}
