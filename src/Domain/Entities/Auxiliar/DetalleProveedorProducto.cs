using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class DetalleProveedorProducto
{
    public int DetalleProveedorProductoId { get; set; }

    public int ProveedorProductoId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public string? Valor { get; set; }

    public int Estado { get; set; }

    public virtual ProveedorProducto ProveedorProducto { get; set; } = null!;
}
