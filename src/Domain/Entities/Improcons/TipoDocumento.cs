using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class TipoDocumento
{
    public int TipoDocumentoId { get; set; }

    public int? ClaseDocumentoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string DescripcionCorta { get; set; } = null!;

    public virtual ClaseDocumento? ClaseDocumento { get; set; }

    public virtual ICollection<DocumentoRrhh> DocumentoRrhhs { get; set; } = new List<DocumentoRrhh>();

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual ICollection<NumeroDocumento> NumeroDocumentos { get; set; } = new List<NumeroDocumento>();
}
