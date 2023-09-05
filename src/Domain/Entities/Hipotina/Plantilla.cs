using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class Plantilla
{
    public int PlantillaId { get; set; }

    public DateTime FechaCreado { get; set; }

    public DateTime? FechaModificado { get; set; }

    public string? Usuario { get; set; }

    public int Estado { get; set; }

    public int ProdId { get; set; }

    public decimal CostoTotal { get; set; }

    public string? Obs { get; set; }

    public string? Tipo { get; set; }

    public virtual ICollection<CostoPlantilla> CostoPlantillas { get; set; } = new List<CostoPlantilla>();

    public virtual ICollection<PlantillaDetalle> PlantillaDetalles { get; set; } = new List<PlantillaDetalle>();

    public virtual Prod Prod { get; set; } = null!;
}
