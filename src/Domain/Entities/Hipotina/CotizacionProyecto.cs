using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class CotizacionProyecto
{
    public int CotizacionProyectoId { get; set; }

    public int ProyectoId { get; set; }

    public int CotizacionId { get; set; }

    public int Estado { get; set; }

    public virtual Cotizacion Cotizacion { get; set; } = null!;

    public virtual Proyecto Proyecto { get; set; } = null!;
}
