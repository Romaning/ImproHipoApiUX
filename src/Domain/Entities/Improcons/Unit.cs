using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Unit
{
    public int UnitId { get; set; }

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public string? City { get; set; }
}
