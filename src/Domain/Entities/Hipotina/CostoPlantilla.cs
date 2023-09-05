using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class CostoPlantilla
{
    public int CostoPlantillaId { get; set; }

    public int? PlantillaId { get; set; }

    public decimal? Costo1 { get; set; }

    public decimal? Costo2 { get; set; }

    public int? Estado { get; set; }

    public int? TipoCostoPlantillaId { get; set; }

    public virtual Plantilla? Plantilla { get; set; }

    public virtual TipoCostoPlantilla? TipoCostoPlantilla { get; set; }
}
