using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class TraspasoNegociacion
{
    public int TraspasoNegociacionId { get; set; }

    public int DespachanteId { get; set; }

    public int Secuencia { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string? Obs { get; set; }

    public bool Vigente { get; set; }

    public virtual Despachante Despachante { get; set; } = null!;

    public virtual ICollection<TraspasoProducto> TraspasoProductos { get; set; } = new List<TraspasoProducto>();
}
