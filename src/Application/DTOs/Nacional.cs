using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Nacional
{
    public int NacionalId { get; set; }

    public string? Nombre { get; set; }

    public string? Nit { get; set; }

    public int? Estado { get; set; }

    public int? PaisId { get; set; }

    public string? PaginaWeb { get; set; }

    public string? Provee { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<ContactoNacional> ContactoNacionals { get; set; } = new List<ContactoNacional>();

    public virtual ICollection<DireccionNacional> DireccionNacionals { get; set; } = new List<DireccionNacional>();

    public virtual ICollection<ProveedorNacional> ProveedorNacionals { get; set; } = new List<ProveedorNacional>();
}
