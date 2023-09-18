using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities.Common;

public /*partial*/ class CategoryBase
{
    public int CategoryId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public string? Codificacion { get; set; }

    public int Estado { get; set; }

    public int? Valor { get; set; }

    public int? Util { get; set; }

    [NotMapped]
    //[JsonIgnore]

    public virtual ICollection<ProdBase> ProdBases { get; set; } = new List<ProdBase>();
}
