using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class EquipamientoDetalle
{
    public int EquipamientoDetalleId { get; set; }

    public int ProdId { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string? Observaciones { get; set; }

    public int EquipamientoId { get; set; }

    public decimal Cantidad { get; set; }

    public virtual Equipamiento Equipamiento { get; set; } = null!;
}
