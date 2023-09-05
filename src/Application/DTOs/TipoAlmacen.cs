﻿using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class TipoAlmacen
{
    public int TipoAlmacenId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? NombreCorto { get; set; }

    public virtual ICollection<Almacen> Almacens { get; set; } = new List<Almacen>();
}
