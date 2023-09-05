using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Movimiento
{
    public int MovimientoId { get; set; }

    public int? DocumentoId { get; set; }

    public int AlmacenId { get; set; }

    public int? DocumentoAutorizacionId { get; set; }

    public int MonedaId { get; set; }

    public int TipoMovimientoId { get; set; }

    public int? RelacionMovimientoId { get; set; }

    public DateTime FechaPendiente { get; set; }

    public bool Regular { get; set; }

    public string Operacion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime? FechaCambioManual { get; set; }

    public DateTime? Fecha { get; set; }

    public DateTime? FechaAnulacion { get; set; }

    public string? RazonAnulacion { get; set; }

    public int? FacturaId { get; set; }

    public string? UserName { get; set; }

    public virtual Almacen Almacen { get; set; } = null!;

    public virtual Documento? Documento { get; set; }

    public virtual Documento? DocumentoAutorizacion { get; set; }

    public virtual ICollection<Movimiento> InverseRelacionMovimiento { get; set; } = new List<Movimiento>();

    public virtual Monedum Moneda { get; set; } = null!;

    public virtual ICollection<MovimientoDetalle> MovimientoDetalles { get; set; } = new List<MovimientoDetalle>();

    public virtual Movimiento? RelacionMovimiento { get; set; }

    public virtual TipoMovimiento TipoMovimiento { get; set; } = null!;
}
