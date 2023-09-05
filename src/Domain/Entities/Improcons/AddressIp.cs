using System;
using System.Collections.Generic;

namespace Domain.Entities.Improcons;

public partial class AddressIp
{
    public int AddressIpId { get; set; }

    public string? NumberIp { get; set; }

    public int UnidadId { get; set; }

    public virtual Unidad Unidad { get; set; } = null!;
}
