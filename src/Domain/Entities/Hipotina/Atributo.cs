using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class Atributo
{
    public int AtributoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? DescripcionCorta { get; set; }

    public string? Tipo { get; set; }

    public virtual ICollection<AtributoProducto> AtributoProductos { get; set; } = new List<AtributoProducto>();

    public virtual ICollection<DominioValorAtributo> DominioValorAtributos { get; set; } = new List<DominioValorAtributo>();
}
