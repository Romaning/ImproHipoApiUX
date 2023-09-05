using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class DocumentoActivo
{
    public int DocumentoActivoId { get; set; }

    public int? TipoDocumentoActivoId { get; set; }

    public long Numero { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime? Cerrado { get; set; }

    public string? Estado { get; set; }

    public int? UnidadId { get; set; }

    public string? UserName { get; set; }

    public virtual ICollection<AltaActivo> AltaActivos { get; set; } = new List<AltaActivo>();

    public virtual ICollection<BajaActivo> BajaActivos { get; set; } = new List<BajaActivo>();

    public virtual ICollection<MovimientoActivo> MovimientoActivos { get; set; } = new List<MovimientoActivo>();

    public virtual ICollection<SolicitudTraspasoActivo> SolicitudTraspasoActivos { get; set; } = new List<SolicitudTraspasoActivo>();

    public virtual TipoDocumentoActivo? TipoDocumentoActivo { get; set; }
}
