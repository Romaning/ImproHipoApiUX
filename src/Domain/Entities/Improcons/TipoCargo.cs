using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class TipoCargo
{
    public int TipoCargoId { get; set; }

    public string? Descripcion { get; set; }

    public decimal Sueldo1 { get; set; }

    public decimal Sueldo2 { get; set; }

    public int Estado { get; set; }

    public int CargoId { get; set; }

    public virtual Cargo Cargo { get; set; } = null!;

    public virtual ICollection<EstructuraPersonal> EstructuraPersonals { get; set; } = new List<EstructuraPersonal>();
}
