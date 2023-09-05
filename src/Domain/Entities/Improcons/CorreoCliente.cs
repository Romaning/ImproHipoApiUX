using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class CorreoCliente
{
    public int CorreoClienteId { get; set; }

    public int ClienteId { get; set; }

    public string? CorreoElectronico { get; set; }

    public int Activo { get; set; }
}
