using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class CompromisoVenta
{
    public int CompromisoVentasId { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaVentaInicial { get; set; }

    public DateTime? FechaVentaFinal { get; set; }

    public DateTime? FechaAprobacion { get; set; }

    public int? Estado { get; set; }

    public DateTime? FechaReporteInicial { get; set; }

    public DateTime? FechaReporteFinal { get; set; }

    public int? MarkId { get; set; }

    public int? ProveedorId { get; set; }

    public int? Finalizado { get; set; }

    public string? Usuario { get; set; }

    public string? ProductosExcepciones { get; set; }

    public string? ProveedorExcepciones { get; set; }

    public int TipoEstadoId { get; set; }

    public int Enviado { get; set; }

    public int PrePedidoProveedor { get; set; }

    public virtual ICollection<CompromisoUnidad> CompromisoUnidads { get; set; } = new List<CompromisoUnidad>();

    public virtual ICollection<ProformaProveedor> ProformaProveedors { get; set; } = new List<ProformaProveedor>();
}
