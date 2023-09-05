using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class FechaEspecial
{
    public int FechaEspecialId { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Motivo { get; set; }

    public int? TipoFechaEspecialId { get; set; }

    public int? UnidadId { get; set; }

    public TimeSpan? HoraIngreso { get; set; }

    public TimeSpan? HoraSalida { get; set; }

    public string? Responsable { get; set; }

    public int Estado { get; set; }

    public virtual TipoFechaEspecial? TipoFechaEspecial { get; set; }

    public virtual Unidad? Unidad { get; set; }
}
