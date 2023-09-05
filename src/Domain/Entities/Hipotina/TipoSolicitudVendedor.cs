using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class TipoSolicitudVendedor
{
    public int TipoSolicitudVendedorId { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<SolicitudVendedor> SolicitudVendedors { get; set; } = new List<SolicitudVendedor>();
}
