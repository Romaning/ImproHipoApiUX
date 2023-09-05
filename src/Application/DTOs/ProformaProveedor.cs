using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class ProformaProveedor
{
    public int ProformaProveedorId { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? Finalizado { get; set; }

    public int? Estado { get; set; }

    public int? Activo { get; set; }

    public int? CompromisoVentasId { get; set; }

    public int? ConcluidoProforma { get; set; }

    public int? AnalisisT { get; set; }

    public int? ProveedorId { get; set; }

    public int? ProformaRelacionId { get; set; }

    public virtual CompromisoVenta? CompromisoVentas { get; set; }

    public virtual ICollection<ProformaProveedorItem> ProformaProveedorItems { get; set; } = new List<ProformaProveedorItem>();
}
