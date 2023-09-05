using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Planilla
{
    public int PlanillaId { get; set; }

    public int? Gestion { get; set; }

    public int? Mes { get; set; }

    public int? UfvId { get; set; }

    public int? TipoPlanillaId { get; set; }

    public string? UnidadId { get; set; }

    public int Estado { get; set; }

    public string? Ciudad { get; set; }

    public decimal? SeguroPatronal { get; set; }

    public decimal? AfpPatronal { get; set; }

    public decimal? SolidarioPatronal { get; set; }

    public decimal? FonviPatronal { get; set; }

    public decimal? AfpPlanilla { get; set; }

    public decimal? UfvI { get; set; }

    public decimal? UfvF { get; set; }

    public int Impositivo { get; set; }

    public virtual ICollection<PlanillaDetalle> PlanillaDetalles { get; set; } = new List<PlanillaDetalle>();

    public virtual TipoPlanilla? TipoPlanilla { get; set; }

    public virtual Ufv? Ufv { get; set; }
}
