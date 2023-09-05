using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class CompromisoProd
{
    public int CompromisoProdId { get; set; }

    public decimal? Cantidad { get; set; }

    public DateTime? Fecha { get; set; }

    public int? CompromisoUnidadId { get; set; }

    public int? ProdId { get; set; }

    public int? ProveedorProductoId { get; set; }

    public string? Observaciones { get; set; }

    public virtual CompromisoUnidad? CompromisoUnidad { get; set; }
}
