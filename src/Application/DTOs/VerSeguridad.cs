using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class VerSeguridad
{
    public int VerSeguridadId { get; set; }

    public string? IdUsuario { get; set; }

    public string? NombreUsuario { get; set; }

    public int IdModulo { get; set; }

    public string? NombreModulo { get; set; }

    public string? Unidad { get; set; }

    public string? Ambito { get; set; }

    public string? Operacion { get; set; }
}
