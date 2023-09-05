using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class NumeroDocumento
{
    public int NumeroDocumentoId { get; set; }

    public int? TipoDocumentoId { get; set; }

    public long Secuencia { get; set; }

    public int? UnidadId { get; set; }

    public virtual TipoDocumento? TipoDocumento { get; set; }

    public virtual Unidad? Unidad { get; set; }
}
