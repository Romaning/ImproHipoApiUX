using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class DireccionCliente
{
    public int DireccionClienteId { get; set; }

    public int ClienteId { get; set; }

    public string? DireccionFiscal { get; set; }

    public string? Coordenadas { get; set; }

    public int Estado { get; set; }
}
