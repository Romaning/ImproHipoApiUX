﻿using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class AsignacionVehiculoChofer
{
    public int AsignacionVehiculoChoferId { get; set; }

    public int VehiculoId { get; set; }

    public int EmpleadoId { get; set; }

    public DateTime FechaAsignacion { get; set; }

    public int Estado { get; set; }
}
