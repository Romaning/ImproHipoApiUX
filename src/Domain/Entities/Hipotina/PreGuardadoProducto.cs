using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class PreGuardadoProducto
{
    public int PreGuardadoProductoId { get; set; }

    public int? ProdId { get; set; }

    public int? ClassProdId { get; set; }

    public int? TypeProdId { get; set; }

    public int? CategoryId { get; set; }

    public int? MarkId { get; set; }

    public decimal? Precio { get; set; }

    public int? DefaultDomainId1 { get; set; }

    public string? Descripcion1 { get; set; }

    public int? Orden1 { get; set; }

    public int? DefaultDomainId2 { get; set; }

    public string? Descripcion2 { get; set; }

    public int? Orden2 { get; set; }

    public int? DefaultDomainId3 { get; set; }

    public string? Descripcion3 { get; set; }

    public int? Orden3 { get; set; }

    public int? DefaultDomainId4 { get; set; }

    public string? Descripcion4 { get; set; }

    public int? Orden4 { get; set; }

    public int? DefaultDomainId5 { get; set; }

    public string? Descripcion5 { get; set; }

    public int? Orden5 { get; set; }

    public int? DefaultDomainId6 { get; set; }

    public string? Descripcion6 { get; set; }

    public int? Orden6 { get; set; }

    public int? DefaultDomainId7 { get; set; }

    public string? Descripcion7 { get; set; }

    public int? Orden7 { get; set; }

    public int? DefaultDomainId8 { get; set; }

    public string? Descripcion8 { get; set; }

    public int? Orden8 { get; set; }

    public decimal? Cantidad { get; set; }

    public int? Estado { get; set; }

    public string? DescripcionCorta { get; set; }

    public int UnidadId { get; set; }

    public string? Usuario { get; set; }

    public string? Referencias { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int EsProduccion { get; set; }

    public int EquipamientoId { get; set; }

    public string? Pos1 { get; set; }

    public string? Pos2 { get; set; }

    public string? Pos3 { get; set; }

    public string? Ruta { get; set; }

    public virtual Prod? Prod { get; set; }
}
