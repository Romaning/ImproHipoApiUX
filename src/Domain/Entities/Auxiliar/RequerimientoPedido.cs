using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class RequerimientoPedido
{
    public int RequerimientoPedidoId { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? FacturaComercial { get; set; }

    public DateTime? FechaInicial { get; set; }

    public DateTime? FechaCierre { get; set; }

    public DateTime? FechaArribo { get; set; }

    public DateTime? FechaEmbarque { get; set; }

    public DateTime? FechaEnvio { get; set; }

    public int? Estado { get; set; }

    public int? Finalizado { get; set; }

    public int? PedidoProveedorId { get; set; }

    public int EsTotal { get; set; }

    public decimal PorcentajePvp { get; set; }

    public decimal TotalCarguio { get; set; }

    public decimal Cambio { get; set; }

    public decimal Sf { get; set; }

    public decimal Cf { get; set; }

    public decimal TotalDsctoPromocion { get; set; }

    public int EnviadoIngreso { get; set; }

    public string? Dim { get; set; }

    public virtual ICollection<CostoImportacion> CostoImportacions { get; set; } = new List<CostoImportacion>();

    public virtual ICollection<Ingreso> Ingresos { get; set; } = new List<Ingreso>();

    public virtual PedidoProveedor? PedidoProveedor { get; set; }

    public virtual ICollection<RequerimientoPedidoItem> RequerimientoPedidoItems { get; set; } = new List<RequerimientoPedidoItem>();
}
