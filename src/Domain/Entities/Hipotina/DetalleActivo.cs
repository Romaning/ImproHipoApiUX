using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class DetalleActivo
{
    public int DetalleActivoId { get; set; }

    public int ActivoId { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Costo { get; set; }

    public int? ActivoComplementoId { get; set; }

    public virtual Activo Activo { get; set; } = null!;
}
