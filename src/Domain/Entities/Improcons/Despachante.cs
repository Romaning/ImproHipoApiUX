using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Despachante
{
    public int DespachanteId { get; set; }

    public int SolicitanteId { get; set; }

    public int UnidadId { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime FechaCambioEstado { get; set; }

    public DateTime? ConformidadS { get; set; }

    public DateTime? ConformidadD { get; set; }

    public int? AlmacenId { get; set; }

    public byte[] RowVersion { get; set; } = null!;

    public virtual Almacen? Almacen { get; set; }

    public virtual Solicitante Solicitante { get; set; } = null!;

    public virtual ICollection<TraspasoNegociacion> TraspasoNegociacions { get; set; } = new List<TraspasoNegociacion>();

    public virtual Unidad Unidad { get; set; } = null!;
}
