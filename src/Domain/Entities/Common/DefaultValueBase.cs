using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities.Common;

public  class DefaultValueBase
{
    public int DefaultValueId { get; set; }

    public int ProdId { get; set; }

    public int DefaultAttribId { get; set; }

    public int? Valor { get; set; }

    public int? Estado { get; set; }

    public int? Util { get; set; }

    [NotMapped]
    //[JsonIgnore]
    public virtual DefaultAttribBase DefaultAttribBase { get; set; } = null!;

    [NotMapped]
    //[JsonIgnore]
    public virtual ProdBase ProdBase { get; set; } = null!;
}
