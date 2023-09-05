using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class VerProd
{
    public int VerProdsId { get; set; }

    public int ProdId { get; set; }

    public string? DescripcionComplex { get; set; }

    public decimal PrecioBase { get; set; }

    public string? Unidad { get; set; }

    public string? CodigoMigracion { get; set; }

    public string? DescripcionSearch { get; set; }
}
