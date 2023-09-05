using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class CodigoOrdenProduccion
{
    public int CodigoOrdenProduccionId { get; set; }

    public int Anio { get; set; }

    public int Mes { get; set; }

    public int Numero { get; set; }

    public int UnidadId { get; set; }
}
