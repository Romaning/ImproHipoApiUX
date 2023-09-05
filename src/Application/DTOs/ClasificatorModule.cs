using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class ClasificatorModule
{
    public int ClasificatorModuleId { get; set; }

    public int ClasificatorId { get; set; }

    public int ModuleId { get; set; }

    public virtual Clasificator Clasificator { get; set; } = null!;

    public virtual Module Module { get; set; } = null!;
}
