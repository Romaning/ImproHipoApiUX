using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class ModuleOperation
{
    public int ModuleOperationId { get; set; }

    public int AccessId { get; set; }

    public bool Create { get; set; }

    public bool Edit { get; set; }

    public bool Delete { get; set; }

    public bool Print { get; set; }

    public bool Search { get; set; }

    public bool Option1 { get; set; }

    public bool Option2 { get; set; }

    public bool Option3 { get; set; }

    public virtual Access Access { get; set; } = null!;
}
