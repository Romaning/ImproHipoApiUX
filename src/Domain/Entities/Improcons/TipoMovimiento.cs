﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class TipoMovimiento
{
    public int TipoMovimientoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? DescripcionCorta { get; set; }

    public bool Recosteo { get; set; }

    public virtual ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();
}
