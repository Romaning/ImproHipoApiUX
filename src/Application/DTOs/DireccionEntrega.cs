using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class DireccionEntrega
{
    public int DireccionEntregaId { get; set; }

    public int ClienteId { get; set; }

    public string? CoordenadaGeografica { get; set; }

    public string Direccion { get; set; } = null!;

    public string Observaciones { get; set; } = null!;

    public int Estado { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;
}
