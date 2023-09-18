﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Domain.Entities.Common;

namespace Domain.Entities.Hipotina;

public partial class DefaultValue : DefaultValueBase
{
    //public int DefaultValueId { get; set; }

    //public int ProdId { get; set; }

    //public int DefaultAttribId { get; set; }

    //public int? Valor { get; set; }

    //public int? Estado { get; set; }

    //public int? Util { get; set; }
    [JsonIgnore]
    public virtual DefaultAttrib DefaultAttrib { get; set; } = null!;
    [JsonIgnore]
    public virtual Prod Prod { get; set; } = null!;
}
