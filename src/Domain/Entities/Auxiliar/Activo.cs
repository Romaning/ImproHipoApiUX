using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class Activo
{
    public int ActivoId { get; set; }

    public DateTime FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public string? Codigo { get; set; }

    public string? Foto { get; set; }

    public string? Descripcion { get; set; }

    public decimal Cantidad { get; set; }

    public int UnidadProductoId { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Costo { get; set; }

    public int ProveedorId { get; set; }

    public int EmpresaId { get; set; }

    public int AreaId { get; set; }

    public int EmpleadoId { get; set; }

    public int ComprobanteActivoId { get; set; }

    public string? Observacion { get; set; }

    public int ClasificacionActivoId { get; set; }

    public string? Usuario { get; set; }

    public int TipoActivoId { get; set; }

    public DateTime? FechaIncorporacion { get; set; }

    public int TipoDetalleActivoId { get; set; }

    public virtual ICollection<AlmacenActivo> AlmacenActivos { get; set; } = new List<AlmacenActivo>();

    public virtual Area Area { get; set; } = null!;

    public virtual ClasificacionActivo ClasificacionActivo { get; set; } = null!;

    public virtual ComprobanteActivo ComprobanteActivo { get; set; } = null!;

    public virtual ICollection<DeprecActDetalleActivo> DeprecActDetalleActivos { get; set; } = new List<DeprecActDetalleActivo>();

    public virtual ICollection<DetalleActivo> DetalleActivos { get; set; } = new List<DetalleActivo>();

    public virtual Empresa Empresa { get; set; } = null!;

    public virtual Proveedor Proveedor { get; set; } = null!;

    public virtual TipoActivo TipoActivo { get; set; } = null!;

    public virtual UnidadProducto UnidadProducto { get; set; } = null!;
}
