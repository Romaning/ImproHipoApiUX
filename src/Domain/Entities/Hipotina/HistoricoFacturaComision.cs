using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class HistoricoFacturaComision
{
    public int HistoricoFacturaComisionId { get; set; }

    public int FacturaId { get; set; }

    public int UnidadId { get; set; }

    public DateTime FechaEmision { get; set; }

    public int Estado { get; set; }
}
