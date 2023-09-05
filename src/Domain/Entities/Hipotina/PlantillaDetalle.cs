using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class PlantillaDetalle
{
    public int PlantillaDetalleId { get; set; }

    public int PlantillaId { get; set; }

    public int ProdId { get; set; }

    public decimal Cantidad { get; set; }

    public virtual Plantilla Plantilla { get; set; } = null!;
}
