using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class ProformaProveedorItem
{
    public int ProformaProveedorItemsId { get; set; }

    public int? ProdId { get; set; }

    public int? ProductoProveedorId { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? CantidadPropuestaPedido { get; set; }

    public decimal? CantidadPropuestaFinal { get; set; }

    public int? ProformaProveedorId { get; set; }

    public int? Util { get; set; }

    public decimal? Pendiente { get; set; }

    public decimal? Uso { get; set; }

    public decimal? TotalExistencias { get; set; }

    public decimal? UltimoPedido { get; set; }

    public decimal? AlmacenProveedor { get; set; }

    public decimal? VentasNacional { get; set; }

    public decimal? CompromisoNacional { get; set; }

    public string? Estado { get; set; }

    public decimal UltimaProforma { get; set; }

    public virtual ProformaProveedor? ProformaProveedor { get; set; }
}
