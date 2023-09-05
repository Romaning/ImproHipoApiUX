using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Entities.Auxiliar;

public partial class TypeProd : Common.TypeProdBase
{
    //public int TypeProdId { get; set; }

    //public int ClassProdId { get; set; }

    //public string? Descripcion { get; set; }

    //public string? DescripcionCorta { get; set; }

    //public string? Codificacion { get; set; }

    //public int Estado { get; set; }

    //public int? Valor { get; set; }

    //public int? Util { get; set; }
    [JsonIgnore]
    public virtual ClassProd ClassProd { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<Prod> Prods { get; set; } = new List<Prod>();

    //ADICIONADO PARA LA BASE DE DATOS
    [NotMapped]
    public char? DatabaseEspecific { get; set; } = 'A';
}