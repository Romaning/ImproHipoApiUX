using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class ProfesionOficio
{
    public int ProfesionOficioId { get; set; }

    public string Profesion { get; set; } = null!;

    public int Estado { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
