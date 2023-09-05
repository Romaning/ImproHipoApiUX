using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class PuntoVentum
{
    public int PuntoVentaId { get; set; }

    public int UnidadId { get; set; }

    public int NumeroPuntoPenta { get; set; }

    public int Estado { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string? UserName { get; set; }
}
