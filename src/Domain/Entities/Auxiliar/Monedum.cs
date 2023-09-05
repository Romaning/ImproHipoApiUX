using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class Monedum
{
    public int MonedaId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? DescripcionCorta { get; set; }

    public virtual ICollection<Ajuste> Ajustes { get; set; } = new List<Ajuste>();

    public virtual ICollection<AlmacenProducto> AlmacenProductos { get; set; } = new List<AlmacenProducto>();

    public virtual ICollection<Altum> Alta { get; set; } = new List<Altum>();

    public virtual ICollection<Baja> Bajas { get; set; } = new List<Baja>();

    public virtual ICollection<ComprobanteActivo> ComprobanteActivos { get; set; } = new List<ComprobanteActivo>();

    public virtual ICollection<DeprecActActivo> DeprecActActivos { get; set; } = new List<DeprecActActivo>();

    public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();
}
