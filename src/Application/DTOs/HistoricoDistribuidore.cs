using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class HistoricoDistribuidore
{
    public int HistoricoDistribuidoresId { get; set; }

    public int ClienteId { get; set; }

    public int OldTipoClienteId { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? TotalCobranzas { get; set; }

    public int? NewTipoClienteId { get; set; }
}
