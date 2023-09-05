using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Prestamo
{
    public int PrestamoId { get; set; }

    public int EmpleadoId { get; set; }

    public decimal Monto { get; set; }

    public int Cuotas { get; set; }

    public string? Motivo { get; set; }

    public DateTime FechaI { get; set; }

    public DateTime FechaF { get; set; }

    public DateTime Fecha { get; set; }

    public int Estado { get; set; }

    public int Finalizado { get; set; }

    public string? Factura { get; set; }

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual ICollection<PrestamoDetalle> PrestamoDetalles { get; set; } = new List<PrestamoDetalle>();
}
