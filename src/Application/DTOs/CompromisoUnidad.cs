using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class CompromisoUnidad
{
    public int CompromisoUnidadId { get; set; }

    public DateTime? Fecha { get; set; }

    public int? CompromisoVentasId { get; set; }

    public int? UnidadId { get; set; }

    public int? Estado { get; set; }

    public virtual ICollection<CompromisoProd> CompromisoProds { get; set; } = new List<CompromisoProd>();

    public virtual CompromisoVenta? CompromisoVentas { get; set; }
}
