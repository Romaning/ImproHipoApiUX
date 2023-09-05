using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class TipoDocImportacion
{
    public int TipoDocImportacionId { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<CostoImportacion> CostoImportacions { get; set; } = new List<CostoImportacion>();
}
