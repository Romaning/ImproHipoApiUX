using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class EscalaVacacion
{
    public int EscalaVacacionId { get; set; }

    public int? AntiguedadInicial { get; set; }

    public int? AntiguedadFinal { get; set; }

    public int? Dias { get; set; }

    public string? Responsable { get; set; }

    public int Estado { get; set; }
}
