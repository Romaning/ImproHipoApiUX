using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class FaltasLog
{
    public int FaltasLogId { get; set; }

    public int EmpleadoId { get; set; }

    public string? Leyenda { get; set; }

    public string? Apellidos { get; set; }

    public string? Nombres { get; set; }

    public float Permisos { get; set; }

    public float Faltas { get; set; }

    public int Atrasos { get; set; }

    public int UnidadId { get; set; }

    public string? UnidadNombre { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public string? Usuario { get; set; }

    public DateTime FechaLog { get; set; }
}
