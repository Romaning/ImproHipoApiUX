using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class PlantillaItemsOp
{
    public int PlantillaItemsOpid { get; set; }

    public int CotizacionId { get; set; }

    public int ProdId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal PrecioBase { get; set; }

    public decimal PrecioCotizacion { get; set; }

    public decimal ValorDescuento { get; set; }

    public decimal PorcentajeReglas { get; set; }

    public int Tipo { get; set; }

    public int CotizacionItemsId { get; set; }
}
