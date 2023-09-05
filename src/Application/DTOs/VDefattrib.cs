using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class VDefattrib
{
    public int ProdId { get; set; }

    public int Codigo { get; set; }

    public string? Atributos { get; set; }

    public string? DescripcionComplex { get; set; }

    public decimal? PrecioBase { get; set; }

    public string? Unidad { get; set; }

    public string? CodigoMigracion { get; set; }

    public DateTime? FechaBaja { get; set; }

    public decimal? CantidadAgrupada { get; set; }

    public decimal? VolumenAgrupado { get; set; }

    public string? DescripcionSearch { get; set; }

    public int TypeProdId { get; set; }
}
