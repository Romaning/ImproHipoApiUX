using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class ProformaItem
{
    public int ProformaItemsId { get; set; }

    public int ProformaId { get; set; }

    public int ProductId { get; set; }

    public int EstadoProducto { get; set; }

    public int UsoProducto { get; set; }

    public int AlmacenId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal Pendiente { get; set; }

    public decimal Use { get; set; }

    public decimal PrecioBase { get; set; }

    public decimal PrecioNominal { get; set; }

    public decimal PorcentajeReglas { get; set; }

    public decimal PreferenteDescuento { get; set; }

    public decimal FraccionDescuento { get; set; }

    public decimal PrecioCotizacion { get; set; }

    public decimal Costo { get; set; }

    public decimal CostoUfv { get; set; }

    public int Estado { get; set; }

    public int Util { get; set; }
}
