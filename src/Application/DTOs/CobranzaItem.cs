using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class CobranzaItem
{
    public int CobranzaItemsId { get; set; }

    public int CobranzaId { get; set; }

    public int ParcialId { get; set; }

    public decimal Total { get; set; }

    public decimal TotalPend { get; set; }

    public int Tipo { get; set; }

    public decimal Importe { get; set; }

    public decimal Descuento { get; set; }

    public int Estado { get; set; }

    public int Util { get; set; }
}
