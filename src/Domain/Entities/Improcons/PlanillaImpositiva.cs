using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class PlanillaImpositiva
{
    public int PlanillaImpositivaId { get; set; }

    public int PlanillaId { get; set; }

    public int PlanillaDetalleId { get; set; }

    public decimal Tganado { get; set; }

    public decimal Sncomputable { get; set; }

    public decimal Dnimponible { get; set; }

    public decimal Dsimpuesto { get; set; }

    public decimal ImpuestoRciva { get; set; }

    public decimal FormularioDiez { get; set; }

    public decimal Smnal { get; set; }

    public decimal Fisco { get; set; }

    public decimal Dependiente { get; set; }

    public decimal SaldoAnterior { get; set; }

    public decimal Mvalor { get; set; }

    public decimal StfavDepen { get; set; }

    public decimal SaldoFavDepen { get; set; }

    public decimal Sutilizado { get; set; }

    public decimal ImpuestoRetenido { get; set; }

    public decimal SaldoFavMesSgte { get; set; }

    public decimal Retroactivo { get; set; }
}
