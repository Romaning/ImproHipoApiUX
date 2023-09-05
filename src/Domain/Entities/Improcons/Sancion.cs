using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Sancion
{
    public int SancionId { get; set; }

    public int EmpleadoId { get; set; }

    public decimal Dias { get; set; }

    public int Cuotas { get; set; }

    public string? Motivo { get; set; }

    public DateTime Fecha { get; set; }

    public int Estado { get; set; }

    public int Finalizado { get; set; }

    public decimal Monto { get; set; }

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual ICollection<SancionDetalle> SancionDetalles { get; set; } = new List<SancionDetalle>();
}
