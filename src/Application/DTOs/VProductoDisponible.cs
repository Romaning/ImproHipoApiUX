using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class VProductoDisponible
{
    public int UnidadId { get; set; }

    public string NombreUnidad { get; set; } = null!;

    public int AlmacenId { get; set; }

    public string NombreAlmacen { get; set; } = null!;

    public int AlmacenProductoId { get; set; }

    public int Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    public decimal? Cantidad { get; set; }

    public int EstadoProductoId { get; set; }

    public string DescripcionEstadoProducto { get; set; } = null!;

    public int UsoProductoId { get; set; }

    public string DescripcionUsoProducto { get; set; } = null!;

    public int? FechaArrivo { get; set; }

    public string Disponible { get; set; } = null!;
}
