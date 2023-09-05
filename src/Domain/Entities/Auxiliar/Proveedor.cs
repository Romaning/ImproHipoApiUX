using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class Proveedor
{
    public int ProveedorId { get; set; }

    public string? Nombre { get; set; }

    public int TipoProveedorId { get; set; }

    public int PaisId { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<Activo> Activos { get; set; } = new List<Activo>();

    public virtual ICollection<IngresoDetalle> IngresoDetalles { get; set; } = new List<IngresoDetalle>();

    public virtual ICollection<Ingreso> Ingresos { get; set; } = new List<Ingreso>();

    public virtual Pai Pais { get; set; } = null!;

    public virtual ICollection<PedidoLocalDetalle> PedidoLocalDetalles { get; set; } = new List<PedidoLocalDetalle>();

    public virtual ICollection<PedidoLocal> PedidoLocals { get; set; } = new List<PedidoLocal>();

    public virtual ICollection<ProveedorFabrica> ProveedorFabricas { get; set; } = new List<ProveedorFabrica>();

    public virtual ICollection<ProveedorNacional> ProveedorNacionals { get; set; } = new List<ProveedorNacional>();

    public virtual ICollection<ProveedorProducto> ProveedorProductos { get; set; } = new List<ProveedorProducto>();

    public virtual ICollection<ProveedorTrader> ProveedorTraders { get; set; } = new List<ProveedorTrader>();

    public virtual TipoProveedor TipoProveedor { get; set; } = null!;
}
