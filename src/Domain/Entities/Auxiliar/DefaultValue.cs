using System;
using System.Collections.Generic;
using Domain.Entities.Common;

namespace Domain.Entities.Auxiliar;

public partial class DefaultValue : DefaultValueBase
{
    //public int DefaultValueId { get; set; }

    //public int ProdId { get; set; }

    //public int DefaultAttribId { get; set; }

    //public int? Valor { get; set; }

    //public int? Estado { get; set; }

    //public int? Util { get; set; }

    public virtual DefaultAttrib DefaultAttrib { get; set; } = null!;

    public virtual Prod Prod { get; set; } = null!;
}
