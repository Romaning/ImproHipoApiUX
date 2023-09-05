using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities.Common;

public class TipoArchivoProductoBase
{
    public int TipoArchivoProductoId { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }
    [NotMapped]
    [JsonIgnore]
    public virtual ICollection<ArchivosProductoBase> ArchivosProductosBases { get; set; } = new List<ArchivosProductoBase>();
}
