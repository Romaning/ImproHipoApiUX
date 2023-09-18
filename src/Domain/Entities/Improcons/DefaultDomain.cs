using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Domain.Entities.Common;

namespace Domain.Entities.Improcons;

public partial class DefaultDomain : DefaultDomainBase
{
    //public int DefaultDomainId { get; set; }

    //public int TypeProdId { get; set; }

    //public string? Descripcion { get; set; }

    //public int Tipo { get; set; }

    //public int NivelDiferenciador { get; set; }

    //public int? Util { get; set; }

    //public int Estado { get; set; }

    //public int Grafico { get; set; }
    [JsonIgnore]
    public virtual ICollection<DefaultAttrib> DefaultAttribs { get; set; } = new List<DefaultAttrib>();
}
