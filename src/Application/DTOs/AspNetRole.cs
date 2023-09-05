using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class AspNetRole
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Access> Accesses { get; set; } = new List<Access>();

    public virtual ICollection<RolModule> RolModules { get; set; } = new List<RolModule>();

    public virtual ICollection<AspNetUser> Users { get; set; } = new List<AspNetUser>();
}
