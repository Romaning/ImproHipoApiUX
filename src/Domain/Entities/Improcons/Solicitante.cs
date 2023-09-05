using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Solicitante
{
    public int SolicitanteId { get; set; }

    public int SolicitudTraspasoId { get; set; }

    public int UnidadId { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime FechaEstado { get; set; }

    public string? Obs { get; set; }

    public int? AlmacenId { get; set; }

    public int? AlmacenDescargaId { get; set; }

    public virtual Almacen? Almacen { get; set; }

    public virtual Almacen? AlmacenDescarga { get; set; }

    public virtual ICollection<Despachante> Despachantes { get; set; } = new List<Despachante>();

    public virtual SolicitudTraspaso SolicitudTraspaso { get; set; } = null!;

    public virtual Unidad Unidad { get; set; } = null!;
}
