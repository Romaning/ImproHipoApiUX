using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class PrecioMarcaCliente
{
    public int PrecioMarcaClienteId { get; set; }

    public int? MarcaId { get; set; }

    public int? TipoClienteId { get; set; }

    public int? PrecioDiferenciadoId { get; set; }

    public DateTime? FechaAlta { get; set; }

    public DateTime? FechaBaja { get; set; }

    public int AnteriorPrecioDiferenciadoId { get; set; }

    public int UnidadId { get; set; }

    public int CategoryId { get; set; }

    public virtual PrecioDiferenciado? PrecioDiferenciado { get; set; }
}
