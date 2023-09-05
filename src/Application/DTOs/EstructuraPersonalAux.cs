using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class EstructuraPersonalAux
{
    public int EstructuraPersonalAuxId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public DateTime FechaProceso { get; set; }

    public DateTime? FechaCierre { get; set; }

    public string? Salida { get; set; }

    public string? Observaciones { get; set; }

    public int Estado { get; set; }

    public decimal? HaberBasico { get; set; }

    public int EmpresaId { get; set; }

    public int UnidadId { get; set; }

    public int EmpleadoId { get; set; }

    public int TipoMovimientoPersonalId { get; set; }

    public int TipoCargoId { get; set; }

    public int AreaId { get; set; }

    public string? CodigoSinempleado { get; set; }
}
