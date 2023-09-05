﻿using System;
using System.Collections.Generic;
using Domain.Entities.Common;

namespace Domain.Entities.Auxiliar;

public partial class DefaultAttrib : DefaultAttribBase
{
    //public int DefaultAttribId { get; set; }

    //public int DefaultDomainId { get; set; }

    //public string? Descripcion { get; set; }

    //public int Tipo { get; set; }

    //public int Nivel { get; set; }

    //public int? Orden { get; set; }

    //public int? Util { get; set; }

    //public int Estado { get; set; }

    //public int DefaultDomain { get; set; }

    public virtual DefaultDomain DefaultDomainNavigation { get; set; } = null!;

    public virtual ICollection<DefaultValue> DefaultValues { get; set; } = new List<DefaultValue>();
}
