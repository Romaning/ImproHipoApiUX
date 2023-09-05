using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class TipoArchivoProducto
{
    public int TipoArchivoProductoId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<ArchivosProducto> ArchivosProductos { get; set; } = new List<ArchivosProducto>();
}
