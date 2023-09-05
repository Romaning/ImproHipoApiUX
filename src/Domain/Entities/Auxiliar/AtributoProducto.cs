using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class AtributoProducto
{
    public int AtributoProductoId { get; set; }

    public int ProductoId { get; set; }

    public int? DominioValorAtributoId { get; set; }

    public int? AtributoId { get; set; }

    public string? Valor { get; set; }

    public virtual Atributo? Atributo { get; set; }

    public virtual DominioValorAtributo? DominioValorAtributo { get; set; }

    public virtual Producto Producto { get; set; } = null!;
}
