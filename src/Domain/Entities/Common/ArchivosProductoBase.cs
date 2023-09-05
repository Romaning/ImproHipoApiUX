using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities.Common;

public  class ArchivosProductoBase
{
    public int ArchivosProductoId { get; set; }

    public string? Nombre { get; set; }

    public string? Descipcion { get; set; }

    public string? Foto { get; set; }

    public int TipoArchivoProductoId { get; set; }

    public int ProdId { get; set; }

    public string? FotoTecnica { get; set; }

    public string? FotoVolumen { get; set; }

    public DateTime? FecModifTec { get; set; }

    public DateTime? FecModifImg { get; set; }

    public DateTime? FecModifImgVol { get; set; }

    [NotMapped]
    [JsonIgnore]
    public virtual ProdBase ProdBase { get; set; } = null!;
    [NotMapped]
    [JsonIgnore]
    public virtual TipoArchivoProductoBase TipoArchivoProductoBase { get; set; } = null!;
}
