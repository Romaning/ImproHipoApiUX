using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class EscalaAntiguedad
{
    public int EscalaAntiguedadId { get; set; }

    public int? AntiguedadIni { get; set; }

    public int? AntiguedadFin { get; set; }

    public int? Porcentaje { get; set; }

    public int Estado { get; set; }

    public string? Responsable { get; set; }
}
