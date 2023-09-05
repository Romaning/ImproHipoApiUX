using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class TipoCostoPlantilla
{
    public int TipoCostoPlantillaId { get; set; }

    public string? Descripcion { get; set; }

    public int? Estado { get; set; }

    public virtual ICollection<CostoPlantilla> CostoPlantillas { get; set; } = new List<CostoPlantilla>();
}
