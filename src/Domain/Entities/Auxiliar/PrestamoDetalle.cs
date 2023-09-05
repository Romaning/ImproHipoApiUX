using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class PrestamoDetalle
{
    public int PrestamoDetalleId { get; set; }

    public int PrestamoId { get; set; }

    public decimal Monto { get; set; }

    public decimal Debe { get; set; }

    public decimal Haber { get; set; }

    public decimal Interes { get; set; }

    public DateTime FechaPago { get; set; }

    public virtual Prestamo Prestamo { get; set; } = null!;
}
