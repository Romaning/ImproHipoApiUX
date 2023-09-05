using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class TipoDocumentoActivo
{
    public int TipoDocumentoActivoId { get; set; }

    public int? ClaseDocumentoActivoId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public virtual ClaseDocumentoActivo? ClaseDocumentoActivo { get; set; }

    public virtual ICollection<DocumentoActivo> DocumentoActivos { get; set; } = new List<DocumentoActivo>();

    public virtual ICollection<NumeroDocumentoActivo> NumeroDocumentoActivos { get; set; } = new List<NumeroDocumentoActivo>();
}
