﻿using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class MatrizMigracion
{
    public int MatrizMigracionId { get; set; }

    public string TipoDato { get; set; } = null!;

    public int IdDato { get; set; }

    public string? Valor { get; set; }
}
