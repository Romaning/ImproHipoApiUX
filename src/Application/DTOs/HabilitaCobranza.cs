using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class HabilitaCobranza
{
    public int HabilitaCobranzaId { get; set; }

    public int Estado { get; set; }

    public int UnidadId { get; set; }

    public DateTime Fecha { get; set; }
}
