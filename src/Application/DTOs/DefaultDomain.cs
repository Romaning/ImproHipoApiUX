using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class DefaultDomain
{
    public int DefaultDomainId { get; set; }

    public int TypeProdId { get; set; }

    public string? Descripcion { get; set; }

    public int Tipo { get; set; }

    public int NivelDiferenciador { get; set; }

    public int? Util { get; set; }

    public int Estado { get; set; }

    public int Grafico { get; set; }

    public virtual ICollection<DefaultAttrib> DefaultAttribs { get; set; } = new List<DefaultAttrib>();
}
