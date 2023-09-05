using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Producto
{
    public int ProductoId { get; set; }

    public int Codigo { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? DescripcionCorta { get; set; }

    public bool Comerciabilizable { get; set; }

    public bool Producible { get; set; }

    public bool Fraccionable { get; set; }

    public bool Exposicion { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public decimal? Volumen { get; set; }
}
