using System;
using System.Collections.Generic;

namespace Domain.Entities.Auxiliar;

public partial class Access
{
    public int AccessId { get; set; }

    public string? ApplicationRoleId { get; set; }

    public string? ApplicationUserId { get; set; }

    public virtual ICollection<AccessClasificatorValue> AccessClasificatorValues { get; set; } = new List<AccessClasificatorValue>();

    public virtual AspNetRole? ApplicationRole { get; set; }

    public virtual AspNetUser? ApplicationUser { get; set; }

    public virtual ICollection<ModuleOperation> ModuleOperations { get; set; } = new List<ModuleOperation>();
}
