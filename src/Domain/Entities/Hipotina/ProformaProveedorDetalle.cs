using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class ProformaProveedorDetalle
{
    public int ProformaProveedorDetalleId { get; set; }

    public string? Descripcion { get; set; }

    public string? Observaciones { get; set; }

    public int ProformaProveedorId { get; set; }
}
