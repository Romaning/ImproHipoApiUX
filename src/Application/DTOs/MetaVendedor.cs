using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class MetaVendedor
{
    public int MetaVendedorId { get; set; }

    public int Ci { get; set; }

    public decimal Meta { get; set; }

    public int Mes { get; set; }

    public int Anio { get; set; }

    public int UnidadId { get; set; }

    public decimal BonoAux { get; set; }

    public string? Type { get; set; }
}
