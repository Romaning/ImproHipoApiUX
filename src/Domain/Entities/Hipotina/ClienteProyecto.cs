using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class ClienteProyecto
{
    public int ClienteProyectoId { get; set; }

    public int ClienteId { get; set; }

    public int ProyectoId { get; set; }

    public int Estado { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual Proyecto Proyecto { get; set; } = null!;
}
