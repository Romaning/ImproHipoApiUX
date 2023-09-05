using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class DetalleAccesorio
{
    public int DetalleAccesorioId { get; set; }

    public int AccesoriosProdId { get; set; }

    public decimal Cantidad { get; set; }

    public int ProdId { get; set; }

    public string? Observaciones { get; set; }
}
