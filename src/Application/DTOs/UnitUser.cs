using System;
using System.Collections.Generic;

namespace Application.DTOs;

public partial class UnitUser
{
    public int UnitUserId { get; set; }

    public string? ApplicationUserId { get; set; }

    public int UnidadId { get; set; }

    public virtual AspNetUser? ApplicationUser { get; set; }

    public virtual Unidad Unidad { get; set; } = null!;
}
