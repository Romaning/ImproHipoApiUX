using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class ProveedorProducto
{
    public int ProveedorProductoId { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? Imagen { get; set; }

    public int ProveedorId { get; set; }

    public int Estado { get; set; }

    public string? Modelo { get; set; }

    public int MarkId { get; set; }

    public string? ImagenTecnica { get; set; }

    public string? ImagenVolumen { get; set; }

    public virtual ICollection<DetalleProveedorProducto> DetalleProveedorProductos { get; set; } = new List<DetalleProveedorProducto>();

    public virtual Proveedor Proveedor { get; set; } = null!;

    public virtual ICollection<ProveedorProdRel> ProveedorProdRels { get; set; } = new List<ProveedorProdRel>();

    public virtual ICollection<ProveedorProductoProd> ProveedorProductoProds { get; set; } = new List<ProveedorProductoProd>();
}
