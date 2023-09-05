using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class RequerimientoPedidoItem
{
    public int RequerimientoPedidoItemsId { get; set; }

    public int? ProdId { get; set; }

    public decimal? Cantidad { get; set; }

    public int? RequerimientoPedidoId { get; set; }

    public int? ProductoProveedorId { get; set; }

    public string? Observaciones { get; set; }

    public decimal? PrecioUnitarioUsd { get; set; }

    public decimal? PrecioTotalUsd { get; set; }

    public decimal? CostoCarguioUsd { get; set; }

    public decimal? DescuentoUsd { get; set; }

    public decimal? TotalFobusd { get; set; }

    public decimal? GastosCif { get; set; }

    public decimal? TotalCifusd { get; set; }

    public decimal? TotalCifbs { get; set; }

    public decimal? GastosImportacionBs { get; set; }

    public decimal? GastosEstibajeBs { get; set; }

    public decimal? CostoTotalBs { get; set; }

    public decimal? DescuentoIvaBs { get; set; }

    public decimal? CostoTotalImportacionBs { get; set; }

    public decimal? CostoTotalImportacionUsd { get; set; }

    public decimal? CostoUnitarioBs { get; set; }

    public decimal? CostoUnitarioUsd { get; set; }

    public decimal? Pvp { get; set; }

    public decimal? PrecioLista { get; set; }

    public decimal? ComplementoBs { get; set; }

    public decimal? PorcentajePvp { get; set; }

    public decimal? PrecioListaFinal { get; set; }

    public int Modificado { get; set; }

    public decimal? GravamenArancelario { get; set; }

    public int ReProdId { get; set; }

    public decimal? CostoUnitarioUsdEuCny { get; set; }

    public decimal? CostoTotalUsdEuCny { get; set; }
}
