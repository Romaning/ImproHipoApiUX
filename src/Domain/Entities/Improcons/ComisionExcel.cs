using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class ComisionExcel
{
    public int ComisionExcelId { get; set; }

    public string? NombreArchivo { get; set; }

    public byte[]? Archivo { get; set; }

    public int Mes { get; set; }

    public int Anio { get; set; }

    public int UnidadId { get; set; }
}
