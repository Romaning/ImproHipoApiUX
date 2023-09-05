using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class BloqueoInventario
{
    public int BloqueoInventarioId { get; set; }

    public int UnidadId { get; set; }

    public int AlmacenId { get; set; }

    public int MarkId { get; set; }

    public DateTime Fecha { get; set; }

    public string? Descripcion { get; set; }

    public int Estado { get; set; }
}
