using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class TraspasoNegociacionActivo
{
    public int TraspasoNegociacionActivoId { get; set; }

    public int DespachanteActivoId { get; set; }

    public int Secuencia { get; set; }

    public string? Estado { get; set; }

    public DateTime Fecha { get; set; }

    public string? Obs { get; set; }

    public bool Vigente { get; set; }

    public virtual DespachanteActivo DespachanteActivo { get; set; } = null!;

    public virtual ICollection<TraspasoActivo> TraspasoActivos { get; set; } = new List<TraspasoActivo>();
}
