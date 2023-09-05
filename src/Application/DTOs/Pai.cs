using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Pai
{
    public int PaisId { get; set; }

    public string? Nombre { get; set; }

    public string? NombreCorto { get; set; }

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();
}
