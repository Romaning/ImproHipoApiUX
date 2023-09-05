using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class RegistroMetaCliente
{
    public int RegistroMetaClienteId { get; set; }

    public int ClienteId { get; set; }

    public decimal MontoAnterior { get; set; }

    public decimal MontoActual { get; set; }

    public DateTime Fecha { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;
}
