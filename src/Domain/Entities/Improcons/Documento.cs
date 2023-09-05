using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Documento
{
    public int DocumentoId { get; set; }

    public int? TipoDocumentoId { get; set; }

    public long Numero { get; set; }

    public DateTime Fecha { get; set; }

    public DateTime? Cerrado { get; set; }

    public string? Estado { get; set; }

    public int? UnidadId { get; set; }

    public string? UserName { get; set; }

    public virtual ICollection<Ajuste> Ajustes { get; set; } = new List<Ajuste>();

    public virtual ICollection<Altum> Alta { get; set; } = new List<Altum>();

    public virtual ICollection<Baja> Bajas { get; set; } = new List<Baja>();

    public virtual ICollection<Movimiento> MovimientoDocumentoAutorizacions { get; set; } = new List<Movimiento>();

    public virtual ICollection<Movimiento> MovimientoDocumentos { get; set; } = new List<Movimiento>();

    public virtual ICollection<SolicitudTraspaso> SolicitudTraspasos { get; set; } = new List<SolicitudTraspaso>();

    public virtual TipoDocumento? TipoDocumento { get; set; }

    public virtual Unidad? Unidad { get; set; }
}
