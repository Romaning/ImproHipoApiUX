using System;
using System.Collections.Generic;

namespace Domain.Entities.Common;

public class ColoreBase
{
    public int ColoresId { get; set; }

    public string? Descripcion { get; set; }

    public string? Valor { get; set; }

    public string? Imagen { get; set; }
}
