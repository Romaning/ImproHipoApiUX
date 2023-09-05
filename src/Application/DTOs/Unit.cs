using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class Unit
{
    public int UnitId { get; set; }

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public string? City { get; set; }
}
