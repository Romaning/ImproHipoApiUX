using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class ProformaProveedorDetalle
{
    public int ProformaProveedorDetalleId { get; set; }

    public string? Descripcion { get; set; }

    public string? Observaciones { get; set; }

    public int ProformaProveedorId { get; set; }
}
