using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class ParcialDetalle
{
    public int ParcialDetalleId { get; set; }

    public int EstadoProductoId { get; set; }

    public int ParcialId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal? Costo { get; set; }

    public int UsoProductoId { get; set; }

    public int Codigo { get; set; }

    public decimal PrecioCotiza { get; set; }

    public int Estado { get; set; }

    public int Util { get; set; }
}
