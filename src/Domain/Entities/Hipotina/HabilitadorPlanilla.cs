using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class HabilitadorPlanilla
{
    public int HabilitadorPlanillaId { get; set; }

    public int Inicial { get; set; }

    public int Final { get; set; }

    public DateTime FechaIni { get; set; }

    public DateTime FechaFin { get; set; }

    public int Unidad { get; set; }
}
