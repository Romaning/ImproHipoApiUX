using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Domain.Entities.Common;

namespace Domain.Entities.Improcons;

public partial class ArchivosProducto : ArchivosProductoBase
{
    //public int ArchivosProductoId { get; set; }

    //public string? Nombre { get; set; }

    //public string? Descipcion { get; set; }

    //public string? Foto { get; set; }

    //public int TipoArchivoProductoId { get; set; }

    //public int ProdId { get; set; }

    public string? FotoTecnica { get; set; }

    public DateTime? FecModifTec { get; set; }

    public DateTime? FecModifImg { get; set; }

    public string? FotoVolumen { get; set; }

    public DateTime? FecModifImgVol { get; set; }
    [JsonIgnore]
    public virtual Prod Prod { get; set; } = null!;
    [JsonIgnore]
    public virtual TipoArchivoProducto TipoArchivoProducto { get; set; } = null!;
}
