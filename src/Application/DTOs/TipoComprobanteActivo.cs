using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class TipoComprobanteActivo
{
    public int TipoComprobanteActivoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ComprobanteActivo> ComprobanteActivos { get; set; } = new List<ComprobanteActivo>();
}
