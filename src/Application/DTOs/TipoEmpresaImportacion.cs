using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class TipoEmpresaImportacion
{
    public int TipoEmpresaImportacionId { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<EmpresaImportacion> EmpresaImportacions { get; set; } = new List<EmpresaImportacion>();
}
