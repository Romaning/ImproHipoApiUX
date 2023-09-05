using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class UnificacionProd
{
    public int UnificacionProdId { get; set; }

    public string? Sistemas { get; set; }

    public int CodigoSies { get; set; }

    public int CodigoSicom { get; set; }

    public int CodigoAuxiliar { get; set; }
}
