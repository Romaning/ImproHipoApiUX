using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Mark
{
    public int MarkId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public string? Codificacion { get; set; }

    public int Estado { get; set; }

    public int? Valor { get; set; }

    public int? Util { get; set; }

    public virtual ICollection<Prod> Prods { get; set; } = new List<Prod>();

    public virtual ICollection<ProveedorFabrica> ProveedorFabricas { get; set; } = new List<ProveedorFabrica>();

    public virtual ICollection<ProveedorNacional> ProveedorNacionals { get; set; } = new List<ProveedorNacional>();

    public virtual ICollection<ProveedorTrader> ProveedorTraders { get; set; } = new List<ProveedorTrader>();
}
