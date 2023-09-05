using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class ClaseDocumentoActivo
{
    public int ClaseDocumentoActivoId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public virtual ICollection<TipoDocumentoActivo> TipoDocumentoActivos { get; set; } = new List<TipoDocumentoActivo>();
}
