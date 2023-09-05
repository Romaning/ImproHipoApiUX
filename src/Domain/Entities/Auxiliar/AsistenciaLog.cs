using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class AsistenciaLog
{
    public int AsistenciaLogId { get; set; }

    public int AsistenciaId { get; set; }

    public DateTime? Fecha { get; set; }

    public TimeSpan? HoraIngreso1 { get; set; }

    public TimeSpan? HoraSalida1 { get; set; }

    public TimeSpan? HoraIngreso2 { get; set; }

    public TimeSpan? HoraSalida2 { get; set; }

    public TimeSpan? HoraIngreso3 { get; set; }

    public TimeSpan? HoraSalida3 { get; set; }

    public int? Retraso1 { get; set; }

    public int? Retraso2 { get; set; }

    public int? Retraso3 { get; set; }

    public int HorarioId { get; set; }

    public int? EmpleadoBiometricoId { get; set; }

    public DateTime FechaLog { get; set; }

    public string? Accion { get; set; }

    public string? UserName { get; set; }
}
