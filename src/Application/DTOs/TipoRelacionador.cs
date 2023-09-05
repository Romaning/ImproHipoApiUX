using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class TipoRelacionador
{
    public int TipoRelacionadorId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Relacionador> Relacionadors { get; set; } = new List<Relacionador>();
}
