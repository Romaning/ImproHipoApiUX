using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class TipoEmpresa
{
    public int TipoEmpresaId { get; set; }

    public string? Descripcion { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();
}
