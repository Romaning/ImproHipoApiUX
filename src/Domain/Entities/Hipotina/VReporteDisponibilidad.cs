using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class VReporteDisponibilidad
{
    public int Codigo { get; set; }

    public string? Descripcion { get; set; }

    public int EstadoProductoId { get; set; }

    public string DescripcionEstadoProducto { get; set; } = null!;

    public decimal? Disponibilidad { get; set; }

    public decimal? Entregas { get; set; }

    public decimal? Traspasos { get; set; }

    public decimal Total { get; set; }

    public string? NombreUnidad { get; set; }

    public string NombreAlmacen { get; set; } = null!;

    public int UnidadId { get; set; }

    public int AlmacenId { get; set; }

    public int TypeProdId { get; set; }

    public int? CategoryId { get; set; }

    public int? MarkId { get; set; }
}
