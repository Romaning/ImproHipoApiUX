using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class RolModule
{
    public int RolModuleId { get; set; }

    public string? ApplicationRoleId { get; set; }

    public int ModuleId { get; set; }

    public virtual AspNetRole? ApplicationRole { get; set; }

    public virtual Module Module { get; set; } = null!;
}
