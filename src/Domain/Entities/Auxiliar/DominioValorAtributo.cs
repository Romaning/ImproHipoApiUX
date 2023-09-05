using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class DominioValorAtributo
{
    public int DominioValorAtributoId { get; set; }

    public int? AtributoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? DescripcionCorta { get; set; }

    public virtual Atributo? Atributo { get; set; }

    public virtual ICollection<AtributoProducto> AtributoProductos { get; set; } = new List<AtributoProducto>();
}
