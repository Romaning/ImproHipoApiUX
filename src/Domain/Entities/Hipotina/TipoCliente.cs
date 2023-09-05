using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class TipoCliente
{
    public int TipoClienteId { get; set; }

    public int ClaseClienteId { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? Jerarquia { get; set; }

    public int? Tipo { get; set; }

    public int? Valor { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? VolumenMinimo { get; set; }

    public decimal? VolumenMaximo { get; set; }

    public virtual ICollection<Categorizacion> Categorizacions { get; set; } = new List<Categorizacion>();

    public virtual ClaseCliente ClaseCliente { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<PrecioDiferenciadoCliente> PrecioDiferenciadoClientes { get; set; } = new List<PrecioDiferenciadoCliente>();
}
