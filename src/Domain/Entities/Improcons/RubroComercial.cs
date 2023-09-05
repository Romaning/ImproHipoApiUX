﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class RubroComercial
{
    public int RubroComercialId { get; set; }

    public string? Descripcion { get; set; }

    public int TipoClienteId { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
