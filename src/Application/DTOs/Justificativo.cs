using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Justificativo
{
    public int JustificativoId { get; set; }

    public int UnidadId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<JustificativoDetalle> JustificativoDetalles { get; set; } = new List<JustificativoDetalle>();
}
