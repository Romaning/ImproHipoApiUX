using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class Ingreso
{
    public int IngresoId { get; set; }

    public int DocumentoId { get; set; }

    public int AlmacenId { get; set; }

    public int? MonedaId { get; set; }

    public int ProveedorId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaEstado { get; set; }

    public int Estado { get; set; }

    public string? Observaciones { get; set; }

    public string? Pedido { get; set; }

    public string? FacturaComercial { get; set; }

    public int UnidadId { get; set; }

    public int Finalizado { get; set; }

    public int Impreso { get; set; }

    public int? RequerimientoPedidoId { get; set; }

    public virtual Almacen Almacen { get; set; } = null!;

    public virtual ICollection<IngresoDetalle> IngresoDetalles { get; set; } = new List<IngresoDetalle>();

    public virtual Proveedor Proveedor { get; set; } = null!;

    public virtual RequerimientoPedido? RequerimientoPedido { get; set; }
}
