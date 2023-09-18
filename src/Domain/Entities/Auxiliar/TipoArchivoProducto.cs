using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Domain.Entities.Common;

namespace Domain.Entities.Auxiliar;

public partial class TipoArchivoProducto : TipoArchivoProductoBase
{
    //public int TipoArchivoProductoId { get; set; }

    //public string? Nombre { get; set; }

    //public string? Descripcion { get; set; }
    [JsonIgnore]
    public virtual ICollection<ArchivosProducto> ArchivosProductos { get; set; } = new List<ArchivosProducto>();
}
