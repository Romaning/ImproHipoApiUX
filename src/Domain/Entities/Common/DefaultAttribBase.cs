using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities.Common;

public class DefaultAttribBase
{
    public int DefaultAttribId { get; set; }

    public int DefaultDomainId { get; set; }

    public string? Descripcion { get; set; }

    public int Tipo { get; set; }

    public int Nivel { get; set; }

    public int? Orden { get; set; }

    public int? Util { get; set; }

    public int Estado { get; set; }

    public int DefaultDomain { get; set; }
    [NotMapped]
    [JsonIgnore]
    public virtual DefaultDomainBase DefaultDomainNavigationBase { get; set; } = null!;
    [NotMapped]
    [JsonIgnore]
    public virtual ICollection<DefaultValueBase> DefaultValueBases { get; set; } = new List<DefaultValueBase>();
}
