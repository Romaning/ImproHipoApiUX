using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class SancionDetalle
{
    public int SancionDetalleId { get; set; }

    public int SancionId { get; set; }

    public decimal Monto { get; set; }

    public decimal Debe { get; set; }

    public decimal Haber { get; set; }

    public decimal Interes { get; set; }

    public DateTime FechaPago { get; set; }

    public virtual Sancion Sancion { get; set; } = null!;
}
