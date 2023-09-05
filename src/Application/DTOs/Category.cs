using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public string? Codificacion { get; set; }

    public int Estado { get; set; }

    public int? Valor { get; set; }

    public int? Util { get; set; }

    public virtual ICollection<Prod> Prods { get; set; } = new List<Prod>();
}
