using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.DTOs;

public partial class ClassProd : ClassProdBase
{
    //public int ClassProdId { get; set; }

    //public string? Descripcion { get; set; }

    //public string? DescripcionCorta { get; set; }

    //public string? Codificacion { get; set; }

    //public int Estado { get; set; }

    //public int? Valor { get; set; }

    //public int? Util { get; set; }

    public virtual ICollection<TypeProd> TypeProds { get; set; } = new List<TypeProd>();

    //ADICIONADO PARA LA BASE DE DATOS
    [NotMapped]
    public char? DatabaseEspecific { get; set; } = 'I';
}
