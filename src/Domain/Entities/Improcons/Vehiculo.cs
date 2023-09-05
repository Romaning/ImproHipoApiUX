﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Vehiculo
{
    public int VehiculoId { get; set; }

    public string? Marca { get; set; }

    public string? Tipo { get; set; }

    public string? Placa { get; set; }

    public int UnidadId { get; set; }
}
