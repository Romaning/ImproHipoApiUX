using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class DetalleSolicitudVendedor
{
    public int DetalleSolicitudVendedorId { get; set; }

    public int? ProdId { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Observaciones { get; set; }

    public int? Estado { get; set; }

    public int? CompromisoVentasId { get; set; }

    public int? SolicitudVendedorId { get; set; }

    public int? ProveedorProductoId { get; set; }

    public virtual SolicitudVendedor? SolicitudVendedor { get; set; }
}
