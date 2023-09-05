using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class AccessClasificatorValue
{
    public int AccessClasificatorValueId { get; set; }

    public int AccessId { get; set; }

    public int ClasificatorValueId { get; set; }

    public virtual Access Access { get; set; } = null!;

    public virtual ClasificatorValue ClasificatorValue { get; set; } = null!;
}
