using System;
using System.Collections.Generic;

namespace Domain.Entities.Hipotina;

public partial class TipoColorProd
{
    public int TipoColorProdId { get; set; }

    public string? Descripcion { get; set; }

    public int? Estado { get; set; }

    public virtual ICollection<ColorProd> ColorProds { get; set; } = new List<ColorProd>();
}
