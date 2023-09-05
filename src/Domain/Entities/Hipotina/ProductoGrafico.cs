using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class ProductoGrafico
{
    public int ProductoGraficoId { get; set; }

    public int ProdId { get; set; }

    public string? CodigoGrafico { get; set; }

    public string? Ruta { get; set; }

    public virtual Prod Prod { get; set; } = null!;
}
