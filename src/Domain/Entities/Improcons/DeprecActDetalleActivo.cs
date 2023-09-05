using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class DeprecActDetalleActivo
{
    public int DeprecActDetalleActivoId { get; set; }

    public int ActivoId { get; set; }

    public int DeprecActActivoId { get; set; }

    public string? Descripcion { get; set; }

    public decimal? ValorOriginal { get; set; }

    public decimal? ValorNeto { get; set; }

    public decimal? ValorNetoActual { get; set; }

    public int? Gestion { get; set; }

    public int? Mes { get; set; }

    public decimal? Ufvinicial { get; set; }

    public decimal? Ufvfinal { get; set; }

    public decimal? Coeficiente { get; set; }

    public decimal? MesesVidaUtil { get; set; }

    public decimal? UnidadActualizacion { get; set; }

    public decimal? ValorActualizado { get; set; }

    public decimal? DepreciacionAcum { get; set; }

    public decimal? UnidadActualizacionDeprec { get; set; }

    public decimal? DepreciacionAcumActualizado { get; set; }

    public decimal? DepreciacionPeriodo { get; set; }

    public decimal? DepreciacionAcumTotal { get; set; }

    public decimal? MesesVidaUtilRestante { get; set; }

    public decimal? VarianteDperiodo { get; set; }

    public virtual Activo Activo { get; set; } = null!;

    public virtual DeprecActActivo DeprecActActivo { get; set; } = null!;
}
