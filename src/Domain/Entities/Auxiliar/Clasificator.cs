using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class Clasificator
{
    public int ClasificatorId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<ClasificatorModule> ClasificatorModules { get; set; } = new List<ClasificatorModule>();

    public virtual ICollection<ClasificatorValue> ClasificatorValues { get; set; } = new List<ClasificatorValue>();
}
