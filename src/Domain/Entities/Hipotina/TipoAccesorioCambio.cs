using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class TipoAccesorioCambio
{
    public int TipoAccesorioCambioId { get; set; }

    public string? Descripcion { get; set; }

    public int? Estado { get; set; }

    public virtual ICollection<AccesoriosCambioProd> AccesoriosCambioProds { get; set; } = new List<AccesoriosCambioProd>();
}
