using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class ClaseDocumento
{
    public int ClaseDocumentoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? DescripcionCorta { get; set; }

    public virtual ICollection<TipoDocumento> TipoDocumentos { get; set; } = new List<TipoDocumento>();
}
