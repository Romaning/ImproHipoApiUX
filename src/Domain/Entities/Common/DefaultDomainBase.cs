using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities.Common;

public  class DefaultDomainBase
{
    public int DefaultDomainId { get; set; }

    public int TypeProdId { get; set; }

    public string? Descripcion { get; set; }

    public int Tipo { get; set; }

    public int NivelDiferenciador { get; set; }

    public int? Util { get; set; }

    public int Estado { get; set; }

    public int Grafico { get; set; }
    [NotMapped]
    //[JsonIgnore]
    public virtual ICollection<DefaultAttribBase> DefaultAttribBases { get; set; } = new List<DefaultAttribBase>();
}
