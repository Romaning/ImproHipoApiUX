using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Garante
{
    public int GaranteId { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public int Ci { get; set; }

    public string? Direccion { get; set; }

    public int? Telefono { get; set; }

    public int Celular { get; set; }

    public int EmpleadoId { get; set; }

    public int Estado { get; set; }

    public string? CoordenadaGeografica { get; set; }

    public virtual Empleado Empleado { get; set; } = null!;
}
