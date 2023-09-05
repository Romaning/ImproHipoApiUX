using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class ClasificatorValue
{
    public int ClasificatorValueId { get; set; }

    public int ClasificatorId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int ValueId { get; set; }

    public virtual ICollection<AccessClasificatorValue> AccessClasificatorValues { get; set; } = new List<AccessClasificatorValue>();

    public virtual Clasificator Clasificator { get; set; } = null!;
}
