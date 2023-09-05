using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Domain.Entities.Common;

namespace Domain.Entities.Improcons;

public partial class Mark : MarkBase
{
    //public int MarkId { get; set; }

    //public string? Descripcion { get; set; }

    //public string? DescripcionCorta { get; set; }

    //public string? Codificacion { get; set; }

    //public int Estado { get; set; }

    //public int? Valor { get; set; }

    //public int? Util { get; set; }
    [JsonIgnore]
    public virtual ICollection<Prod> Prods { get; set; } = new List<Prod>();
    [JsonIgnore]
    public virtual ICollection<ProveedorFabrica> ProveedorFabricas { get; set; } = new List<ProveedorFabrica>();
    [JsonIgnore]
    public virtual ICollection<ProveedorNacional> ProveedorNacionals { get; set; } = new List<ProveedorNacional>();
    [JsonIgnore]
    public virtual ICollection<ProveedorTrader> ProveedorTraders { get; set; } = new List<ProveedorTrader>();
}
