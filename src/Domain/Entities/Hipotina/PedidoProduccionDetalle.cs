using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class PedidoProduccionDetalle
{
    public int PedidoProduccionDetalleId { get; set; }

    public int PedidoProduccionId { get; set; }

    public decimal Cantidad { get; set; }

    public DateTime FechaPedido { get; set; }

    public int Estado { get; set; }

    public int ProdId { get; set; }

    public virtual PedidoProduccion PedidoProduccion { get; set; } = null!;

    public virtual ICollection<RegistroProduccion> RegistroProduccions { get; set; } = new List<RegistroProduccion>();
}
