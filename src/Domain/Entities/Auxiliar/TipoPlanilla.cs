using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class TipoPlanilla
{
    public int TipoPlanillaId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public virtual ICollection<Planilla> Planillas { get; set; } = new List<Planilla>();
}
