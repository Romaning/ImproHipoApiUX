using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class PlanillaAuxiliar
{
    public int PlanillaAuxiliarId { get; set; }

    public int PlanillaId { get; set; }

    public int EmpleadoId { get; set; }

    public string? Empleado { get; set; }

    public int EstructuraPersonalId { get; set; }

    public decimal OtrosBonos { get; set; }

    public decimal Comision { get; set; }

    public decimal Afp { get; set; }

    public decimal PorcentajeAfp { get; set; }

    public decimal TotalGanado { get; set; }

    public decimal Rciva { get; set; }

    public string? UnidadId { get; set; }

    public string? Ciudad { get; set; }

    public int Estado { get; set; }
}
