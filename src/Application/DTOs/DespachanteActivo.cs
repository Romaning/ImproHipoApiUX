using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class DespachanteActivo
{
    public int DespachanteActivoId { get; set; }

    public int SolicitanteActivoId { get; set; }

    public int UnidadId { get; set; }

    public string? Estado { get; set; }

    public DateTime FechaCambioEstado { get; set; }

    public DateTime? ConformidadS { get; set; }

    public DateTime? ConformidadD { get; set; }

    public int? AlmacenAfid { get; set; }

    public byte[]? RowVersion { get; set; }

    public int AreaId { get; set; }

    public int EmpleadoId { get; set; }

    public virtual SolicitanteActivo SolicitanteActivo { get; set; } = null!;

    public virtual ICollection<TraspasoNegociacionActivo> TraspasoNegociacionActivos { get; set; } = new List<TraspasoNegociacionActivo>();
}
