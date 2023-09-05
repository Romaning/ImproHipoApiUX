using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class NotaComision
{
    public int NotaComisionId { get; set; }

    public int UnidadId { get; set; }

    public string? Descripcion { get; set; }

    public int Mes { get; set; }

    public int Anio { get; set; }
}
