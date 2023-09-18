using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities.Common;

public /*partial*/ class MarkBase
{
    public int MarkId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public string? Codificacion { get; set; }

    public int Estado { get; set; }

    public int? Valor { get; set; }

    public int? Util { get; set; }

    [NotMapped]
    //[JsonIgnore]
    public virtual ICollection<ProdBase> ProdBases { get; set; } = new List<ProdBase>();

    //public virtual ICollection<ProveedorFabrica> ProveedorFabricas { get; set; } = new List<ProveedorFabrica>();

    //public virtual ICollection<ProveedorNacional> ProveedorNacionals { get; set; } = new List<ProveedorNacional>();

    //public virtual ICollection<ProveedorTrader> ProveedorTraders { get; set; } = new List<ProveedorTrader>();
}
