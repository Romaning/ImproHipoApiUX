using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class AlmacenProducto
{
    public int AlmacenProductoId { get; set; }

    public int EstadoProductoId { get; set; }

    public int MonedaId { get; set; }

    public int AlmacenId { get; set; }

    public int Codigo { get; set; }

    public decimal Cantidad { get; set; }

    public decimal? Costo { get; set; }

    public int UsoProductoId { get; set; }

    public virtual ICollection<AjusteDetalle> AjusteDetalles { get; set; } = new List<AjusteDetalle>();

    public virtual Almacen Almacen { get; set; } = null!;

    public virtual ICollection<BajaDetalle> BajaDetalles { get; set; } = new List<BajaDetalle>();

    public virtual EstadoProducto EstadoProducto { get; set; } = null!;

    public virtual Monedum Moneda { get; set; } = null!;

    public virtual ICollection<TraspasoProductoDet> TraspasoProductoDets { get; set; } = new List<TraspasoProductoDet>();

    public virtual UsoProducto UsoProducto { get; set; } = null!;
}
