using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class PlanillaDetalle
{
    public int PlanillaDetalleId { get; set; }

    public decimal? HaberBasico { get; set; }

    public decimal? HaberMensual { get; set; }

    public decimal? BonoAntiguedad { get; set; }

    public decimal? BonoProduccion { get; set; }

    public decimal? OtrosBonos { get; set; }

    public decimal? Comision { get; set; }

    public decimal? Afp { get; set; }

    public decimal? Anticipo { get; set; }

    public decimal? Rciva { get; set; }

    public decimal? DescuentoFaltas { get; set; }

    public decimal? DescuentoRetrasos { get; set; }

    public decimal? DescuentoOtros { get; set; }

    public decimal? TotalGanado { get; set; }

    public decimal? TotalDescuentos { get; set; }

    public decimal? LiquidoPagable { get; set; }

    public decimal? TotalDiasTrabajados { get; set; }

    public decimal? TotalDiasVacacion { get; set; }

    public decimal? TotalPermisos { get; set; }

    public decimal? TotalFaltas { get; set; }

    public decimal? TotalRetrasos { get; set; }

    public int? EstructuraPersonalId { get; set; }

    public int? PlanillaId { get; set; }

    public decimal? PorcentajeAfp { get; set; }

    public decimal? DescuentoSancion { get; set; }

    public decimal? MontoRetrazo { get; set; }

    public virtual EstructuraPersonal? EstructuraPersonal { get; set; }

    public virtual Planilla? Planilla { get; set; }
}
