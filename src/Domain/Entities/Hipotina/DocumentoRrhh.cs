using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class DocumentoRrhh
{
    public int DocumentoRrhhid { get; set; }

    public int? TipoDocumentoId { get; set; }

    public long Numero { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime? Cerrado { get; set; }

    public string? Estado { get; set; }

    public int? UnidadId { get; set; }

    public string? UserName { get; set; }

    public virtual TipoDocumento? TipoDocumento { get; set; }
}
