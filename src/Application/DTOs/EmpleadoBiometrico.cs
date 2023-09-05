using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class EmpleadoBiometrico
{
    public int EmpleadoBiometricoId { get; set; }

    public string? Activo { get; set; }

    public DateTime? Fecha { get; set; }

    public int? BiometricoId { get; set; }

    public int? EmpleadoId { get; set; }

    public TimeSpan? Hora { get; set; }

    public int? TipoMarcacion { get; set; }

    public int? ModoVerificacion { get; set; }

    public int? UnidadId { get; set; }

    public virtual ICollection<Asistencium> Asistencia { get; set; } = new List<Asistencium>();

    public virtual Biometrico? Biometrico { get; set; }

    public virtual Empleado? Empleado { get; set; }
}
