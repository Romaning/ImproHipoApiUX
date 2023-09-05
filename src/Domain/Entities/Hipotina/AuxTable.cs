using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class AuxTable
{
    public int Codigo { get; set; }

    public string? Descripcion { get; set; }

    public int CostoAnterior { get; set; }

    public decimal? CostoActual { get; set; }

    public decimal? PlantillaCosto { get; set; }

    public string AltaProduccion { get; set; } = null!;

    public string BajaProduccion { get; set; } = null!;

    public int EnProduccion { get; set; }

    public decimal ManoDeObra { get; set; }

    public decimal GastosDeFabricacion { get; set; }
}
