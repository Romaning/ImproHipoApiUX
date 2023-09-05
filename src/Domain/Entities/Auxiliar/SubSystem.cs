using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class SubSystem
{
    public int SubSystemId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Module> Modules { get; set; } = new List<Module>();
}
