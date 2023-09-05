using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class ConceptoCosto
{
    public int ConceptoCostoId { get; set; }

    public string? Descripcion { get; set; }

    public int? TipoConceptoCostoId { get; set; }

    public virtual ICollection<CostoImportacion> CostoImportacions { get; set; } = new List<CostoImportacion>();

    public virtual TipoConceptoCosto? TipoConceptoCosto { get; set; }
}
