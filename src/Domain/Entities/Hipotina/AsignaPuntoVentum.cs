using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class AsignaPuntoVentum
{
    public int AsignaPuntoVentaId { get; set; }

    public string? UserName { get; set; }

    public DateTime? Fecha { get; set; }

    public int NumeroPuntoVenta { get; set; }

    public int Estado { get; set; }

    public int UnidadId { get; set; }
}
