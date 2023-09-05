using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class PrecioDiferenciado
{
    public int PrecioDiferenciadoId { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Porcentaje { get; set; }

    public virtual ICollection<PrecioClientePreferencial> PrecioClientePreferencials { get; set; } = new List<PrecioClientePreferencial>();

    public virtual ICollection<PrecioDiferenciadoCliente> PrecioDiferenciadoClientes { get; set; } = new List<PrecioDiferenciadoCliente>();

    public virtual ICollection<PrecioMarcaCliente> PrecioMarcaClientes { get; set; } = new List<PrecioMarcaCliente>();
}
