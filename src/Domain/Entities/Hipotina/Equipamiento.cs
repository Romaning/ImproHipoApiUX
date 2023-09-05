using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class Equipamiento
{
    public int EquipamientoId { get; set; }

    public string? Descripcion { get; set; }

    public int? TipoEquipamientoId { get; set; }

    public DateTime Fecha { get; set; }

    public virtual ICollection<EquipamientoDetalle> EquipamientoDetalles { get; set; } = new List<EquipamientoDetalle>();

    public virtual ICollection<EquipamientoProd> EquipamientoProds { get; set; } = new List<EquipamientoProd>();

    public virtual TipoEquipamiento? TipoEquipamiento { get; set; }
}
