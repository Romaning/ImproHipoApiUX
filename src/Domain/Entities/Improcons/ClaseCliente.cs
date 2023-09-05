using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class ClaseCliente
{
    public int ClaseClienteId { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? Tipo { get; set; }

    public int? Valor { get; set; }

    public virtual ICollection<TipoCliente> TipoClientes { get; set; } = new List<TipoCliente>();
}
