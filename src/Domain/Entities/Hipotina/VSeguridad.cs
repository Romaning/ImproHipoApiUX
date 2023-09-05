using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class VSeguridad
{
    public string IdUsuario { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public int IdModulo { get; set; }

    public string? NombreModulo { get; set; }

    public string? Unidad { get; set; }

    public string? Ambito { get; set; }

    public string? Operacion { get; set; }
}
