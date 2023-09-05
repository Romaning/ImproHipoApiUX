using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class RegistroCambioProducto
{
    public int RegistroCambioProductosId { get; set; }

    public int ProdId { get; set; }

    public decimal PrecioBaseAnterior { get; set; }

    public decimal PrecioBaseActual { get; set; }

    public DateTime FechaCambio { get; set; }

    public decimal Costo { get; set; }

    public string? Observaciones { get; set; }

    public string? Justificativo { get; set; }

    public string? Autorizado { get; set; }

    public string? Usuario { get; set; }

    public int Estado { get; set; }

    public int Numero { get; set; }

    public int MarkId { get; set; }

    public virtual Prod Prod { get; set; } = null!;
}
