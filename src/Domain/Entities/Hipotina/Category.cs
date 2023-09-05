using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Domain.Entities.Common;

namespace Domain.Entities.Hipotina;

public partial class Category : CategoryBase
{
    //public int CategoryId { get; set; }

    //public string? Descripcion { get; set; }

    //public string? DescripcionCorta { get; set; }

    //public string? Codificacion { get; set; }

    //public int Estado { get; set; }

    //public int? Valor { get; set; }

    //public int? Util { get; set; }
    [JsonIgnore]
    public virtual ICollection<Prod> Prods { get; set; } = new List<Prod>();
}
