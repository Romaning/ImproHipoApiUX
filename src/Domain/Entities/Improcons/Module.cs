using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class Module
{
    public int ModuleId { get; set; }

    public int SubSystemId { get; set; }

    public string? Name { get; set; }

    public string? Identificador { get; set; }

    public virtual ICollection<ClasificatorModule> ClasificatorModules { get; set; } = new List<ClasificatorModule>();

    public virtual ICollection<RolModule> RolModules { get; set; } = new List<RolModule>();

    public virtual SubSystem SubSystem { get; set; } = null!;
}
