using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Permiso
{
    public int PermisoId { get; set; }

    public string? Fechas { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public string? Turno { get; set; }

    public int Estado { get; set; }

    public string? Haber { get; set; }

    public string? Observaciones { get; set; }

    public int? TipoPermisoId { get; set; }

    public int? EmpleadoId { get; set; }

    public TimeSpan? HoraInicio { get; set; }

    public TimeSpan? HoraFin { get; set; }

    public TimeSpan? TotalTiempo { get; set; }

    public string? Nota { get; set; }

    public string? Responsable { get; set; }

    public string? Clasificador { get; set; }

    public int? DocumentoRrhhid { get; set; }

    public string? IngresoSalida { get; set; }

    public virtual Empleado? Empleado { get; set; }

    public virtual TipoPermiso? TipoPermiso { get; set; }
}
