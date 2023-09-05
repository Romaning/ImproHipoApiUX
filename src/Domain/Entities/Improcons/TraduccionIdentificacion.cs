using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class TraduccionIdentificacion
{
    public int TraduccionIdentificacionId { get; set; }

    public int LocalDbEmpleadoId { get; set; }

    public int SourceDbEmpleadoId { get; set; }

    public int EmpresaOrigenId { get; set; }

    public string? NombreEmpresaOrigen { get; set; }
}
