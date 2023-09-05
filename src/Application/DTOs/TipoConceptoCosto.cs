using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class TipoConceptoCosto
{
    public int TipoConceptoCostoId { get; set; }

    public string? Descricpion { get; set; }

    public virtual ICollection<ConceptoCosto> ConceptoCostos { get; set; } = new List<ConceptoCosto>();
}
