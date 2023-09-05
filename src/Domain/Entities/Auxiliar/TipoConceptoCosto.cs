using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class TipoConceptoCosto
{
    public int TipoConceptoCostoId { get; set; }

    public string? Descricpion { get; set; }

    public virtual ICollection<ConceptoCosto> ConceptoCostos { get; set; } = new List<ConceptoCosto>();
}
