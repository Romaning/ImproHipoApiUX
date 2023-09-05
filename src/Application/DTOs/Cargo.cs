using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Cargo
{
    public int CargoId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<TipoCargo> TipoCargos { get; set; } = new List<TipoCargo>();
}
