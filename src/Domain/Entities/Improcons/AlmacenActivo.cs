using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class AlmacenActivo
{
    public int AlmacenActivoId { get; set; }

    public int Codigo { get; set; }

    public int? MonedaId { get; set; }

    public int AlmacenAfid { get; set; }

    public int ActivoId { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Costo { get; set; }

    public int Estado { get; set; }

    public virtual Activo Activo { get; set; } = null!;

    public virtual AlmacenAf AlmacenAf { get; set; } = null!;

    public virtual ICollection<TraspasoActivoDet> TraspasoActivoDets { get; set; } = new List<TraspasoActivoDet>();
}
