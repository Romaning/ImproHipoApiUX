using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Parametro
{
    public int ParametroId { get; set; }

    public string? Gestion { get; set; }

    public DateTime? InicioGest { get; set; }

    public DateTime? FinGest { get; set; }

    public int Moneda { get; set; }

    public decimal TipoCambio { get; set; }

    public int Estado { get; set; }

    public int Util { get; set; }
}
