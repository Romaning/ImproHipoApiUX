using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class Ajuste
{
    public int AjusteId { get; set; }

    public int DocumentoId { get; set; }

    public int AlmacenId { get; set; }

    public int? MonedaId { get; set; }

    public DateTime FechaEstado { get; set; }

    public string? Observaciones { get; set; }

    public string Estado { get; set; } = null!;

    public int TipoAjusteId { get; set; }

    public decimal TotalA { get; set; }

    public decimal TotalB { get; set; }

    public virtual ICollection<AjusteDetalle> AjusteDetalles { get; set; } = new List<AjusteDetalle>();

    public virtual Almacen Almacen { get; set; } = null!;

    public virtual Documento Documento { get; set; } = null!;

    public virtual Monedum? Moneda { get; set; }
}
