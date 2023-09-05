using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class AreaAux
{
    public int AreaAuxId { get; set; }

    public string? Descripcion { get; set; }

    public int UnidadId { get; set; }

    public string? DescripcionCorta { get; set; }

    public int Estado { get; set; }
}
