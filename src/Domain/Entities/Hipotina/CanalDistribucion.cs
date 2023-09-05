using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class CanalDistribucion
{
    public int CanalDistribucionId { get; set; }

    public string? Descripcion { get; set; }

    public int Estado { get; set; }
}
