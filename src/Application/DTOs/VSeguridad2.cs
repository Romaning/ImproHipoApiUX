using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class VSeguridad2
{
    public string IdUsuario { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public int IdModulo { get; set; }

    public string? NombreModulo { get; set; }

    public string? OpcionModulo { get; set; }

    public int UnidadId { get; set; }

    public string? NumberIp { get; set; }

    public string? NombreAmbito { get; set; }

    public string? TipoAmbito { get; set; }

    public int IdAmbito { get; set; }

    public string? Operacion { get; set; }
}
