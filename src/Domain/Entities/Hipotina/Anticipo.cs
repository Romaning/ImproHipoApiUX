using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class Anticipo
{
    public int AnticipoId { get; set; }

    public string? Mes { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? Monto { get; set; }

    public int Estado { get; set; }

    public int? Anio { get; set; }

    public int? DocumentoRrhhid { get; set; }

    public string? Responsable { get; set; }

    public int? EmpleadoId { get; set; }

    public string? Nota { get; set; }

    public virtual Empleado? Empleado { get; set; }
}
