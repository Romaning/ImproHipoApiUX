using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Ufv
{
    public int UfvId { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? Valor { get; set; }

    public int Estado { get; set; }

    public string? Responsable { get; set; }

    public virtual ICollection<Planilla> Planillas { get; set; } = new List<Planilla>();
}
