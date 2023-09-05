using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class SolicitanteActivo
{
    public int SolicitanteActivoId { get; set; }

    public int SolicitudTraspasoActivoId { get; set; }

    public int UnidadId { get; set; }

    public string? Estado { get; set; }

    public DateTime FechaEstado { get; set; }

    public string? Obs { get; set; }

    public int? AlmacenDescargaId { get; set; }

    public int? AlmacenAfid { get; set; }

    public int AreaId { get; set; }

    public int EmpleadoId { get; set; }

    public virtual AlmacenAf? AlmacenAf { get; set; }

    public virtual ICollection<DespachanteActivo> DespachanteActivos { get; set; } = new List<DespachanteActivo>();

    public virtual SolicitudTraspasoActivo SolicitudTraspasoActivo { get; set; } = null!;

    public virtual Unidad Unidad { get; set; } = null!;
}
