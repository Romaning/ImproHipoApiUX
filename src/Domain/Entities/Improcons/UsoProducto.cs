using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class UsoProducto
{
    public int UsoProductoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? DescripcionCorta { get; set; }

    public virtual ICollection<AjusteDetalle> AjusteDetalles { get; set; } = new List<AjusteDetalle>();

    public virtual ICollection<AlmacenProducto> AlmacenProductos { get; set; } = new List<AlmacenProducto>();

    public virtual ICollection<AltaDetalleActivo> AltaDetalleActivos { get; set; } = new List<AltaDetalleActivo>();

    public virtual ICollection<AltaDetalle> AltaDetalles { get; set; } = new List<AltaDetalle>();

    public virtual ICollection<BajaDetalleActivo> BajaDetalleActivos { get; set; } = new List<BajaDetalleActivo>();

    public virtual ICollection<BajaDetalle> BajaDetalles { get; set; } = new List<BajaDetalle>();

    public virtual ICollection<IngresoDetalle> IngresoDetalles { get; set; } = new List<IngresoDetalle>();

    public virtual ICollection<IngresoInicialDetalle> IngresoInicialDetalles { get; set; } = new List<IngresoInicialDetalle>();

    public virtual ICollection<MovimientoDetalle> MovimientoDetalles { get; set; } = new List<MovimientoDetalle>();

    public virtual ICollection<PedidoLocalDetalle> PedidoLocalDetalles { get; set; } = new List<PedidoLocalDetalle>();

    public virtual ICollection<TraspasoActivo> TraspasoActivos { get; set; } = new List<TraspasoActivo>();

    public virtual ICollection<TraspasoProducto> TraspasoProductos { get; set; } = new List<TraspasoProducto>();
}
