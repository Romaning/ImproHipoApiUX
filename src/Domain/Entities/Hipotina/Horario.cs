using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class Horario
{
    public int HorarioId { get; set; }

    public TimeSpan? HoraIngreso1 { get; set; }

    public TimeSpan? HoraSalida1 { get; set; }

    public TimeSpan? HoraIngreso2 { get; set; }

    public TimeSpan? HoraSalida2 { get; set; }

    public TimeSpan? HoraIngreso3 { get; set; }

    public TimeSpan? HoraSalida3 { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? EmpleadoId { get; set; }

    public string? Responsable { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<Asistencium> Asistencia { get; set; } = new List<Asistencium>();

    public virtual Empleado? Empleado { get; set; }
}
