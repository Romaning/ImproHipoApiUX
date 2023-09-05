using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class EstructuraPersonalLog
{
    public int EstructuraPersonalLogId { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Usuario { get; set; }

    public string? Correo { get; set; }

    public int? EstructuraPersonalId { get; set; }

    public int? EmpleadoIdOld { get; set; }

    public DateTime? FechaInicioOld { get; set; }

    public DateTime? FechaFinOld { get; set; }

    public int? EmpresaIdOld { get; set; }

    public int? UnidadIdOld { get; set; }

    public int? TipoMovimientoPersonalIdOld { get; set; }

    public int? AreaIdOld { get; set; }

    public string? SalidaOld { get; set; }

    public decimal? HaberBasicoOld { get; set; }

    public int? TipoCargoIdOld { get; set; }

    public int? EmpleadoIdNew { get; set; }

    public DateTime? FechaInicioNew { get; set; }

    public DateTime? FechaFinNew { get; set; }

    public int? EmpresaIdNew { get; set; }

    public int? UnidadIdNew { get; set; }

    public int? TipoMovimientoPersonalIdNew { get; set; }

    public int? AreaIdNew { get; set; }

    public string? SalidaNew { get; set; }

    public decimal? HaberBasicoNew { get; set; }

    public int? TipoCargoIdNew { get; set; }
}
