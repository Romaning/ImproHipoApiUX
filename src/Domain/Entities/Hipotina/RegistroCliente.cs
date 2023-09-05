using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class RegistroCliente
{
    public int RegistroClienteId { get; set; }

    public int ClienteId { get; set; }

    public string? AplicationUsersId { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public int? Estado { get; set; }

    public string? AspNetUsersId { get; set; }

    public virtual AspNetUser? AspNetUsers { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;
}
