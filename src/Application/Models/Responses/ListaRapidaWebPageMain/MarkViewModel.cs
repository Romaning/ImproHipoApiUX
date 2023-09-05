using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models.Responses.ListaRapidaWebPageMain;

public /*partial*/ class MarkViewModel
{
    //public int MarkId { get; set; }

    public string? Descripcion { get; set; }

    public string? DescripcionCorta { get; set; }

    //public string? Codificacion { get; set; }

    //public int Estado { get; set; }

    //public int? Valor { get; set; }

    //public int? Util { get; set; }

    //[NotMapped]
    //public virtual ICollection<ProdViewModel> Prods { get; set; } = new List<ProdViewModel>();
}
