using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class Transporte
{
    public int TransporteId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Placa { get; set; } = null!;

    public decimal Cubicaje { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Conductor> Conductors { get; set; } = new List<Conductor>();
}
