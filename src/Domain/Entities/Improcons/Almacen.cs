using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Almacen
{
    public int AlmacenId { get; set; }

    public int UnidadId { get; set; }

    public int TipoAlmacenId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? NombreCorto { get; set; }

    public virtual ICollection<Ajuste> Ajustes { get; set; } = new List<Ajuste>();

    public virtual ICollection<AlmacenProducto> AlmacenProductos { get; set; } = new List<AlmacenProducto>();

    public virtual ICollection<Altum> Alta { get; set; } = new List<Altum>();

    public virtual ICollection<Baja> Bajas { get; set; } = new List<Baja>();

    public virtual ICollection<Despachante> Despachantes { get; set; } = new List<Despachante>();

    public virtual ICollection<Ingreso> Ingresos { get; set; } = new List<Ingreso>();

    public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();

    public virtual ICollection<PedidoLocal> PedidoLocals { get; set; } = new List<PedidoLocal>();

    public virtual ICollection<Solicitante> SolicitanteAlmacenDescargas { get; set; } = new List<Solicitante>();

    public virtual ICollection<Solicitante> SolicitanteAlmacens { get; set; } = new List<Solicitante>();

    public virtual TipoAlmacen TipoAlmacen { get; set; } = null!;

    public virtual Unidad Unidad { get; set; } = null!;
}
