using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class NumeroDocumentoActivo
{
    public int NumeroDocumentoActivoId { get; set; }

    public int? TipoDocumentoActivoId { get; set; }

    public long Secuencia { get; set; }

    public int? UnidadId { get; set; }

    public virtual TipoDocumentoActivo? TipoDocumentoActivo { get; set; }

    public virtual Unidad? Unidad { get; set; }
}
